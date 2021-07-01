using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace Windows.Main
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Business.Logic.UsuarioLogic ul = new UsuarioLogic();
            Business.Entities.Usuario usr = new Usuario();
            //Comprueba si hay un error en la base de datos
            try
            {
                usr = ul.GetOneUsuario(txtUsuario.Text);
                //si recibe el usuario bien compara la contraseña con el txtContraseña
                if (usr.Habilitado)
                {
                    if (usr.NombreUsuario == txtUsuario.Text && usr.Clave == txtContraseña.Text)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else if (usr.NombreUsuario != txtUsuario.Text || usr.Clave != txtContraseña.Text)
                    {
                        NotificarError("Usuario o Contraseña incorrectos");
                    }
                }
                else
                {
                    NotificarError("Usuario no Habilitado");
                }
            }
            catch (Exception Ex)

            {
                NotificarError(Ex.Message);
            }

        }

        private void btn_salir (object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
                   
