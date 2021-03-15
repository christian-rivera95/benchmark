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
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
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
            int count = 0;
            String textbox1 = TextBox1.Text;
            bool christian_input = String.Equals(textbox1,"", StringComparison.InvariantCulture);
            if(!christian_input)
            {
                count = Convert.ToInt32(TextBox1.Text);
            }
            Boolean christian = CheckBox1.Checked;
            Boolean maria = CheckBox2.Checked;
            Boolean pedro = CheckBox3.Checked;
            Boolean jorge = CheckBox4.Checked;
            Boolean roberto = CheckBox5.Checked;

            int n = 0;
            while (n < count && christian)
            {

                //crear un objeto tipo sql alumno
                sql_Benchmark insercion = new sql_Benchmark();

                    String nombre = RandomString(10);
                    DateTime edad = RandomDay();

                    //Ejecutar metodo insertar
                    insercion.insertarChristian(nombre, edad);
                    n++;

            }

            count = 0;
            String textbox2 = TextBox2.Text;
            bool maria_input = String.Equals(textbox2, "", StringComparison.InvariantCulture);
            if (!maria_input)
            {
                count = Convert.ToInt32(TextBox2.Text);
            }

            n = 0;
            while (n < count && maria)
            {

                //crear un objeto tipo sql alumno
                sql_Benchmark insercion = new sql_Benchmark();

                String nombre = RandomString(10);
                DateTime edad = RandomDay();

                //Ejecutar metodo insertar
                insercion.insertarMaria(nombre, edad);
                n++;

            }

            count = 0;
            String textbox3 = TextBox3.Text;
            bool pedro_input = String.Equals(textbox3, "", StringComparison.InvariantCulture);
            if (!pedro_input)
            {
                count = Convert.ToInt32(TextBox3.Text);
            }

            n = 0;
            while (n < count && pedro)
            {

                //crear un objeto tipo sql alumno
                sql_Benchmark insercion = new sql_Benchmark();

                String nombre = RandomString(10);
                DateTime edad = RandomDay();

                //Ejecutar metodo insertar
                insercion.insertarPedro(nombre, edad);
                n++;

            }

            count = 0;
            String textbox4 = TextBox4.Text;
            bool jorge_input = String.Equals(textbox4, "", StringComparison.InvariantCulture);
            if (!jorge_input)
            {
                count = Convert.ToInt32(TextBox4.Text);
            }

            n = 0;
            while (n < count && jorge)
            {

                //crear un objeto tipo sql alumno
                sql_Benchmark insercion = new sql_Benchmark();

                String nombre = RandomString(10);
                DateTime edad = RandomDay();

                //Ejecutar metodo insertar
                insercion.insertarJorge(nombre, edad);
                n++;

            }

            count = 0;
            String textbox5 = TextBox5.Text;
            bool roberto_input = String.Equals(textbox5, "", StringComparison.InvariantCulture);
            if (!christian_input)
            {
                count = Convert.ToInt32(TextBox5.Text);
            }

            n = 0;
            while (n < count && roberto)
            {

                //crear un objeto tipo sql alumno
                sql_Benchmark insercion = new sql_Benchmark();

                String nombre = RandomString(10);
                DateTime edad = RandomDay();

                //Ejecutar metodo insertar
                insercion.insertarRoberto(nombre, edad);
                n++;

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Boolean christian = CheckBox6.Checked;
            Boolean maria = CheckBox7.Checked;
            Boolean pedro = CheckBox8.Checked;
            Boolean jorge = CheckBox9.Checked;
            Boolean roberto = CheckBox10.Checked;

            if (christian)
            {
                //crear un objeto tipo sql alumno
                sql_Benchmark insercion = new sql_Benchmark();

                //Ejecutar metodo insertar
                insercion.deleteChristian();
            }

            if (maria)
            {
                //crear un objeto tipo sql alumno
                sql_Benchmark insercion = new sql_Benchmark();

                //Ejecutar metodo insertar
                insercion.deleteMaria();
            }

            if (pedro)
            {
                //crear un objeto tipo sql alumno
                sql_Benchmark insercion = new sql_Benchmark();

                //Ejecutar metodo insertar
                insercion.deletePedro();
            }

            if (jorge)
            {
                //crear un objeto tipo sql alumno
                sql_Benchmark insercion = new sql_Benchmark();

                //Ejecutar metodo insertar
                insercion.deleteJorge();
            }

            if (roberto)
            {
                //crear un objeto tipo sql alumno
                sql_Benchmark insercion = new sql_Benchmark();

                //Ejecutar metodo insertar
                insercion.deleteRoberto();
            }

        }
    }
}