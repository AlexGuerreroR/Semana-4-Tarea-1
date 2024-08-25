using _06Publicaciones.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones
{
    public class Empleado
    {
        public string Emp_id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Minit { get; set; }
        public string Job_id { get; set; }
        public string Job_lvl { get; set; }
        public string Pub_id { get; set; }
        public DateTime Hire_date { get; set; }

       
        public Empleado() { }

     
        public static Empleado Insertar(Empleado empleado)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO employee (emp_id, fname, lname, minit, job_id, job_lvl, pub_id, hire_date) " +
                                   "VALUES (@Emp_id, @Fname, @Lname, @Minit, @Job_id, @Job_lvl, @Pub_id, @Hire_date);";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Emp_id", empleado.Emp_id);
                        comando.Parameters.AddWithValue("@Fname", empleado.Fname);
                        comando.Parameters.AddWithValue("@Lname", empleado.Lname);
                        comando.Parameters.AddWithValue("@Minit", empleado.Minit);
                        comando.Parameters.AddWithValue("@Job_id", Convert.ToInt16(empleado.Job_id));
                        comando.Parameters.AddWithValue("@Job_lvl", empleado.Job_lvl);
                        comando.Parameters.AddWithValue("@Pub_id", empleado.Pub_id);
                        comando.Parameters.AddWithValue("@Hire_date", empleado.Hire_date);

                        comando.ExecuteNonQuery();
                    }

                    return ObtenerPorId(empleado.Emp_id);
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, $"Error al insertar el empleado: {ex.Message}");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, $"Error general al insertar el empleado: {ex.Message}");
            }
            return null;
        }

        public static string Actualizar(Empleado empleado)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE employee SET fname = @Fname, lname = @Lname, minit = @Minit, " +
                                   "job_id = @Job_id, job_lvl = @Job_lvl, pub_id = @Pub_id, hire_date = @Hire_date WHERE emp_id = @Emp_id";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Emp_id", empleado.Emp_id);
                        comando.Parameters.AddWithValue("@Fname", empleado.Fname);
                        comando.Parameters.AddWithValue("@Lname", empleado.Lname);
                        comando.Parameters.AddWithValue("@Minit", empleado.Minit);
                        comando.Parameters.AddWithValue("@Job_id", empleado.Job_id);
                        comando.Parameters.AddWithValue("@Job_lvl", empleado.Job_lvl);
                        comando.Parameters.AddWithValue("@Pub_id", empleado.Pub_id);
                        comando.Parameters.AddWithValue("@Hire_date", empleado.Hire_date);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el empleado.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el empleado.");
                return "Error";
            }
        }

    
        public static string Eliminar(string emp_id)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM employee WHERE emp_id = @Emp_id";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Emp_id", emp_id);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar el empleado.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el empleado.");
                return "Error";
            }
        }

      
        public static Empleado ObtenerPorId(string emp_id)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM employee WHERE emp_id = @Emp_id";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Emp_id", emp_id);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Empleado
                                {
                                    Emp_id = lector["emp_id"].ToString(),
                                    Fname = lector["fname"].ToString(),
                                    Lname = lector["lname"].ToString(),
                                    Minit = lector["minit"].ToString(),
                                    Job_id = lector["job_id"].ToString(),
                                    Job_lvl = lector["job_lvl"].ToString(),
                                    Pub_id = lector["pub_id"].ToString(),
                                    Hire_date = DateTime.Parse(lector["hire_date"].ToString())
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el empleado.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el empleado.");
            }
            return null;
        }

        public static List<Empleado> ObtenerTodos()
        {
            var empleados = new List<Empleado>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM employee";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                empleados.Add(new Empleado
                                {
                                    Emp_id = lector["emp_id"].ToString(),
                                    Fname = lector["fname"].ToString(),
                                    Lname = lector["lname"].ToString(),
                                    Minit = lector["minit"].ToString(),
                                    Job_id = lector["job_id"].ToString(),
                                    Job_lvl = lector["job_lvl"].ToString(),
                                    Pub_id = lector["pub_id"].ToString(),
                                    Hire_date = DateTime.Parse(lector["hire_date"].ToString())
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de empleados.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de empleados.");
            }

            return empleados;
        }
    }
}