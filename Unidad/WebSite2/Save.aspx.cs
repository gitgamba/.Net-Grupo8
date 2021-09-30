using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite2
{
    public partial class Save : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["inputText"] = TextBox1.Text;
            TextBox1.Text = "";

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}