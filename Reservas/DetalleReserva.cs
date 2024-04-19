using Caribe.Reservas.Modelo;

namespace Caribe.Reservas
{
    public partial class DetalleReserva : Form
    {

        private int modo; // 1 - Añadir   2 - Editar  
        private AlmacenReservas dbReservas;
        private ListaReservas formListaReservas;
        private Reserva reserva;

        public DetalleReserva(AlmacenReservas dbReservas, int id, int modo, ListaReservas formListaReservas)
        {

            InitializeComponent();

            this.dbReservas = dbReservas;
            this.formListaReservas = formListaReservas;
            this.modo = modo;

            ToolTip tooltip = new ToolTip();
            tooltip.IsBalloon = true;
            tooltip.SetToolTip(txtFecha,"Indique la fecha");
            tooltip.SetToolTip(txtContacto, "Indique el nombre del contacto de la reserva (obligatorio");
            tooltip.SetToolTip(txtTelefono, "Indique el número de teléfono");
            tooltip.SetToolTip(comboTipo, "Indique el tipo de reserva");
            tooltip.SetToolTip(numericPersonas, "Indique el número de personas de la reserva");
            tooltip.SetToolTip(groupRestaurante, "Seleccione el tipo de servicio de restaurante si lo precisa");
            tooltip.SetToolTip(numericJornadas, "Indique el número de jornadas");
            tooltip.SetToolTip(checkRequiereHabitaciones, "Indique si la reserva requiere habitaciones");
            tooltip.SetToolTip(btnGuardar, "Pulse para guardar los datos introducidos");
            tooltip.SetToolTip(btnCancelar, "Pulse para descartar los cambios");

            if (modo == 1) // añadir
            {
                this.reserva = new Reserva();
                txtFecha.Value = DateTime.Now;
            }
            else if (modo == 2) // editar
            {
                this.reserva = dbReservas.obtener(id);
                txtFecha.Value = reserva.Fecha;
                txtContacto.Text = reserva.Contacto;
                txtTelefono.Text = reserva.Telefono;
                comboTipo.SelectedItem = reserva.Tipo;
                numericPersonas.Value = reserva.Personas;
                radioResBufe.Checked = reserva.ResBufe;
                radioResCarta.Checked = reserva.ResCarta;
                radioResChef.Checked = reserva.ResChef;
                radioResNoPrecisa.Checked = reserva.ResNo;
                numericJornadas.Value = reserva.Jornadas;
                checkRequiereHabitaciones.Checked = reserva.Habitaciones;
            }

            evaluaVisibles();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtContacto.Text))
            {
                reserva.Fecha = txtFecha.Value;
                reserva.Contacto = txtContacto.Text;
                reserva.Telefono = txtTelefono.Text;
                if( comboTipo.SelectedIndex >= 0 )
                    reserva.Tipo = comboTipo.SelectedItem.ToString();
                reserva.Personas = (int)numericPersonas.Value;
                reserva.ResBufe = radioResBufe.Checked;
                reserva.ResCarta = radioResCarta.Checked;
                reserva.ResChef = radioResChef.Checked;
                reserva.ResNo = radioResNoPrecisa.Checked;
                reserva.Jornadas = (int)numericJornadas.Value;
                reserva.Habitaciones = checkRequiereHabitaciones.Checked;
                if (modo == 1)
                    dbReservas.nueva(reserva);
                else if (modo == 2)
                    dbReservas.actualizar(reserva);
                formListaReservas.refrescarTabla();
                this.Close();
            }
            else
            {
                MessageBox.Show("El nombre del contacto es obligatorio", "");
            }
        }

        private void evaluaVisibles()
        {
            if (comboTipo.SelectedIndex >= 0)
            {

                String seleccionado = comboTipo.SelectedItem.ToString();
                if (seleccionado == "Congreso")
                {
                    labelJornadas.Visible = true;
                    numericJornadas.Visible = true;
                    checkRequiereHabitaciones.Visible = true;
                }
                else
                {
                    labelJornadas.Visible = false;
                    numericJornadas.Visible = false;
                    checkRequiereHabitaciones.Visible = false;
                }
            }
            else
            {
                labelJornadas.Visible = false;
                numericJornadas.Visible = false;
                checkRequiereHabitaciones.Visible = false;

            }

        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            evaluaVisibles();
        }
    }

}
