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
    public partial class EspecialidadDesktop : Windows.ApplicationForm
    {
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }

        public Especialidad EspecialidadActual { get; set; }
        public EspecialidadDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            EspecialidadActual = new Business.Entities.Especialidad();
        }

        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                txtID.ReadOnly = true;
                txtDescripcion.ReadOnly = true;
            }
            Modo = modo;
            Business.Logic.EspecialidadLogic el = new Business.Logic.EspecialidadLogic();
            try
            {
                EspecialidadActual = el.GetOneId(ID);
                MapearDeDatos();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Desc_Especialidad;
            

            //Copiado de usuario desktop
            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)

                ////EspecialidadActual = new Especialidad(); //// problema con creacion de Especialidad

                if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
                {
                    if (Modo != ModoForm.Alta)



                        this.EspecialidadActual.ID = int.Parse(this.txtID.Text);
                    this.EspecialidadActual.Desc_Especialidad = this.txtDescripcion.Text;
                    

                }

            if (Modo == ModoForm.Alta) EspecialidadActual.State = BusinessEntity.States.New;
            if (Modo == ModoForm.Baja) EspecialidadActual.State = BusinessEntity.States.Deleted;
            if (Modo == ModoForm.Consulta) EspecialidadActual.State = BusinessEntity.States.Unmodified;// Consulta actualiza State a Unmodified?
            if (Modo == ModoForm.Modificacion) EspecialidadActual.State = BusinessEntity.States.Modified;
        }
        public override bool Validar()
        {


            if (txtDescripcion.Text.Equals(String.Empty))
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
            EspecialidadLogic el = new EspecialidadLogic();

            try
            {
                el.Save(EspecialidadActual);
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
     
    }

  }

