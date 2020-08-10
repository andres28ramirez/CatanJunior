using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catan_Junior
{
    class Nodo_Carta
    {
        public Nodo_Carta siguiente;
        public int tipo;

        /*Tipo Simboliza que Carta de Ayuda de Coco simboliza:
         * 1.-Construir Fortaleza o Barco
         * 2.-Mover el Pirata
         * 3.-Obtencion de Recurso (2 Piñas / 2 Maderas)
         * 4.-Obtencion de Recurso (2 Ovejas / 2 Sables)
        */

        public Nodo_Carta(int x)
        {
            tipo = x;           //(x) simboliza el tipo de carta seleccionada
            siguiente = null;
        }
    }
}
