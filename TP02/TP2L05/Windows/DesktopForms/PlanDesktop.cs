using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;


namespace Windows.DesktopForms
{
    public partial class PlanDesktop : Windows.ApplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
        }
       
        public PlanDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            PlanActual = new Business.Entities.Plan();
            PlanActual.Id_Especialidad = -1; //para validar q hay fk
        }
        private Business.Entities.Plan _PlanActual;
        public Plan PlanActual { get; set; }

        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                txtDesc.ReadOnly = true;
                
            }
            Modo = modo;
            Business.Logic.PlanLogic pll = new Business.Logic.PlanLogic();
            try
            {
                PlanActual = pll.GetOneId(ID);
                MapearDeDatos();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDesc.Text = this.PlanActual.Desc_plan;
            

            //Copiado de usuario desktop
            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta) PlanActual = new Plan();

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo != ModoForm.Alta) this.PlanActual.ID = int.Parse(this.txtID.Text);
                this.PlanActual.Id_Especialidad = Convert.ToInt32(this.lbNombreEspecialidad.Text);
                this.PlanActual.Desc_plan = this.txtDesc.Text;

            }

            if (Modo == ModoForm.Alta) PlanActual.State = BusinessEntity.States.New;
            if (Modo == ModoForm.Baja) PlanActual.State = BusinessEntity.States.Deleted;
            if (Modo == ModoForm.Consulta) PlanActual.State = BusinessEntity.States.Unmodified;// Consulta actualiza State a Unmodified?
            if (Modo == ModoForm.Modificacion) PlanActual.State = BusinessEntity.States.Modified;
        }
        public override bool Validar()
        {


            if (txtDesc.Text.Equals(String.Empty) ||
                lbNombreEspecialidad.Text.Equals("No selecciono ninguna Especialidad"))
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
            PlanLogic plLogic = new PlanLogic();

            try
            {
                plLogic.Save(PlanActual);
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
    }
}
