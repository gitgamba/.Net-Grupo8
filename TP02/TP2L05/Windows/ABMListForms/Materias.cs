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

namespace Windows
{
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            MateriasLogic ml = new MateriasLogic();

            try { this.dgvMaterias.DataSource = ml.getAll(); }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + "\nError Interno: ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }

        }
        private void Materias_Load(object sender, EventArgs e)
        {
            dgvMaterias.AutoGenerateColumns = false;
            this.Listar();
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            try
            {

                MateriaDesktop formMateria = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
                formMateria.ShowDialog();
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
            if (this.dgvMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Porfavor selecccione una fila.", "Acción invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // para obtener el ID utilizamos los que estaba en el pdf
            int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            //Ahora utilizamos el ctor de UsuarioDesktop que requiere enviar el ID y el Modo
            MateriaDesktop formMateria = new MateriaDesktop(ID, ApplicationForm.ModoForm.Modificacion); //estamos en modificacion
            formMateria.ShowDialog(); // mostramos el formUsuario
            this.Listar(); // para que se actualice
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Porfavor seleccione una fila.", "Acción invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // para obtener el ID utilizamos los que estaba en el pdf
            int ID = ((Business.Entities.Comision)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            //Ahora utilizamos el ctor de UsuarioDesktop que requiere enviar el ID y Modo

            MateriaDesktop formMateria = new MateriaDesktop(ID, ApplicationForm.ModoForm.Baja);
            formMateria.ShowDialog();
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
        
    }
}
