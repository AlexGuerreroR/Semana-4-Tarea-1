using _06Publicaciones.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones
{

    public class TrabajoModel
    {
        public string job_id { get; set; }
        public string job_desc { get; set; }
        public int min_lvl { get; set; }
        public int max_lvl { get; set; }

        // Constructor vacío
        public TrabajoModel() { }

        // Método para insertar un nuevo trabajo y retornar el registro insertado
        public static TrabajoModel Insertar(TrabajoModel trabajo)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO jobs (job_desc, min_lvl, max_lvl) " + // No incluimos 'job_id'
                                   "OUTPUT INSERTED.job_id, INSERTED.job_desc, INSERTED.min_lvl, INSERTED.max_lvl " +
                                   "VALUES (@Descripcion, @NivelMinimo, @NivelMaximo)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Descripcion", trabajo.job_desc);
                        comando.Parameters.AddWithValue("@NivelMinimo", trabajo.min_lvl);
                        comando.Parameters.AddWithValue("@NivelMaximo", trabajo.max_lvl);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new TrabajoModel
                                {
                                    job_id = lector["job_id"].ToString(),
                                    job_desc = lector["job_desc"].ToString(),
                                    min_lvl = Convert.ToInt32(lector["min_lvl"]),
                                    max_lvl = Convert.ToInt32(lector["max_lvl"])
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el trabajo.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el trabajo.");
            }
            return null;
        }

        public static string Actualizar(TrabajoModel trabajo)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE jobs SET job_desc = @Descripcion, min_lvl = @NivelMinimo, max_lvl = @NivelMaximo WHERE job_id = @IdTrabajo";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTrabajo", trabajo.job_id);
                        comando.Parameters.AddWithValue("@Descripcion", trabajo.job_desc);
                        comando.Parameters.AddWithValue("@NivelMinimo", trabajo.min_lvl);
                        comando.Parameters.AddWithValue("@NivelMaximo", trabajo.max_lvl);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error 2 al actualizar el trabajo.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error 3 al actualizar el trabajo.");
                return "Error";
            }
        }

        public static string Eliminar(string idTrabajo)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM jobs WHERE job_id = @IdTrabajo";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTrabajo", idTrabajo);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar el trabajo.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el trabajo.");
                return "Error";
            }
        }

        public static TrabajoModel ObtenerPorId(string idTrabajo)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM jobs WHERE job_id = @IdTrabajo";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTrabajo", idTrabajo);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new TrabajoModel
                                {
                                    job_id = lector["job_id"].ToString(),
                                    job_desc = lector["job_desc"].ToString(),
                                    min_lvl = Convert.ToInt32(lector["min_lvl"]),
                                    max_lvl = Convert.ToInt32(lector["max_lvl"])
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el trabajo.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el trabajo.");
            }
            return null;
        }

        public static List<TrabajoModel> ObtenerTodos()
        {
            var trabajos = new List<TrabajoModel>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM jobs";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                trabajos.Add(new TrabajoModel
                                {
                                    job_id = lector["job_id"].ToString(),
                                    job_desc = lector["job_desc"].ToString(),
                                    min_lvl = Convert.ToInt32(lector["min_lvl"]),
                                    max_lvl = Convert.ToInt32(lector["max_lvl"])
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de trabajos.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de trabajos.");
            }

            return trabajos;
        }
    }













}
