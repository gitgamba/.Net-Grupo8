using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;


namespace Windows
{
    public partial class ComisionesDesktop : Windows.ApplicationForm
    {
        public ComisionesDesktop()
        {
            InitializeComponent();
        }

        public Comision ComisionActual { get ; set; }
        public ComisionesDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            ComisionActual = new Business.Entities.Comision();
        }

        public ComisionesDesktop(int ID, ModoForm modo) : this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                txtAnio.ReadOnly = true;
                txtDescripcion.ReadOnly = true;
                btnSeleccionarPlan.Enabled = false;
            }
            Modo = modo;
            Business.Logic.ComisionesLogic cl = new Business.Logic.ComisionesLogic();
            try
            {
                ComisionActual = cl.GetOneId(ID);
                MapearDeDatos();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ComisionActual.ID.ToString();
            this.txtDescripcion.Text = this.ComisionActual.DescComision;
            this.txtAnio.Text = this.ComisionActual.AnioEspecialidad.ToString();

            PlanLogic pl = new PlanLogic();
            lbNoPlan.Text = pl.GetOneId(ComisionActual.IdPlan).Desc_plan;

            //Copiado de usuario desktop
            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                ComisionActual.State = BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    ComisionActual.State = BusinessEntity.States.New;
                }
                ComisionActual.AnioEspecialidad = int.Parse(txtAnio.Text);
                ComisionActual.DescComision = txtDescripcion.Text;
                //ComisionActual.IdPlan se mapea en el metodo del boton seleccionar plan               
            }
            if (Modo == ModoForm.Baja)
            {
                ComisionActual.State = BusinessEntity.States.Deleted;
            }
        }
    
        public override bool Validar()
        {


            if (txtDescripcion.Text.Equals(String.Empty) ||
                txtAnio.Text.Equals(String.Empty))
            {
                Notificar("Informacion invalida", "Complete todos los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            ComisionesLogic comLogic = new ComisionesLogic();

            try
            {
                comLogic.Save(ComisionActual);
        }
            catch (Exception Ex)
            {
                throw Ex;
            }
}

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e) // va
        {
            this.Close();
        }


        private void btnAceptar_Click_1(object sender, EventArgs e) // va
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnSeleccionarPlan_Click(object sender, EventArgs e)
        {
            SelectPlan sp = new SelectPlan();
            DialogResult DRsp = sp.ShowDialog(); // lo seleccionado lo tnemos que guardar en algun lado en este caso un dialog result
            if (DRsp != DialogResult.Cancel)
            {
                ComisionActual.IdPlan = sp.IdSelectPlan;
                lbNoPlan.Text = sp.DescSelectPlan;

            }
            else if (DRsp == DialogResult.Cancel)
            {
                Notificar("Comisiones", "Debe seleccionar un Plan.\nSi no hay debe crear uno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }










 }
