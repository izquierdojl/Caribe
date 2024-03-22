using Caribe.Reservas;
using Caribe.Reservas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caribe
{
    public partial class ListaReservas : Form
    {

        private AlmacenReservas dbReservas;

        public ListaReservas(AlmacenReservas dbReservas)
        {
            InitializeComponent();
            this.dbReservas = dbReservas;
            refrescarTabla();
        }

        private void toolbtnAnadir_Click(object sender, EventArgs e)
        {

            Reserva reserva = new Reserva();
            reserva.Fecha = DateTime.Now.AddDays(1);
            reserva.Contacto = "José Luis Izquierdo";
            DetalleReserva detalleReserva = new DetalleReserva( dbReservas , 0 , 1 , this );
            detalleReserva.ShowDialog();
        }

        public void refrescarTabla()
        {
            this.tablaReservas.Rows.Clear();
            foreach (Reserva reserva in dbReservas.ListaReservas)
            {
                tablaReservas.Rows.Add(reserva.Contacto, reserva.Fecha, reserva.Telefono);
            }

        }

    }
}
