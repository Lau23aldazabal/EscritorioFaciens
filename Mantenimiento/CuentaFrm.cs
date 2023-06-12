using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscritorioFaciens.DTO;

namespace EscritorioFaciens.Mantenimiento
{
    public partial class CuentaFrm : Form
    {
        private CuentasEstadoDTO _cuentasEstadoDTO;

        private CuentaFrm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public CuentaFrm(CuentasEstadoDTO cuentasEstadoDTO) : this()
        {
            this._cuentasEstadoDTO = cuentasEstadoDTO;
            if (cuentasEstadoDTO != null)
            {
                this.lblUsername.Text += $" {cuentasEstadoDTO.Nombre}";
                this.lblEmail.Text += $" {cuentasEstadoDTO.Email}";
                if (cuentasEstadoDTO.Bloqueado)
                {
                    this.chbBloquear.Checked = true;
                    this.dtpBloqueo.Value = _cuentasEstadoDTO.Fecha.Value.DateTime;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.chbBloquear.Checked)
            {
                this._cuentasEstadoDTO.Bloqueado = true;
                this._cuentasEstadoDTO.Fecha = new DateTimeOffset(dtpBloqueo.Value);
            }
            else
            {
                this._cuentasEstadoDTO.Bloqueado = false;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbBloquear_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbBloquear.Checked)
            {
                this.dtpBloqueo.Enabled = true;
            }
            else
            {
                this.dtpBloqueo.Enabled = false;
            }
        }
    }
}
