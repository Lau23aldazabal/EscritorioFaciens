using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioFaciens.FormsUsuario
{
    public partial class PrincipalUsuarioMDI : Form
    {
        private bool _cerrarSesion = false;
        //LO HE PUESTO EN MDI SEPARADOS POR QUE QUERIA UN DISEÑO DISTITNO PARA USUARIOS Y ADMINISTRADORES
        //INTENTARE CAMBIAR EL DISEÑO DE AQUÍ AL DÍA DE LA PRESENTACIÓN. Y PASAR LOS OBJETOS A LOS DTO.
        public PrincipalUsuarioMDI()
        {
            InitializeComponent();
        }


        private void PrincipalUsuarioMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_cerrarSesion)
            {
                Application.Exit();
            }
        }

        private void PrincipalUsuarioMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cerrarSesion)
            {
                return;
            }
            if (MessageBox.Show("¿Estás seguro de que quieres abandonar el programa?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void tsmiNovedades_Click(object sender, EventArgs e)
        {
            Form novedadesUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(b => b is NovedadesUsuario);
            if (novedadesUsuario != null)
            {
                novedadesUsuario.BringToFront();
                return;
            }
            novedadesUsuario = new NovedadesUsuario();
            novedadesUsuario.MdiParent = this;
            novedadesUsuario.Show();
        }

        private void tsmiMisProyectos_Click(object sender, EventArgs e)
        {
            Form proyectos = Application.OpenForms.Cast<Form>().FirstOrDefault(b => b is Proyectos);
            if (proyectos != null)
            {
                proyectos.BringToFront();
                return;
            }
            proyectos = new Proyectos();
            proyectos.MdiParent = this;
            proyectos.Show();
        }

        private void tsmiCerrarSesionMDI_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _cerrarSesion = true;
                Properties.Settings.Default.JwtToken = string.Empty;
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void tsmiSalirMDI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
