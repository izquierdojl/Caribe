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
            groupRestaurante = new GroupBox();
            radioResNoPrecisa = new RadioButton();
            radioResChef = new RadioButton();
            radioResCarta = new RadioButton();
            radioResBufe = new RadioButton();
            checkRequiereHabitaciones = new CheckBox();
            numericJornadas = new NumericUpDown();
            labelJornadas = new Label();
            numericPersonas = new NumericUpDown();
            label5 = new Label();
            comboTipo = new ComboBox();
            label4 = new Label();
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
            groupRestaurante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericJornadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPersonas).BeginInit();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(groupRestaurante);
            panelPrincipal.Controls.Add(checkRequiereHabitaciones);
            panelPrincipal.Controls.Add(numericJornadas);
            panelPrincipal.Controls.Add(labelJornadas);
            panelPrincipal.Controls.Add(numericPersonas);
            panelPrincipal.Controls.Add(label5);
            panelPrincipal.Controls.Add(comboTipo);
            panelPrincipal.Controls.Add(label4);
            panelPrincipal.Controls.Add(txtTelefono);
            panelPrincipal.Controls.Add(label3);
            panelPrincipal.Controls.Add(txtContacto);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(txtFecha);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(682, 315);
            panelPrincipal.TabIndex = 0;
            // 
            // groupRestaurante
            // 
            groupRestaurante.Controls.Add(radioResNoPrecisa);
            groupRestaurante.Controls.Add(radioResChef);
            groupRestaurante.Controls.Add(radioResCarta);
            groupRestaurante.Controls.Add(radioResBufe);
            groupRestaurante.Font = new Font("Verdana", 9F, FontStyle.Italic);
            groupRestaurante.Location = new Point(13, 214);
            groupRestaurante.Name = "groupRestaurante";
            groupRestaurante.Size = new Size(351, 87);
            groupRestaurante.TabIndex = 14;
            groupRestaurante.TabStop = false;
            groupRestaurante.Text = "Servicio de Restaurante";
            // 
            // radioResNoPrecisa
            // 
            radioResNoPrecisa.AutoSize = true;
            radioResNoPrecisa.Location = new Point(254, 39);
            radioResNoPrecisa.Name = "radioResNoPrecisa";
            radioResNoPrecisa.Size = new Size(87, 18);
            radioResNoPrecisa.TabIndex = 16;
            radioResNoPrecisa.TabStop = true;
            radioResNoPrecisa.Text = "No Precisa";
            radioResNoPrecisa.UseVisualStyleBackColor = true;
            // 
            // radioResChef
            // 
            radioResChef.AutoSize = true;
            radioResChef.Location = new Point(175, 39);
            radioResChef.Name = "radioResChef";
            radioResChef.Size = new Size(52, 18);
            radioResChef.TabIndex = 15;
            radioResChef.TabStop = true;
            radioResChef.Text = "Chef";
            radioResChef.UseVisualStyleBackColor = true;
            // 
            // radioResCarta
            // 
            radioResCarta.AutoSize = true;
            radioResCarta.Location = new Point(93, 39);
            radioResCarta.Name = "radioResCarta";
            radioResCarta.Size = new Size(57, 18);
            radioResCarta.TabIndex = 14;
            radioResCarta.TabStop = true;
            radioResCarta.Text = "Carta";
            radioResCarta.UseVisualStyleBackColor = true;
            // 
            // radioResBufe
            // 
            radioResBufe.AutoSize = true;
            radioResBufe.Location = new Point(15, 39);
            radioResBufe.Name = "radioResBufe";
            radioResBufe.Size = new Size(52, 18);
            radioResBufe.TabIndex = 13;
            radioResBufe.TabStop = true;
            radioResBufe.Text = "Bufé";
            radioResBufe.UseVisualStyleBackColor = true;
            // 
            // checkRequiereHabitaciones
            // 
            checkRequiereHabitaciones.AutoSize = true;
            checkRequiereHabitaciones.Font = new Font("Verdana", 9F, FontStyle.Italic);
            checkRequiereHabitaciones.Location = new Point(402, 181);
            checkRequiereHabitaciones.Name = "checkRequiereHabitaciones";
            checkRequiereHabitaciones.Size = new Size(158, 18);
            checkRequiereHabitaciones.TabIndex = 12;
            checkRequiereHabitaciones.Text = "Requiere Habitaciones";
            checkRequiereHabitaciones.UseVisualStyleBackColor = true;
            // 
            // numericJornadas
            // 
            numericJornadas.Location = new Point(315, 180);
            numericJornadas.Name = "numericJornadas";
            numericJornadas.Size = new Size(66, 23);
            numericJornadas.TabIndex = 11;
            numericJornadas.TextAlign = HorizontalAlignment.Right;
            // 
            // labelJornadas
            // 
            labelJornadas.AutoSize = true;
            labelJornadas.Font = new Font("Verdana", 9F, FontStyle.Italic);
            labelJornadas.Location = new Point(244, 182);
            labelJornadas.Name = "labelJornadas";
            labelJornadas.Size = new Size(65, 14);
            labelJornadas.TabIndex = 10;
            labelJornadas.Text = "Jornadas:";
            // 
            // numericPersonas
            // 
            numericPersonas.Location = new Point(151, 179);
            numericPersonas.Name = "numericPersonas";
            numericPersonas.Size = new Size(70, 23);
            numericPersonas.TabIndex = 9;
            numericPersonas.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Italic);
            label5.Location = new Point(12, 181);
            label5.Name = "label5";
            label5.Size = new Size(137, 14);
            label5.TabIndex = 8;
            label5.Text = "Número de Personas:";
            // 
            // comboTipo
            // 
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.FormattingEnabled = true;
            comboTipo.Items.AddRange(new object[] { "Banquete", "Jornada", "Congreso" });
            comboTipo.Location = new Point(151, 138);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(189, 23);
            comboTipo.TabIndex = 7;
            comboTipo.SelectedIndexChanged += comboTipo_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Italic);
            label4.Location = new Point(13, 141);
            label4.Name = "label4";
            label4.Size = new Size(106, 14);
            label4.TabIndex = 6;
            label4.Text = "Tipo de Reserva:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(150, 97);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 23);
            txtTelefono.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Italic);
            label3.Location = new Point(13, 101);
            label3.Name = "label3";
            label3.Size = new Size(137, 14);
            label3.TabIndex = 4;
            label3.Text = "Teléfono de Contacto:";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(149, 56);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(380, 23);
            txtContacto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Italic);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(134, 14);
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
            label1.Font = new Font("Verdana", 9F, FontStyle.Italic);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(117, 14);
            label1.TabIndex = 0;
            label1.Text = "Fecha de Reserva:";
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnCancelar);
            panelBotones.Controls.Add(btnGuardar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 315);
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
            ClientSize = new Size(682, 384);
            Controls.Add(panelPrincipal);
            Controls.Add(panelBotones);
            Name = "DetalleReserva";
            Text = "Detalle de Reserva";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            groupRestaurante.ResumeLayout(false);
            groupRestaurante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericJornadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPersonas).EndInit();
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
        private ComboBox comboTipo;
        private Label label4;
        private CheckBox checkRequiereHabitaciones;
        private NumericUpDown numericJornadas;
        private Label labelJornadas;
        private NumericUpDown numericPersonas;
        private Label label5;
        private GroupBox groupRestaurante;
        private RadioButton radioResNoPrecisa;
        private RadioButton radioResChef;
        private RadioButton radioResCarta;
        private RadioButton radioResBufe;
    }
}