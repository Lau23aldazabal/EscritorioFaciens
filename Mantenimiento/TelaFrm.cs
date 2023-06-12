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

namespace EscritorioFaciens
{
    public partial class TelaFrm : Form
    {
        private Tela _tela;
        private TelaFrm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        public TelaFrm(Tela tela) : this()
        {
            this._tela = tela;
            if (this._tela.TelaId > 0)
            {
                this.txtNombre.Text = this._tela.Nombre;
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
            this._tela.Nombre = this.txtNombre.Text;
            if (this._tela.TelaId > 0)
            {
                this._tela.FechaModificacion = DateTime.Now;
            }
            else
            {
                this._tela.FechaCreacion = DateTime.Now;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
