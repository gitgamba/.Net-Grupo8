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

            //Copiado de usuario desktop
            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta) ComisionActual = new Comision();

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo != ModoForm.Alta) this.ComisionActual.ID = int.Parse(this.txtID.Text);
                this.ComisionActual.AnioEspecialidad = Convert.ToInt32( this.txtAnio.Text);
                this.ComisionActual.DescComision = this.txtDescripcion.Text;
               
            }

            if (Modo == ModoForm.Alta) ComisionActual.State = BusinessEntity.States.New;
            if (Modo == ModoForm.Baja) ComisionActual.State = BusinessEntity.States.Deleted;
            if (Modo == ModoForm.Consulta) ComisionActual.State = BusinessEntity.States.Unmodified;// Consulta actualiza State a Unmodified?
            if (Modo == ModoForm.Modificacion) ComisionActual.State = BusinessEntity.States.Modified;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
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
            DialogResult DRsp = sp.ShowDialog();
            if(DRsp != DialogResult.Cancel)
            {
                lbNoPlan.Text = sp.DescSelectPlan;
                   ComisionActual.IdPlan = sp.IdSelectPlan;
            }
        }

        private void lbNoPlan_Click(object sender, EventArgs e)
        {

        }

       
    }










 }
