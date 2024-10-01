using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vuelos;
namespace AplicacionAeropuerto
{
    internal class Reserva
    {
        private Vuelo vueloElegido;
        private int billetesAdulto;
        private int billetesKid;
        private Boolean equipajeExtra;

        public Reserva(Vuelo vE, int bA, int bK, Boolean eE)
        {
            vueloElegido = vE;
            billetesAdulto = bA;
            billetesKid = bK;
            equipajeExtra = eE;
        }

        public void confirmarReserva()
        {

        }
    }
}
