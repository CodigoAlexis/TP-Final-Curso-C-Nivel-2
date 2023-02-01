using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AplicaciónParaGestiónDeArtículos
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo = null;
        public frmDetalleArticulo()
        {
            InitializeComponent();
        }
        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle del artículo";
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pictureBoxDetalle.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxDetalle.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }


        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                

                if (articulo != null)
                {
                    textBoxVerCodigo.Text = articulo.Codigo;
                    textBoxVerNombre.Text = articulo.Nombre;
                    textBoxVerDescripcion.Text = articulo.Descripcion;
                    textBoxVerUrlImagen.Text = articulo.ImagenUrl;
                    textBoxVerPrecio.Text = articulo.Precio.ToString();
                    CargarImagen(articulo.ImagenUrl);
                    textBoxVerCategoria.Text = articulo.Categoria.ToString();
                    textBoxVerMarca.Text= articulo.Marca.ToString();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
