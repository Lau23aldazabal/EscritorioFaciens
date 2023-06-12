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
    public partial class PrendaFrm : Form
    {
        private Prenda _prenda;
        private PrendaFrm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        public PrendaFrm(Prenda prenda) : this()
        {
            this._prenda = prenda;
            if (_prenda.PrendaId > 0)
            {
                this.txtNombre.Text = this._prenda.Nombre;
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
            this._prenda.Nombre = this.txtNombre.Text;
            if (this._prenda.PrendaId > 0)
            {
                this._prenda.FechaModificacion = DateTime.Now;
            }
            this._prenda.FechaCreacion = DateTime.Now;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
