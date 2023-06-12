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
using System.Security.Cryptography;
using System.Net.Mail;
using EscritorioFaciens.FormsUsuario;

namespace EscritorioFaciens
{
    public partial class Login : Form
    {
        private readonly Negocio _negocio;
        private bool _inicioSesion = false;

        public Login()
        {
            InitializeComponent();
            this._negocio = new Negocio();
            this.DialogResult = DialogResult.Cancel;
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }
            CredencialesUsuarioDTO credenciales = new CredencialesUsuarioDTO();
            credenciales.Password = this.txtPassword.Text;
            if (ValidarEmail(this.txtUsuario.Text))
            {
                credenciales.Email = this.txtUsuario.Text;
            }
            else
            {
                credenciales.Username = this.txtUsuario.Text;
            }
            await MostrarInicio(credenciales);
        }

        private async Task MostrarInicio(CredencialesUsuarioDTO credenciales)
        {
            try
            {
                if (await _negocio.Login(credenciales))
                {
                    this.DialogResult = DialogResult.OK;
                    if (await this._negocio.EsAdminAsync())
                    {
                        Principal principalAdmin = new Principal();
                        if (await this._negocio.EsSuperAdminAsync())
                        {
                            principalAdmin.tsmiSuperAdmin.Visible = true;
                        }
                        principalAdmin.Show();
                    }
                    else
                    {
                        PrincipalUsuarioMDI principalUsuario = new PrincipalUsuarioMDI();
                        principalUsuario.Show();
                    }
                }
                _inicioSesion = true;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void lnlRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Opacity = 0.7;
            CredencialesUsuarioDTO credencialesUsuario = new CredencialesUsuarioDTO();
            if (new Registro(credencialesUsuario).ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (await this._negocio.Registro(credencialesUsuario))
                        MessageBox.Show("Se ha registrado con éxito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Opacity = 1;
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("El campo usuario nombre o email debe de estar completo.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.txtUsuario.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("El campo contraseña debe estar completo.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.txtPassword.Focus();
                return false;
            }
            return true;
        }

        public bool ValidarEmail(string emailaddress) //PARA SABER SI EEL USUARIO INTRODUCE EMAIL O USERNAME PARA INICIAR SESCION
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_inicioSesion)
            {
                Application.Exit();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_inicioSesion) //POR SI EL USUARIO CIERRA SESIÓN Y SI CIERRA LA PESTAÑA DE LOGIN, LA APLICACION EJECUTE EL .EXIT Y DEJE DE ESTAR FUNCIONANDO SIN MOSTRARSE
            {
                return;
            }
            if (MessageBox.Show("¿Estás seguro de que quieres abandonar el programa?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
