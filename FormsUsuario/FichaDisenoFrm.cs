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
using Windows.UI.Xaml.Controls;

namespace EscritorioFaciens.FormsUsuario
{
    public partial class FichaDisenoFrm : Form
    {
        private readonly Diseno _diseno;
        private readonly Negocio _negocio;
        private List<ImagenDiseno> _imagenDisenos;
        private int _index;
        private FichaDisenoFrm()
        {
            InitializeComponent();
        }

        public FichaDisenoFrm(Diseno diseno) : this()
        {
            this._negocio = new Negocio();
            this._diseno = diseno;
            if (_diseno.DisenoId > 0)
            {
                this.Text = _diseno.Nombre.ToUpper();
                this.txtDescripcion.Text = String.Concat(_diseno.Descripcion, Environment.NewLine, Environment.NewLine, $"MATERIALES: {_diseno.Materiales}");
                this.CargarListaImagenes();
                this.CargarListaComentarios();
                this.CargarPropiedades();
            }
        }

        private async void CargarPropiedades()
        {
            try
            {
                string estilo = await _negocio.ObteneNombrerEstilo(_diseno.EstiloId);
                string prenda = await _negocio.ObteneNombrerPrenda(_diseno.PrendaId);
                string tela = await _negocio.ObteneNombrerTela(_diseno.TelaId);
                this.txtDescripcion.Text += String.Concat(Environment.NewLine, $"EXTERIOR {tela.ToUpper()}", Environment.NewLine, $"ESTILO {prenda.ToUpper()}{" "}{estilo.ToUpper()}");
                List<Proyecto> proyectos = await _negocio.ObtenerProyectos();
                this.btnAniadirProyecto.Enabled = !proyectos.Any(p => p.DisenoId == _diseno.DisenoId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarListaImagenes()
        {
            try
            {
                _imagenDisenos = await _negocio.ObtenerImagenes(_diseno.DisenoId);
                _index = 0;
                this.pbImgDiseno.Image = FuncionesGenerales.CargarImagen(_imagenDisenos.First().Foto);
                this.rtbDescripcionImg.Text = _imagenDisenos.First().Nombre.ToUpper() + Environment.NewLine + _imagenDisenos.First().Descripcion + Environment.NewLine;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarListaComentarios()
        {
            this.flpComentarios.Controls.Clear();
            try
            {
                List<Comentario> comentarios = await _negocio.ObtenerComentarios(_diseno.DisenoId);
                //comentarios.OrderByDescending(c => c.FechaCreacion);
                comentarios.ForEach(async c =>
                {
                    ComentarioUc comentarioUc = new ComentarioUc();
                    comentarioUc.lblFecha.Text = c.FechaCreacion.ToString("dd/MM/yyyy");
                    comentarioUc.lblUser.Text = await this._negocio.ObtenerUsername(c.UsuarioId); //pasar el nombre del usuario directamente .
                    comentarioUc.txtComentario.Text = c.Texto;
                    this.flpComentarios.Controls.Add(comentarioUc);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void txtComentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtComentario.Text.Trim()))
            {
                if (e.KeyChar == (char)13)
                {
                    await EnviarComentario();
                }
            }
        }

        private async Task EnviarComentario()
        {
            try
            {
                await _negocio.CrearComentario(new Comentario() { Texto = this.txtComentario.Text.Trim(), FechaCreacion = DateTime.Now, DisenoId = _diseno.DisenoId });
                this.CargarListaComentarios();
                this.txtComentario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al enviar el comentario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (_index == this._imagenDisenos.Count - 1)
            {
                return;
            }
            _index++;
            this.pbImgDiseno.Image = FuncionesGenerales.CargarImagen(this._imagenDisenos.ElementAt(_index).Foto);
            this.rtbDescripcionImg.Text = _imagenDisenos.ElementAt(_index).Nombre.ToUpper() + Environment.NewLine + _imagenDisenos.ElementAt(_index).Descripcion + Environment.NewLine;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_index == 0)
            {
                return;
            }
            _index--;
            this.pbImgDiseno.Image = FuncionesGenerales.CargarImagen(this._imagenDisenos.ElementAt(_index).Foto);
            this.rtbDescripcionImg.Text = _imagenDisenos.ElementAt(_index).Nombre.ToUpper() + Environment.NewLine + _imagenDisenos.ElementAt(_index).Descripcion + Environment.NewLine;
        }

        private async void btnAniadirProyecto_Click(object sender, EventArgs e)
        {
            try
            {
                await this._negocio.CrearProyecto(new Proyecto() { DisenoId = _diseno.DisenoId, Realizado = false, FechaGuardado = DateTime.Now });
                this.btnAniadirProyecto.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al enviar el comentario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
