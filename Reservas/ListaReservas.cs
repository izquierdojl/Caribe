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
            vistaAnade();
        }

        private void toolBtnBorrar_Click(object sender, EventArgs e)
        {
            vistaBorrar();
        }

        private void toolBtnEditar_Click(object sender, EventArgs e)
        {
            vistaEditar();
        }

        public void refrescarTabla()
        {
            int posicion = -1;
            if (tablaReservas.RowCount > 0)
            {
                posicion = tablaReservas.SelectedRows[0].Index;
                this.tablaReservas.Rows.Clear();
            }
            foreach (Reserva reserva in dbReservas.ListaReservas)
            {
                tablaReservas.Rows.Add(reserva.Id, reserva.Fecha.ToShortDateString(), reserva.Contacto, reserva.Telefono);
            }
            tablaReservas.AutoResizeColumns(); // ajusta el ancho de las columnas
            if (posicion != -1 && tablaReservas.RowCount > 0)
            {
                tablaReservas.Rows[posicion].Selected = true;
            }
            tablaReservas.Focus();

        }

        private void vistaAnade()
        {
            DetalleReserva detalleReserva = new DetalleReserva(dbReservas, 0, 1, this);
            detalleReserva.ShowDialog();
        }

        private void vistaEditar()
        {
            if (tablaReservas.RowCount > 0)
            {
                int id = (int)tablaReservas.SelectedRows[0].Cells[0].Value;
                if (id > 0)
                {
                    DetalleReserva detalleReserva = new DetalleReserva(dbReservas, id, 2, this);
                    detalleReserva.ShowDialog();
                }
            }
        }

        private void vistaBorrar()
        {
            int id = (int)tablaReservas.SelectedRows[0].Cells[0].Value;
            if (id > 0)
            {
                if (MessageBox.Show("¿ Seguro de borrar la reserva " + id + " ?", "Borrado de reserva", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dbReservas.borrar(id);
                    refrescarTabla();
                }
            }
        }

        private void tablaReservas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                vistaEditar();
            }
            else if (e.KeyCode == Keys.Insert)
            {
                vistaAnade();

            }
            else if (e.KeyCode == Keys.Delete)
            {
                vistaBorrar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
