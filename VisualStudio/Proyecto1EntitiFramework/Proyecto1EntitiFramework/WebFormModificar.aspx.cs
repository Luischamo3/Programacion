using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1EntitiFramework
{
    public partial class WebFormModificar : System.Web.UI.Page
    {
        public string codalu { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            Session["posicion"] = "0"; // Variables Globales
            codalu = Session["COD_ALU"].ToString();

            //Session["campo"] = deletebutton.Text;
            if (Session["Mostrar"] == "1")
            {
                deletebutton.Visible = false;
            }
            else
            {
                deletebutton.Visible = true;
            }

            if (!IsPostBack)
            {

                using (modeloOcupacional contexto = new modeloOcupacional())
                // Clase que contiene el contexto, abre y cierra la base de datos
                {
                    //if (IsPostBack)
                    //{
                    

                    try
                    {
                        int posi = Convert.ToInt32(Session["posicion"]);
                        // Consulta con Lin

                        var valumno = (from pcurso in contexto.ALUMNOS
                                       where pcurso.COD_ALU == codalu
                                       select pcurso).First();



                        if (valumno != null)
                        {
                            //Rellena Los Texbox
                            alumno_codalu.Text = valumno.COD_ALU;
                            alumno_codcur.Text = valumno.COD_CUR;
                            alumno_apellido.Text = valumno.APELLIDOS;
                            alumno_nombre.Text = valumno.NOMBRE;
                            alumno_dni.Text = valumno.DNI;

                        }

                    }
                    catch
                    {
                        string mensaje = "No se han podido cargar los cursos ";
                        ClientScript.RegisterStartupScript(this.GetType(), "Aviso", "alert('" + mensaje + "')", true);
                        Session["nuevo"] = "0";
                        return;
                    }

                    
                    
                }
            }
        }

        protected void deletebutton_OnClick(object sender, EventArgs e)
        {
            int posi = Convert.ToInt32(Session["posicion"]);

            using (modeloOcupacional contexto = new modeloOcupacional())
            {
                try
                {
                    ///Borrar Nota de Alumno
                    var vnotas = (from pnotas in contexto.NOTAS
                                   where pnotas.COD_ALU == codalu
                                   select pnotas).First();
                    contexto.NOTAS.Remove(vnotas);
                    contexto.SaveChanges();

                    ///Borrar Alumno

                    var valumno = (from pcurso in contexto.ALUMNOS
                                   where pcurso.COD_ALU == codalu
                                   select pcurso).First();

                    contexto.ALUMNOS.Remove(valumno);
                    contexto.SaveChanges();

                   Response.Redirect("WebFormAlumnos.aspx");
                }
                catch (Exception)
                {
                    string mensaje = "Error al intentar borrar el registro ";
                    ClientScript.RegisterStartupScript(this.GetType(), "Aviso", "alert('" + mensaje + "')", true);
                    Session["nuevo"] = "0";
                    return;

                }
            }
        }


        protected void acceptbutton_OnClick(object sender, EventArgs e)
        {
            using (modeloOcupacional contexto = new modeloOcupacional())
            {
                foreach (var alu in contexto.ALUMNOS)
                {
                    if (alu.COD_ALU == codalu)
                    {
                        

                        alu.COD_ALU = alumno_codalu.Text;
                        alu.COD_CUR = alumno_codcur.Text;
                        alu.APELLIDOS = alumno_apellido.Text;
                        alu.NOMBRE = alumno_nombre.Text;
                        alu.DNI = alumno_dni.Text;

                        
                    }
                }
                contexto.SaveChanges();

            }

        }

        protected void cancelbutton_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("WebFormAlumnos.aspx");
        }

       
        
    }
}