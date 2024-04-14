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

        private int modo; // 1 - Añadir   2 - Editar  
        private AlmacenReservas dbReservas;
        private ListaReservas formListaReservas;
        private Reserva reserva;

        public DetalleReserva(AlmacenReservas dbReservas, int id, int modo, ListaReservas formListaReservas )
        {
            InitializeComponent();

            this.dbReservas = dbReservas;
            this.formListaReservas = formListaReservas;
            this.modo = modo;

            if( modo == 1 ) // añadir
            {
                this.reserva = new Reserva();
                txtFecha.Value = DateTime.Now;
            }else if( modo == 2 ) // editar
            {
                this.reserva = dbReservas.obtener(id);
                txtFecha.Value  = reserva.Fecha;
                txtContacto.Text = reserva.Contacto;    
                txtTelefono.Text = reserva.Telefono;   
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
            if( modo == 1)
              dbReservas.nueva(reserva);
            else if( modo == 2 )
              dbReservas.actualizar(reserva);
            formListaReservas.refrescarTabla();
            this.Close();
        }
    }
}
