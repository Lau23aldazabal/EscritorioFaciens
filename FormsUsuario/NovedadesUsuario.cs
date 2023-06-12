using EscritorioFaciens.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml.Media;

namespace EscritorioFaciens.FormsUsuario
{
    public partial class NovedadesUsuario : Form
    {
        private readonly Negocio _negocio;

        public NovedadesUsuario()
        {
            InitializeComponent();
            this._negocio = new Negocio();
            this.CargarCombos();
            this.InicializarLista();
        }

        private async void CargarCombos()
        {
            try
            {
                this.clbDificultad.DataSource = Enum.GetValues(typeof(DificultadEnum));
                List<Estilo> estilo = await this._negocio.ObtenerEstilos();
                this.clbEstilo.DataSource = estilo;
                this.clbEstilo.DisplayMember = "Nombre";
                this.clbEstilo.ValueMember = "EstiloId";
                List<Prenda> prenda = await this._negocio.ObtenerPrendas();
                this.clbPrenda.DataSource = prenda;
                this.clbPrenda.DisplayMember = "Nombre";
                this.clbPrenda.ValueMember = "PrendaId";
                List<Tela> tela = await this._negocio.ObtenerTelas();
                this.clbTela.DataSource = tela;
                this.clbTela.DisplayMember = "Nombre";
                this.clbTela.ValueMember = "TelaId";
                this.LimpiarSeleccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarSeleccion()
        {
            this.clbDificultad.SelectedItems.Clear();
            this.clbEstilo.SelectedItems.Clear();
            this.clbPrenda.SelectedItems.Clear();
            this.clbTela.SelectedItems.Clear();
        }

        private async void InicializarLista()
        {
            try
            {
                this.CargarDisenos(await _negocio.ObtenerDisenos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDisenos(List<Diseno> disenos)
        {
            this.flpPrincipal.Controls.Clear();
            try
            {
                disenos = disenos.OrderByDescending(d => d.FechaCreacion).ToList();
                disenos.ForEach(async d =>
                {
                    NovedadDisenoUc novedad = new NovedadDisenoUc();
                    List<ImagenDiseno> imagen = await _negocio.ObtenerImagenes(d.DisenoId);
                    novedad.pbImagen.Image = FuncionesGenerales.CargarImagen(imagen.First().Foto);
                    novedad.pbImagen.Tag = d.DisenoId;
                    novedad.pbImagen.SizeMode = novedad.pbImagen.Image.Size.Width > novedad.pbImagen.ClientSize.Width || novedad.pbImagen.Image.Size.Height > novedad.pbImagen.ClientSize.Height ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
                    novedad.txtDetallesDiseno.Text = Environment.NewLine + d.Nombre.ToUpper() + Environment.NewLine;
                    this.flpPrincipal.Controls.Add(novedad);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task FiltrosDisenosAsync()
        {
            List<Diseno> disenos = await _negocio.ObtenerDisenos();
            if (!String.IsNullOrEmpty(this.txtNombreDiseno.Text.Trim()))
            {
                disenos = disenos.Where(d => d.Nombre.Trim().ToUpper().Contains(this.txtNombreDiseno.Text.Trim().ToUpper())).ToList();
            }
            if (clbTela.CheckedItems.Count > 0 && clbTela.CheckedItems.Count < clbTela.Items.Count)
            {
                disenos = disenos.Where(d => clbTela.CheckedItems.Cast<Tela>().ToList().Any(t => t.TelaId.Equals(d.TelaId))).ToList();
            }
            if (clbEstilo.CheckedItems.Count > 0 && clbEstilo.CheckedItems.Count < clbEstilo.Items.Count)
            {
                disenos = disenos.Where(d => clbEstilo.CheckedItems.Cast<Estilo>().ToList().Any(e => e.EstiloId.Equals(d.EstiloId))).ToList();
            }
            if (clbPrenda.CheckedItems.Count > 0 && clbPrenda.CheckedItems.Count < clbPrenda.Items.Count)
            {
                disenos = disenos.Where(d => clbPrenda.CheckedItems.Cast<Prenda>().ToList().Any(p => p.PrendaId.Equals(d.PrendaId))).ToList();
            }
            if (clbDificultad.CheckedItems.Count > 0 && clbDificultad.CheckedItems.Count < clbDificultad.Items.Count)
            {
                disenos = disenos.Where(d => clbDificultad.CheckedItems.Cast<DificultadEnum>().ToList().Any(nivel => nivel.ToString().Trim().Equals(d.Dificultad.Trim()))).ToList();
            }
            this.CargarDisenos(disenos);
        }

        private async void txtNombreDiseno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                await this.FiltrosDisenosAsync();
            }
        }

        private void ComprobarSeleccion(CheckedListBox checkedList)
        {
            if (checkedList.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedList.Items.Count; i++)
                    checkedList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void Limpiar()
        {
            this.txtNombreDiseno.Clear();
            this.ComprobarSeleccion(this.clbDificultad);
            this.ComprobarSeleccion(this.clbEstilo);
            this.ComprobarSeleccion(this.clbPrenda);
            this.ComprobarSeleccion(this.clbTela);
            this.LimpiarSeleccion();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.InicializarLista();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await this.FiltrosDisenosAsync();
        }

    }
}
