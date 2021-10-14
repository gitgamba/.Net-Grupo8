using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabABM
{
    public partial class ListaUsuarios : System.Web.UI.Page
    {
        private bool PaginaEnEstadoEdicion()
        {
            
            if (Request.QueryString["ID"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       private bool _estado;


        public bool estado { get => _estado; set => _estado = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            estado = PaginaEnEstadoEdicion();
            if (estado)
            {

                lblAccion.Text = "Editar Usuario <idUsuario>";

            }
            else
            {
                lblAccion.Text = "Agregar Nuevo Usuario";
               // CargarDatosUsuario((this.grdUsuarios.Rows[1].DataItem));
               
            }
        }
        private void CargarDatosUsuario(int idUsuario)
        {
            // 1 - Obtener los datos del usuario en cuestión
            // 2 - Cargar en los controles de la tabla los datos del usuario obtenido
            ManagerUsuarios mu = new ManagerUsuarios();
            Usuario user = mu.GetUsuario(idUsuario);
            txtNombre.Text = user.Nombre;
            txtApellido.Text = user.Apellido;
            txtClave.Text = user.Clave;
            txtEmail.Text = user.Email;
            txtNombreUsuario.Text = user.NombreUsuario;
            chbxHabilitado.Checked = user.Habilitado;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            
            user.Nombre = txtNombre.Text;
            user.Apellido = txtApellido.Text;
            user.Clave=txtClave.Text;
            user.Email = txtEmail.Text;
            user.NombreUsuario= txtNombreUsuario.Text;
            user.Habilitado = chbxHabilitado.Checked;
            ManagerUsuarios mu = new ManagerUsuarios();
            if (estado)
            {
                mu.AgregarUsuario(user);
            }
            else
            {
                mu.ActualizarUsuario(user);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}