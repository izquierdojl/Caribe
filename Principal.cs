using Caribe.Reservas.Modelo;
using System.Collections;

namespace Caribe
{
    public partial class Principal : Form
    {

        ArrayList arrayReservas;
        AlmacenReservas dbReservas;

        public Principal()
        {
            InitializeComponent();
            arrayReservas = new ArrayList(); // almaceno un array list
            dbReservas = new AlmacenReservas(arrayReservas); // creo un objeto almacén para gesionarlo
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
                    Form listaReservas = new ListaReservas(dbReservas);   
                    listaReservas.ShowDialog();
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
            string mensaje = "Aplicación desarrollada para la práctica del módulo Desarrollo de Interfaces de DAM por\n José Luis Izquierdo Barberán\nMarzo/Abril 2024";
            string titulo = "Acerca de...";
            MessageBoxButtons botones = MessageBoxButtons.OK;
            MessageBoxIcon icono = MessageBoxIcon.Information;
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
    }
}
