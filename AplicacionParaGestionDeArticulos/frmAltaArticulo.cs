using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace AplicaciónParaGestiónDeArtículos
{


    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo=null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Articulo art = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.Codigo = textBoxCodigo.Text;
                articulo.Nombre = textBoxNombre.Text;
                articulo.Descripcion = textBoxDescripcion.Text;
                articulo.Marca = (Marca)comboBoxMarca.SelectedItem;
                articulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                articulo.ImagenUrl = textBoxImagenUrl.Text;
                articulo.Precio = Decimal.Parse(textBoxPrecio.Text);


                if (articulo.Id != 0)
                {
                    negocio.Modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");

                }
                else
                {
                    negocio.Agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");

                }

                // Guardo imagen si la levanto localmente
                if(archivo!=null&&!(textBoxImagenUrl.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                }

                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Verifiqué que todas las casillas estén completas y estén completas con el formato correspondiente");
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                comboBoxCategoria.DataSource = categoriaNegocio.Listar();
                comboBoxCategoria.ValueMember = "Id";
                comboBoxCategoria.DisplayMember = "Descripcion";
                comboBoxMarca.DataSource = marcaNegocio.Listar();
                comboBoxMarca.ValueMember = "Id";
                comboBoxMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    textBoxCodigo.Text = articulo.Codigo;
                    textBoxNombre.Text = articulo.Nombre;
                    textBoxDescripcion.Text = articulo.Descripcion;
                    textBoxImagenUrl.Text = articulo.ImagenUrl;
                    textBoxPrecio.Text = articulo.Precio.ToString();
                    CargarImagen(articulo.ImagenUrl);
                    comboBoxCategoria.SelectedValue = articulo.Categoria.Id;
                    comboBoxMarca.SelectedValue = articulo.Marca.Id;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void textBoxImagenUrl_Leave(object sender, EventArgs e)
        {
            CargarImagen(textBoxImagenUrl.Text);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pictureBoxNuevoArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxNuevoArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo=new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            archivo.ShowDialog();

            if(archivo.ShowDialog() == DialogResult.OK)
            {
                textBoxImagenUrl.Text=archivo.FileName;
                CargarImagen(archivo.FileName);

                // Guardo la imagen
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] +archivo.SafeFileName);

            }

        }
    }
}
