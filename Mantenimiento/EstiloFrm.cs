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

namespace EscritorioFaciens.Administradores
{
    public partial class EstiloFrm : Form
    {
        private Estilo _estilo;
        private EstiloFrm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        public EstiloFrm(Estilo estilo) : this()
        {
            this._estilo = estilo;
            if (_estilo.EstiloId > 0)
            {
                this.txtNombre.Text = _estilo.Nombre;
            }
        }

        private bool ValidarDatos()
        {
            if (String.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("El campo nombre no puede estar vacío.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.txtNombre.Focus();
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }
            this._estilo.Nombre = this.txtNombre.Text;
            if (this._estilo.EstiloId > 0)
            {
                this._estilo.FechaModificacion = DateTime.Now;
            }
            else
            {
                this._estilo.FechaCreacion = DateTime.Now;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
