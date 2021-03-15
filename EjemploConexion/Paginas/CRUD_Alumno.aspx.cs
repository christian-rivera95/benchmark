using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EjemploConexion.Datos;

namespace EjemploConexion.Paginas
{
    public partial class CRUD_Alumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Instantiate random string generator.  
        private static Random random = new Random();

        // Generates a random string within a range.      
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // Instantiate random number generator.  
        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber()
        {
            return _random.Next(200000000, 299999999);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Obtener los datos
            String nombre = Convert.ToString(TextBox4.Text);
            String carrera = Convert.ToString(TextBox5.Text);
            String carnet = DropDownList1.SelectedValue;

            //crear un objeto tipo sql alumno
            sql_Alumno edicion = new sql_Alumno();

            //Ejecutar metodo insertar
            edicion.editarAlumno(carnet, nombre, carrera);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            int n = 0;
            while (n < 5)
            {
                //Obtener los datos
                //String nombre = Convert.ToString(TextBox1.Text);
                String nombre = RandomString(10);
                String carnet = RandomNumber().ToString();
                String carrera = Convert.ToString(TextBox3.Text);

                //crear un objeto tipo sql alumno
                sql_Alumno insercion = new sql_Alumno();

                //Ejecutar metodo insertar
                insercion.insertarAlumno(carnet, nombre, carrera);
                n++;
            }
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Paginas/CRUD_Alumno.aspx", true);
        }
    }
}