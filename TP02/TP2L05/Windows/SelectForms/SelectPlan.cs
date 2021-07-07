
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
    public partial class SelectPlan : Form
    {
        public SelectPlan()
        {
            InitializeComponent();
            this.dgvSelectPlan.AutoGenerateColumns = false;
            this.Listar();
        }

        public void Listar()
        {
            PlanLogic plan = new PlanLogic();

            try { this.dgvSelectPlan.DataSource = plan.getAll(); }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + "\nError Interno: ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }
        }

        private void Planes_Load(object sender, EventArgs e)
        {

            Listar();
        }

        private int _idSelectPlan;
        private string _descSelectPlan;

        public int IdSelectPlan { get => _idSelectPlan; set => _idSelectPlan = value; }
        public string DescSelectPlan { get => _descSelectPlan; set => _descSelectPlan = value; }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            if (dgvSelectPlan.SelectedRows != null)
            {
                IdSelectPlan = ((Business.Entities.Plan)dgvSelectPlan.SelectedRows[0].DataBoundItem).ID;
                DescSelectPlan = ((Business.Entities.Plan)dgvSelectPlan.SelectedRows[0].DataBoundItem).Desc_plan;
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (dgvSelectPlan.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}