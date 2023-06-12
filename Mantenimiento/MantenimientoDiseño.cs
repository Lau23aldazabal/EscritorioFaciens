using EscritorioFaciens.Administradores;
using EscritorioFaciens.Entidades;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioFaciens
{
    public partial class MantenimientoDiseño : Form
    {
        private Negocio _negocio;
        public MantenimientoDiseño()
        {
            InitializeComponent();
            this._negocio = new Negocio();
            this.CargarLista();
            this.CargarControles();
        }

        private async void CargarLista()
        {
            try
            {
                List<Diseno> diseno = await this._negocio.ObtenerDisenos();
                this.RefrescarLista(diseno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarLista(List<Diseno> disenos)
        {
            this.lvDiseno.Items.Clear();
            disenos = disenos.OrderByDescending(d => d.FechaCreacion).ToList();
            try
            {
                disenos.ForEach(async d =>
                {
                    string tela = await this._negocio.ObteneNombrerTela(d.TelaId);
                    string prenda = await this._negocio.ObteneNombrerPrenda(d.PrendaId);
                    string estilo = await this._negocio.ObteneNombrerEstilo(d.EstiloId);
                    string creador = await this._negocio.ObtenerUsername(d.UsuarioIdCreador); //SSE VA A SUSTITUIR POR EL DTO DE DISEÑO, DE ESTE MODO NO SE COMPROMETE EL ID DEL USUARIO.
                    string modificacion = string.Empty;
                    string umodificacion = string.Empty;
                    if (d.FechaModificacion.HasValue)
                    {
                        modificacion = d.FechaModificacion.Value.ToString("dd/MM/yyyy");
                        umodificacion = await this._negocio.ObtenerUsername(d.UsuarioIdModificacion);
                    }
                    this.
                    lvDiseno
                    .Items
                    .Add(new ListViewItem(new string[] { d.Nombre, d.Descripcion, d.Materiales, d.Dificultad, estilo, prenda, tela, creador, d.FechaCreacion.ToString("dd/MM/yyyy"), umodificacion, modificacion })).Tag = d.DisenoId;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarControles()
        {
            try
            {
                this.clbDificultad.DataSource = Enum.GetValues(typeof(DificultadEnum));
                List<Estilo> estilo = await this._negocio.ObtenerEstilos();
                this.clbEstilo.DataSource = estilo;
                this.clbEstilo.DisplayMember = "Nombre";
                this.clbEstilo.ValueMember = "EstiloId";
                List<Prenda> prenda = await this._negocio.ObtenerPrendas();
                this.clbPrenda.DataSource = prenda;
                this.clbPrenda.DisplayMember = "Nombre";
                this.clbPrenda.ValueMember = "PrendaId";
                List<Tela> tela = await this._negocio.ObtenerTelas();
                this.clbTela.DataSource = tela;
                this.clbTela.DisplayMember = "Nombre";
                this.clbTela.ValueMember = "TelaId";
                this.LimpiarSeleccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void tsmiModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Diseno diseno = await this._negocio.ObtenerDiseno((int)this.lvDiseno.SelectedItems[0].Tag);
                await ModificarDiseno(diseno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ModificarDiseno(Diseno diseno) 
        {
            if (diseno != null)
            {
                if (new DisenoFrm(diseno).ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        await this._negocio.ModificarDiseno(diseno);
                        this.CargarLista();
                        this.Limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void tsmiAniadir_Click(object sender, EventArgs e)
        {
            Diseno diseno = new Diseno();
            diseno.ImagenDisenos = new List<ImagenDiseno>(); //HAGO EL NEW DE LA LISTA PARA METER LOS DISEÑOS.
            if (new DisenoFrm(diseno).ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int cod = await this._negocio.CrearDiseno(diseno); //OBTENEMOS EL ID DEL DISEÑO INSERTADO Y ALMACENAMOS LAS IMAGENES DE LA LISTA.
                    diseno.ImagenDisenos.ForEach(async id =>
                    {
                        id.DisenoId = cod;
                        try
                        {
                            await this._negocio.CrearImagenDiseno(id); //SE LIMPIA y se miran los filtros
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    });
                    this.CargarLista();
                    this.Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void tsmiEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar este diseño?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    await this._negocio.EliminarDiseno((int)this.lvDiseno.SelectedItems[0].Tag);
                    this.CargarLista();
                    this.Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cmListaDiseno_Opening(object sender, CancelEventArgs e)
        {
            this.tsmiEliminar.Enabled = false;
            this.tsmiModificar.Enabled = false;
            if (lvDiseno.SelectedItems.Count > 0)
            {
                this.tsmiEliminar.Enabled = true;
                this.tsmiModificar.Enabled = true;
            }
        }

        private async void lvDiseno_DoubleClick(object sender, EventArgs e)
        {
            ListView list = (ListView)sender;
            try
            {
                Diseno diseno = await _negocio.ObtenerDiseno((int)list.SelectedItems[0].Tag);
                await ModificarDiseno(diseno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnBuscar_ClickAsync(object sender, EventArgs e)
        {
            await FiltrarDisenos();
        }

        private async Task FiltrarDisenos()
        {
            try
            {
                List<Diseno> disenos = await _negocio.ObtenerDisenos();
                if (!String.IsNullOrEmpty(this.txtNombreDiseno.Text.Trim()))
                {
                    disenos = disenos.Where(d => d.Nombre.Trim().ToUpper().Contains(this.txtNombreDiseno.Text.Trim().ToUpper())).ToList();
                }
                if (clbTela.CheckedItems.Count > 0 && clbTela.CheckedItems.Count < clbTela.Items.Count)
                {
                    disenos = disenos.Where(d => clbTela.CheckedItems.Cast<Tela>().ToList().Any(t => t.TelaId.Equals(d.TelaId))).ToList();
                }
                if (clbEstilo.CheckedItems.Count > 0 && clbEstilo.CheckedItems.Count < clbEstilo.Items.Count)
                {
                    disenos = disenos.Where(d => clbEstilo.CheckedItems.Cast<Estilo>().ToList().Any(es => es.EstiloId.Equals(d.EstiloId))).ToList();
                }
                if (clbPrenda.CheckedItems.Count > 0 && clbPrenda.CheckedItems.Count < clbPrenda.Items.Count)
                {
                    disenos = disenos.Where(d => clbPrenda.CheckedItems.Cast<Prenda>().ToList().Any(p => p.PrendaId.Equals(d.PrendaId))).ToList();
                }
                if (clbDificultad.CheckedItems.Count > 0 && clbDificultad.CheckedItems.Count < clbDificultad.Items.Count)
                {
                    disenos = disenos.Where(d => clbDificultad.CheckedItems.Cast<DificultadEnum>().ToList().Any(nivel => nivel.ToString().Trim().Equals(d.Dificultad.Trim()))).ToList();
                }
                this.RefrescarLista(disenos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarSeleccion()
        {
            this.clbDificultad.SelectedItems.Clear();
            this.clbEstilo.SelectedItems.Clear();
            this.clbPrenda.SelectedItems.Clear();
            this.clbTela.SelectedItems.Clear();
        }
        private void ComprobarSeleccion(CheckedListBox checkedList)
        {
            if (checkedList.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedList.Items.Count; i++)
                    checkedList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void Limpiar()
        {
            this.txtNombreDiseno.Clear();
            this.ComprobarSeleccion(this.clbDificultad);
            this.ComprobarSeleccion(this.clbEstilo);
            this.ComprobarSeleccion(this.clbPrenda);
            this.ComprobarSeleccion(this.clbTela);
            this.LimpiarSeleccion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.CargarLista();

        }

        private async void txtNombreDiseno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                await this.FiltrarDisenos();
            }
        }

    }
}
