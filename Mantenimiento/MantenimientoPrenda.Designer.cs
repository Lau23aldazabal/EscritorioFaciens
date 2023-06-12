
namespace EscritorioFaciens
{
    partial class MantenimientoPrenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoPrenda));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvPrenda = new System.Windows.Forms.ListView();
            this.ch0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsPrenda = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombrePrenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.cmsPrenda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lvPrenda, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.41667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.58334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 432);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lvPrenda
            // 
            this.lvPrenda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvPrenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch0,
            this.ch1,
            this.ch2,
            this.ch3,
            this.ch4});
            this.lvPrenda.ContextMenuStrip = this.cmsPrenda;
            this.lvPrenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPrenda.ForeColor = System.Drawing.Color.Black;
            this.lvPrenda.FullRowSelect = true;
            this.lvPrenda.GridLines = true;
            this.lvPrenda.HideSelection = false;
            this.lvPrenda.Location = new System.Drawing.Point(3, 48);
            this.lvPrenda.MultiSelect = false;
            this.lvPrenda.Name = "lvPrenda";
            this.lvPrenda.Size = new System.Drawing.Size(909, 381);
            this.lvPrenda.TabIndex = 1;
            this.lvPrenda.UseCompatibleStateImageBehavior = false;
            this.lvPrenda.View = System.Windows.Forms.View.Details;
            this.lvPrenda.DoubleClick += new System.EventHandler(this.lvPrenda_DoubleClick);
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
            this.ch2.Width = 133;
            // 
            // ch3
            // 
            this.ch3.Text = "Fecha modificación";
            this.ch3.Width = 133;
            // 
            // ch4
            // 
            this.ch4.Text = "Usuario modificación";
            this.ch4.Width = 133;
            // 
            // cmsPrenda
            // 
            this.cmsPrenda.BackColor = System.Drawing.Color.White;
            this.cmsPrenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmsPrenda.BackgroundImage")));
            this.cmsPrenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmsPrenda.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsPrenda.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsPrenda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevo,
            this.tsmiModificar,
            this.tsmiEliminar});
            this.cmsPrenda.Name = "cmsEstilo";
            this.cmsPrenda.Size = new System.Drawing.Size(241, 121);
            this.cmsPrenda.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPrenda_Opening);
            // 
            // tsmiNuevo
            // 
            this.tsmiNuevo.BackColor = System.Drawing.Color.White;
            this.tsmiNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsmiNuevo.BackgroundImage")));
            this.tsmiNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmiNuevo.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.tsmiNuevo.ForeColor = System.Drawing.Color.Black;
            this.tsmiNuevo.Name = "tsmiNuevo";
            this.tsmiNuevo.Size = new System.Drawing.Size(240, 28);
            this.tsmiNuevo.Text = "Añadir prenda";
            this.tsmiNuevo.Click += new System.EventHandler(this.tsmiNuevo_Click);
            // 
            // tsmiModificar
            // 
            this.tsmiModificar.BackColor = System.Drawing.Color.White;
            this.tsmiModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsmiModificar.BackgroundImage")));
            this.tsmiModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmiModificar.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.tsmiModificar.ForeColor = System.Drawing.Color.Black;
            this.tsmiModificar.Name = "tsmiModificar";
            this.tsmiModificar.Size = new System.Drawing.Size(240, 28);
            this.tsmiModificar.Text = "Modificar prenda";
            this.tsmiModificar.Click += new System.EventHandler(this.tsmiModificar_Click);
            // 
            // tsmiEliminar
            // 
            this.tsmiEliminar.BackColor = System.Drawing.Color.White;
            this.tsmiEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsmiEliminar.BackgroundImage")));
            this.tsmiEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmiEliminar.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.tsmiEliminar.ForeColor = System.Drawing.Color.Black;
            this.tsmiEliminar.Name = "tsmiEliminar";
            this.tsmiEliminar.Size = new System.Drawing.Size(240, 28);
            this.tsmiEliminar.Text = "Eliminar prenda";
            this.tsmiEliminar.Click += new System.EventHandler(this.tsmiEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtNombrePrenda);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 39);
            this.panel1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(288, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombrePrenda
            // 
            this.txtNombrePrenda.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNombrePrenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombrePrenda.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.txtNombrePrenda.ForeColor = System.Drawing.Color.Black;
            this.txtNombrePrenda.Location = new System.Drawing.Point(62, 9);
            this.txtNombrePrenda.Name = "txtNombrePrenda";
            this.txtNombrePrenda.Size = new System.Drawing.Size(220, 25);
            this.txtNombrePrenda.TabIndex = 12;
            this.txtNombrePrenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePrenda_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // MantenimientoPrenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 432);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimientoPrenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento prenda";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cmsPrenda.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lvPrenda;
        private System.Windows.Forms.ContextMenuStrip cmsPrenda;
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
        private System.Windows.Forms.TextBox txtNombrePrenda;
        private System.Windows.Forms.Label label1;
    }
}