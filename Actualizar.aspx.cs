using Laboratorio_12.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static public List<Universidad> UniTemp = new List<Universidad>();
        static public List<Alumno> alumnos = new List<Alumno>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach (var universidad in UniTemp)
            {
                alumnos = universidad.Alumnos;
                Alumno Alumnosaux = alumnos.Find(c => c.Carne == TextBox1.Text);
                if (Alumnosaux != null)
                {
                    TextBox2.Text = Alumnosaux.Nombre;
                    TextBox3.Text = Alumnosaux.Apellido;
                    encontrado = true;
                }
                if (!encontrado)
                {
                    TextBox1.Text = "";
                    Response.Write("<script>alert('Alumno no encontrado')</acript>");
                }
            }
        }
        private void ActualizarJson()
        {
            string json = JsonConvert.SerializeObject(UniTemp);
            string archivo = Server.MapPath("Dato.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (var universidad in UniTemp)
            {
                alumnos = universidad.Alumnos;
                Alumno Alumnob = alumnos.Find(b => b.Carne == TextBox3.Text);
                if (Alumnob != null)
                {
                    Alumnob.Nombre = TextBox2.Text;
                    Alumnob.Apellido = TextBox3.Text;

                }
            }
            ActualizarJson();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";

        }
    }
}