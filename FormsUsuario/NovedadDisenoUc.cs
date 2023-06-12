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

namespace EscritorioFaciens.FormsUsuario
{
    public partial class NovedadDisenoUc : UserControl
    {
        public NovedadDisenoUc()
        {
            InitializeComponent();
        }

        private async void pbImagen_DoubleClick(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            try
            {
                Diseno diseno = await negocio.ObtenerDiseno((int)pbImagen.Tag);
                if (diseno != null)
                {
                    FichaDisenoFrm disenoFicha = new FichaDisenoFrm(diseno);
                    disenoFicha.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
