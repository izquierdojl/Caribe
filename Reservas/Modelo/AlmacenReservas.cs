using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caribe.Reservas.Modelo
{
    public class AlmacenReservas
    {

        private ArrayList listaReservas            ;

        public AlmacenReservas(ArrayList listaReservas)
        {
            this.listaReservas = listaReservas; 
        }

        public ArrayList ListaReservas { get => listaReservas; set => listaReservas = value; }


        public void nueva(Reserva reserva)
        {
            reserva.Id = listaReservas.Count + 1;
            listaReservas.Add(reserva);
        }

        public void borrar(int id)
        {
            foreach (Reserva reserva in listaReservas)
            {
                if( reserva.Id == id)
                {
                    listaReservas.Remove(reserva);
                    break;
                }
            }
        }

        public Reserva obtener(int id)
        {
            foreach (Reserva reserva in listaReservas)
            {
                if (reserva.Id == id)
                {
                    return reserva; 
                    break;
                }
            }
            return null;
        }


        public int longitud()
        {
            return listaReservas.Count;   
        }

    }
}
