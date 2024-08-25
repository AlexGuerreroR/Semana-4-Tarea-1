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

namespace _06Publicaciones.Views.Empleados
{
    public partial class frm_empleados : Form
    {
        public frm_empleados()
        {
            InitializeComponent();
        }

        private void frm_empleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        public void CargarEmpleados()
        {
            List<Empleado> listaEmpleados = Empleado.ObtenerTodos();
            lst_Empleados.DataSource = null;
            lst_Empleados.DataSource = listaEmpleados;
            lst_Empleados.DisplayMember = "Fname";
            lst_Empleados.ValueMember = "Emp_id";
        }

        private bool ValidarCampos(params TextBox[] cajadetexto)
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

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_empid, txt_fname, txt_lname, txt_minit, txt_jobid, txt_joblvl, txt_pubid))
                {
                    return;
                }

                var empleado = new Empleado
                {
                    Emp_id = txt_empid.Text,
                    Fname = txt_fname.Text,
                    Lname = txt_lname.Text,
                    Minit = txt_minit.Text,
                    Job_id = txt_jobid.Text,
                    Job_lvl = txt_joblvl.Text,
                    Pub_id = txt_pubid.Text,
                    Hire_date = dtp_hiredate.Value
                };

                var insertado = Empleado.Insertar(empleado);
                if (insertado != null)
                {
                    CargarEmpleados();
                    ErrorHandler.ManejarInsertar();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el empleado.");
            }
        }

      

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_empid, txt_fname, txt_lname, txt_minit, txt_jobid, txt_joblvl, txt_pubid))
                {
                    return;
                }

                var empleado = new Empleado
                {
                    Emp_id = txt_empid.Text,
                    Fname = txt_fname.Text,
                    Lname = txt_lname.Text,
                    Minit = txt_minit.Text,
                    Job_id = txt_jobid.Text,
                    Job_lvl = txt_joblvl.Text,
                    Pub_id = txt_pubid.Text,
                    Hire_date = dtp_hiredate.Value
                };

                var existente = Empleado.ObtenerPorId(empleado.Emp_id);

                if (existente == null)
                {
                    var insertado = Empleado.Insertar(empleado);
                    if (insertado != null)
                    {
                        CargarEmpleados();
                        ErrorHandler.ManejarInsertar();
                        MessageBox.Show("Empleado insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var actualizado = Empleado.Actualizar(empleado);
                    if (actualizado != null)
                    {
                        CargarEmpleados();
                        ErrorHandler.ManejarActualizar();
                        MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                btn_limpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al guardar el empleado.");
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_empid.Clear();
            txt_fname.Clear();
            txt_lname.Clear();
            txt_minit.Clear();
            txt_jobid.Clear();
            txt_joblvl.Clear();
            txt_pubid.Clear();
        }

        private void lst_Empleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_Empleados_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Empleados.SelectedValue != null)
            {
                var empleado = Empleado.ObtenerPorId(lst_Empleados.SelectedValue.ToString());
                txt_empid.Text = empleado.Emp_id;
                txt_fname.Text = empleado.Fname;
                txt_lname.Text = empleado.Lname;
                txt_minit.Text = empleado.Minit;
                txt_jobid.Text = empleado.Job_id;
                txt_joblvl.Text = empleado.Job_lvl;
                txt_pubid.Text = empleado.Pub_id;
                dtp_hiredate.Value = empleado.Hire_date;
            }
            else
            {
                ErrorHandler.ManejarErrorGeneral(null, "Seleccione un ítem de la lista");
            }
        }
    }
}