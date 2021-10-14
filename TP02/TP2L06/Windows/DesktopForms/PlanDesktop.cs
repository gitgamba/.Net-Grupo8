using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;


namespace Windows
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
        public Business.Entities.Plan PlanActual
        {
            get { return _PlanActual; }
            set { _PlanActual = value; }
        }

        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                txtDesc.ReadOnly = true;
                btnSeleccionarEspecialidad.Enabled = false;
                
            }
            Modo = modo;
            PlanLogic pll = new PlanLogic();
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

            EspecialidadLogic el = new EspecialidadLogic();
            lbNombreEspecialidad.Text = el.GetOneId(PlanActual.Id_Especialidad).Desc_Especialidad;

            //Copiado de usuario desktop
            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                PlanActual.State = BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    PlanActual.State = BusinessEntity.States.New;
                }
                PlanActual.Desc_plan = txtDesc.Text;
                /*PlanActual.id_especialidad se setea al seleccionar el boton especialidad
                 Y en validacion es obligatorio seleccionar un boton antes de MapearADatos*/
            }
            if (Modo == ModoForm.Baja)
            {
                PlanActual.State = BusinessEntity.States.Deleted;
            }
        }
        public override bool Validar()
        {


            if (String.IsNullOrWhiteSpace(txtDesc.Text))
            {
                Notificar("Debe llenar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PlanActual.Id_Especialidad < 0)//si no se apreto el boton seleccionar especialidad queda -1 (seteado al principio ene l constructor)
            {
                Notificar("Planes", "Debe seleccionar una Especialidad.\nSi no hay debe crear una", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSeleccionarEspecialidad_Click(object sender, EventArgs e)
        {
            SelectEspecialidad se = new SelectEspecialidad();
            DialogResult DRse = se.ShowDialog();
            if (DRse == DialogResult.OK)
            {
                PlanActual.Id_Especialidad = se.IdSelectEspecialidad;
                lbNombreEspecialidad.Text = se.DescSelectEspecialidad;
            }
            else if (DRse != DialogResult.OK)
            {
                Notificar("Planes", "Debe seleccionar una Especialidad.\nSi no hay debe crear una", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void lbNombreEspecialidad_Click(object sender, EventArgs e)
        {

        }
    }
}
