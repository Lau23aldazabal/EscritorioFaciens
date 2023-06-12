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

namespace EscritorioFaciens
{
    public partial class Registro : Form
    {
        private CredencialesUsuarioDTO _credencialesUsuarioDTO;
        private Registro()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public Registro(CredencialesUsuarioDTO credencialesUsuarioDTO) : this()
        {
            this._credencialesUsuarioDTO = credencialesUsuarioDTO;
        }
        private void txtRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }
            _credencialesUsuarioDTO.Email = this.txtEmail.Text;
            _credencialesUsuarioDTO.Password =this.txtContrasena.Text; //se encipta aquí
            _credencialesUsuarioDTO.Username = this.txtNombreUsuario.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
 
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(this.txtContrasena.Text))
            {
                MessageBox.Show("El campo contraseña debe de estar completo.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.txtContrasena.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtEmail.Text))
            {
                MessageBox.Show("El campo email debe estar completo.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtNombreUsuario.Text))
            {
                MessageBox.Show("El campo nombre de usuario debe estar completo.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.txtNombreUsuario.Focus();
                return false;
            }
            return true;
        }
    }
}
