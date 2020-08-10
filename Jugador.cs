using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catan_Junior
{
    class Jugador
    {
        public bool[] fortalezas = new bool[7];
        public int cartas;
        public int[] recursos = new int[5];
        public int color;

        //ESTEN PUBLICOS, PERO SI LOS PONGO PRIAVTE, DEBO COLOCAR METODOS SET Y GET O PROPIEDADES
        /*Representacion del Indice por material:
         * 0.- Sables
         * 1.- Ovejas
         * 2.- Madera
         * 3.- Piña
         * 4.- Oro
         */

        public Jugador(int x)
        {
            for (int i = 0; i < 5; i++)
                recursos[i] = 0;
            cartas = 0;
            color = x;          //color grabara un char o un entero usado para ponerle color al control que lo simbolize;

            for (int i = 0; i < 2; i++)     //Cada jugador inicializa con dos fortalezas ya generadas
                fortalezas[i] = true;
            
            recursos[0] = 1;    //Cada jugador inicia con 1 de sable y 1 de madera
            recursos[2] = 1;
        }
    }
}
