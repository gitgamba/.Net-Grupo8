using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windows.DesktopForms
{
    public partial class MateriaDesktop : Windows.ApplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();
        }
        
        public Materia MateriaActual { get; set; }
        public MateriaDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            MateriaActual = new Materia();
        }
    
        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                txtHsSem.ReadOnly = true;
                txtDescripcion.ReadOnly = true;
                btnSeleccionarPlan.Enabled = false;
            }
         Modo = modo;
            Business.Logic.MateriasLogic ml = new Business.Logic.MateriasLogic();
            try
            {
            MateriaActual = ml.GetOneId(ID);
            MapearDeDatos();
            }
            catch (Exception Ex)
            {
            throw Ex;
            }
        }
            public override void MapearDeDatos()
            {
                this.txtID.Text = this.MateriaActual.ID.ToString();
                this.txtDescripcion.Text = this.MateriaActual.DescMateria;
                this.txtHsSem.Text = this.MateriaActual.HorasSem.ToString();
                this.txtHsTotales.Text = this.MateriaActual.HorasTot.ToString();

                PlanLogic pl = new PlanLogic();
                lbNoPlan.Text = pl.GetOneId(MateriaActual.IdPlan).Desc_plan;

                //Copiado de usuario desktop
                if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
                else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
                else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";
            }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                MateriaActual.State = BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    MateriaActual.State = BusinessEntity.States.New;
                }
                MateriaActual.HorasSem = int.Parse(txtHsSem.Text);
                MateriaActual.HorasTot = int.Parse(txtHsTotales.Text);
                MateriaActual.DescMateria = txtDescripcion.Text;
                //MateriaActual.IdPlan se mapea en el metodo del boton seleccionar plan               
            }
            if (Modo == ModoForm.Baja)
            {
                MateriaActual.State = BusinessEntity.States.Deleted;
            }
        
    }
        public override bool Validar()
        {


            if (txtDescripcion.Text.Equals(String.Empty) ||
                txtHsSem.Text.Equals(String.Empty))
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
            MateriasLogic matLogic = new MateriasLogic();

            try
            {
                matLogic.Save(MateriaActual);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionarPlan_Click(object sender, EventArgs e)
        {
            SelectPlan sp = new SelectPlan();
            DialogResult DRsp = sp.ShowDialog(); // lo seleccionado lo tnemos que guardar en algun lado en este caso un dialog result
            if (DRsp != DialogResult.Cancel)
            {
                MateriaActual.IdPlan = sp.IdSelectPlan;
                lbNoPlan.Text = sp.DescSelectPlan;

            }
            else if (DRsp == DialogResult.Cancel)
            {
                Notificar("Comisiones", "Debe seleccionar un Plan.\nSi no hay debe crear uno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
