using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Controllers
{
    public class EmpleadoController
    {
     
        public Empleado InsertarEmpleado(Empleado empleado)
        {
            return Empleado.Insertar(empleado);
        }

        // Método para actualizar un empleado
        public string ActualizarEmpleado(Empleado empleado)
        {
            return Empleado.Actualizar(empleado);
        }

        
        public string EliminarEmpleado(string idEmpleado)
        {
            return Empleado.Eliminar(idEmpleado);
        }


        public Empleado ObtenerEmpleadoPorId(string idEmpleado)
        {
            return Empleado.ObtenerPorId(idEmpleado);
        }


        public List<Empleado> ObtenerTodosLosEmpleados()
        {
            return Empleado.ObtenerTodos();
        }
    }
}
