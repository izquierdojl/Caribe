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
        private String tipo;
        private int personas;
        private bool resBufe;
        private bool resCarta;
        private bool resChef;
        private bool resNo;
        private int jornadas;
        private bool habitaciones;


        public Reserva()
        {
        }

        public Reserva(int id, DateTime fecha, string contacto, string telefono, string tipo, int personas, bool resBufe, bool resCarta, bool resChef, bool resNo, int jornadas, bool habitaciones)
        {
            this.id = id;
            this.fecha = fecha;
            this.contacto = contacto;
            this.telefono = telefono;
            this.tipo = tipo;
            this.personas = personas;
            this.resBufe = resBufe;
            this.resCarta = resCarta;
            this.resChef = resChef;
            this.resNo = resNo;
            this.jornadas = jornadas;
            this.habitaciones = habitaciones;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Personas { get => personas; set => personas = value; }
        public bool ResBufe { get => resBufe; set => resBufe = value; }
        public bool ResCarta { get => resCarta; set => resCarta = value; }
        public bool ResChef { get => resChef; set => resChef = value; }
        public bool ResNo { get => resNo; set => resNo = value; }
        public int Jornadas { get => jornadas; set => jornadas = value; }
        public bool Habitaciones { get => habitaciones; set => habitaciones = value; }
    }
}
