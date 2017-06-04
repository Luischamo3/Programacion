using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1EntitiFramework
{
    public partial class WebFormAlumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["posicion"] = "0"; // Variables Globales
                Session["campo"] = "0";

                using (modeloOcupacional contexto = new modeloOcupacional())
                {


                    // Clase que contiene el contexto, abre y cierra la base de datos
                    // Consulta con Linq

                    var valumno = (from palumno in contexto.ALUMNOS orderby palumno.COD_CUR ascending select palumno).ToList();


                    gridview1.DataSource = valumno;
                    gridview1.DataBind();

                }
            }
        }

        protected void gridview1_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Modifica")
            {
                Session["Mostrar"] = "1";
            }
            else
            {
                Session["Mostrar"] = "2";
            }
            
            Session["COD_ALU"] = gridview1.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text;// Carga los texbox con la fila en donde hemos hecho click
            string test = Session["COD_ALU"].ToString();
            Response.Redirect("WebFormModificar.aspx");
        }

        protected void newalu_OnClick(object sender, EventArgs e)
        {
           Response.Redirect("WebformNuevoAlumno.aspx");
        }
    }
}