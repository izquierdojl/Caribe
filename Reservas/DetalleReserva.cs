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
        private AlmacenReservas dbReservas;
        private ListaReservas formListaReservas;
        private Reserva reserva;

        public DetalleReserva(AlmacenReservas dbReservas, int id, int modo, ListaReservas formListaReservas )
        {
            InitializeComponent();

            this.dbReservas = dbReservas;
            this.formListaReservas = formListaReservas;

            if( modo == 1 )
            {
                this.reserva = new Reserva();
                txtFecha.Value = DateTime.Now;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            reserva.Fecha = txtFecha.Value;
            reserva.Contacto = txtContacto.Text;
            reserva.Telefono = txtTelefono.Text;
            dbReservas.nueva(reserva);
            formListaReservas.refrescarTabla();
            this.Close();
        }
    }
}
