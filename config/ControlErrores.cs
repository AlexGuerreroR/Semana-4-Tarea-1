using System;
using System.Windows.Forms;

namespace _06Publicaciones.config
{
    public static class ErrorHandler
    {
        // Método para manejar excepciones de SQL
        public static void ManejarErrorSql(Exception ex, string mensajePersonalizado = "Ocurrió un error en la base de datos.")
        {
            // Registrar el error (puede expandirse para registrar en un archivo o base de datos)
           // Console.WriteLine($"Error de SQL: {ex.Message}");

            // Mostrar el MessageBox con el mensaje de error
            MessageBox.Show($"{mensajePersonalizado}\n\nDetalles del error:\n{ex.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Método para manejar excepciones generales
        public static void ManejarErrorGeneral(Exception ex=null, string mensajePersonalizado = "Ocurrió un error inesperado.")
        {
            // Registrar el error (puede expandirse para registrar en un archivo o base de datos)
            //Console.WriteLine($"Error: {ex.Message}");

            // Mostrar el MessageBox con el mensaje de error
            if (ex != null)
            {
                MessageBox.Show($"{mensajePersonalizado}\n\nDetalles del error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                MessageBox.Show(mensajePersonalizado);
            }

        }
        public static void ManejarInsertar() {
            MessageBox.Show("Se insertó con éxito");
        }
        public static void ManejarActualizar()
        {
            MessageBox.Show("Se actualizó con éxito");
        }
        public static void ManejarEliminar()
        {
            MessageBox.Show("Se eliminó con éxito");
        }
    }
}
