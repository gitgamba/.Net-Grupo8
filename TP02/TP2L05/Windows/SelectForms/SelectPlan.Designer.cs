
namespace Windows
{
    partial class SelectPlan
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
            this.tcPlan = new System.Windows.Forms.ToolStripContainer();
            this.tlPlan = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSelectPlan = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.tcPlan.ContentPanel.SuspendLayout();
            this.tcPlan.SuspendLayout();
            this.tlPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPlan
            // 
            // 
            // tcPlan.ContentPanel
            // 
            this.tcPlan.ContentPanel.Controls.Add(this.tlPlan);
            this.tcPlan.ContentPanel.Size = new System.Drawing.Size(376, 422);
            this.tcPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPlan.Location = new System.Drawing.Point(0, 0);
            this.tcPlan.Name = "tcPlan";
            this.tcPlan.Size = new System.Drawing.Size(376, 422);
            this.tcPlan.TabIndex = 2;
            this.tcPlan.Text = "toolStripContainer1";
            // 
            // tcPlan.TopToolStripPanel
            // 
            this.tcPlan.TopToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            // 
            // tlPlan
            // 
            this.tlPlan.ColumnCount = 2;
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPlan.Controls.Add(this.dgvSelectPlan, 0, 0);
            this.tlPlan.Controls.Add(this.btnSalir, 1, 1);
            this.tlPlan.Controls.Add(this.btnSeleccionar, 0, 1);
            this.tlPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPlan.Location = new System.Drawing.Point(0, 0);
            this.tlPlan.Name = "tlPlan";
            this.tlPlan.RowCount = 2;
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.Size = new System.Drawing.Size(376, 422);
            this.tlPlan.TabIndex = 0;
            // 
            // dgvSelectPlan
            // 
            this.dgvSelectPlan.AllowUserToAddRows = false;
            this.dgvSelectPlan.AllowUserToDeleteRows = false;
            this.dgvSelectPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Descripcion,
            this.Año});
            this.tlPlan.SetColumnSpan(this.dgvSelectPlan, 2);
            this.dgvSelectPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectPlan.Location = new System.Drawing.Point(3, 3);
            this.dgvSelectPlan.MultiSelect = false;
            this.dgvSelectPlan.Name = "dgvSelectPlan";
            this.dgvSelectPlan.ReadOnly = true;
            this.dgvSelectPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectPlan.Size = new System.Drawing.Size(370, 387);
            this.dgvSelectPlan.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Desc_plan";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Año
            // 
            this.Año.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Año.DataPropertyName = "Id_Especialidad";
            this.Año.HeaderText = "ID Especialidad";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            this.Año.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(298, 396);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSeleccionar.Location = new System.Drawing.Point(217, 396);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // SelectPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 422);
            this.Controls.Add(this.tcPlan);
            this.Name = "SelectPlan";
            this.Text = "SelectPlan";
            this.tcPlan.ContentPanel.ResumeLayout(false);
            this.tcPlan.ResumeLayout(false);
            this.tcPlan.PerformLayout();
            this.tlPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcPlan;
        private System.Windows.Forms.TableLayoutPanel tlPlan;
        private System.Windows.Forms.DataGridView dgvSelectPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}