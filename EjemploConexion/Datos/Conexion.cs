using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace EjemploConexion.Datos
{
    public class Conexion
    {

        private static MySqlConnection conexion = new MySqlConnection("Server=localhost;Port=3306;Database=ipc2;Uid=root;Pwd=admin;");

        public static MySqlConnection RecibirConexion()
        {
            return conexion;
        }

    }
}