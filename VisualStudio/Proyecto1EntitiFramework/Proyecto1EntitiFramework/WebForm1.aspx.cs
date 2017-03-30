using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Proyecto1EntitiFramework
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (modeloOcupacional contexto = new modeloOcupacional())
            // Clase que contiene el contexto, abre y cierra la base de datos
            {
                var vnotas = (from pnotas in contexto.NOTAS orderby pnotas.NOTA1 descending select pnotas).ToList();
                var vcurso = (from pcurso in contexto.ALUMNOS select pcurso.NOMBRE).ToList();
                var valumnos = (from palumno in contexto.ALUMNOS orderby palumno.NOMBRE descending select palumno).ToList();
                /*combobox1.DataSource = vcurso;
                combobox1.DataValueField = "COD_CUR";
                combobox1.DataTextField = "DESCRIPCION";
                combobox1.DataBind();// para Visualizar*/

                //
                //gridView1.DataSource = vcurso;

                // gridView1.DataBind();



                //combobox2.DataSource = valumnos;
                //combobox2.DataValueField = "NOMBRE";
                /* combobox2.DataTextField = "DNI".ToString();
               combobox2.DataBind();// para Visualizar


                 gridView2.DataSource = vnotas;

                 gridView2.DataBind();*/

                campocurso.Text = vcurso.ToString();
                
                campocurso.DataBind(); 


            }

        }
    }
}