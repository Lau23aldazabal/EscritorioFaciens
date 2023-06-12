using EscritorioFaciens.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EscritorioFaciens.Mantenimiento
{
    public partial class ImagenDisenoFrm : Form
    {
        private ImagenDiseno _imagenDiseno;
        private ImagenDisenoFrm()
        {
            InitializeComponent();
        }

        public ImagenDisenoFrm(ImagenDiseno imagenDiseno) : this()
        {
            this._imagenDiseno = imagenDiseno;
            if (_imagenDiseno.ImagenDisenoId > 0)
            {
                this.txtNombre.Text = this._imagenDiseno.Nombre;
                this.txtDescripcion.Text = this._imagenDiseno.Descripcion;
                this.pbImagenDiseno.Image = FuncionesGenerales.CargarImagen(this._imagenDiseno.Foto);
            }
            else if(_imagenDiseno.Foto!=null) //SI NO ES UNA URL 
            {
                this.txtNombre.Text = this._imagenDiseno.Nombre;
                this.txtDescripcion.Text = this._imagenDiseno.Descripcion;
                this.pbImagenDiseno.Image = new Bitmap(this._imagenDiseno.Foto);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }
            this._imagenDiseno.Nombre = this.txtNombre.Text;
            this._imagenDiseno.Descripcion = this.txtDescripcion.Text;
            if (this._imagenDiseno.ImagenDisenoId > 0)
            {
                this._imagenDiseno.FechaModificacion = DateTime.Now;
            }
            else
            {
                this._imagenDiseno.FechaCreacion = DateTime.Now;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarDatos()
        {
            if (String.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("El campo nombre no puede estar vacío.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.txtNombre.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(this.txtDescripcion.Text))
            {
                MessageBox.Show("El campo descripción no puede estar vacío.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.txtDescripcion.Focus();
                return false;
            }
            if (this.pbImagenDiseno.Image == null)
            {
                MessageBox.Show("La imágen no puede estar vacía.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.pbImagenDiseno.Focus();
                return false;
            }
            return true;
        }

        private void tsbAdjuntarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif" +
            "|PNG Portable Network Graphics (*.png)|*.png" +
            "|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
            "|BMP Windows Bitmap (*.bmp)|*.bmp" +
            "|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
            "|GIF Graphics Interchange Format (*.gif)|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pbImagenDiseno.Image = new Bitmap(dialog.FileName);
                this.pbImagenDiseno.SizeMode = PictureBoxSizeMode.Zoom;
                this._imagenDiseno.Foto = dialog.FileName;
            }
        }
    }
}
