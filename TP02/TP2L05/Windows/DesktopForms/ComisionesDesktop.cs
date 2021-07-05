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

        public Comisiones ComisionActual { get ; set; }
        public ComisionesDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            ComisionActual = new Business.Entities.Comisiones();
        }

       








    }
}
