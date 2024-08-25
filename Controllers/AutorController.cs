using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _06Publicaciones.config;

namespace _06Publicaciones.Controllers
{
    public class AutorController
    {

        public Autor InsertarAutor(Autor autor)
        {
             return Autor.Insertar(autor);
        }
      
        public string ActualizarAutor(Autor autor)
        {
               return Autor.Actualizar(autor);               
        }
     
        public string EliminarAutor(string idAutor)
        {
                return Autor.Eliminar(idAutor);
        }
        
        public Autor ObtenerAutorPorId(string idAutor)
        {
                return Autor.ObtenerPorId(idAutor);
        }

        public List<Autor> ObtenerTodosLosAutores()
        {
                return Autor.ObtenerTodos();
        }
    }
}
