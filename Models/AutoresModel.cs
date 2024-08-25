using System;
using System.Data.SqlClient;
using _06Publicaciones.config;
using System.Windows.Forms;
using System.Collections.Generic;

namespace _06Publicaciones
{
    public class Autor
    {
        public string IdAutor { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }
        public string Contrato { get; set; }
      
        public string NombreCompleto { get; set; }

     
        public Autor() { }

     
        public static Autor Insertar(Autor autor)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO authors (au_id, au_lname, au_fname, phone, address, city, state, zip,contract) " +
                                   "OUTPUT INSERTED.au_id, INSERTED.au_lname, INSERTED.au_fname, INSERTED.phone, " +
                                   "INSERTED.address, INSERTED.city, INSERTED.state, INSERTED.zip " +
                                   "VALUES (@IdAutor, @Apellido, @Nombre, @Telefono, @Direccion, @Ciudad, @Estado, @CodigoPostal,@Contrato)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdAutor", autor.IdAutor);
                        comando.Parameters.AddWithValue("@Apellido", autor.Apellido);
                        comando.Parameters.AddWithValue("@Nombre", autor.Nombre);
                        comando.Parameters.AddWithValue("@Telefono", autor.Telefono);
                        comando.Parameters.AddWithValue("@Direccion", autor.Direccion);
                        comando.Parameters.AddWithValue("@Ciudad", autor.Ciudad);
                        comando.Parameters.AddWithValue("@Estado", autor.Estado);
                        comando.Parameters.AddWithValue("@CodigoPostal", autor.CodigoPostal);
                        comando.Parameters.AddWithValue("@Contrato", "1");

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Autor
                                {
                                    IdAutor = lector["au_id"].ToString(),
                                    Apellido = lector["au_lname"].ToString(),
                                    Nombre = lector["au_fname"].ToString(),
                                    Telefono = lector["phone"].ToString(),
                                    Direccion = lector["address"].ToString(),
                                    Ciudad = lector["city"].ToString(),
                                    Estado = lector["state"].ToString(),
                                    CodigoPostal = lector["zip"].ToString(),
                                    
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el autor.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el autor.");
            }
            return null;
        }

       
        public static string Actualizar(Autor autor)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE authors SET au_lname = @Apellido, au_fname = @Nombre, phone = @Telefono, " +
                                   "address = @Direccion, city = @Ciudad, state = @Estado, zip = @CodigoPostal WHERE au_id = @IdAutor";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                       
                        comando.Parameters.AddWithValue("@IdAutor", autor.IdAutor);
                        comando.Parameters.AddWithValue("@Apellido", autor.Apellido);
                        comando.Parameters.AddWithValue("@Nombre", autor.Nombre);
                        comando.Parameters.AddWithValue("@Telefono", autor.Telefono);
                        comando.Parameters.AddWithValue("@Direccion", autor.Direccion);
                        comando.Parameters.AddWithValue("@Ciudad", autor.Ciudad);
                        comando.Parameters.AddWithValue("@Estado", autor.Estado);
                        comando.Parameters.AddWithValue("@CodigoPostal", autor.CodigoPostal);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el autor.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el autor.");
                return "Error";
            }
        }

   
        public static string Eliminar(string idAutor)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM authors WHERE au_id = @IdAutor";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdAutor", idAutor);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar el autor.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el autor.");
                return "Error";
            }
        }

       
        public static Autor ObtenerPorId(string idAutor)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM authors WHERE au_id = @IdAutor";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdAutor", idAutor);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Autor
                                {
                                    IdAutor = lector["au_id"].ToString(),
                                    Apellido = lector["au_lname"].ToString(),
                                    Nombre = lector["au_fname"].ToString(),
                                    Telefono = lector["phone"].ToString(),
                                    Direccion = lector["address"].ToString(),
                                    Ciudad = lector["city"].ToString(),
                                    Estado = lector["state"].ToString(),
                                    CodigoPostal = lector["zip"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el autor.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el autor.");
            }
            return null;
        }
        public static List<Autor> ObtenerTodos()
        {
           var autores = new List<Autor>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM authors";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                
                                autores.Add(new Autor
                                {
                                    IdAutor = lector["au_id"].ToString(),
                                    Apellido = lector["au_lname"].ToString(),
                                    Nombre = lector["au_fname"].ToString(),
                                    Telefono = lector["phone"].ToString(),
                                    Direccion = lector["address"].ToString(),
                                    Ciudad = lector["city"].ToString(),
                                    Estado = lector["state"].ToString(),
                                    CodigoPostal = lector["zip"].ToString(),
                                    NombreCompleto = lector["au_fname"].ToString() + " " + lector["au_lname"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de autores.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de autores.");
            }

            return autores;
        }
    }
}

