
namespace EscritorioFaciens
{
    partial class MantenimientoDiseño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoDiseño));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvDiseno = new System.Windows.Forms.ListView();
            this.ch0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmListaDiseno = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAniadir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.clbPrenda = new System.Windows.Forms.CheckedListBox();
            this.clbEstilo = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clbDificultad = new System.Windows.Forms.CheckedListBox();
            this.clbTela = new System.Windows.Forms.CheckedListBox();
            this.tlpNombre = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombreDiseno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.cmListaDiseno.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.tlpNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lvDiseno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.58915F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.41085F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1148, 516);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lvDiseno
            // 
            this.lvDiseno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch0,
            this.ch1,
            this.ch2,
            this.ch3,
            this.ch4,
            this.ch5,
            this.ch6,
            this.ch7,
            this.ch8,
            this.ch9,
            this.ch10});
            this.lvDiseno.ContextMenuStrip = this.cmListaDiseno;
            this.lvDiseno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDiseno.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.lvDiseno.FullRowSelect = true;
            this.lvDiseno.GridLines = true;
            this.lvDiseno.HideSelection = false;
            this.lvDiseno.Location = new System.Drawing.Point(10, 165);
            this.lvDiseno.Margin = new System.Windows.Forms.Padding(10, 2, 10, 10);
            this.lvDiseno.MultiSelect = false;
            this.lvDiseno.Name = "lvDiseno";
            this.lvDiseno.Size = new System.Drawing.Size(1128, 341);
            this.lvDiseno.TabIndex = 1;
            this.lvDiseno.UseCompatibleStateImageBehavior = false;
            this.lvDiseno.View = System.Windows.Forms.View.Details;
            this.lvDiseno.DoubleClick += new System.EventHandler(this.lvDiseno_DoubleClick);
            // 
            // ch0
            // 
            this.ch0.Text = "Nombre";
            this.ch0.Width = 160;
            // 
            // ch1
            // 
            this.ch1.Text = "Descripción";
            this.ch1.Width = 160;
            // 
            // ch2
            // 
            this.ch2.Text = "Materiales";
            this.ch2.Width = 142;
            // 
            // ch3
            // 
            this.ch3.Text = "Dificultad";
            // 
            // ch4
            // 
            this.ch4.Text = "Estilo";
            // 
            // ch5
            // 
            this.ch5.Text = "Prenda";
            // 
            // ch6
            // 
            this.ch6.Text = "Tela";
            // 
            // ch7
            // 
            this.ch7.Text = "Usuario creación";
            this.ch7.Width = 100;
            // 
            // ch8
            // 
            this.ch8.Text = "Fecha creación";
            this.ch8.Width = 100;
            // 
            // ch9
            // 
            this.ch9.Text = "Usuario modificación";
            this.ch9.Width = 100;
            // 
            // ch10
            // 
            this.ch10.Text = "Fecha modificación";
            this.ch10.Width = 100;
            // 
            // cmListaDiseno
            // 
            this.cmListaDiseno.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmListaDiseno.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAniadir,
            this.tsmiModificar,
            this.tsmiEliminar});
            this.cmListaDiseno.Name = "cmListaDiseno";
            this.cmListaDiseno.Size = new System.Drawing.Size(241, 121);
            this.cmListaDiseno.Opening += new System.ComponentModel.CancelEventHandler(this.cmListaDiseno_Opening);
            // 
            // tsmiAniadir
            // 
            this.tsmiAniadir.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.tsmiAniadir.Name = "tsmiAniadir";
            this.tsmiAniadir.Size = new System.Drawing.Size(240, 28);
            this.tsmiAniadir.Text = "Añadir diseño";
            this.tsmiAniadir.Click += new System.EventHandler(this.tsmiAniadir_Click);
            // 
            // tsmiModificar
            // 
            this.tsmiModificar.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.tsmiModificar.Name = "tsmiModificar";
            this.tsmiModificar.Size = new System.Drawing.Size(240, 28);
            this.tsmiModificar.Text = "Modificar diseño";
            this.tsmiModificar.Click += new System.EventHandler(this.tsmiModificar_Click);
            // 
            // tsmiEliminar
            // 
            this.tsmiEliminar.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.tsmiEliminar.Name = "tsmiEliminar";
            this.tsmiEliminar.Size = new System.Drawing.Size(240, 28);
            this.tsmiEliminar.Text = "Eliminar diseño";
            this.tsmiEliminar.Click += new System.EventHandler(this.tsmiEliminar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tlpFiltros, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tlpNombre, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.21019F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.78981F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1142, 157);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.ColumnCount = 10;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.602113F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.330986F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.042253F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.2993F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.369718F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.274648F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.330986F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.14789F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.97535F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.413926F));
            this.tlpFiltros.Controls.Add(this.clbPrenda, 3, 0);
            this.tlpFiltros.Controls.Add(this.clbEstilo, 1, 0);
            this.tlpFiltros.Controls.Add(this.label6, 2, 0);
            this.tlpFiltros.Controls.Add(this.label4, 0, 0);
            this.tlpFiltros.Controls.Add(this.label5, 4, 0);
            this.tlpFiltros.Controls.Add(this.label7, 6, 0);
            this.tlpFiltros.Controls.Add(this.clbDificultad, 7, 0);
            this.tlpFiltros.Controls.Add(this.clbTela, 5, 0);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.tlpFiltros.ForeColor = System.Drawing.Color.Black;
            this.tlpFiltros.Location = new System.Drawing.Point(0, 51);
            this.tlpFiltros.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 1;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Size = new System.Drawing.Size(1139, 103);
            this.tlpFiltros.TabIndex = 3;
            // 
            // clbPrenda
            // 
            this.clbPrenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbPrenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbPrenda.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.clbPrenda.FormattingEnabled = true;
            this.clbPrenda.Location = new System.Drawing.Point(264, 10);
            this.clbPrenda.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.clbPrenda.Name = "clbPrenda";
            this.clbPrenda.Size = new System.Drawing.Size(111, 58);
            this.clbPrenda.TabIndex = 9;
            // 
            // clbEstilo
            // 
            this.clbEstilo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbEstilo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbEstilo.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.clbEstilo.FormattingEnabled = true;
            this.clbEstilo.Location = new System.Drawing.Point(78, 10);
            this.clbEstilo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.clbEstilo.Name = "clbEstilo";
            this.clbEstilo.Size = new System.Drawing.Size(100, 58);
            this.clbEstilo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(184, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Prenda:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estilo:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(387, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tela:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(541, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dificultad:";
            // 
            // clbDificultad
            // 
            this.clbDificultad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbDificultad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbDificultad.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.clbDificultad.FormattingEnabled = true;
            this.clbDificultad.Location = new System.Drawing.Point(642, 10);
            this.clbDificultad.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.clbDificultad.Name = "clbDificultad";
            this.clbDificultad.Size = new System.Drawing.Size(132, 29);
            this.clbDificultad.TabIndex = 6;
            // 
            // clbTela
            // 
            this.clbTela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbTela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbTela.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.clbTela.FormattingEnabled = true;
            this.clbTela.Location = new System.Drawing.Point(442, 10);
            this.clbTela.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.clbTela.Name = "clbTela";
            this.clbTela.Size = new System.Drawing.Size(88, 58);
            this.clbTela.TabIndex = 7;
            // 
            // tlpNombre
            // 
            this.tlpNombre.ColumnCount = 7;
            this.tlpNombre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.426056F));
            this.tlpNombre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.6338F));
            this.tlpNombre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.96272F));
            this.tlpNombre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.63857F));
            this.tlpNombre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.184765F));
            this.tlpNombre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.779632F));
            this.tlpNombre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.394205F));
            this.tlpNombre.Controls.Add(this.txtNombreDiseno, 1, 0);
            this.tlpNombre.Controls.Add(this.label8, 0, 0);
            this.tlpNombre.Controls.Add(this.btnBuscar, 4, 0);
            this.tlpNombre.Controls.Add(this.btnLimpiar, 5, 0);
            this.tlpNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNombre.ForeColor = System.Drawing.Color.Black;
            this.tlpNombre.Location = new System.Drawing.Point(0, 3);
            this.tlpNombre.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tlpNombre.Name = "tlpNombre";
            this.tlpNombre.RowCount = 1;
            this.tlpNombre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNombre.Size = new System.Drawing.Size(1139, 42);
            this.tlpNombre.TabIndex = 2;
            // 
            // txtNombreDiseno
            // 
            this.txtNombreDiseno.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNombreDiseno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreDiseno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreDiseno.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.txtNombreDiseno.Location = new System.Drawing.Point(75, 13);
            this.txtNombreDiseno.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.txtNombreDiseno.Name = "txtNombreDiseno";
            this.txtNombreDiseno.Size = new System.Drawing.Size(339, 25);
            this.txtNombreDiseno.TabIndex = 0;
            this.txtNombreDiseno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreDiseno_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(7, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(843, 8);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_ClickAsync);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(935, 8);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // MantenimientoDiseño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1148, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimientoDiseño";
            this.Text = "Mantenimiento diseños";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cmListaDiseno.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tlpFiltros.ResumeLayout(false);
            this.tlpFiltros.PerformLayout();
            this.tlpNombre.ResumeLayout(false);
            this.tlpNombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip cmListaDiseno;
        private System.Windows.Forms.ToolStripMenuItem tsmiAniadir;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminar;
        private System.Windows.Forms.ListView lvDiseno;
        private System.Windows.Forms.ColumnHeader ch0;
        private System.Windows.Forms.ColumnHeader ch1;
        private System.Windows.Forms.ColumnHeader ch2;
        private System.Windows.Forms.ColumnHeader ch3;
        private System.Windows.Forms.ColumnHeader ch4;
        private System.Windows.Forms.ColumnHeader ch5;
        private System.Windows.Forms.ColumnHeader ch6;
        private System.Windows.Forms.ColumnHeader ch7;
        private System.Windows.Forms.ColumnHeader ch8;
        private System.Windows.Forms.ColumnHeader ch9;
        private System.Windows.Forms.ColumnHeader ch10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tlpNombre;
        private System.Windows.Forms.TextBox txtNombreDiseno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.CheckedListBox clbPrenda;
        private System.Windows.Forms.CheckedListBox clbEstilo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox clbDificultad;
        private System.Windows.Forms.CheckedListBox clbTela;
    }
}