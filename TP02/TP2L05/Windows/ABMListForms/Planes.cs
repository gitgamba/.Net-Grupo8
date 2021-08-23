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

namespace Windows
{
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
           
        }
      
        public void Listar()
        {
            PlanLogic plan = new PlanLogic();

            try { this.dgvPlanes.DataSource = plan.getAll(); }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + "\nError Interno: ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            dgvPlanes.AutoGenerateColumns = false;
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

                PlanDesktop formPlan = new PlanDesktop(ApplicationForm.ModoForm.Alta);
                formPlan.ShowDialog();
                
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
            if (this.dgvPlanes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Porfavor selecccione una fila.", "Acción invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // para obtener el ID utilizamos los que estaba en el pdf
            int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            //Ahora utilizamos el ctor de UsuarioDesktop que requiere enviar el ID y el Modo
            PlanDesktop formPlan = new PlanDesktop(ID, ApplicationForm.ModoForm.Modificacion); //estamos en modificacion
            formPlan.ShowDialog(); // mostramos el formUsuario
            this.Listar(); // para que se actualice
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPlanes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Porfavor seleccione una fila.", "Acción invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // para obtener el ID utilizamos los que estaba en el pdf
            int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            //Ahora utilizamos el ctor de UsuarioDesktop que requiere enviar el ID y Modo

           PlanDesktop formPlan = new PlanDesktop(ID, ApplicationForm.ModoForm.Baja);
            formPlan.ShowDialog();
            this.Listar();
        }
    }
}
