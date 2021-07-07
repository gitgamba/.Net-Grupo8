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
using Windows.DesktopForms;

namespace Windows.ABMListForms
{
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            dgvPlanes.AutoGenerateColumns = false;
            this.Listar();
        }

        public void Listar() // en estos hya que enviar un MB
        {
            PlanLogic pll = new PlanLogic();

            try { this.dgvPlanes.DataSource = pll.getAll(); }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + "\nError Interno: ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }

        }


        private void Planes_Load(object sender, EventArgs e)
        {
            dgvPlanes.AutoGenerateColumns = false;
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvPlanes.AutoGenerateColumns = false;
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
      
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

        }


        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
