using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace EjemploConexion.Datos
{
    public class ConexionB
    {
        private static MySqlConnection conexion = new MySqlConnection("Server=localhost;Port=3306;Database=benchmark;Uid=root;Pwd=admin;");

        public static MySqlConnection RecibirConexion()
        {
            return conexion;
        }
    }
}