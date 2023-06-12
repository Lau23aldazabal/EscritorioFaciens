using EscritorioFaciens.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioFaciens.Mantenimiento
{
    public partial class MantenimientoPermisos : Form
    {
        private Negocio _negocio;
        public MantenimientoPermisos()
        {
            InitializeComponent();
            this._negocio = new Negocio();
            this.CargarLista();
        }

        private async void CargarLista()
        {
            try
            {
                List<UsuarioAdministradorDTO> usuarios = await this._negocio.ObtenerAdministradores();
                this.RefrescarListas(usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefrescarListas(List<UsuarioAdministradorDTO> listado)
        {
            this.lvAdmin.Items.Clear();
            this.lvNoAdmin.Items.Clear();
            try
            {
                listado.ForEach(u =>
                {
                    if (u.esAdmin)
                    {
                        this.
                       lvAdmin
                       .Items
                       .Add(new ListViewItem(new string[] { u.username })).Tag = u.username;
                    }
                    else
                    {
                        this.
                       lvNoAdmin
                       .Items
                       .Add(new ListViewItem(new string[] { u.username })).Tag = u.username;
                    }

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lvAdmin.SelectedItems.Count == 0)
            {
                return;
            }
            try
            {
                await this._negocio.QuitarPrivilegiosAdministrativos((string)this.lvAdmin.SelectedItems[0].Tag);
                this.txtUsername.Clear();
                this.CargarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAniadir_Click(object sender, EventArgs e)
        {
            if (this.lvNoAdmin.SelectedItems.Count == 0)
            {
                return;
            }
            try
            {
                await this._negocio.DarPrivilegiosAdministrativos((string)this.lvNoAdmin.SelectedItems[0].Tag);
                this.txtUsername.Clear();
                this.CargarLista();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Filtrar()
        {
            try
            {
                List<UsuarioAdministradorDTO> listado = await this._negocio.ObtenerAdministradores();
                listado = listado.Where(u => u.username.Trim().ToUpper().Contains(this.txtUsername.Text.Trim().ToUpper())).ToList();
                this.RefrescarListas(listado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.Filtrar();
            }
        }

        private void btnUsername_Click(object sender, EventArgs e)
        {
            this.Filtrar();
        }
    }
}
