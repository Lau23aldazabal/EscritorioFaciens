using EscritorioFaciens.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioFaciens.FormsUsuario
{
    public partial class Proyectos : Form
    {
        private readonly Negocio _negocio;
        public Proyectos()
        {
            InitializeComponent();
            this._negocio = new Negocio();
            this.InicializarLista();
            this.CargarCombos();
        }
        private void CargarCombos()
        {
            try
            {
                this.clbDificultad.DataSource = Enum.GetValues(typeof(DificultadEnum));
                this.LimpiarSeleccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarSeleccion()
        {
            this.clbDificultad.SelectedItems.Clear();
        }

        private async void InicializarLista()
        {
            try
            {
                this.CargarProyectos(await _negocio.ObtenerProyectos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProyectos(List<Proyecto> proyectos)
        {

            try
            {
                int x = 0;
                this.ilMisProyectos.Images.Clear();
                this.lvProyectos.Items.Clear();
                proyectos.ForEach(async p =>
                {
                    List<ImagenDiseno> imagen = await _negocio.ObtenerImagenes(p.DisenoId);
                    this.ilMisProyectos.Images.Add(FuncionesGenerales.CargarImagen(imagen.First().Foto));
                    string nombre = await _negocio.ObteneNombrerDiseno(p.DisenoId);
                    ListViewItem item = new ListViewItem(new string[] { nombre.ToUpper() });
                    item.ImageIndex = x;
                    item.Tag = p.ProyectoId;
                    this.lvProyectos.Items.Add(item);
                    x++;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComprobarSeleccion(CheckedListBox checkedList)
        {
            if (checkedList.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedList.Items.Count; i++)
                    checkedList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
        private async void Filtrar()
        {
            try
            {
                List<Proyecto> proyectos = await _negocio.ObtenerProyectos();
                List<Diseno> disenos = await _negocio.ObtenerDisenos();
                if (this.chbRecientes.Checked)
                {
                    proyectos = proyectos.OrderByDescending(d => d.FechaGuardado).ToList();
                }
                if (!String.IsNullOrEmpty(this.txtNombreProyecto.Text.Trim()))
                {
                    proyectos = (from p in proyectos
                                 join d in disenos on p.DisenoId equals d.DisenoId
                                 where d.Nombre.ToUpper().Trim().Contains(this.txtNombreProyecto.Text.ToUpper().Trim())
                                 select p).ToList();
                }
                if (clbDificultad.CheckedItems.Count > 0 && clbDificultad.CheckedItems.Count < clbDificultad.Items.Count)
                {
                    proyectos = (from p in proyectos
                                 join d in disenos on p.DisenoId equals d.DisenoId
                                 where clbDificultad.CheckedItems.Cast<DificultadEnum>().ToList().Any(nivel => nivel.ToString().Trim().Equals(d.Dificultad))
                                 select p).ToList();
                }
                if (!cbRealizado.CheckState.Equals(cbNoRealizado.CheckState))
                {
                    if (cbNoRealizado.Checked)
                    {
                        proyectos = proyectos.Where(p => !p.Realizado).ToList();
                    }
                    else
                    {
                        proyectos = proyectos.Where(p => p.Realizado).ToList();
                    }
                }
                this.CargarProyectos(proyectos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Filtrar();
        }

        private void Limpiar()
        {
            this.txtNombreProyecto.Clear();
            this.cbNoRealizado.Checked = false;
            this.cbRealizado.Checked = false;
            this.chbRecientes.Checked = false;
            this.ComprobarSeleccion(this.clbDificultad);
            this.LimpiarSeleccion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.InicializarLista();
        }

        private void txtNombreProyecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.Filtrar();
            }
        }

        private async Task BuscarDisenoAsync()
        {
            try
            {
                Proyecto proyecto = await this._negocio.ObtenerProyecto((int)this.lvProyectos.SelectedItems[0].Tag);
                if (proyecto != null)
                {
                    Diseno diseno = await this._negocio.ObtenerDiseno(proyecto.DisenoId);
                    if (diseno != null)
                    {
                        FichaDisenoFrm disenoFicha = new FichaDisenoFrm(diseno);
                        disenoFicha.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private async void lvProyectos_DoubleClick(object sender, EventArgs e)
        {
            await this.BuscarDisenoAsync();
        }

        private async void tsmiVer_Click(object sender, EventArgs e)
        {
            await this.BuscarDisenoAsync();
        }

        private async void tsmiCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto proyecto = await this._negocio.ObtenerProyecto((int)this.lvProyectos.SelectedItems[0].Tag);
                if (proyecto != null)
                {
                    string realizado = "no realizado";
                    if (!proyecto.Realizado)
                    {
                        realizado = "realizado";
                    }
                    if (MessageBox.Show($"¿Desea marcar este proyecto como {realizado}?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        proyecto.Realizado = !proyecto.Realizado;
                        await _negocio.ModificarProyecto(proyecto);
                        this.InicializarLista();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void tsmiEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar este diseño?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    await _negocio.EliminarProyecto((int)this.lvProyectos.SelectedItems[0].Tag);
                    this.InicializarLista();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsProyectos_Opening(object sender, CancelEventArgs e)
        {
            this.tsmiVer.Enabled = true;
            this.tsmiEliminar.Enabled = true;
            this.tsmiCambiar.Enabled = true;
            if (lvProyectos.SelectedItems.Count == 0)
            {
                this.tsmiVer.Enabled = false;
                this.tsmiEliminar.Enabled = false;
                this.tsmiCambiar.Enabled = false;
            }
        }
    }
}
