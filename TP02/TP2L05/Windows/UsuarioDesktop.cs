using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace Windows
{
    public partial class UsuarioDesktop : Windows.ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public Usuario UsuarioActual { get; set; }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            UsuarioActual = new Business.Entities.Usuario(); // this.Modo = modo 
        }

        public UsuarioDesktop(int ID, ModoForm modo):this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                txtNombre.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtClave.ReadOnly = true;
                txtApellido.ReadOnly = true;
                txtUsuario.ReadOnly = true;
                txtConfirmarClave.ReadOnly = false;
                chkHabilitado.Enabled = false;
            }
            Modo = modo;
            Business.Logic.UsuarioLogic ul = new Business.Logic.UsuarioLogic();
            try
            {
                UsuarioActual = ul.GetOneId(ID);
                MapearDeDatos();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }



        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;

            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";

            //base.MapearDeDatos();
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta) UsuarioActual = new Usuario();

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo != ModoForm.Alta) this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                this.UsuarioActual.Nombre = this.txtNombre.Text;
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                this.UsuarioActual.Email = this.txtEmail.Text;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                this.UsuarioActual.Clave = this.txtClave.Text;
            }

            if (Modo == ModoForm.Alta) UsuarioActual.State = BusinessEntity.States.New;
            if (Modo == ModoForm.Baja) UsuarioActual.State = BusinessEntity.States.Deleted;
            //if (modo == ModoForm.Consulta) UsuarioActual.State = BusinessEntity.States.Unmodified;// Consulta actualiza State a Unmodified?
            if (Modo == ModoForm.Modificacion) UsuarioActual.State = BusinessEntity.States.Modified;
        }

        public override bool Validar()
        {
            
            
            if (txtNombre.Text.Equals(String.Empty) ||
                txtApellido.Text.Equals(String.Empty) ||
                txtEmail.Text.Equals(String.Empty) ||
                txtUsuario.Text.Equals(String.Empty) ||
                txtClave.Text.Equals(String.Empty) ||
                txtConfirmarClave.Text.Equals(String.Empty))
            {
                Notificar("Informacion invalida", "Complete todos los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!txtClave.Text.Equals(txtConfirmarClave.Text))
            {
                Notificar("Contraseña invalida", "Las contraseñas no coinciden.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            UsuarioLogic usrLogic = new UsuarioLogic();

            try { 
                usrLogic.Save(UsuarioActual);
                 }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar()) { GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
