namespace Caribe
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            BarraMenu = new MenuStrip();
            menuHotel = new ToolStripMenuItem();
            menuHotel_Reservas = new ToolStripMenuItem();
            menuHotelSalir = new ToolStripMenuItem();
            menuAcercaDe = new ToolStripMenuItem();
            barra = new ToolStrip();
            barraReservas = new ToolStripButton();
            BarraMenu.SuspendLayout();
            barra.SuspendLayout();
            SuspendLayout();
            // 
            // BarraMenu
            // 
            BarraMenu.Items.AddRange(new ToolStripItem[] { menuHotel, menuAcercaDe });
            BarraMenu.Location = new Point(0, 0);
            BarraMenu.Name = "BarraMenu";
            BarraMenu.Size = new Size(800, 24);
            BarraMenu.TabIndex = 0;
            BarraMenu.Text = "menuStrip1";
            // 
            // menuHotel
            // 
            menuHotel.DropDownItems.AddRange(new ToolStripItem[] { menuHotel_Reservas, menuHotelSalir });
            menuHotel.Name = "menuHotel";
            menuHotel.Size = new Size(48, 20);
            menuHotel.Text = "Hotel";
            // 
            // menuHotel_Reservas
            // 
            menuHotel_Reservas.Image = Properties.Resources.hotel1;
            menuHotel_Reservas.Name = "menuHotel_Reservas";
            menuHotel_Reservas.ShortcutKeys = Keys.Control | Keys.R;
            menuHotel_Reservas.Size = new Size(223, 22);
            menuHotel_Reservas.Text = "Reservas";
            menuHotel_Reservas.Click += menuHotel_Reservas_Click;
            // 
            // menuHotelSalir
            // 
            menuHotelSalir.Image = (Image)resources.GetObject("menuHotelSalir.Image");
            menuHotelSalir.Name = "menuHotelSalir";
            menuHotelSalir.ShortcutKeys = Keys.Control | Keys.S;
            menuHotelSalir.Size = new Size(223, 22);
            menuHotelSalir.Text = "Salir de la Aplicación";
            menuHotelSalir.ToolTipText = "Pulse para abandonar la aplicación";
            menuHotelSalir.Click += menuHotelSalir_Click;
            // 
            // menuAcercaDe
            // 
            menuAcercaDe.Name = "menuAcercaDe";
            menuAcercaDe.ShortcutKeys = Keys.Control | Keys.A;
            menuAcercaDe.Size = new Size(80, 20);
            menuAcercaDe.Text = "Acerca de...";
            menuAcercaDe.ToolTipText = "Muesra información de la aplicación";
            menuAcercaDe.Click += menuAcercaDe_Click;
            // 
            // barra
            // 
            barra.Items.AddRange(new ToolStripItem[] { barraReservas });
            barra.Location = new Point(0, 24);
            barra.Name = "barra";
            barra.Size = new Size(800, 38);
            barra.TabIndex = 1;
            barra.Text = "toolStrip1";
            // 
            // barraReservas
            // 
            barraReservas.Image = Properties.Resources.hotel;
            barraReservas.ImageTransparentColor = Color.Magenta;
            barraReservas.Name = "barraReservas";
            barraReservas.Size = new Size(56, 35);
            barraReservas.Text = "Reservas";
            barraReservas.TextImageRelation = TextImageRelation.ImageAboveText;
            barraReservas.Click += barraReservas_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(barra);
            Controls.Add(BarraMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = BarraMenu;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Caribe";
            WindowState = FormWindowState.Maximized;
            BarraMenu.ResumeLayout(false);
            BarraMenu.PerformLayout();
            barra.ResumeLayout(false);
            barra.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip BarraMenu;
        private ToolStripMenuItem menuHotel;
        private ToolStripMenuItem menuHotel_Reservas;
        private ToolStripMenuItem menuHotelSalir;
        private ToolStripMenuItem menuAcercaDe;
        private ToolStrip barra;
        private ToolStripButton barraReservas;
    }
}
