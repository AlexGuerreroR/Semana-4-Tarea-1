using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06Publicaciones.Views.Empleados;
using _06Publicaciones.Views.Autores;
using _06Publicaciones.Views.Trabajos;


namespace _06Publicaciones.Views
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_empleados _Empleados = new frm_empleados();
            _Empleados.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Autores _Autores = new frm_Autores();
            _Autores.ShowDialog();

        }

        private void trabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         frm_Trabajos Trabajos = new frm_Trabajos();
            Trabajos.ShowDialog();
        }
    }
}
