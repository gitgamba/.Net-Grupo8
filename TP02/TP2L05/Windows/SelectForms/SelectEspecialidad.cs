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
    public partial class SelectEspecialidad : Form
    {
        public SelectEspecialidad()
        {
            InitializeComponent();
            this.dgvSelectEspecialidad.AutoGenerateColumns = false;
            this.Listar();
        }
        public void Listar()
        {
            EspecialidadLogic especialidad = new EspecialidadLogic();

            try { this.dgvSelectEspecialidad.DataSource = especialidad.getAll(); }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + "\nError Interno: ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {

            Listar();
        }

        private int _idSelectEspecialidad;
        private string _descSelectEspecialidad;

        public int IdSelectEspecialidad { get => _idSelectEspecialidad; set => _idSelectEspecialidad = value; }
        public string DescSelectEspecialidad { get => _descSelectEspecialidad; set => _descSelectEspecialidad = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvSelectEspecialidad.SelectedRows != null)
            {
                IdSelectEspecialidad = ((Business.Entities.Especialidad)dgvSelectEspecialidad.SelectedRows[0].DataBoundItem).ID;
                DescSelectEspecialidad = ((Business.Entities.Especialidad)dgvSelectEspecialidad.SelectedRows[0].DataBoundItem).Desc_Especialidad;
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (dgvSelectEspecialidad.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione una Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
