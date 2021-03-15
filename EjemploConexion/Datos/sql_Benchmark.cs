using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace EjemploConexion.Datos
{
    public class sql_Benchmark
    {

        //Metodo para insertar Alumno
        public void insertarRegistros(String nombre, DateTime edad)
        {
            MySqlConnection conectar = ConexionB.RecibirConexion();

            try
            {
                //Abrir Conexion
                conectar.Open();

                //Crear Objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Cadena de Conexion
                comando.Connection = conectar;

                //Especificar el tipo Sql
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO CHRISTIAN VALUES(@a, @b, @c);";

                //Agregar parametros
                comando.Parameters.AddWithValue("@a", 0);
                comando.Parameters.AddWithValue("@b", nombre);
                comando.Parameters.AddWithValue("@c", edad);

                //Ejecutar Comando SQL

                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void insertarChristian(int tiny, int small, int medium, float randomFloat, String randomChar, String varchar, String tinyText, String text, String mediumText, DateTime date)
        {
            MySqlConnection conectar = ConexionB.RecibirConexion();

            try
            {
                //Abrir Conexion
                conectar.Open();

                //Crear Objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Cadena de Conexion
                comando.Connection = conectar;

                //Especificar el tipo Sql
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO CHRISTIAN VALUES(@a, @b, @c, @d, @e, @f, @g, @h, @i, @j, @k);";

                //Agregar parametros
                comando.Parameters.AddWithValue("@a", 0);
                comando.Parameters.AddWithValue("@b", tiny);
                comando.Parameters.AddWithValue("@c", small);
                comando.Parameters.AddWithValue("@d", medium);
                comando.Parameters.AddWithValue("@e", randomFloat);
                comando.Parameters.AddWithValue("@f", randomChar);
                comando.Parameters.AddWithValue("@g", varchar);
                comando.Parameters.AddWithValue("@h", tinyText);
                comando.Parameters.AddWithValue("@i", text);
                comando.Parameters.AddWithValue("@j", mediumText);
                comando.Parameters.AddWithValue("@k", date);

                //Ejecutar Comando SQL

                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void insertarMaria(int tiny, int small, int medium, float randomFloat, String randomChar, String varchar, String tinyText, String text, String mediumText, DateTime date)
        {
            MySqlConnection conectar = ConexionB.RecibirConexion();

            try
            {
                //Abrir Conexion
                conectar.Open();

                //Crear Objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Cadena de Conexion
                comando.Connection = conectar;

                //Especificar el tipo Sql
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO MARIA VALUES(@a, @b, @c, @d, @e, @f, @g, @h, @i, @j, @k);";

                //Agregar parametros
                comando.Parameters.AddWithValue("@a", 0);
                comando.Parameters.AddWithValue("@b", tiny);
                comando.Parameters.AddWithValue("@c", small);
                comando.Parameters.AddWithValue("@d", medium);
                comando.Parameters.AddWithValue("@e", randomFloat);
                comando.Parameters.AddWithValue("@f", randomChar);
                comando.Parameters.AddWithValue("@g", varchar);
                comando.Parameters.AddWithValue("@h", tinyText);
                comando.Parameters.AddWithValue("@i", text);
                comando.Parameters.AddWithValue("@j", mediumText);
                comando.Parameters.AddWithValue("@k", date);

                //Ejecutar Comando SQL

                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void insertarPedro(int tiny, int small, int medium, float randomFloat, String randomChar, String varchar, String tinyText, String text, String mediumText, DateTime date)
        {
            MySqlConnection conectar = ConexionB.RecibirConexion();

            try
            {
                //Abrir Conexion
                conectar.Open();

                //Crear Objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Cadena de Conexion
                comando.Connection = conectar;

                //Especificar el tipo Sql
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO PEDRO VALUES(@a, @b, @c, @d, @e, @f, @g, @h, @i, @j, @k);";

                //Agregar parametros
                comando.Parameters.AddWithValue("@a", 0);
                comando.Parameters.AddWithValue("@b", tiny);
                comando.Parameters.AddWithValue("@c", small);
                comando.Parameters.AddWithValue("@d", medium);
                comando.Parameters.AddWithValue("@e", randomFloat);
                comando.Parameters.AddWithValue("@f", randomChar);
                comando.Parameters.AddWithValue("@g", varchar);
                comando.Parameters.AddWithValue("@h", tinyText);
                comando.Parameters.AddWithValue("@i", text);
                comando.Parameters.AddWithValue("@j", mediumText);
                comando.Parameters.AddWithValue("@k", date);

                //Ejecutar Comando SQL

                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void insertarJorge(int tiny, int small, int medium, float randomFloat, String randomChar, String varchar, String tinyText, String text, String mediumText, DateTime date)
        {
            MySqlConnection conectar = ConexionB.RecibirConexion();

            try
            {
                //Abrir Conexion
                conectar.Open();

                //Crear Objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Cadena de Conexion
                comando.Connection = conectar;

                //Especificar el tipo Sql
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO JORGE VALUES(@a, @b, @c, @d, @e, @f, @g, @h, @i, @j, @k);";

                //Agregar parametros
                comando.Parameters.AddWithValue("@a", 0);
                comando.Parameters.AddWithValue("@b", tiny);
                comando.Parameters.AddWithValue("@c", small);
                comando.Parameters.AddWithValue("@d", medium);
                comando.Parameters.AddWithValue("@e", randomFloat);
                comando.Parameters.AddWithValue("@f", randomChar);
                comando.Parameters.AddWithValue("@g", varchar);
                comando.Parameters.AddWithValue("@h", tinyText);
                comando.Parameters.AddWithValue("@i", text);
                comando.Parameters.AddWithValue("@j", mediumText);
                comando.Parameters.AddWithValue("@k", date);

                //Ejecutar Comando SQL

                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void insertarRoberto(int tiny, int small, int medium, float randomFloat, String randomChar, String varchar, String tinyText, String text, String mediumText, DateTime date)
        {
            MySqlConnection conectar = ConexionB.RecibirConexion();

            try
            {
                //Abrir Conexion
                conectar.Open();

                //Crear Objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Cadena de Conexion
                comando.Connection = conectar;

                //Especificar el tipo Sql
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO ROBERTO VALUES(@a, @b, @c, @d, @e, @f, @g, @h, @i, @j, @k);";

                //Agregar parametros
                comando.Parameters.AddWithValue("@a", 0);
                comando.Parameters.AddWithValue("@b", tiny);
                comando.Parameters.AddWithValue("@c", small);
                comando.Parameters.AddWithValue("@d", medium);
                comando.Parameters.AddWithValue("@e", randomFloat);
                comando.Parameters.AddWithValue("@f", randomChar);
                comando.Parameters.AddWithValue("@g", varchar);
                comando.Parameters.AddWithValue("@h", tinyText);
                comando.Parameters.AddWithValue("@i", text);
                comando.Parameters.AddWithValue("@j", mediumText);
                comando.Parameters.AddWithValue("@k", date);

                //Ejecutar Comando SQL

                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void deleteChristian()
        {
            MySqlConnection conectar = ConexionB.RecibirConexion();

            try
            {
                //Abrir Conexion
                conectar.Open();

                //Crear Objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Cadena de Conexion
                comando.Connection = conectar;

                //Especificar el tipo Sql
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "TRUNCATE CHRISTIAN;";


                //Ejecutar Comando SQL

                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void deleteMaria()
        {
            MySqlConnection conectar = ConexionB.RecibirConexion();

            try
            {
                //Abrir Conexion
                conectar.Open();

                //Crear Objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Cadena de Conexion
                comando.Connection = conectar;

                //Especificar el tipo Sql
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "TRUNCATE MARIA;";


                //Ejecutar Comando SQL

                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void deletePedro()
        {
            MySqlConnection conectar = ConexionB.RecibirConexion();

            try
            {
                //Abrir Conexion
                conectar.Open();

                //Crear Objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Cadena de Conexion
                comando.Connection = conectar;

                //Especificar el tipo Sql
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "TRUNCATE PEDRO;";


                //Ejecutar Comando SQL

                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void deleteJorge()
        {
            MySqlConnection conectar = ConexionB.RecibirConexion();

            try
            {
                //Abrir Conexion
                conectar.Open();

                //Crear Objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Cadena de Conexion
                comando.Connection = conectar;

                //Especificar el tipo Sql
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "TRUNCATE JORGE;";


                //Ejecutar Comando SQL

                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void deleteRoberto()
        {
            MySqlConnection conectar = ConexionB.RecibirConexion();

            try
            {
                //Abrir Conexion
                conectar.Open();

                //Crear Objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Cadena de Conexion
                comando.Connection = conectar;

                //Especificar el tipo Sql
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "TRUNCATE ROBERTO;";


                //Ejecutar Comando SQL

                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}