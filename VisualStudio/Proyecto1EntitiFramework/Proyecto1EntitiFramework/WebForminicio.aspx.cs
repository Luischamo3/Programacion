using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1EntitiFramework
{
    public partial class WebForminicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            using(modeloOcupacional contexto = new modeloOcupacional())
                    // Clase que contiene el contexto, abre y cierra la base de datos
            {

                

            }

        }
    }
}