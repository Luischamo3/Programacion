using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1EntitiFramework
{
    public partial class WebformNuevoAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Session["posicion"] = "0";
                int posi = Convert.ToInt32(Session["posicion"] = "0");

                using (modeloOcupacional contexto = new modeloOcupacional())
                // Clase que contiene el contexto, abre y cierra la base de datos
                {
                    try
                    {



                    }
                    catch
                    {
                        string mensaje = "No se han podido cargar los cursos ";
                        ClientScript.RegisterStartupScript(this.GetType(), "Aviso", "alert('" + mensaje + "')", true);
                        Session["nuevo"] = "0";
                        return;
                    }

                }
                using (modeloOcupacional contexto = new modeloOcupacional())
                // Clase que contiene el contexto, abre y cierra la base de datos
                {

                    var vcurso =
                        (from pcurso in contexto.CURSOS
                         orderby pcurso.COD_CUR ascending
                         select pcurso).ToList();
                    // var valumnos = (from palumno in contexto.ALUMNOS orderby palumno.NOMBRE descending select palumno).ToList();


                    comboboxcursos.DataSource = vcurso;
                    comboboxcursos.DataValueField = "COD_CUR";
                    comboboxcursos.DataTextField = "DESCRIPCION";
                    comboboxcursos.DataBind(); // para Visualizar*/

                } 
            }
        }

        protected void savebutton_OnClick(object sender, EventArgs e)
        {


            //ALUMNOS grabaalAlumnos = new ALUMNOS();
            //NOTAS grabaNotas = new NOTAS();

            int posi = Convert.ToInt32(Session["posicion"]);

            using (modeloOcupacional contexto = new modeloOcupacional())
            {

                try
                {
                    
                    ALUMNOS grabaalAlumnos = new ALUMNOS()
                    {
                        COD_ALU = campocodalu.Text,
                       COD_CUR = comboboxcursos.SelectedValue.ToString(),
                        DNI = campodni.Text,
                        NOMBRE = camponombre.Text,
                        APELLIDOS = campoapellido.Text
                    };

                    contexto.ALUMNOS.Add(grabaalAlumnos);

                    NOTAS grabaNotas = new NOTAS()
                    {
                        COD_ALU = grabaalAlumnos.COD_ALU,
                        COD_CUR = grabaalAlumnos.COD_CUR,
                        NOTA1 = Convert.ToInt32(camponota1.Text),
                        NOTA2 = Convert.ToInt32(camponota2.Text),
                        NOTA3 = Convert.ToInt32(camponota1.Text),
                        MEDIA = (Convert.ToInt32(camponota1.Text) + Convert.ToInt32(camponota2.Text) + Convert.ToInt32(camponota3.Text)) / 3
                    };

                    contexto.NOTAS.Add(grabaNotas);

                    contexto.SaveChanges();

                }
                catch (Exception exception)
                {
                    string mensaje = "Error al grabar ";
                    ClientScript.RegisterStartupScript(this.GetType(), "Aviso", "alert('" + mensaje + "')", true);
                    Session["nuevo"] = "0";
                    return;
                }
            }
        }

        protected void comboboxcursos_OnSelectedIndexChanged(object sender, EventArgs e)
        {

           
        }
    }
}