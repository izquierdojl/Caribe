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
        public ListaReservas()
        {
            InitializeComponent();
        }

        private void toolbtnAnadir_Click(object sender, EventArgs e)
        {

            Reserva reserva = new Reserva();
            reserva.Fecha = DateTime.Now.AddDays(1);
            reserva.Contacto = "José Luis Izquierdo";
            DetalleReserva detalleReserva = new DetalleReserva( reserva , 1 );
            detalleReserva.ShowDialog();
        }
    }
}
