using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06Publicaciones.config;

namespace _06Publicaciones.Controllers
{
    public class TrabajoController
    {
        // Método para insertar un trabajo
        public TrabajoModel InsertarTrabajo(TrabajoModel trabajo)
        {
            return TrabajoModel.Insertar(trabajo);
        }

        // Método para actualizar un trabajo
        public string ActualizarTrabajo(TrabajoModel trabajo)
        {
            return TrabajoModel.Actualizar(trabajo);
        }

        // Método para eliminar un trabajo
        public string EliminarTrabajo(string trabajo)
        {
            return TrabajoModel.Eliminar(trabajo);
        }

        // Método para obtener un trabajo por ID
        public TrabajoModel ObtenerTrabajoPorId(string idTrabajo)
        {
            return TrabajoModel.ObtenerPorId(idTrabajo);
        }

        // Método para obtener todos los trabajos
        public List<TrabajoModel> ObtenerTodosLosTrabajos()
        {
            return TrabajoModel.ObtenerTodos();
        }
    }
}
