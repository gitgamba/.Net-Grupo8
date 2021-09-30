using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabGrillaASP
{
    public partial class ListaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Verificarmos que se ejecute lo siguiente solamente cuando lo produce
            //a este evento el botón Insertar
            if (e.CommandName.ToLower() == "insertar")
            {
                TextBox cajaTexto;
                string textoActual;
                Negocio.Usuario usuarioNuevo = new Negocio.Usuario();



                //Busco el control y se lo asigno a la propiedad correspondiente 
                //del objeto Usuario
                cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtNombre");
                textoActual = cajaTexto.Text;
                usuarioNuevo.Nombre = textoActual;

                //Así hago sucesivamente con el resto de los parámetros
                cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtApellido");
                textoActual = cajaTexto.Text;
                usuarioNuevo.Apellido = textoActual;
             
                cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtEmail");
                textoActual = cajaTexto.Text;
                usuarioNuevo.Email = textoActual;                

                cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtNombreUsuario");
                textoActual = cajaTexto.Text;
                usuarioNuevo.NombreUsuario = textoActual;

                cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtClave");
                textoActual = cajaTexto.Text;
                usuarioNuevo.Clave = textoActual;

                //Defino una variable del Manager para ejecutar el evento de Insertar
                Negocio.UsuarioData manager = new Negocio.UsuarioData();

                //Agrego el Nuevo Usuario
                manager.AgregarUsuario(usuarioNuevo);

                //Actualizo la Grilla
                grdUsuarios.DataBind();
            }

        }

    }
}
