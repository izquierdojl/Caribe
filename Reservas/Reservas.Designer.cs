namespace Caribe
{
    partial class Reservas
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
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            btnEditar = new ToolStripButton();
            panel1 = new Panel();
            tablaReservas = new DataGridView();
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
            barraReservas.Items.AddRange(new ToolStripItem[] { btnSalir, toolStripButton1, toolStripButton2, btnEditar });
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
            btnSalir.ToolTipText = "Pulse para abandonar";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.anadir;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(45, 35);
            toolStripButton1.Text = "Nueva";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.ToolTipText = "Pulse para añadir reserva";
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.editar;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(41, 35);
            toolStripButton2.Text = "Editar";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton2.ToolTipText = "Pulse para añadir reserva";
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.borrar;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(43, 35);
            btnEditar.Text = "Borrar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.ToolTipText = "Pulse para borrar reserva";
            // 
            // panel1
            // 
            panel1.Controls.Add(tablaReservas);
            panel1.Location = new Point(0, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(1165, 525);
            panel1.TabIndex = 1;
            // 
            // tablaReservas
            // 
            tablaReservas.AllowUserToAddRows = false;
            tablaReservas.AllowUserToDeleteRows = false;
            tablaReservas.AllowUserToOrderColumns = true;
            tablaReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaReservas.Columns.AddRange(new DataGridViewColumn[] { Fecha, Contacto, Teléfono });
            tablaReservas.Dock = DockStyle.Fill;
            tablaReservas.Location = new Point(0, 0);
            tablaReservas.MultiSelect = false;
            tablaReservas.Name = "tablaReservas";
            tablaReservas.ReadOnly = true;
            tablaReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaReservas.Size = new Size(1165, 525);
            tablaReservas.TabIndex = 0;
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
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 564);
            Controls.Add(panel1);
            Controls.Add(barraReservas);
            Name = "Reservas";
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
        private ToolStripButton btnEditar;
        private ToolStripButton btnSalir;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private Panel panel1;
        private DataGridView tablaReservas;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Contacto;
        private DataGridViewTextBoxColumn Teléfono;
    }
}