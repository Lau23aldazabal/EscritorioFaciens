
namespace EscritorioFaciens
{
    partial class MantenimientoTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoTela));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvTela = new System.Windows.Forms.ListView();
            this.ch0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsTela = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreTela = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.cmsTela.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lvTela, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.722222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.27778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 432);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lvTela
            // 
            this.lvTela.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvTela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch0,
            this.ch1,
            this.ch2,
            this.ch3,
            this.ch4});
            this.lvTela.ContextMenuStrip = this.cmsTela;
            this.lvTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTela.FullRowSelect = true;
            this.lvTela.GridLines = true;
            this.lvTela.HideSelection = false;
            this.lvTela.Location = new System.Drawing.Point(3, 45);
            this.lvTela.MultiSelect = false;
            this.lvTela.Name = "lvTela";
            this.lvTela.Size = new System.Drawing.Size(909, 384);
            this.lvTela.TabIndex = 1;
            this.lvTela.UseCompatibleStateImageBehavior = false;
            this.lvTela.View = System.Windows.Forms.View.Details;
            this.lvTela.DoubleClick += new System.EventHandler(this.lvTela_DoubleClickAsync);
            // 
            // ch0
            // 
            this.ch0.Text = "Nombre";
            this.ch0.Width = 133;
            // 
            // ch1
            // 
            this.ch1.Text = "Fecha creación";
            this.ch1.Width = 133;
            // 
            // ch2
            // 
            this.ch2.Text = "Usuario creación";
            this.ch2.Width = 174;
            // 
            // ch3
            // 
            this.ch3.Text = "Fecha modificación";
            this.ch3.Width = 185;
            // 
            // ch4
            // 
            this.ch4.Text = "Usuario modificación";
            this.ch4.Width = 212;
            // 
            // cmsTela
            // 
            this.cmsTela.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsTela.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevo,
            this.tsmiModificar,
            this.tsmiEliminar});
            this.cmsTela.Name = "cmsEstilo";
            this.cmsTela.Size = new System.Drawing.Size(241, 121);
            this.cmsTela.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTela_Opening);
            // 
            // tsmiNuevo
            // 
            this.tsmiNuevo.BackColor = System.Drawing.Color.White;
            this.tsmiNuevo.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.tsmiNuevo.ForeColor = System.Drawing.Color.Black;
            this.tsmiNuevo.Name = "tsmiNuevo";
            this.tsmiNuevo.Size = new System.Drawing.Size(240, 28);
            this.tsmiNuevo.Text = "Añadir tela";
            this.tsmiNuevo.Click += new System.EventHandler(this.tsmiNuevo_Click);
            // 
            // tsmiModificar
            // 
            this.tsmiModificar.BackColor = System.Drawing.Color.White;
            this.tsmiModificar.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.tsmiModificar.ForeColor = System.Drawing.Color.Black;
            this.tsmiModificar.Name = "tsmiModificar";
            this.tsmiModificar.Size = new System.Drawing.Size(240, 28);
            this.tsmiModificar.Text = "Modificar tela";
            this.tsmiModificar.Click += new System.EventHandler(this.tsmiModificar_Click);
            // 
            // tsmiEliminar
            // 
            this.tsmiEliminar.BackColor = System.Drawing.Color.White;
            this.tsmiEliminar.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.tsmiEliminar.ForeColor = System.Drawing.Color.Black;
            this.tsmiEliminar.Name = "tsmiEliminar";
            this.tsmiEliminar.Size = new System.Drawing.Size(240, 28);
            this.tsmiEliminar.Text = "Eliminar tela";
            this.tsmiEliminar.Click += new System.EventHandler(this.tsmiEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtNombreTela);
            this.panel1.Controls.Add(this.label2);
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
            this.btnBuscar.Location = new System.Drawing.Point(288, 6);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 24);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreTela
            // 
            this.txtNombreTela.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNombreTela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreTela.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.txtNombreTela.ForeColor = System.Drawing.Color.Black;
            this.txtNombreTela.Location = new System.Drawing.Point(62, 9);
            this.txtNombreTela.Name = "txtNombreTela";
            this.txtNombreTela.Size = new System.Drawing.Size(220, 25);
            this.txtNombreTela.TabIndex = 18;
            this.txtNombreTela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreTela_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // MantenimientoTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 432);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimientoTela";
            this.Text = "Mantenimiento tela";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cmsTela.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lvTela;
        private System.Windows.Forms.ContextMenuStrip cmsTela;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminar;
        private System.Windows.Forms.ColumnHeader ch0;
        private System.Windows.Forms.ColumnHeader ch1;
        private System.Windows.Forms.ColumnHeader ch2;
        private System.Windows.Forms.ColumnHeader ch3;
        private System.Windows.Forms.ColumnHeader ch4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombreTela;
        private System.Windows.Forms.Label label2;
    }
}