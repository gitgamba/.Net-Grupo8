using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx?msj=Hace memoria pa!");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("admin") && txtClave.Text.Equals("admin"))
            {
                Page.Response.Write("Ingreso OK");
            }
            else
            {
                Page.Response.Write("Usuario Y/O Clave incorrectos");
            }
        }

        protected void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}