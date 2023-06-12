using EscritorioFaciens.Administradores;
using EscritorioFaciens.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioFaciens
{
    public partial class MantenimientoEstilo : Form
    {
        private Negocio _negocio;
        public MantenimientoEstilo()
        {
            InitializeComponent();
            this._negocio = new Negocio();
            this.CargarLista();
        }

        private async void CargarLista() // se borran los eventos¿? se limpia¿?
        {
            try
            {
                List<Estilo> estilos = await this._negocio.ObtenerEstilos();
                this.RefrescarLista(estilos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarLista(List<Estilo> estilos)
        {
            this.lvEstilo.Items.Clear();
            try
            {
                estilos.ForEach(async e =>
                {
                    string modificacion = string.Empty;
                    string userModi = string.Empty;
                    string creador = await this._negocio.ObtenerUsername(e.UsuarioIdCreador); //SSE VA A SUSTITUIR POR EL DTO DE DISEÑO, DE ESTE MODO NO SE COMPROMETE EL ID DEL USUARIO.
                    if (e.FechaModificacion.HasValue)
                    {
                        modificacion = e.FechaModificacion.Value.ToString("dd/MM/yyyy");
                        userModi = await this._negocio.ObtenerUsername(e.UsuarioIdModificacion);
                    }
                    this
                    .lvEstilo
                    .Items
                    .Add(new ListViewItem(new string[] { e.Nombre, e.FechaCreacion.ToString("dd/MM/yyyy"), creador, modificacion, userModi })).Tag = e.EstiloId;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsEstilo_Opening(object sender, CancelEventArgs e)
        {
            this.tsmiEliminar.Enabled = false;
            this.tsmiModificar.Enabled = false;
            if (this.lvEstilo.SelectedItems.Count == 1)
            {
                this.tsmiEliminar.Enabled = true;
                this.tsmiModificar.Enabled = true;
            }
        }

        private async void tsmiNuevo_Click(object sender, EventArgs e)
        {
            Estilo estilo = new Estilo();
            if (new EstiloFrm(estilo).ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await this._negocio.CrearEstilo(estilo);
                    this.CargarLista();
                    this.txtNombreEstilo.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private async void tsmiModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Estilo estilo = await this._negocio.ObtenerEstilo((int)this.lvEstilo.SelectedItems[0].Tag);
                await ModificarEstilo(estilo);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async Task ModificarEstilo(Estilo estilo)
        {
            if (estilo != null)
            {
                if (new EstiloFrm(estilo).ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        await this._negocio.ModificarEstilo(estilo);
                        this.CargarLista();
                        this.txtNombreEstilo.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //modificar el error.
                    }
                }
            }
        }

        private async void tsmiEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar este estilo?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    await this._negocio.EliminarEstilo((int)this.lvEstilo.SelectedItems[0].Tag);
                    this.CargarLista();
                    this.txtNombreEstilo.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private async void BuscarEstilo()
        {
            try
            {
                List<Estilo> estilos = await this._negocio.ObtenerEstilos();
                if (!String.IsNullOrWhiteSpace(this.txtNombreEstilo.Text.Trim()))
                {
                    estilos = estilos.Where(e => e.Nombre.ToUpper().Trim().Contains(this.txtNombreEstilo.Text.ToUpper().Trim())).ToList();
                }
                this.RefrescarLista(estilos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarEstilo();
        }

        private async void lvEstilo_DoubleClick(object sender, EventArgs e)
        {
            ListView list = (ListView)sender;
            try
            {
                Estilo estilo = await _negocio.ObtenerEstilo((int)list.SelectedItems[0].Tag);
                await ModificarEstilo(estilo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreEstilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.BuscarEstilo();
            }
        }
    }
}
