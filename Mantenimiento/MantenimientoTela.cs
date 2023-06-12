using EscritorioFaciens.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioFaciens
{
    public partial class MantenimientoTela : Form
    {
        private Negocio _negocio;
        public MantenimientoTela()
        {
            InitializeComponent();
            this._negocio = new Negocio();
            this.CargarLista();
        }

        private async void CargarLista()
        {
            try
            {
                List<Tela> telas = await this._negocio.ObtenerTelas();
                this.RefrescarLista(telas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarLista(List<Tela> telas)
        {
            this.lvTela.Items.Clear();
            try
            {
                telas.ForEach(async t =>
                {
                    string creador = await this._negocio.ObtenerUsername(t.UsuarioIdCreador);
                    string modificacion = string.Empty;
                    string umodificacion = string.Empty;
                    if (t.FechaModificacion.HasValue)
                    {
                        modificacion = t.FechaModificacion.Value.ToString("dd/MM/yyyy");
                        umodificacion = await this._negocio.ObtenerUsername(t.UsuarioIdModificacion); //SSE VA A SUSTITUIR POR EL DTO DE DISEÑO, DE ESTE MODO NO SE COMPROMETE EL ID DEL USUARIO.
                    }
                    this
                    .lvTela
                    .Items
                    .Add(new ListViewItem(new string[] { t.Nombre, t.FechaCreacion.ToString("dd/MM/yyyy"), creador, modificacion, umodificacion })).Tag = t.TelaId;
                });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void cmsTela_Opening(object sender, CancelEventArgs e)
        {
            this.tsmiEliminar.Enabled = false;
            this.tsmiModificar.Enabled = false;
            if (this.lvTela.SelectedItems.Count == 1)
            {
                this.tsmiEliminar.Enabled = true;
                this.tsmiModificar.Enabled = true;
            }
        }

        private async void tsmiNuevo_Click(object sender, EventArgs e)
        {
            Tela tela = new Tela();
            if (new TelaFrm(tela).ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await this._negocio.CrearTela(tela);
                    this.CargarLista();
                    this.txtNombreTela.Clear();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private async void tsmiModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Tela tela = await this._negocio.ObtenerTela((int)this.lvTela.SelectedItems[0].Tag);
                await ModificarTela(tela);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private async Task ModificarTela(Tela tela)
        {
            if (tela != null)
            {
                if (new TelaFrm(tela).ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        await this._negocio.ModificarTela(tela);
                        this.CargarLista();
                        this.txtNombreTela.Clear();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private async void tsmiEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar esta tela?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    await this._negocio.EliminarTela((int)this.lvTela.SelectedItems[0].Tag);
                    this.CargarLista();
                    this.txtNombreTela.Clear();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private async void BuscarTela()
        {
            try
            {
                List<Tela> telas = await this._negocio.ObtenerTelas();
                if (!string.IsNullOrEmpty(this.txtNombreTela.Text.Trim()))
                {
                    telas = telas.Where(t => t.Nombre.ToUpper().Trim().Contains(this.txtNombreTela.Text.ToUpper().Trim())).ToList();
                }
                this.RefrescarLista(telas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarTela();
        }

        private async void lvTela_DoubleClickAsync(object sender, EventArgs e)
        {
            ListView list = (ListView)sender;
            try
            {
                Tela tela = await _negocio.ObtenerTela((int)list.SelectedItems[0].Tag);
                await ModificarTela(tela);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreTela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.BuscarTela();
            }
        }
    }
}
