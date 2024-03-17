using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caribe.Reservas.Modelo
{
    public class Reserva
    {

        private DateTime fecha;
        private String contacto;
        private String telefono;

        public Reserva()
        {
        }

        public Reserva(DateTime fecha, string contacto, string telefono)
        {
            this.Fecha = fecha;
            this.Contacto = contacto;
            this.Telefono = telefono;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string Telefono { get => telefono; set => telefono = value; }

    }
}
