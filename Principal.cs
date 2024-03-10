namespace Caribe
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void menuHotelSalir_Click(object sender, EventArgs e)
        {
            OpcionesMenu("Salir");
        }

        private void OpcionesMenu(string opcion)
        {
            switch (opcion)
            {
                case "Reservas":
                    Form reservas = new Reservas();
                    reservas.ShowDialog();
                    break;
                case "Salir":
                    this.Close();
                    break;
            }
        }

        private void barraReservas_Click(object sender, EventArgs e)
        {
            OpcionesMenu("Reservas");
        }

        private void menuHotel_Reservas_Click(object sender, EventArgs e)
        {
            OpcionesMenu("Reservas");
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            string mensaje = "Aplicaci�n desarrollada para la pr�ctica del m�dulo Desarrollo de Interfaces de DAM por\n Jos� Luis Izquierdo Barber�n\nMarzo/Abril 2024";
            string titulo = "Acerca de...";
            MessageBoxButtons botones = MessageBoxButtons.OK;
            MessageBoxIcon icono = MessageBoxIcon.Information;
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
    }
}
