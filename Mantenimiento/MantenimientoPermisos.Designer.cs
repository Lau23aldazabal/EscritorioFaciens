
namespace EscritorioFaciens.Mantenimiento
{
    partial class MantenimientoPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoPermisos));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlAdministradores = new System.Windows.Forms.Panel();
            this.tlpAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.lvAdmin = new System.Windows.Forms.ListView();
            this.chCon0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlAdmins = new System.Windows.Forms.Panel();
            this.pnlNoAdministradores = new System.Windows.Forms.Panel();
            this.tlpNoAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.lvNoAdmin = new System.Windows.Forms.ListView();
            this.chNoAdmin0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlNoAdmin = new System.Windows.Forms.Panel();
            this.btnBuscarUsername = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAdministradores.SuspendLayout();
            this.tlpAdmin.SuspendLayout();
            this.pnlNoAdministradores.SuspendLayout();
            this.tlpNoAdmin.SuspendLayout();
            this.pnlNoAdmin.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlAdministradores, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlNoAdministradores, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 491);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(454, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(282, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 27);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar permiso";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnlAdministradores
            // 
            this.pnlAdministradores.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdministradores.Controls.Add(this.tlpAdmin);
            this.pnlAdministradores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdministradores.Location = new System.Drawing.Point(454, 3);
            this.pnlAdministradores.Name = "pnlAdministradores";
            this.pnlAdministradores.Size = new System.Drawing.Size(445, 434);
            this.pnlAdministradores.TabIndex = 1;
            // 
            // tlpAdmin
            // 
            this.tlpAdmin.ColumnCount = 1;
            this.tlpAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpAdmin.Controls.Add(this.lvAdmin, 0, 1);
            this.tlpAdmin.Controls.Add(this.pnlAdmins, 0, 0);
            this.tlpAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAdmin.Location = new System.Drawing.Point(0, 0);
            this.tlpAdmin.Name = "tlpAdmin";
            this.tlpAdmin.RowCount = 2;
            this.tlpAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.55276F));
            this.tlpAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.44724F));
            this.tlpAdmin.Size = new System.Drawing.Size(445, 434);
            this.tlpAdmin.TabIndex = 0;
            // 
            // lvAdmin
            // 
            this.lvAdmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCon0});
            this.lvAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAdmin.FullRowSelect = true;
            this.lvAdmin.GridLines = true;
            this.lvAdmin.HideSelection = false;
            this.lvAdmin.Location = new System.Drawing.Point(3, 48);
            this.lvAdmin.MultiSelect = false;
            this.lvAdmin.Name = "lvAdmin";
            this.lvAdmin.Size = new System.Drawing.Size(439, 383);
            this.lvAdmin.TabIndex = 0;
            this.lvAdmin.UseCompatibleStateImageBehavior = false;
            this.lvAdmin.View = System.Windows.Forms.View.Details;
            // 
            // chCon0
            // 
            this.chCon0.Text = "Usuario con privilegios administrativos";
            this.chCon0.Width = 308;
            // 
            // pnlAdmins
            // 
            this.pnlAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdmins.Location = new System.Drawing.Point(3, 3);
            this.pnlAdmins.Name = "pnlAdmins";
            this.pnlAdmins.Size = new System.Drawing.Size(439, 39);
            this.pnlAdmins.TabIndex = 1;
            // 
            // pnlNoAdministradores
            // 
            this.pnlNoAdministradores.BackColor = System.Drawing.Color.Transparent;
            this.pnlNoAdministradores.Controls.Add(this.tlpNoAdmin);
            this.pnlNoAdministradores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoAdministradores.Location = new System.Drawing.Point(3, 3);
            this.pnlNoAdministradores.Name = "pnlNoAdministradores";
            this.pnlNoAdministradores.Size = new System.Drawing.Size(445, 434);
            this.pnlNoAdministradores.TabIndex = 2;
            // 
            // tlpNoAdmin
            // 
            this.tlpNoAdmin.ColumnCount = 1;
            this.tlpNoAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNoAdmin.Controls.Add(this.lvNoAdmin, 0, 1);
            this.tlpNoAdmin.Controls.Add(this.pnlNoAdmin, 0, 0);
            this.tlpNoAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNoAdmin.Location = new System.Drawing.Point(0, 0);
            this.tlpNoAdmin.Name = "tlpNoAdmin";
            this.tlpNoAdmin.RowCount = 2;
            this.tlpNoAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.55276F));
            this.tlpNoAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.44724F));
            this.tlpNoAdmin.Size = new System.Drawing.Size(445, 434);
            this.tlpNoAdmin.TabIndex = 0;
            // 
            // lvNoAdmin
            // 
            this.lvNoAdmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNoAdmin0});
            this.lvNoAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNoAdmin.FullRowSelect = true;
            this.lvNoAdmin.GridLines = true;
            this.lvNoAdmin.HideSelection = false;
            this.lvNoAdmin.Location = new System.Drawing.Point(3, 48);
            this.lvNoAdmin.MultiSelect = false;
            this.lvNoAdmin.Name = "lvNoAdmin";
            this.lvNoAdmin.Size = new System.Drawing.Size(439, 383);
            this.lvNoAdmin.TabIndex = 0;
            this.lvNoAdmin.UseCompatibleStateImageBehavior = false;
            this.lvNoAdmin.View = System.Windows.Forms.View.Details;
            // 
            // chNoAdmin0
            // 
            this.chNoAdmin0.Text = "Usuario sin privilegios administrativos";
            this.chNoAdmin0.Width = 341;
            // 
            // pnlNoAdmin
            // 
            this.pnlNoAdmin.Controls.Add(this.btnBuscarUsername);
            this.pnlNoAdmin.Controls.Add(this.txtUsername);
            this.pnlNoAdmin.Controls.Add(this.label1);
            this.pnlNoAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoAdmin.Location = new System.Drawing.Point(3, 3);
            this.pnlNoAdmin.Name = "pnlNoAdmin";
            this.pnlNoAdmin.Size = new System.Drawing.Size(439, 39);
            this.pnlNoAdmin.TabIndex = 1;
            // 
            // btnBuscarUsername
            // 
            this.btnBuscarUsername.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscarUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsername.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUsername.Location = new System.Drawing.Point(319, 5);
            this.btnBuscarUsername.Name = "btnBuscarUsername";
            this.btnBuscarUsername.Size = new System.Drawing.Size(65, 25);
            this.btnBuscarUsername.TabIndex = 2;
            this.btnBuscarUsername.Text = "Buscar";
            this.btnBuscarUsername.UseVisualStyleBackColor = false;
            this.btnBuscarUsername.Click += new System.EventHandler(this.btnUsername_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(67, 8);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(246, 25);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnAniadir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 443);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 45);
            this.panel3.TabIndex = 3;
            // 
            // btnAniadir
            // 
            this.btnAniadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAniadir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadir.ForeColor = System.Drawing.Color.White;
            this.btnAniadir.Location = new System.Drawing.Point(277, 8);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(165, 27);
            this.btnAniadir.TabIndex = 0;
            this.btnAniadir.Text = "Añadir permiso";
            this.btnAniadir.UseVisualStyleBackColor = false;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // MantenimientoPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(902, 491);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimientoPermisos";
            this.Text = "Mantenimiento permisos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlAdministradores.ResumeLayout(false);
            this.tlpAdmin.ResumeLayout(false);
            this.pnlNoAdministradores.ResumeLayout(false);
            this.tlpNoAdmin.ResumeLayout(false);
            this.pnlNoAdmin.ResumeLayout(false);
            this.pnlNoAdmin.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAdministradores;
        private System.Windows.Forms.Panel pnlNoAdministradores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.TableLayoutPanel tlpNoAdmin;
        private System.Windows.Forms.TableLayoutPanel tlpAdmin;
        private System.Windows.Forms.ListView lvAdmin;
        private System.Windows.Forms.ColumnHeader chCon0;
        private System.Windows.Forms.ListView lvNoAdmin;
        private System.Windows.Forms.ColumnHeader chNoAdmin0;
        private System.Windows.Forms.Panel pnlAdmins;
        private System.Windows.Forms.Panel pnlNoAdmin;
        private System.Windows.Forms.Button btnBuscarUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
    }
}