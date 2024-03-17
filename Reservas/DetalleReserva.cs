using Caribe.Reservas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caribe.Reservas
{
    public partial class DetalleReserva : Form
    {

        private int modo; // 1 - Añadir   2 - Editar  3 - Borrar
        private Reserva reserva;

        public DetalleReserva( Reserva reserva, int modo )
        {
            InitializeComponent();

            txtFecha.Value = reserva.Fecha;
            txtContacto.Text = reserva.Contacto;
            txtTelefono.Text = reserva.Telefono;    

        }
    }
}
