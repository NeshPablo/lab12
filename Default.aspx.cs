using Laboratorio_12.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace Laboratorio_12
{
    public partial class _Default : Page
    {
        static public List<Nota> NotasTemp = new List<Nota>();
        static public List<Alumno> AlumnoTemp = new List<Alumno>();
        static public List<Alumno> AlumnoTemp2 = new List<Alumno>();
        static public List<Universidad> UniversidadTemp = new List<Universidad>();
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (!IsPostBack)
           {

             /*  string archivo = Server.MapPath("Alumno.json");
               StreamReader jsonStream = System.IO.File.OpenText(archivo);
               string json = jsonStream.ReadToEnd();
               jsonStream.Close();
               Alumno = JsonConvert.DeserializeObject<List<Alumno>>(json);
           }*/
        }
        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(UniversidadTemp);
            string archivo = Server.MapPath("Datos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Universidad universidad = new Universidad();
            universidad.universidades = DropDownList1.SelectedValue;
            universidad.Alumnos = AlumnoTemp.ToArray().ToList();


            UniversidadTemp.Add(universidad);
            Guardar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Carne = TextBox1.Text;
            alumno.Nombre = TextBox2.Text;
            alumno.Apellido = TextBox3.Text;
            alumno.Notas = NotasTemp.ToArray().ToList();

            AlumnoTemp.Add(alumno);
            Guardar();
            NotasTemp.Clear();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            nota.Curso = txt_Curso.Text;
            nota.Punteo = txt_punteo.Text;

            NotasTemp.Add(nota);
            txt_punteo.Text = "";
            txt_Curso.Text = "";
        }
    }
}