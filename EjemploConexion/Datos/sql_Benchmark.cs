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

        public void insertarChristian(String nombre, DateTime edad)
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

        public void insertarMaria(String nombre, DateTime edad)
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
                comando.CommandText = "INSERT INTO MARIA VALUES(@a, @b, @c);";

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

        public void insertarPedro(String nombre, DateTime edad)
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
                comando.CommandText = "INSERT INTO PEDRO VALUES(@a, @b, @c);";

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

        public void insertarJorge(String nombre, DateTime edad)
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
                comando.CommandText = "INSERT INTO JORGE VALUES(@a, @b, @c);";

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

        public void insertarRoberto(String nombre, DateTime edad)
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
                comando.CommandText = "INSERT INTO ROBERTO VALUES(@a, @b, @c);";

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
    }
}