using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06Publicaciones.config;

namespace _06Publicaciones.Views.Autores
{
    public partial class frm_Autores : Form
    {
        public frm_Autores()
        {
            InitializeComponent();
        }

        private void frm_Autores_Load(object sender, EventArgs e)
        {
            CargaAutores();
        }

        public void CargaAutores() {
            var listaAutores = Autor.ObtenerTodos();
            lst_Autores.DataSource = null;
            lst_Autores.DataSource = listaAutores;
            lst_Autores.DisplayMember = "NombreCompleto";
            lst_Autores.ValueMember = "IdAutor";



        }
        private bool validarcampos(params TextBox[] cajadetexto) {
            foreach (var caja in cajadetexto) {
                if (string.IsNullOrWhiteSpace(caja.Text)) {
                    ErrorHandler.ManejarErrorGeneral(null, "Complete la informacion");
                    return false;               
                }
            }
            return true;
        }
        private void ButtonInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                #region
                /*if (string.IsNullOrWhiteSpace(textBoxIdAutor.Text)|| 
                    string.IsNullOrWhiteSpace(textBoxApellido.Text) ||
                    string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                    string.IsNullOrWhiteSpace(textBoxCiudad.Text) ||
                    string.IsNullOrWhiteSpace(textBoxCodigoPostal.Text) ||
                    string.IsNullOrWhiteSpace(textBoxDireccion.Text) ||
                    string.IsNullOrWhiteSpace(textBoxTelefono.Text) ||
                    string.IsNullOrWhiteSpace(textBoxEstado.Text) 
                    ) {
                    ErrorHandler.ManejarErrorGeneral(null, "Complete todo los campos");
                    return;
                }*/
                #endregion

                if (!validarcampos(textBoxApellido, textBoxCiudad, textBoxCodigoPostal, textBoxDireccion, textBoxEstado, textBoxIdAutor, textBoxNombre)) {
                    return;
                }

                var autor = new Autor
                {
                    IdAutor = textBoxIdAutor.Text,
                    Apellido = textBoxApellido.Text,
                    Nombre = textBoxNombre.Text,
                    Telefono = textBoxTelefono.Text,
                    Direccion = textBoxDireccion.Text,
                    Ciudad = textBoxCiudad.Text,
                    Estado = textBoxEstado.Text,
                    CodigoPostal = textBoxCodigoPostal.Text
                };

                var insertado = Autor.Insertar(autor);
                if (insertado != null)
                {
                    CargaAutores();
                    ErrorHandler.ManejarInsertar();
                }
                else {
                    return;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "");
            }
        }
        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIdAutor.Clear();
            textBoxApellido.Clear();
            textBoxNombre.Clear();
            textBoxTelefono.Clear();
            textBoxDireccion.Clear();
            textBoxCiudad.Clear();
            textBoxEstado.Clear();
            textBoxCodigoPostal.Clear();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Autores.SelectedValue != null)
            {
                var autor = Autor.ObtenerPorId(lst_Autores.SelectedValue.ToString());
                textBoxIdAutor.Text = autor.IdAutor;
                textBoxApellido.Text = autor.Apellido;
                textBoxNombre.Text = autor.Nombre;
                textBoxTelefono.Text = autor.Telefono;
                textBoxDireccion.Text = autor.Direccion;
                textBoxCiudad.Text = autor.Ciudad;
                textBoxEstado.Text = autor.Estado;
                textBoxCodigoPostal.Text = autor.CodigoPostal;
            }
            else
            {
                ErrorHandler.ManejarErrorGeneral(null, "Seleccione un item de la lista");
            }
        }

        private void lst_Autores_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}
