using Business.Logic;
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
    public partial class Comisiones : Form
    {
        public Comisiones()
        {
            InitializeComponent();
        }
        public void Listar() 
        {
            ComisionesLogic cl = new ComisionesLogic();

            try { this.dgvComisiones.DataSource = cl.getAll(); }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + "\nError Interno: ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }

        }


        private void Comisiones_Load(object sender, EventArgs e)
        {
            dgvComisiones.AutoGenerateColumns = false;
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

            try
            {
               
                ComisionesDesktop formComisiones = new ComisionesDesktop(ApplicationForm.ModoForm.Alta);
                formComisiones.ShowDialog();
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nError Interno: ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                this.Listar();
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisiones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Porfavor selecccione una fila.", "Acción invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // para obtener el ID utilizamos los que estaba en el pdf
            int ID = ((Business.Entities.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            //Ahora utilizamos el ctor de UsuarioDesktop que requiere enviar el ID y el Modo
           ComisionesDesktop formComisiones = new ComisionesDesktop(ID, ApplicationForm.ModoForm.Modificacion); //estamos en modificacion
            formComisiones.ShowDialog(); // mostramos el formUsuario
            this.Listar(); // para que se actualice
        }


        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisiones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Porfavor seleccione una fila.", "Acción invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // para obtener el ID utilizamos los que estaba en el pdf
            int ID = ((Business.Entities.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            //Ahora utilizamos el ctor de UsuarioDesktop que requiere enviar el ID y Modo

            ComisionesDesktop formComisiones = new ComisionesDesktop(ID, ApplicationForm.ModoForm.Baja);
            formComisiones.ShowDialog();
            this.Listar();


        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
