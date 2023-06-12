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
    public partial class MantenimientoPrenda : Form
    {
        private Negocio _negocio;
        public MantenimientoPrenda()
        {
            InitializeComponent();
            this._negocio = new Negocio();
            this.CargarLista();
        }

        private async void CargarLista()
        {
            try
            {
                List<Prenda> prendas = await this._negocio.ObtenerPrendas();
                this.RefrescarLista(prendas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarLista(List<Prenda> prendas)
        {
            this.lvPrenda.Items.Clear();
            try
            {
                prendas.ForEach(async p =>
                {
                    string modificacion = string.Empty;
                    string userModi = string.Empty;
                    string creador = await this._negocio.ObtenerUsername(p.UsuarioIdCreador); //SSE VA A SUSTITUIR POR EL DTO DE DISEÑO, DE ESTE MODO NO SE COMPROMETE EL ID DEL USUARIO.
                    if (p.FechaModificacion.HasValue)
                    {
                        modificacion = p.FechaModificacion.Value.ToString("dd/MM/yyyy");
                        userModi = await this._negocio.ObtenerUsername(p.UsuarioIdModificacion);
                    }
                    this
                    .lvPrenda
                    .Items
                    .Add(new ListViewItem(new string[] { p.Nombre, p.FechaCreacion.ToString("dd/MM/yyyy"), creador, modificacion, userModi })).Tag = p.PrendaId;
                });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmsPrenda_Opening(object sender, CancelEventArgs e)
        {
            this.tsmiEliminar.Enabled = false;
            this.tsmiModificar.Enabled = false;
            if (this.lvPrenda.SelectedItems.Count == 1)
            {
                this.tsmiEliminar.Enabled = true;
                this.tsmiModificar.Enabled = true;
            }
        }

        private async void tsmiNuevo_Click(object sender, EventArgs e)
        {
            Prenda prenda = new Prenda();
            if (new PrendaFrm(prenda).ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await this._negocio.CrearPrenda(prenda);
                    this.CargarLista();
                    this.txtNombrePrenda.Clear();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private async void tsmiModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Prenda prenda = await this._negocio.ObtenerPrenda((int)this.lvPrenda.SelectedItems[0].Tag);
                await ModificarPrenda(prenda);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private async Task ModificarPrenda(Prenda prenda)
        {
            if (prenda != null)
            {
                if (new PrendaFrm(prenda).ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        await this._negocio.ModificarPrenda(prenda);
                        this.CargarLista();
                        this.txtNombrePrenda.Clear();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private async void tsmiEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar esta prenda?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    await this._negocio.EliminarPrenda((int)this.lvPrenda.SelectedItems[0].Tag);
                    this.CargarLista();
                    this.txtNombrePrenda.Clear();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private async void BuscarPrenda()
        {
            try
            {
                List<Prenda> prendas = await this._negocio.ObtenerPrendas();
                if (!String.IsNullOrWhiteSpace(this.txtNombrePrenda.Text.Trim()))
                {
                    prendas = prendas.Where(t => t.Nombre.ToUpper().Trim().Contains(this.txtNombrePrenda.Text.ToUpper().Trim())).ToList();
                }
                this.RefrescarLista(prendas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarPrenda();
        }

        private async void lvPrenda_DoubleClick(object sender, EventArgs e)
        {
            ListView list = (ListView)sender;
            try
            {
                Prenda prenda = await _negocio.ObtenerPrenda((int)list.SelectedItems[0].Tag);
                await ModificarPrenda(prenda);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombrePrenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.BuscarPrenda();
            }
        }
    }
}
