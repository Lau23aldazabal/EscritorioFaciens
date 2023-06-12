
namespace EscritorioFaciens.FormsUsuario
{
    partial class PrincipalUsuarioMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalUsuarioMDI));
            this.msPrincipalUsuario = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalirMDI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesionMDI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisenos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNovedades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMisProyectos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipalUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipalUsuario
            // 
            this.msPrincipalUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.msPrincipalUsuario.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msPrincipalUsuario.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msPrincipalUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiDisenos,
            this.tsmiVentanas});
            this.msPrincipalUsuario.Location = new System.Drawing.Point(0, 0);
            this.msPrincipalUsuario.Name = "msPrincipalUsuario";
            this.msPrincipalUsuario.Size = new System.Drawing.Size(800, 33);
            this.msPrincipalUsuario.TabIndex = 1;
            this.msPrincipalUsuario.Text = "menuStrip1";
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalirMDI,
            this.tsmiCerrarSesionMDI});
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(88, 29);
            this.tsmiArchivo.Text = "Archivo";
            // 
            // tsmiSalirMDI
            // 
            this.tsmiSalirMDI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiSalirMDI.Name = "tsmiSalirMDI";
            this.tsmiSalirMDI.Size = new System.Drawing.Size(270, 34);
            this.tsmiSalirMDI.Text = "Salir";
            this.tsmiSalirMDI.Click += new System.EventHandler(this.tsmiSalirMDI_Click);
            // 
            // tsmiCerrarSesionMDI
            // 
            this.tsmiCerrarSesionMDI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiCerrarSesionMDI.Name = "tsmiCerrarSesionMDI";
            this.tsmiCerrarSesionMDI.Size = new System.Drawing.Size(270, 34);
            this.tsmiCerrarSesionMDI.Text = "Cerrar sesión";
            this.tsmiCerrarSesionMDI.Click += new System.EventHandler(this.tsmiCerrarSesionMDI_Click);
            // 
            // tsmiDisenos
            // 
            this.tsmiDisenos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiDisenos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNovedades,
            this.tsmiMisProyectos});
            this.tsmiDisenos.Name = "tsmiDisenos";
            this.tsmiDisenos.Size = new System.Drawing.Size(91, 29);
            this.tsmiDisenos.Text = "Diseños";
            // 
            // tsmiNovedades
            // 
            this.tsmiNovedades.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiNovedades.Name = "tsmiNovedades";
            this.tsmiNovedades.Size = new System.Drawing.Size(270, 34);
            this.tsmiNovedades.Text = "Diseños";
            this.tsmiNovedades.Click += new System.EventHandler(this.tsmiNovedades_Click);
            // 
            // tsmiMisProyectos
            // 
            this.tsmiMisProyectos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiMisProyectos.Name = "tsmiMisProyectos";
            this.tsmiMisProyectos.Size = new System.Drawing.Size(270, 34);
            this.tsmiMisProyectos.Text = "Mis proyectos";
            this.tsmiMisProyectos.Click += new System.EventHandler(this.tsmiMisProyectos_Click);
            // 
            // tsmiVentanas
            // 
            this.tsmiVentanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadaToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.tsmiVentanas.Name = "tsmiVentanas";
            this.tsmiVentanas.Size = new System.Drawing.Size(99, 29);
            this.tsmiVentanas.Text = "Ventanas";
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // PrincipalUsuarioMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msPrincipalUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipalUsuario;
            this.Name = "PrincipalUsuarioMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faciens";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalUsuarioMDI_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrincipalUsuarioMDI_FormClosed);
            this.msPrincipalUsuario.ResumeLayout(false);
            this.msPrincipalUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipalUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalirMDI;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesionMDI;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisenos;
        private System.Windows.Forms.ToolStripMenuItem tsmiNovedades;
        private System.Windows.Forms.ToolStripMenuItem tsmiMisProyectos;
        private System.Windows.Forms.ToolStripMenuItem tsmiVentanas;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
    }
}