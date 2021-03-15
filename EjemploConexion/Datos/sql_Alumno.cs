using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace EjemploConexion.Datos
{
    public class sql_Alumno
    {
        //Metodo para insertar Alumno
        public void insertarAlumno(String carnet, String nombre, String carrera)
        {
            MySqlConnection conectar = Conexion.RecibirConexion();

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
                comando.CommandText = "INSERT INTO ALUMNO VALUES(@a, @b, @c);";

                //Agregar parametros
                comando.Parameters.AddWithValue("@a", carnet);
                comando.Parameters.AddWithValue("@b", nombre);
                comando.Parameters.AddWithValue("@c", carrera);

                //Ejecutar Comando SQL

                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            
        }

        public void editarAlumno(String carnet, String nombre, String carrera)
        {
            MySqlConnection conectar = Conexion.RecibirConexion();

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
                comando.CommandText = "UPDATE ALUMNO SET nombre= @b, carrera = @c WHERE carnet = @a;";

                //Agregar parametros
                comando.Parameters.AddWithValue("@a", carnet);
                comando.Parameters.AddWithValue("@b", nombre);
                comando.Parameters.AddWithValue("@c", carrera);

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