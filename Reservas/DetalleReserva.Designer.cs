namespace Caribe.Reservas
{
    partial class DetalleReserva
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
            panelPrincipal = new Panel();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtContacto = new TextBox();
            label2 = new Label();
            txtFecha = new DateTimePicker();
            label1 = new Label();
            panelBotones = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panelPrincipal.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(txtTelefono);
            panelPrincipal.Controls.Add(label3);
            panelPrincipal.Controls.Add(txtContacto);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(txtFecha);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(682, 404);
            panelPrincipal.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(150, 94);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 23);
            txtTelefono.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 97);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 4;
            label3.Text = "Teléfono de Contacto:";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(149, 54);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(380, 23);
            txtContacto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre de Contacto:";
            // 
            // txtFecha
            // 
            txtFecha.Format = DateTimePickerFormat.Short;
            txtFecha.Location = new Point(150, 15);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(150, 23);
            txtFecha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha de Reserva:";
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnCancelar);
            panelBotones.Controls.Add(btnGuardar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 404);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(682, 69);
            panelBotones.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(575, 19);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 38);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = true;
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.Location = new Point(465, 19);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(91, 38);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // DetalleReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 473);
            Controls.Add(panelPrincipal);
            Controls.Add(panelBotones);
            Name = "DetalleReserva";
            Text = "Detalle de Reserva";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Panel panelBotones;
        private Button btnCancelar;
        private Button btnGuardar;
        private DateTimePicker txtFecha;
        private Label label1;
        private TextBox txtContacto;
        private Label label2;
        private TextBox txtTelefono;
        private Label label3;
    }
}