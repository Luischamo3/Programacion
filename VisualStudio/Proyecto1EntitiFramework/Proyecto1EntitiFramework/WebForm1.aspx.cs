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


        public void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["posicion"] = "0"; // Variables Globales
                Session["Nuevo"] = "0";

                using (modeloOcupacional contexto = new modeloOcupacional())
                // Clase que contiene el contexto, abre y cierra la base de datos
                {
                    try
                    {

                        // Consulta con Linq

                        var vcurso =
                            (from pcurso in contexto.CURSOS orderby pcurso.COD_CUR ascending select pcurso).First();
                        //var vcurso = (from pcurso in contexto.CURSOS orderby pcurso.COD_CUR ascending select  new {Nombre=pcurso.TUTOR} ).First();
                        var vnotas = (from pnotas in contexto.NOTAS orderby pnotas.COD_CUR ascending select pnotas).First();

                        if (vcurso != null)
                        {
                            //Rellena Los Texbox
                            this.campocurso.Text = vcurso.COD_CUR.ToString();
                            campodescripcion.Text = vcurso.DESCRIPCION.ToString();
                            campohoras.Text = vcurso.HORAS.ToString();
                            campotutor.Text = vcurso.TUTOR.ToString();


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


        /// <summary>
        /// Botón que nos lleva al primer registro de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void primero_OnClick(object sender, EventArgs e)
        {
            int posi = Convert.ToInt32(Session["posicion"]);
            posi = 0;
            using (modeloOcupacional contexto = new modeloOcupacional())
            {

                try
                {

                    {
                        // Clase que contiene el contexto, abre y cierra la base de datos
                        // Consulta con Linq

                        var vcurso =
                            (from pcurso in contexto.CURSOS orderby pcurso.COD_CUR ascending select pcurso).Skip(posi)
                            .First();

                        //Rellena Los Texbox
                        this.campocurso.Text = vcurso.COD_CUR.ToString();
                        campodescripcion.Text = vcurso.DESCRIPCION.ToString();
                        campohoras.Text = vcurso.HORAS.ToString();
                        campotutor.Text = vcurso.TUTOR.ToString();

                    }


                }
                catch (Exception)
                {
                    posi--;
                }

                Session["posicion"] = posi.ToString();
            }

        }
        /// <summary>
        /// Botón que nos lleva al registro anterior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void anterior_OnClick(object sender, EventArgs e)
        {
            int posi = Convert.ToInt32(Session["posicion"]);
            posi--;
            using (modeloOcupacional contexto = new modeloOcupacional())
            {

                try
                {

                    {
                        // Clase que contiene el contexto, abre y cierra la base de datos
                        // Consulta con Linq

                        var vcurso =
                            (from pcurso in contexto.CURSOS orderby pcurso.COD_CUR ascending select pcurso).Skip(posi)
                            .First();


                        //Rellena Los Texbox
                        this.campocurso.Text = vcurso.COD_CUR.ToString();
                        campodescripcion.Text = vcurso.DESCRIPCION.ToString();
                        campohoras.Text = vcurso.HORAS.ToString();
                        campotutor.Text = vcurso.TUTOR.ToString();

                    }


                }
                catch (Exception)
                {
                    posi++;
                }
                Session["posicion"] = posi.ToString();
            }
        }
        /// <summary>
        /// Botón que nos lleva al registro siguiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void siguiente_OnClick(object sender, EventArgs e)
        {
            int posi = Convert.ToInt32(Session["posicion"]);
            posi++;
            using (modeloOcupacional contexto = new modeloOcupacional())
            {

                try
                {

                    {
                        // Clase que contiene el contexto, abre y cierra la base de datos
                        // Consulta con Linq

                        var vcurso =
                            (from pcurso in contexto.CURSOS orderby pcurso.COD_CUR ascending select pcurso).Skip(posi)
                            .First();

                        //var vcurso = (from pcurso in contexto.CURSOS orderby pcurso.COD_CUR ascending select  new {Nombre=pcurso.TUTOR} ).First();

                        //Rellena Los Texbox
                        this.campocurso.Text = vcurso.COD_CUR.ToString();
                        campodescripcion.Text = vcurso.DESCRIPCION.ToString();
                        campohoras.Text = vcurso.HORAS.ToString();
                        campotutor.Text = vcurso.TUTOR.ToString();

                    }


                }
                catch (Exception)
                {

                    posi--;
                }
                Session["posicion"] = posi.ToString();
            }
        }
        /// <summary>
        /// Botón NOS lleva al útimo registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ultimo_OnClick(object sender, EventArgs e)
        {
            int posi = Convert.ToInt32(Session["posicion"]);
            using (modeloOcupacional contexto = new modeloOcupacional())
            {
                posi = contexto.CURSOS.Count() - 1;
                try
                {

                    {
                        // Clase que contiene el contexto, abre y cierra la base de datos
                        // Consulta con Linq

                        var vcurso =
                            (from pcurso in contexto.CURSOS orderby pcurso.COD_CUR ascending select pcurso).Skip(posi)
                            .First();

                        //var vcurso = (from pcurso in contexto.CURSOS orderby pcurso.COD_CUR ascending select  new {Nombre=pcurso.TUTOR} ).First();

                        //Rellena Los Texbox
                        this.campocurso.Text = vcurso.COD_CUR.ToString();
                        campodescripcion.Text = vcurso.DESCRIPCION.ToString();
                        campohoras.Text = vcurso.HORAS.ToString();
                        campotutor.Text = vcurso.TUTOR.ToString();

                    }


                }
                catch (Exception)
                {

                    posi--;
                }
                Session["posicion"] = posi.ToString();
            }
        }
        /// <summary>
        /// Evento del botón que graba un nuevo registro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rec_OnClick(object sender, EventArgs e)
        {
            int posi = Convert.ToInt32(Session["posicion"]);


            using (modeloOcupacional contexto = new modeloOcupacional())
            {
                //posi = contexto.CURSOS.Count() - 1;
                /// si encuentra codcur
                try
                {

                    if (contexto.CURSOS.SingleOrDefault(x => x.COD_CUR == campocurso.Text) != null)
                    {
                        // Enlace a ese curso
                        var x = contexto.CURSOS.SingleOrDefault(c => c.COD_CUR == campocurso.Text);


                        x.DESCRIPCION = campodescripcion.Text.ToString();
                        x.HORAS = Convert.ToInt32(campohoras.Text);
                        x.TUTOR = campotutor.Text.ToString();

                        contexto.SaveChanges();
                    }
                    else
                    {
                        CURSOS graba = new CURSOS();

                        graba.COD_CUR = campocurso.Text.ToString();
                        graba.DESCRIPCION = campodescripcion.Text.ToString();
                        graba.HORAS = Convert.ToInt32(campohoras.Text);
                        graba.TUTOR = campotutor.Text.ToString();

                        contexto.CURSOS.Add(graba);
                        contexto.SaveChanges();
                    }


                    /*var vcurso =
                             (from pcurso in contexto.CURSOS orderby pcurso.COD_CUR ascending select pcurso).Skip(posi)
                             .First();*/



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
        /// <summary>
        /// Botón que limpia los textbox y nos situa en una posición para grabar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void new_OnClick(object sender, EventArgs e)
        {

            campocurso.Text = "";
            campodescripcion.Text = "";
            campohoras.Text = "";
            campotutor.Text = "";

            int posi = Convert.ToInt32(Session["posicion"]);
            posi = 1;
        }
        /// <summary>
        /// Botón borrar el registro actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Delete_OnClick(object sender, EventArgs e)
        {
            int posi = Convert.ToInt32(Session["posicion"]);

            using (modeloOcupacional contexto = new modeloOcupacional())
            {
                try
                {

                    var vcurso = (from pcurso in contexto.CURSOS
                                  where pcurso.COD_CUR == campocurso.Text
                                  select pcurso).First();

                    contexto.CURSOS.Remove(vcurso);
                    contexto.SaveChanges();

                    campocurso.Text = "";
                    campodescripcion.Text = "";
                    campohoras.Text = "";
                    campotutor.Text = "";
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
    }
}