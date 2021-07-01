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

        public void NotificarError(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_salir (object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Business.Logic.UsuarioLogic ul = new UsuarioLogic();
            Business.Entities.Usuario usr = new Usuario();
            //Comprueba si hay un error en la base de datos
            try
            {
                usr = ul.GetOneUsuario(textBox1.Text);
                //si recibe el usuario bien compara la contraseña con el txtContraseña
                if (usr.Habilitado)
                {
                    if (usr.NombreUsuario == textBox1.Text && usr.Clave == textBox2.Text)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else if (usr.NombreUsuario != textBox1.Text || usr.Clave != textBox2.Text)
                    {
                        NotificarError("error", "Usuario o Contraseña incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    NotificarError("error", "Usuario o Contraseña incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception Ex)

            {
                NotificarError("error", "Usuario o Contraseña incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
                   
