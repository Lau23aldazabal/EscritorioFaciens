using EscritorioFaciens.Administradores;
using EscritorioFaciens.Mantenimiento;
using Infragistics.Win.UltraWinTabControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace EscritorioFaciens
{
    public partial class Principal : Form
    {
        private bool _cerrarSesion = false;
        public Principal()
        {
            InitializeComponent();
        }

        private void tsmiDiseño_Click(object sender, EventArgs e)
        {
            Form mantenimientoDiseño = Application.OpenForms.Cast<Form>().FirstOrDefault(u => u is MantenimientoDiseño); //SE COMPRUEBA QUE NO ESTA YA ABIERTO ESTE FORMULARIO.
            if (mantenimientoDiseño != null)
            {

                mantenimientoDiseño.BringToFront();
                return;

            }
            mantenimientoDiseño = new MantenimientoDiseño();
            mantenimientoDiseño.MdiParent = this;
            mantenimientoDiseño.Show();
        }

        private void tsmiEstilo_Click(object sender, EventArgs e)
        {
            Form mantenimientoEstilo = Application.OpenForms.Cast<Form>().FirstOrDefault(u => u is MantenimientoEstilo);
            if (mantenimientoEstilo != null)
            {
                mantenimientoEstilo.BringToFront();
                return;

            }
            mantenimientoEstilo = new MantenimientoEstilo();
            mantenimientoEstilo.MdiParent = this;
            mantenimientoEstilo.Show();
        }

        private void tsmiPrenda_Click(object sender, EventArgs e)
        {
            Form mantenimientoPrenda = Application.OpenForms.Cast<Form>().FirstOrDefault(u => u is MantenimientoPrenda);
            if (mantenimientoPrenda != null)
            {
                mantenimientoPrenda.BringToFront();
                return;

            }
            mantenimientoPrenda = new MantenimientoPrenda();
            mantenimientoPrenda.MdiParent = this;
            mantenimientoPrenda.Show();
        }

        private void tsmiTela_Click(object sender, EventArgs e)
        {
            Form mantenimientoTela = Application.OpenForms.Cast<Form>().FirstOrDefault(u => u is MantenimientoTela);
            if (mantenimientoTela != null)
            {
                mantenimientoTela.BringToFront();
                return;

            }
            mantenimientoTela = new MantenimientoTela();
            mantenimientoTela.MdiParent = this;
            mantenimientoTela.Show();
        }

        private void tsmiPermisosUsuario_Click(object sender, EventArgs e)
        {
            Form mantenimientoPermisos = Application.OpenForms.Cast<Form>().FirstOrDefault(u => u is MantenimientoPermisos);
            if (mantenimientoPermisos != null)
            {
                mantenimientoPermisos.BringToFront();
                return;
            }
            mantenimientoPermisos = new MantenimientoPermisos();
            mantenimientoPermisos.MdiParent = this;
            mantenimientoPermisos.Show();
        }

        private void tsmiBloqueosDesbloqueos_Click(object sender, EventArgs e)
        {
            Form mantenimientoBloqueos = Application.OpenForms.Cast<Form>().FirstOrDefault(b => b is MantenimientoCuentas);
            if (mantenimientoBloqueos != null)
            {
                mantenimientoBloqueos.BringToFront();
                return;
            }
            mantenimientoBloqueos = new MantenimientoCuentas();
            mantenimientoBloqueos.MdiParent = this;
            mantenimientoBloqueos.Show();
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiCascada_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_cerrarSesion)
            {
                Application.Exit();
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
