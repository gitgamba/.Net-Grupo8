using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Windows
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            Login lg = new Login();
            DialogResult loginRes = lg.ShowDialog();
            if (loginRes != DialogResult.OK)
            {
                Close();
            }
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.ShowDialog();
        }
        private void formMain_Shown(object sender, EventArgs e)
        {
            Login appLogin = new Login();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.ShowDialog();
            
        }

        private void btnPlan_Click(object sender,EventArgs e)
        {
            Planes pl = new Planes();
            pl.ShowDialog();
        }



        private void btnComisiones_Click(object sender, EventArgs e)
        {
            Comisiones com = new Comisiones();
            com.ShowDialog();

        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            Especialidades esp = new Especialidades();
            esp.ShowDialog(); 
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            Materias mat = new Materias();
            mat.ShowDialog();
        }
    }
}
