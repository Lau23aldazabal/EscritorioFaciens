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
    public partial class MantenimientoCuentas : Form
    {
        private Negocio _negocio;
        public MantenimientoCuentas()
        {
            InitializeComponent();
            this._negocio = new Negocio();
            this.CargarLista();
        }

        private async void CargarLista()
        {
            try
            {
                List<CuentasEstadoDTO> cuentas = await this._negocio.ObtenerEstadoCuentas();
                this.RefrescarLista(cuentas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarLista(List<CuentasEstadoDTO> cuentas)
        {
            this.lvCuentas.Items.Clear();
            cuentas.ForEach(c =>
            {
                string bloqueado = string.Empty;
                string fecha = string.Empty;
                if (c.Bloqueado)
                {
                    bloqueado = "Bloqueado";
                    fecha = c.Fecha.Value.ToString("dd/MM/yyyy");
                }
                this.
                      lvCuentas
                      .Items
                      .Add(new ListViewItem(new string[] { c.Nombre, c.Email, bloqueado, fecha }));
            });

        }

        private async void Filtrar()
        {
            try
            {
                List<CuentasEstadoDTO> listado = await this._negocio.ObtenerEstadoCuentas();
                listado = listado.Where(u => u.Nombre.Trim().ToUpper().Contains(this.txtUsername.Text.Trim().ToUpper()) || u.Email.Trim().ToUpper().Contains(this.txtUsername.Text.Trim().ToUpper())).ToList();
                this.RefrescarLista(listado);
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

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.Filtrar();
            }
        }

        private void cmsEstado_Opening(object sender, CancelEventArgs e)
        {
            this.tsmiModificar.Enabled = true;
            if (lvCuentas.SelectedItems.Count == 0)
            {
                this.tsmiModificar.Enabled = false;
            }
        }

        private async void tsmiModificar_Click(object sender, EventArgs e)
        {
            try
            {
                List<CuentasEstadoDTO> cuentas = await _negocio.ObtenerEstadoCuentas();
                CuentasEstadoDTO cuenta = cuentas.FirstOrDefault(c => c.Nombre.Trim().Equals(this.lvCuentas.SelectedItems[0].SubItems[0].Text));
                if (cuenta != null)
                {
                    if (new CuentaFrm(cuenta).ShowDialog() == DialogResult.OK)
                    {
                        if (cuenta.Bloqueado)
                        {
                            await this._negocio.BloquearCuenta(cuenta);
                        }
                        else
                        {
                            await this._negocio.DesbloquearCuenta(cuenta.Nombre);
                        }
                    }
                    this.CargarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
