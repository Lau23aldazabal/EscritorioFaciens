
namespace EscritorioFaciens
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.msFaciens = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDiseño = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEstilo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTela = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSuperAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPermisosUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBloqueosDesbloqueos = new System.Windows.Forms.ToolStripMenuItem();
            this.msFaciens.SuspendLayout();
            this.SuspendLayout();
            // 
            // msFaciens
            // 
            this.msFaciens.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.msFaciens.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msFaciens.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msFaciens.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msFaciens.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiSuperAdmin,
            this.tsmiMantenimiento,
            this.tsmiVentanas});
            this.msFaciens.Location = new System.Drawing.Point(0, 0);
            this.msFaciens.Name = "msFaciens";
            this.msFaciens.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.msFaciens.Size = new System.Drawing.Size(684, 30);
            this.msFaciens.TabIndex = 1;
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalir,
            this.cerrarSesiónToolStripMenuItem});
            this.tsmiArchivo.ForeColor = System.Drawing.Color.Black;
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(86, 28);
            this.tsmiArchivo.Text = "Archivo";
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiSalir.ForeColor = System.Drawing.Color.Black;
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(270, 34);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // tsmiMantenimiento
            // 
            this.tsmiMantenimiento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDiseño,
            this.tsmiEstilo,
            this.tsmiPrenda,
            this.tsmiTela});
            this.tsmiMantenimiento.ForeColor = System.Drawing.Color.Black;
            this.tsmiMantenimiento.Name = "tsmiMantenimiento";
            this.tsmiMantenimiento.Size = new System.Drawing.Size(146, 28);
            this.tsmiMantenimiento.Text = "Mantenimiento";
            // 
            // tsmiDiseño
            // 
            this.tsmiDiseño.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiDiseño.ForeColor = System.Drawing.Color.Black;
            this.tsmiDiseño.Name = "tsmiDiseño";
            this.tsmiDiseño.Size = new System.Drawing.Size(270, 34);
            this.tsmiDiseño.Text = "Diseño";
            this.tsmiDiseño.Click += new System.EventHandler(this.tsmiDiseño_Click);
            // 
            // tsmiEstilo
            // 
            this.tsmiEstilo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiEstilo.ForeColor = System.Drawing.Color.Black;
            this.tsmiEstilo.Name = "tsmiEstilo";
            this.tsmiEstilo.Size = new System.Drawing.Size(270, 34);
            this.tsmiEstilo.Text = "Estilo";
            this.tsmiEstilo.Click += new System.EventHandler(this.tsmiEstilo_Click);
            // 
            // tsmiPrenda
            // 
            this.tsmiPrenda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiPrenda.ForeColor = System.Drawing.Color.Black;
            this.tsmiPrenda.Name = "tsmiPrenda";
            this.tsmiPrenda.Size = new System.Drawing.Size(270, 34);
            this.tsmiPrenda.Text = "Prenda";
            this.tsmiPrenda.Click += new System.EventHandler(this.tsmiPrenda_Click);
            // 
            // tsmiTela
            // 
            this.tsmiTela.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiTela.ForeColor = System.Drawing.Color.Black;
            this.tsmiTela.Name = "tsmiTela";
            this.tsmiTela.Size = new System.Drawing.Size(270, 34);
            this.tsmiTela.Text = "Tela";
            this.tsmiTela.Click += new System.EventHandler(this.tsmiTela_Click);
            // 
            // tsmiVentanas
            // 
            this.tsmiVentanas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiVentanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCascada,
            this.tsmiHorizontal,
            this.tsmiVertical});
            this.tsmiVentanas.ForeColor = System.Drawing.Color.Black;
            this.tsmiVentanas.Name = "tsmiVentanas";
            this.tsmiVentanas.Size = new System.Drawing.Size(98, 28);
            this.tsmiVentanas.Text = "Ventanas";
            // 
            // tsmiCascada
            // 
            this.tsmiCascada.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiCascada.ForeColor = System.Drawing.Color.Black;
            this.tsmiCascada.Name = "tsmiCascada";
            this.tsmiCascada.Size = new System.Drawing.Size(192, 34);
            this.tsmiCascada.Text = "Cascada";
            this.tsmiCascada.Click += new System.EventHandler(this.tsmiCascada_Click);
            // 
            // tsmiHorizontal
            // 
            this.tsmiHorizontal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiHorizontal.ForeColor = System.Drawing.Color.Black;
            this.tsmiHorizontal.Name = "tsmiHorizontal";
            this.tsmiHorizontal.Size = new System.Drawing.Size(192, 34);
            this.tsmiHorizontal.Text = "Horizontal";
            this.tsmiHorizontal.Click += new System.EventHandler(this.tsmiHorizontal_Click);
            // 
            // tsmiVertical
            // 
            this.tsmiVertical.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiVertical.ForeColor = System.Drawing.Color.Black;
            this.tsmiVertical.Name = "tsmiVertical";
            this.tsmiVertical.Size = new System.Drawing.Size(192, 34);
            this.tsmiVertical.Text = "Vertical";
            this.tsmiVertical.Click += new System.EventHandler(this.tsmiVertical_Click);
            // 
            // tsmiSuperAdmin
            // 
            this.tsmiSuperAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPermisosUsuario,
            this.tsmiBloqueosDesbloqueos});
            this.tsmiSuperAdmin.Name = "tsmiSuperAdmin";
            this.tsmiSuperAdmin.Size = new System.Drawing.Size(145, 28);
            this.tsmiSuperAdmin.Text = "Administración";
            this.tsmiSuperAdmin.Visible = false;
            // 
            // tsmiPermisosUsuario
            // 
            this.tsmiPermisosUsuario.Name = "tsmiPermisosUsuario";
            this.tsmiPermisosUsuario.Size = new System.Drawing.Size(304, 34);
            this.tsmiPermisosUsuario.Text = "Permisos usuario";
            this.tsmiPermisosUsuario.Click += new System.EventHandler(this.tsmiPermisosUsuario_Click);
            // 
            // tsmiBloqueosDesbloqueos
            // 
            this.tsmiBloqueosDesbloqueos.Name = "tsmiBloqueosDesbloqueos";
            this.tsmiBloqueosDesbloqueos.Size = new System.Drawing.Size(304, 34);
            this.tsmiBloqueosDesbloqueos.Text = "Bloqueos / desbloqueos";
            this.tsmiBloqueosDesbloqueos.Click += new System.EventHandler(this.tsmiBloqueosDesbloqueos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 410);
            this.Controls.Add(this.msFaciens);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msFaciens;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.GradientActiveCaption;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.msFaciens.ResumeLayout(false);
            this.msFaciens.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msFaciens;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tsmiDiseño;
        private System.Windows.Forms.ToolStripMenuItem tsmiEstilo;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrenda;
        private System.Windows.Forms.ToolStripMenuItem tsmiTela;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmiVentanas;
        private System.Windows.Forms.ToolStripMenuItem tsmiCascada;
        private System.Windows.Forms.ToolStripMenuItem tsmiHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsmiVertical;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBloqueosDesbloqueos;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiSuperAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiPermisosUsuario;
    }
}