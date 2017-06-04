using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1EntitiFramework
{
    public partial class WebFormNotas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            if (!IsPostBack)
            {

                using (modeloOcupacional contexto = new modeloOcupacional())
                // Clase que contiene el contexto, abre y cierra la base de datos
                {

                    var vcurso =
                        (from pcurso in contexto.CURSOS
                         orderby pcurso.COD_CUR ascending
                         select pcurso).ToList();
                    
                    ListItem n = new ListItem("Seleccione curso", "");
                    combobox1.Items.Add(n);

                    foreach (CURSOS c in vcurso)
                    {
                        ListItem newc = new ListItem(c.DESCRIPCION, c.COD_CUR);
                        combobox1.Items.Add(newc);
                    }
                   
                    
                    Panel1.Visible = false;

                }
            }
            else
            {
                if (combobox1.SelectedIndex == 0)
                {
                    gridView2.Visible = false;
                }
                else
                {
                    gridView2.Visible = true;
                }
            }


        }

        public void combobox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {


            using (modeloOcupacional contexto = new modeloOcupacional())
            {

                var vnotas = (from pnotas in contexto.NOTAS
                              join palumnos in contexto.ALUMNOS
                              on pnotas.COD_ALU equals palumnos.COD_ALU
                              where pnotas.COD_CUR == combobox1.SelectedItem.Value.ToString()
                              orderby palumnos.NOMBRE, palumnos.APELLIDOS

                              select new
                              {
                                  COD_ALU = palumnos.COD_ALU,
                                  APELLIDOS = palumnos.APELLIDOS,
                                  NOMBRE = palumnos.NOMBRE,
                                  NOTA1 = pnotas.NOTA1,
                                  NOTA2 = pnotas.NOTA2,
                                  NOTA3 = pnotas.NOTA3,
                                  MEDIA = pnotas.MEDIA,
                              }).Distinct().ToList();


                gridView2.DataSource = vnotas;
                gridView2.DataBind();


                gridView2.Columns[1].ControlStyle.CssClass = "nodisplay";


            }
            
        }


        protected void savebutton_OnClick(object sender, EventArgs e)
        {
            using (modeloOcupacional contexto = new modeloOcupacional()) { 
                foreach (NOTAS nota in contexto.NOTAS)
                {
                    if (nota.COD_ALU== campocodalu.Text)
                    {
                        nota.NOTA1 = Convert.ToInt32(note1.Text);
                        nota.NOTA2 = Convert.ToInt32(note2.Text);
                        nota.NOTA3 = Convert.ToInt32(note3.Text);
                        nota.MEDIA = ((Convert.ToInt32((note1.Text)) + Convert.ToInt32((note2.Text)) +
                                       Convert.ToInt32((note3.Text))) / 3);
                    }
                    
                }
                contexto.SaveChanges();
                combobox1.SelectedIndex = 0;
                gridView2.Visible = false;
                gridView2.DataBind();

            }
        }
    

        protected void cancelbutton_OnClick(object sender, EventArgs e)
        {
            
            note1.Text = "";
            note2.Text = "";
            note3.Text = "";
            //avg.Text = "";
            combobox1.SelectedIndex = 0;
            gridView2.Visible = false;

        }

        protected void gridView2_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {

            string t = gridView2.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text;
            Panel1.Visible = true;

            campocodalu.Text = gridView2.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text;
            note1.Text = gridView2.Rows[Convert.ToInt32(e.CommandArgument)].Cells[4].Text;
            note2.Text = gridView2.Rows[Convert.ToInt32(e.CommandArgument)].Cells[5].Text;
            note3.Text = gridView2.Rows[Convert.ToInt32(e.CommandArgument)].Cells[6].Text;
            string media = ((Convert.ToInt32((note1.Text)) + Convert.ToInt32((note2.Text)) + Convert.ToInt32((note3.Text))) /3).ToString();
            //avg.Text = media;


        }

        protected void deletebutton_OnClick(object sender, EventArgs e)
        {
            using (modeloOcupacional contexto = new modeloOcupacional())
            {
                foreach (NOTAS nota in contexto.NOTAS)
                {
                    if (nota.COD_ALU == campocodalu.Text)
                    {

                        nota.NOTA1 = 0;
                        nota.NOTA2 = 0;
                        nota.NOTA3 = 0;
                        nota.MEDIA = 0;
                    }

                }
                contexto.SaveChanges();
                combobox1.SelectedIndex = 0;
                gridView2.Visible = false;

            }
        }
    }
}