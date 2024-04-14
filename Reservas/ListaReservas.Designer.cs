namespace Caribe
{
    partial class ListaReservas
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
            barraReservas = new ToolStrip();
            btnSalir = new ToolStripButton();
            toolbtnAnadir = new ToolStripButton();
            toolBtnEditar = new ToolStripButton();
            toolBtnBorrar = new ToolStripButton();
            panel1 = new Panel();
            tablaReservas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Contacto = new DataGridViewTextBoxColumn();
            Teléfono = new DataGridViewTextBoxColumn();
            barraReservas.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaReservas).BeginInit();
            SuspendLayout();
            // 
            // barraReservas
            // 
            barraReservas.Items.AddRange(new ToolStripItem[] { btnSalir, toolbtnAnadir, toolBtnEditar, toolBtnBorrar });
            barraReservas.Location = new Point(0, 0);
            barraReservas.Name = "barraReservas";
            barraReservas.Size = new Size(1165, 38);
            barraReservas.TabIndex = 0;
            barraReservas.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            btnSalir.Image = Properties.Resources.salir;
            btnSalir.ImageTransparentColor = Color.Magenta;
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(33, 35);
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.ToolTipText = "Pulse para abandonar (Alt-F4)";
            btnSalir.Click += btnSalir_Click;
            // 
            // toolbtnAnadir
            // 
            toolbtnAnadir.Image = Properties.Resources.anadir;
            toolbtnAnadir.ImageTransparentColor = Color.Magenta;
            toolbtnAnadir.Name = "toolbtnAnadir";
            toolbtnAnadir.Size = new Size(45, 35);
            toolbtnAnadir.Text = "Nueva";
            toolbtnAnadir.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbtnAnadir.ToolTipText = "Pulse para añadir reserva (Ins)";
            toolbtnAnadir.Click += toolbtnAnadir_Click;
            // 
            // toolBtnEditar
            // 
            toolBtnEditar.Image = Properties.Resources.editar;
            toolBtnEditar.ImageTransparentColor = Color.Magenta;
            toolBtnEditar.Name = "toolBtnEditar";
            toolBtnEditar.Size = new Size(41, 35);
            toolBtnEditar.Text = "Editar";
            toolBtnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            toolBtnEditar.ToolTipText = "Pulse para editar reserva (INTRO)";
            toolBtnEditar.Click += toolBtnEditar_Click;
            // 
            // toolBtnBorrar
            // 
            toolBtnBorrar.Image = Properties.Resources.borrar;
            toolBtnBorrar.ImageTransparentColor = Color.Magenta;
            toolBtnBorrar.Name = "toolBtnBorrar";
            toolBtnBorrar.Size = new Size(43, 35);
            toolBtnBorrar.Text = "Borrar";
            toolBtnBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            toolBtnBorrar.ToolTipText = "Pulse para borrar reserva (Supr)";
            toolBtnBorrar.Click += toolBtnBorrar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tablaReservas);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(1165, 526);
            panel1.TabIndex = 1;
            // 
            // tablaReservas
            // 
            tablaReservas.AllowUserToAddRows = false;
            tablaReservas.AllowUserToDeleteRows = false;
            tablaReservas.AllowUserToOrderColumns = true;
            tablaReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaReservas.Columns.AddRange(new DataGridViewColumn[] { Id, Fecha, Contacto, Teléfono });
            tablaReservas.Dock = DockStyle.Fill;
            tablaReservas.Location = new Point(0, 0);
            tablaReservas.MultiSelect = false;
            tablaReservas.Name = "tablaReservas";
            tablaReservas.ReadOnly = true;
            tablaReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaReservas.Size = new Size(1165, 526);
            tablaReservas.TabIndex = 0;
            tablaReservas.DoubleClick += toolBtnEditar_Click;
            tablaReservas.KeyDown += tablaReservas_KeyDown;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Contacto
            // 
            Contacto.HeaderText = "Contacto";
            Contacto.Name = "Contacto";
            Contacto.ReadOnly = true;
            // 
            // Teléfono
            // 
            Teléfono.HeaderText = "Teléfono";
            Teléfono.Name = "Teléfono";
            Teléfono.ReadOnly = true;
            // 
            // ListaReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 564);
            Controls.Add(panel1);
            Controls.Add(barraReservas);
            Name = "ListaReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Reservas";
            barraReservas.ResumeLayout(false);
            barraReservas.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip barraReservas;
        private ToolStripButton toolBtnBorrar;
        private ToolStripButton btnSalir;
        private ToolStripButton toolbtnAnadir;
        private ToolStripButton toolBtnEditar;
        private Panel panel1;
        private DataGridView tablaReservas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Contacto;
        private DataGridViewTextBoxColumn Teléfono;
    }
}