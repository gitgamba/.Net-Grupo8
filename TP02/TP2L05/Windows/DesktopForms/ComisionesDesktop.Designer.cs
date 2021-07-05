
namespace Windows
{
    partial class ComisionesDesktop
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbID = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbAnio = new System.Windows.Forms.Label();
            this.lbPlan = new System.Windows.Forms.Label();
            this.btnSeleccionarPlan = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lbNoPlan = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.81042F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.18958F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.Controls.Add(this.lbID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbDescripcion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbAnio, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbPlan, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAnio, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbNoPlan, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSeleccionarPlan, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 403);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbID
            // 
            this.lbID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(63, 47);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(84, 47);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID:";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(63, 123);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(84, 13);
            this.lbDescripcion.TabIndex = 1;
            this.lbDescripcion.Text = "Descripción: ";
            this.lbDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAnio
            // 
            this.lbAnio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAnio.AutoSize = true;
            this.lbAnio.Location = new System.Drawing.Point(63, 193);
            this.lbAnio.Name = "lbAnio";
            this.lbAnio.Size = new System.Drawing.Size(84, 13);
            this.lbAnio.TabIndex = 2;
            this.lbAnio.Text = "Año:";
            this.lbAnio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlan
            // 
            this.lbPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlan.AutoSize = true;
            this.lbPlan.Location = new System.Drawing.Point(63, 262);
            this.lbPlan.Name = "lbPlan";
            this.lbPlan.Size = new System.Drawing.Size(84, 13);
            this.lbPlan.TabIndex = 3;
            this.lbPlan.Text = "Plan: ";
            this.lbPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSeleccionarPlan
            // 
            this.btnSeleccionarPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarPlan.Location = new System.Drawing.Point(153, 307);
            this.btnSeleccionarPlan.Name = "btnSeleccionarPlan";
            this.btnSeleccionarPlan.Size = new System.Drawing.Size(228, 23);
            this.btnSeleccionarPlan.TabIndex = 4;
            this.btnSeleccionarPlan.Text = "Seleccionar Plan";
            this.btnSeleccionarPlan.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAceptar.Location = new System.Drawing.Point(306, 367);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(387, 367);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(217, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.Location = new System.Drawing.Point(217, 120);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtAnio
            // 
            this.txtAnio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAnio.Location = new System.Drawing.Point(217, 189);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 9;
            // 
            // lbNoPlan
            // 
            this.lbNoPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNoPlan.AutoSize = true;
            this.lbNoPlan.Location = new System.Drawing.Point(153, 262);
            this.lbNoPlan.Name = "lbNoPlan";
            this.lbNoPlan.Size = new System.Drawing.Size(228, 13);
            this.lbNoPlan.TabIndex = 10;
            this.lbNoPlan.Text = "No seleccionó ningún plan ";
            // 
            // ComisionesDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(463, 403);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ComisionesDesktop";
            this.Text = "Comisiones";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbAnio;
        private System.Windows.Forms.Label lbPlan;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lbNoPlan;
        private System.Windows.Forms.Button btnSeleccionarPlan;
    }
}
