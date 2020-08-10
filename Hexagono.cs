using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catan_Junior
{
    class Hexagono
    {
        public int[] Fortalezas = new int[6];  //Maximo de Fortalezas, Grabara un numero que especificara el jugador:
        //1.-Jugador 1 / 2.- Jugador 2 / 3.- Jugador 3 / 4.- Jugador 4   // a su vez sera un indice para el jugador
        public bool pirata;
        public int material;
        public int dado;       //Valor de acuerdo al dado

        /*Material grabara un numero que simbolizara un recurso:
         * 0.- Sables
         * 1.- Ovejas
         * 2.- Madera
         * 3.- Piña
         * 4.- Oro
         */

        /*Las Fortaleza grabaran un entero entre 1-4 (Jugador //entero//)*/

        public Hexagono(int n, int x)   //n = valor segun el dado, x = material o recurso que fabrique
        {
            dado = n;
            material = x;
            pirata = false;
            for (int i = 0; i < 6; i++)
                Fortalezas[i] = 0; //Cada espacio tendra un 0 (si es 0 no tiene fortalezas de ningun usuario)
        }

        //TODOS LOS ATIBUTOS ESTAN PUBLICOS DE PRUEBA, PERO PUEDES SER PRIVATE Y HABRIA QUE PONERLE METODOS SET Y GET
    }
}
