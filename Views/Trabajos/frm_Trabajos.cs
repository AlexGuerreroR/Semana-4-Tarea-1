using _06Publicaciones.config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _06Publicaciones.Views.Trabajos
{
    public partial class frm_Trabajos : Form
    {
        public frm_Trabajos()
        {
            InitializeComponent();
        }


        private void frm_Trabajos_Load(object sender, EventArgs e)
        {
            CargarTrabajos();
        }
        public void CargarTrabajos()
        {
            List<TrabajoModel> listaTrabajos = TrabajoModel.ObtenerTodos();
            lst_Trabajos.DataSource = null;
            lst_Trabajos.DataSource = listaTrabajos;
            lst_Trabajos.DisplayMember = "job_desc";
            lst_Trabajos.ValueMember = "job_id";
        }

        private bool validarcampos(params TextBox[] cajadetexto)
        {
            foreach (var caja in cajadetexto)
            {
                if (string.IsNullOrWhiteSpace(caja.Text))
                {
                    ErrorHandler.ManejarErrorGeneral(null, "Complete la información");
                    return false;
                }
            }
            return true;
        }

        private void ButtonInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarcampos(txt_idtrabajo, txt_nivelmax, txt_nivelmin, txt_trabajo))
                {
                    return;
                }

                var trabajo = new TrabajoModel
                {
                    job_id = txt_idtrabajo.Text,
                    job_desc = txt_trabajo.Text,
                    min_lvl = int.Parse(txt_nivelmin.Text),
                    max_lvl = int.Parse(txt_nivelmax.Text)
                };

                var insertado = TrabajoModel.Insertar(trabajo); 
                if (insertado != null)
                {
                    CargarTrabajos();
                    ErrorHandler.ManejarInsertar();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el trabajo.");
            }
        }

     

     

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (!validarcampos(txt_idtrabajo, txt_nivelmax, txt_nivelmin, txt_trabajo))
                {
                    return;
                }

                
                var trabajo = new TrabajoModel
                {

                    job_id = txt_idtrabajo.Text,
                    job_desc = txt_trabajo.Text,
                    min_lvl = int.Parse(txt_nivelmin.Text),
                    max_lvl = int.Parse(txt_nivelmax.Text)
                    
                };

              
                var existente = TrabajoModel.ObtenerPorId(trabajo.job_id);

                if (existente == null)
                {
                   
                    var insertado = TrabajoModel.Insertar(trabajo);
                    if (insertado != null)
                    {
                        CargarTrabajos();
                        ErrorHandler.ManejarInsertar();
                        MessageBox.Show("Trabajo insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar el trabajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                   
                    var actualizado = TrabajoModel.Actualizar(trabajo);
                    if (actualizado != null)
                    {
                        CargarTrabajos();
                        ErrorHandler.ManejarActualizar(); 
                        MessageBox.Show("Trabajo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error 1 al actualizar el trabajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

              
                btn_limpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al guardar el trabajo.");
            }
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_idtrabajo.Clear();
            txt_trabajo.Clear();
            txt_nivelmin.Clear();
            txt_nivelmax.Clear();
        }

        private void lst_Trabajos_DoubleClick(object sender, EventArgs e)
        {

            if (lst_Trabajos.SelectedValue != null)
            {
                var trabajo = TrabajoModel.ObtenerPorId(lst_Trabajos.SelectedValue.ToString()); 
                txt_idtrabajo.Text = trabajo.job_id;
                txt_trabajo.Text = trabajo.job_desc;
                txt_nivelmin.Text = trabajo.min_lvl.ToString();
                txt_nivelmax.Text = trabajo.max_lvl.ToString();
            }
            else
            {
                ErrorHandler.ManejarErrorGeneral(null, "Seleccione un ítem de la lista");
            }
        }
    }
}