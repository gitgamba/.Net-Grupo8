
namespace Windows.ABMListForms
{
    partial class Materias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Id_Materia = new System.Windows.Forms.Label();
            this.hs_semanales = new System.Windows.Forms.Label();
            this.Id_Plan = new System.Windows.Forms.Label();
            this.desc_materia = new System.Windows.Forms.Label();
            this.hs_totales = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.41485F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.58515F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Controls.Add(this.Id_Materia, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hs_semanales, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Id_Plan, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.desc_materia, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.hs_totales, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 320);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Id_Materia
            // 
            this.Id_Materia.AutoSize = true;
            this.Id_Materia.Location = new System.Drawing.Point(3, 0);
            this.Id_Materia.Name = "Id_Materia";
            this.Id_Materia.Size = new System.Drawing.Size(54, 13);
            this.Id_Materia.TabIndex = 1;
            this.Id_Materia.Text = "Id Materia";
            // 
            // hs_semanales
            // 
            this.hs_semanales.AutoSize = true;
            this.hs_semanales.Location = new System.Drawing.Point(3, 88);
            this.hs_semanales.Name = "hs_semanales";
            this.hs_semanales.Size = new System.Drawing.Size(90, 13);
            this.hs_semanales.TabIndex = 2;
            this.hs_semanales.Text = "Horas Semanales";
            // 
            // Id_Plan
            // 
            this.Id_Plan.AutoSize = true;
            this.Id_Plan.Location = new System.Drawing.Point(232, 0);
            this.Id_Plan.Name = "Id_Plan";
            this.Id_Plan.Size = new System.Drawing.Size(40, 13);
            this.Id_Plan.TabIndex = 3;
            this.Id_Plan.Text = "Id Plan";
            // 
            // desc_materia
            // 
            this.desc_materia.AutoSize = true;
            this.desc_materia.Location = new System.Drawing.Point(232, 88);
            this.desc_materia.Name = "desc_materia";
            this.desc_materia.Size = new System.Drawing.Size(101, 13);
            this.desc_materia.TabIndex = 4;
            this.desc_materia.Text = "Descripcion Materia";
            // 
            // hs_totales
            // 
            this.hs_totales.AutoSize = true;
            this.hs_totales.Location = new System.Drawing.Point(3, 176);
            this.hs_totales.Name = "hs_totales";
            this.hs_totales.Size = new System.Drawing.Size(73, 13);
            this.hs_totales.TabIndex = 5;
            this.hs_totales.Text = "Horas Totales";
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 315);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Materias";
            this.Text = "Materias";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Id_Materia;
        private System.Windows.Forms.Label hs_semanales;
        private System.Windows.Forms.Label Id_Plan;
        private System.Windows.Forms.Label desc_materia;
        private System.Windows.Forms.Label hs_totales;
    }
}