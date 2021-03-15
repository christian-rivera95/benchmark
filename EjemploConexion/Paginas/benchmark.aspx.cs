using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EjemploConexion.Datos;

namespace EjemploConexion.Paginas
{
    public partial class benchmark : System.Web.UI.Page
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

        // Instantiate random Date generator.  
        private Random gen = new Random();

        // Generates a random Date within a range.     
        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            uint count = 0;
            String textbox1 = TextBox1.Text;
            bool equal = String.Equals(textbox1,"", StringComparison.InvariantCulture);
            if(!equal)
            {
                count = Convert.ToUInt32(TextBox1.Text);
            }

            int n = 0;
            while (n < count)
            {
                //Obtener los datos
                //String nombre = Convert.ToString(TextBox1.Text);
                String nombre = RandomString(10);
                DateTime edad = RandomDay();

                //crear un objeto tipo sql alumno
                sql_Benchmark insercion = new sql_Benchmark();

                //Ejecutar metodo insertar
                insercion.insertarRegistros(nombre, edad);
                n++;
            }
            Response.Redirect("/Paginas/benchmark.aspx", true);
        }
    }
}