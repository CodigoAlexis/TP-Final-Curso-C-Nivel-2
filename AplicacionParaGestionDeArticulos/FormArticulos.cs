using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace AplicaciónParaGestiónDeArtículos
{
    public partial class FormArticulos : System.Windows.Forms.Form
    {
        private List<Articulo> listaArticulo;
        public FormArticulos()
        {
            InitializeComponent();
        }




        private void FormArticulos_Load(object sender, EventArgs e)
        {
            Cargar();
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Descripcion");
        }

        private void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulo = negocio.listar();
                dataGridViewArticulos.DataSource = listaArticulo;
                OcultarColumnas();
                pictureBoxArticulo.Load(listaArticulo[0].ImagenUrl);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void OcultarColumnas()
        {
            dataGridViewArticulos.Columns["ImagenUrl"].Visible = false;
            dataGridViewArticulos.Columns["Id"].Visible = false;
        }

        private void dataGridViewArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);

            }




        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pictureBoxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            Cargar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            try
            {
                seleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;
                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                modificar.ShowDialog();
                Cargar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Por favor, seleccione un articulo para modificar");
            }
        }

        private void buttonEliminarFisica_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {


                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;
                    negocio.EliminarFisica(seleccionado.Id);
                    Cargar();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool ValidarFiltro()
        {
            if (comboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar");
                return true;
            }
            if (comboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccionle el criterio para filtrar");
                return true;
            }
            return false;
        }

        private void buttonFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (ValidarFiltro())
                {
                    return;
                }

                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltroAvanzado.Text;
                dataGridViewArticulos.DataSource = negocio.Filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }



        }

        private void textBoxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = textBoxFiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listaArticulo;
            }



            dataGridViewArticulos.DataSource = null;
            dataGridViewArticulos.DataSource = listaFiltrada;
            OcultarColumnas();
        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.Text.ToString();

            if (opcion == "Nombre" || opcion == "Descripcion")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Comienza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }

        }

        private void buttonVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();

            try
            {
                seleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;
                frmDetalleArticulo detalle = new frmDetalleArticulo(seleccionado);
                detalle.ShowDialog();
                Cargar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Por favor, seleccione un articulo para ver el detalle");
            }
        }
    }
}
