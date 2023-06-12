using EscritorioFaciens.Entidades;
using EscritorioFaciens.Mantenimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioFaciens.Administradores
{
    public partial class DisenoFrm : Form
    {
        private Diseno _diseno;
        private Negocio _negocio;
        private DisenoFrm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public DisenoFrm(Diseno diseno) : this()
        {
            this._negocio = new Negocio();
            this._diseno = diseno;
            this.CompletarPropiedades();
        }

        public async void CompletarPropiedades()
        {
            await CargarCombos(); //ESTO ES PARA ESPERAR HASTA QUE CARGEN LAS PROPIEDADES
            if (_diseno.DisenoId > 0)
            {
                this.txtNombre.Text = this._diseno.Nombre;
                this.txtDescripcion.Text = this._diseno.Descripcion;
                this.txtMateriales.Text = this._diseno.Materiales;
                this.cbPrenda.SelectedValue = this._diseno.PrendaId;
                this.cbEstilo.SelectedValue = this._diseno.EstiloId;
                this.cbTela.SelectedValue = this._diseno.TelaId;
                this.ObtenerEstado();
                await this.RefrescarImagenesAsync();
            }
        }

        private void ObtenerEstado()
        {
            switch (this._diseno.Dificultad)
            {
                case "Fácil":
                    this.cbDificultad.Text = DificultadEnum.Fácil.ToString();
                    break;
                case "Intermedio":
                    this.cbDificultad.Text = DificultadEnum.Intermedio.ToString();
                    break;
                case "Avanzado":
                    this.cbDificultad.Text = DificultadEnum.Avanzado.ToString();
                    break;
            }
        }

        private async Task CargarCombos()
        {
            try
            {
                List<Estilo> estilo = await this._negocio.ObtenerEstilos();
                List<Prenda> prenda = await this._negocio.ObtenerPrendas();
                List<Tela> tela = await this._negocio.ObtenerTelas();
                this.cbEstilo.DataSource = estilo;
                this.cbEstilo.DisplayMember = "Nombre";
                this.cbEstilo.ValueMember = "EstiloId";
                this.cbPrenda.DataSource = prenda;
                this.cbPrenda.DisplayMember = "Nombre";
                this.cbPrenda.ValueMember = "PrendaId";
                this.cbTela.DataSource = tela;
                this.cbTela.DisplayMember = "Nombre";
                this.cbTela.ValueMember = "TelaId";
                this.cbDificultad.DataSource = Enum.GetValues(typeof(DificultadEnum));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarImagenesDisenoNuevo()
        {
            int x = 0;
            this.lvDiseno.Items.Clear();
            this.ilImagenDiseno.Images.Clear();
            _diseno.ImagenDisenos.ForEach(id =>
            {
                this.ilImagenDiseno.Images.Add(new System.Drawing.Bitmap(id.Foto));
                ListViewItem item = new ListViewItem(new string[] { id.Nombre });
                item.ImageIndex = x;
                item.Tag = x;
                this.lvDiseno.Items.Add(item);
                x++;
            });

        }

        private async Task RefrescarImagenesAsync()
        {
            try
            {
                int x = 0;
                List<ImagenDiseno> imagenDiseno = await _negocio.ObtenerImagenes(_diseno.DisenoId);
                this.ilImagenDiseno.Images.Clear();
                this.lvDiseno.Items.Clear();
                imagenDiseno.ForEach(i =>
                {
                    this.ilImagenDiseno.Images.Add(FuncionesGenerales.CargarImagen(i.Foto));
                    ListViewItem item = new ListViewItem(new string[] { i.Nombre });
                    item.ImageIndex = x;
                    item.Tag = i.ImagenDisenoId;
                    this.lvDiseno.Items.Add(item);
                    x++;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            if (String.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                this.txtNombre.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(this.txtMateriales.Text))
            {
                this.txtMateriales.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(this.txtDescripcion.Text))
            {
                this.txtDescripcion.Focus();
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
            this._diseno.Nombre = this.txtNombre.Text;
            this._diseno.Materiales = this.txtMateriales.Text;
            this._diseno.Descripcion = this.txtDescripcion.Text;
            this._diseno.Dificultad = (string)this.cbDificultad.SelectedValue.ToString();
            this._diseno.EstiloId = (int)this.cbEstilo.SelectedValue;
            this._diseno.PrendaId = (int)this.cbPrenda.SelectedValue;
            this._diseno.TelaId = (int)this.cbTela.SelectedValue;
            if (this._diseno.DisenoId > 0)
            {
                this._diseno.FechaModificacion = DateTime.Now;
            }
            else
            {
                this._diseno.FechaCreacion = DateTime.Now;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmImagenesDiseno_Opening(object sender, CancelEventArgs e)
        {
            this.tsmiEliminarImagen.Enabled = false;
            this.tsmiModificarImagen.Enabled = false;
            if (this.lvDiseno.SelectedItems.Count > 0)
            {
                this.tsmiEliminarImagen.Enabled = true;
                this.tsmiModificarImagen.Enabled = true;
            }
        }

        private async void tsmiCrearImagen_ClickAsync(object sender, EventArgs e)
        {
            ImagenDiseno imagenDiseno = new ImagenDiseno();
            if (new ImagenDisenoFrm(imagenDiseno).ShowDialog() == DialogResult.OK)
            {
                if (_diseno.DisenoId == 0)
                {
                    _diseno.ImagenDisenos.Add(imagenDiseno); //SE INSERTAN LAS IMAGENES PARA DESDE EL MANTENIMIENTO DEL DISEÑO GUARDARLAS
                   this.CargarImagenesDisenoNuevo(); //SE CARGA LA LISTA DE IMAGENES DE OTRA FORMA
                }
                else
                {
                    try
                    {
                        imagenDiseno.DisenoId = _diseno.DisenoId;
                        await this._negocio.CrearImagenDiseno(imagenDiseno);
                        await this.RefrescarImagenesAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void tsmiModificarImagen_Click(object sender, EventArgs e)
        {
            if (_diseno.DisenoId == 0)
            {
                ModificarImagenDisenoNoAlmacenado();
            }
            else
            {
                try
                {
                    ImagenDiseno imagen = await this._negocio.ObtenerImagen((int)this.lvDiseno.SelectedItems[0].Tag);
                    await ModificarImagenDisenoAlmacenado(imagen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ModificarImagenDisenoNoAlmacenado()
        {
            int tag = (int)this.lvDiseno.SelectedItems[0].Tag;
            ImagenDiseno imagen = _diseno.ImagenDisenos.ElementAt(tag);
            this._diseno.ImagenDisenos.RemoveAt(tag);
            if (imagen != null)
            {
                if (new ImagenDisenoFrm(imagen).ShowDialog() == DialogResult.OK)
                {
                    _diseno.ImagenDisenos.Add(imagen); //SE GUARDA LA MODIFICADA
                    this.CargarImagenesDisenoNuevo();
                }
            }
        }

        private async Task ModificarImagenDisenoAlmacenado(ImagenDiseno imagen)
        {
            if (imagen != null)
            {
                if (new ImagenDisenoFrm(imagen).ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        await this._negocio.ModificarImagenDiseno(imagen); //MODIFICAR AQUI TMBN.
                        await this.RefrescarImagenesAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void tsmiEliminarImagen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar esta imágen?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (_diseno.DisenoId > 0)
                {
                    try
                    {
                        await this._negocio.EliminarImagenDiseno((int)this.lvDiseno.SelectedItems[0].Tag);
                        await this.RefrescarImagenesAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    int tag = (int)this.lvDiseno.SelectedItems[0].Tag; 
                    this.lvDiseno.SelectedItems.Clear();
                    _diseno.ImagenDisenos.RemoveAt(tag); 
                    this.CargarImagenesDisenoNuevo();
                }
            }
        }

        private async void lvDiseno_DoubleClick(object sender, EventArgs e)
        {
            ListView list = (ListView)sender;
            if (_diseno.DisenoId == 0)
            {
                ModificarImagenDisenoNoAlmacenado();
            }
            else
            {
                try
                {
                    ImagenDiseno imagen = await this._negocio.ObtenerImagen((int)list.SelectedItems[0].Tag);
                    await ModificarImagenDisenoAlmacenado(imagen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
