using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public void actualizar(Reserva reservaActualizada)
        {
            Reserva reservaExistente = obtener(reservaActualizada.Id);
            if (reservaExistente != null)
            {
                Type tipoReserva = typeof(Reserva);
                PropertyInfo[] propiedades = tipoReserva.GetProperties();

                foreach (PropertyInfo propiedad in propiedades)
                {
                    object valor = propiedad.GetValue(reservaActualizada);
                    propiedad.SetValue(reservaExistente, valor);
                }
            }
        }

        public int longitud()
        {
            return listaReservas.Count;   
        }

    }
}
