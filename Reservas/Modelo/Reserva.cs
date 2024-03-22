using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caribe.Reservas.Modelo
{
    public class Reserva
    {

        private int id;
        private DateTime fecha;
        private String contacto;
        private String telefono;

        public Reserva()
        {
        }

        public Reserva(int id, DateTime fecha, string contacto, string telefono)
        {
            this.id = id;
            this.Fecha = fecha;
            this.Contacto = contacto;
            this.Telefono = telefono;



        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string Telefono { get => telefono; set => telefono = value; }

    }
}
