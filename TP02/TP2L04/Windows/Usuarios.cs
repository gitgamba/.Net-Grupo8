using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace Windows
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();

        }

        public void Listar()
        {
            UsuarioLogic ul = new UsuarioLogic();
            this.dgvUsuarios.DataSource = ul.getAll();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.AutoGenerateColumns = false;
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            UsuarioDesktop formUsuario = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
            formUsuario.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Porfavor selecccione una fila.", "Acción invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;  
            }

            // para obtener el ID utilizamos los que estaba en el pdf
            int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            //Ahora utilizamos el ctor de UsuarioDesktop que requiere enviar el ID y el Modo
            UsuarioDesktop formUsuario = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Modificacion); //estamos en modificacion
            formUsuario.ShowDialog(); // mostramos el formUsuario
            this.Listar(); // para que se actualice
        }


        private void tsbEliminar_Click(object sender, EventArgs e)
        {
                if (this.dgvUsuarios.SelectedRows.Count == 0)
                {
                MessageBox.Show("Porfavor seleccione una fila.", "Acción invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
                    }

                // para obtener el ID utilizamos los que estaba en el pdf
            int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            //Ahora utilizamos el ctor de UsuarioDesktop que requiere enviar el ID y Modo

            UsuarioDesktop formUsuario = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Baja);
            formUsuario.ShowDialog();
            this.Listar();


        }

        //private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
        // para hacer commit de 12:25
    }
}
