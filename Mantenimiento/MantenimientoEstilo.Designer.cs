
namespace EscritorioFaciens
{
    partial class MantenimientoEstilo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoEstilo));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvEstilo = new System.Windows.Forms.ListView();
            this.column0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsEstilo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreEstilo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.cmsEstilo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lvEstilo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.953704F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0463F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 432);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lvEstilo
            // 
            this.lvEstilo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvEstilo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column0,
            this.column1,
            this.column2,
            this.column3,
            this.column4});
            this.lvEstilo.ContextMenuStrip = this.cmsEstilo;
            this.lvEstilo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEstilo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvEstilo.FullRowSelect = true;
            this.lvEstilo.GridLines = true;
            this.lvEstilo.HideSelection = false;
            this.lvEstilo.Location = new System.Drawing.Point(3, 45);
            this.lvEstilo.MultiSelect = false;
            this.lvEstilo.Name = "lvEstilo";
            this.lvEstilo.Size = new System.Drawing.Size(909, 384);
            this.lvEstilo.TabIndex = 1;
            this.lvEstilo.UseCompatibleStateImageBehavior = false;
            this.lvEstilo.View = System.Windows.Forms.View.Details;
            this.lvEstilo.DoubleClick += new System.EventHandler(this.lvEstilo_DoubleClick);
            // 
            // column0
            // 
            this.column0.Text = "Nombre";
            this.column0.Width = 133;
            // 
            // column1
            // 
            this.column1.Text = "Fecha creación";
            this.column1.Width = 176;
            // 
            // column2
            // 
            this.column2.Text = "Usuario creación";
            this.column2.Width = 188;
            // 
            // column3
            // 
            this.column3.Text = "Fecha modificación";
            this.column3.Width = 187;
            // 
            // column4
            // 
            this.column4.Text = "Usuario modificación";
            this.column4.Width = 194;
            // 
            // cmsEstilo
            // 
            this.cmsEstilo.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEstilo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsEstilo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevo,
            this.tsmiModificar,
            this.tsmiEliminar});
            this.cmsEstilo.Name = "cmsEstilo";
            this.cmsEstilo.Size = new System.Drawing.Size(203, 88);
            this.cmsEstilo.Opening += new System.ComponentModel.CancelEventHandler(this.cmsEstilo_Opening);
            // 
            // tsmiNuevo
            // 
            this.tsmiNuevo.BackColor = System.Drawing.Color.White;
            this.tsmiNuevo.ForeColor = System.Drawing.Color.Black;
            this.tsmiNuevo.Name = "tsmiNuevo";
            this.tsmiNuevo.Size = new System.Drawing.Size(202, 28);
            this.tsmiNuevo.Text = "Añadir estilo";
            this.tsmiNuevo.Click += new System.EventHandler(this.tsmiNuevo_Click);
            // 
            // tsmiModificar
            // 
            this.tsmiModificar.BackColor = System.Drawing.Color.White;
            this.tsmiModificar.ForeColor = System.Drawing.Color.Black;
            this.tsmiModificar.Name = "tsmiModificar";
            this.tsmiModificar.Size = new System.Drawing.Size(202, 28);
            this.tsmiModificar.Text = "Modificar estilo";
            this.tsmiModificar.Click += new System.EventHandler(this.tsmiModificar_Click);
            // 
            // tsmiEliminar
            // 
            this.tsmiEliminar.BackColor = System.Drawing.Color.White;
            this.tsmiEliminar.ForeColor = System.Drawing.Color.Black;
            this.tsmiEliminar.Name = "tsmiEliminar";
            this.tsmiEliminar.Size = new System.Drawing.Size(202, 28);
            this.tsmiEliminar.Text = "Eliminar estilo";
            this.tsmiEliminar.Click += new System.EventHandler(this.tsmiEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtNombreEstilo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 36);
            this.panel1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(285, 7);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreEstilo
            // 
            this.txtNombreEstilo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNombreEstilo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEstilo.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.txtNombreEstilo.ForeColor = System.Drawing.Color.Black;
            this.txtNombreEstilo.Location = new System.Drawing.Point(59, 9);
            this.txtNombreEstilo.Name = "txtNombreEstilo";
            this.txtNombreEstilo.Size = new System.Drawing.Size(220, 25);
            this.txtNombreEstilo.TabIndex = 10;
            this.txtNombreEstilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEstilo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre:";
            // 
            // MantenimientoEstilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 432);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimientoEstilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento estilo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cmsEstilo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lvEstilo;
        private System.Windows.Forms.ContextMenuStrip cmsEstilo;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminar;
        private System.Windows.Forms.ColumnHeader column0;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.ColumnHeader column2;
        private System.Windows.Forms.ColumnHeader column3;
        private System.Windows.Forms.ColumnHeader column4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombreEstilo;
        private System.Windows.Forms.Label label1;
    }
}