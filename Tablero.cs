using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catan_Junior
{   //DEBO VERIFICAR QUE TODAS LAS LINEAS DE CODIGO REALIZAN LO QUE DESEO QUE HAGAN// IMPORTANTE!!!!
    //HACERLE CORRIDA EN FRIO, MEJOR PA PROBAR QUE HAGA LAS COSAS COMO SON
    class Tablero
    {
        public int[] recursos = new int[5];    //Banco de los recursos
        public Jugador[] Player;
        public Hexagono[] isla;
        public int[] salvavidas = new int[5];
        public Nodo_Carta AyudaCoco;
        public int JugadorIsla;      //Tendra el indice del jugador que tiene una fortaleza en la isla 6
        public int z;        //z grabara el indice del jugador el cual cambiara turno a turno
        public bool partida;    //estara true al culminar el juego, o falso si continua.
        public int carta;   //vale el tipo de carta

        /*Representacion del Indice por material:
         * 0.- Sables
         * 1.- Ovejas
         * 2.- Madera
         * 3.- Piña
         * 4.- Oro
         */

        public Tablero()
        {
            for (int i = 0; i < 5; i++)
            {
                recursos[i] = 17; //Inicializo cada Recurso con 18 disponibles
                salvavidas[i] = i;  //Inicializa los salvavidas con un entero que sera cada recurso..
            }
            z = 0;              //arranque el indice de jugadores en 0
            AyudaCoco = null;
            JugadorIsla = -1;   //-1 para que el indice no se tome en cuenta la primera pasada
            partida = false; //Indicara true cuando se acabe el juego   //***********************//

            //----------------------------------------Creacion de las Cartas de Ayuda de Coco--------------------------------------------//
            int propiedad = 0, pir = 0, rec1 = 0, rec2 = 0, valor;
            
            Nodo_Carta aux = AyudaCoco;
            /* estado -> valida si se puede seguir grabando el tipo de carta
             * Significado de los int:
             * propiedad = carta fortaleza / barco (5 disponibles)
             * pir = carta del pirata (7 disponibles)
             * rec1 = carta Obtencion de Recurso [2 Piñas / 2 Maderas] (2 disponibles)
             * rec2 = carta Obtencion de Recurso [2 Ovejas / 2 Sables] (2 disponibles)
            */
            for (int i = 0; i < 16; i++)  //Maximo de cartas (16)
            {
                if (pir < 7)
                {
                    pir++;
                    valor = 2;
                }
                else if (propiedad < 5)
                {
                    propiedad++;
                    valor = 1;
                }
                else if (rec1 < 2)
                {
                    rec1++;
                    valor = 3;
                }
                else
                {
                    rec2++;
                    valor = 4;
                }

                Nodo_Carta nuevo = new Nodo_Carta(valor);       //Reservo un nodo con el tipo de carta segun valor
                if (AyudaCoco == null)                          //acomodo la cabecera si hace falta
                {
                    aux = nuevo;
                    AyudaCoco = aux;
                    AyudaCoco.siguiente = AyudaCoco;
                }
                else                                            //Grabo el nodo en mi aux.siguiente y paso a que aux apunte el ultimo
                {
                    nuevo.siguiente = AyudaCoco;
                    aux.siguiente = nuevo;
                    aux = nuevo;
                }                                               //Lista circular de cartas completamente llenada
            }
        }

        public void Reservar(int n) //El handler del control que pregunta numero de jugadores, lanza este metodo con n representado cuantos son
        {
            Player = new Jugador[n];
            for (int i = 0; i < n; i++)
                Player[i] = new Jugador(i + 1);    //i+1 se graba en color que seria la representacion del jugador

            if (n == 2)     //Reservacion para el tablero de 2 Personas
            {
                isla = new Hexagono[9];     //Reservo el numero de islas

                /*Representacion del Indice por material:
                    * 0.- Sables
                    * 1.- Ovejas
                    * 2.- Madera
                    * 3.- Piña
                    * 4.- Oro
                */
                isla[0] = new Hexagono(1, 0);         //(1,0) 1 = Valor del Dado, 0= Valor del Material (Sables)
                isla[1] = new Hexagono(2, 1);         //(2,1) 2 = Valor del Dado, 1= Valor del Material (Ovejas)
                isla[2] = new Hexagono(3, 2);         //(3,2) 3 = Valor del Dado, 2= Valor del Material (Madera)
                isla[3] = new Hexagono(3, 3);         //(3,3) 3 = Valor del Dado, 3= Valor del Material (Piña)
                isla[4] = new Hexagono(5, 4);         //(5,4) 5 = Valor del Dado, 4= Valor del Material (Oro)
                isla[5] = new Hexagono(4, 3);         //(4,3) 4 = Valor del Dado, 3= Valor del Material (Piña)
                isla[6] = new Hexagono(4, 2);         //(4,2) 4 = Valor del Dado, 2= Valor del Material (Madera)
                isla[7] = new Hexagono(1, 1);         //(1,1) 1 = Valor del Dado, 1= Valor del Material (Ovejas)
                isla[8] = new Hexagono(2, 0);         //(2,0) 2 = Valor del Dado, 0= Valor del Material (Sables)
            }
            //-----------------------------------------------------------------------------------------------------------------//
            else  //Tablero para 3 o 4 Personas
            {
                isla = new Hexagono[12];    //Reservo el numero de islas

                isla[0] = new Hexagono(2, 3);         //(2,3) 2 = Valor del Dado, 3= Valor del Material (Piña)
                isla[1] = new Hexagono(1, 1);         //(1,1) 1 = Valor del Dado, 1= Valor del Material (Ovejas)
                isla[2] = new Hexagono(2, 2);         //(2,2) 2 = Valor del Dado, 2= Valor del Material (Madera)
                isla[3] = new Hexagono(1, 0);         //(1,0) 1 = Valor del Dado, 0= Valor del Material (Sables)
                isla[4] = new Hexagono(5, 1);         //(5,1) 5 = Valor del Dado, 1= Valor del Material (Ovejas)
                isla[5] = new Hexagono(3, 4);         //(3,4) 3 = Valor del Dado, 4= Valor del Material (Oro)
                isla[6] = new Hexagono(5, 4);         //(5,4) 5 = Valor del Dado, 4= Valor del Material (Oro)
                isla[7] = new Hexagono(3, 2);         //(3,2) 3 = Valor del Dado, 2= Valor del Material (Madera)
                isla[8] = new Hexagono(4, 3);         //(4,3) 4 = Valor del Dado, 3= Valor del Material (Piña)
                isla[9] = new Hexagono(2, 1);         //(2,1) 2 = Valor del Dado, 1= Valor del Material (Ovejas)
                isla[10] = new Hexagono(1, 2);         //(1,2) 1 = Valor del Dado, 2= Valor del Material (Madera)
                isla[11] = new Hexagono(4, 0);         //(4,0) 4 = Valor del Dado, 0= Valor del Material (Sables)
            }

            for (int i = 0; i < n; i++) //Para eliminar el 1 de sable y de madera que se da a cada jugador
            {
                recursos[0]--;
                recursos[2]--;
            }
        }

        public void Cambiar()   //Metodo que reestablece los recursos de los salvavidas a cada uno diferente
        {
            switch (salvavidas[0])  //reviso que recurso esta en todos y lo devuelvo al stock principal (Banco)
            {
                case 0: recursos[0] += 5; break;
                case 1: recursos[1] += 5; break;
                case 2: recursos[2] += 5; break;
                case 3: recursos[3] += 5; break;
                case 4: recursos[4] += 5; break;
            }
            for (int i = 0; i < 5; i++)
            {  //Restablece los recursos en cada salvavida
                salvavidas[i] = i;
                recursos[i]--;
            }
        }

        public void Restaurar(int i) //Restaurar recurso del stock (Banco) que se haya acabado   
        {
            for (int j = 0; j < Player.Length; j++)
            {  //Entro en cada usuario y lo pongo en 0 el recurso que mando como indice en i
                recursos[i] += Player[j].recursos[i];   //Restablezco el stock sumando los recursos de cada usuario
                Player[j].recursos[i] = 0;
            }
        }

        public void Revision()  //Se ejecuta con un Handler que representa terminar turno del jugador
        {
            //bool partida = false;
            //--------------------------------REVISAR NUMERO DE CARTAS PARA VALIDAR LA FORTIFICACION DE LA ISLA 6-------------------------//
            int indice = 0, mayor = -1;       //Se utilizara para saber el indice jugador con mas cartas y darle la fortaleza de la isla 6
            bool posicion = true;              //este bool me dice si debo quitar o poner la fortaleza...

            for (int i = 0; i < Player.Length; i++)
            {
                if (mayor <= Player[i].cartas) //reviso jugador a jugador si tiene mas cartas que mayor (este guarda el numero de cartas mayor anterior)
                {
                    if (mayor == Player[i].cartas)  //reviso si no son la misma cantidad, de ser asi rompo el ciclo y pongo posicion falso
                    {                               //para que no entre en el if de abajo que modifica la fortaleza
                        posicion = false;
                    }
                    else
                    {
                        mayor = Player[i].cartas;   //tendra el mayor numero de cartas que luego sera usado en la validacion del if..
                        indice = i;     //Tendra guardado el indice con el jugador con mas cartas..
                        posicion = true;
                    }
                }
            }

            if (JugadorIsla != indice)   //tengo que ver que el indice no termino siendo el mismo de JugadorIsla
            {
                if (posicion)       //si posicion se mantuvo true es decir que si hay cambio de fortaleza en la isla 6..
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (Player[indice].fortalezas[i] == false)  //Recorro las fortalezas, cuando haye uno en false, lo cambio a true y rompo
                        {                                           //el ciclo, de tal forma adhisione uno al jugador con fortaleza nueva
                            Player[indice].fortalezas[i] = true;
                            break;
                        }
                    }
                    if (JugadorIsla != -1)      //si JugadorIsla es diferente a -1 debo borrarle 1 fortaleza al jugador indice que graba la variable
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            if (Player[JugadorIsla].fortalezas[i] == false)     //Parecido al de arriba solamente que recorro hasta llegar a una fortaleza
                            {                                                   //en falso, lo cual indica que la anterior esta en true, me cambio a esa
                                Player[JugadorIsla].fortalezas[i - 1] = false;    //y la pongo en falso haciendo el borrado de una fortaleza
                                break;
                            }
                        }
                    }
                    JugadorIsla = indice;   //Ahora JugadorIsla tendra el indice del jugador con mayor cartas
                }
            }
            if (posicion==false)
            {
                if (JugadorIsla != -1)      //si JugadorIsla es diferente a -1 debo borrarle 1 fortaleza al jugador indice que graba la variable
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (Player[JugadorIsla].fortalezas[i] == false)     //Parecido al de arriba solamente que recorro hasta llegar a una fortaleza
                        {                                                   //en falso, lo cual indica que la anterior esta en true, me cambio a esa
                            Player[JugadorIsla].fortalezas[i - 1] = false;    //y la pongo en falso haciendo el borrado de una fortaleza
                            break;
                        }
                    }
                }
                JugadorIsla = -1; //Acomodo el indice del jugador isla a -1 para que no grabe a nadie...
            }

            //---------------------------------------REVISAR SI UN JUGADOR YA GANO-------------------------------------------//

            for (int i = 0; i < Player.Length; i++)       //Reviso Jugador x Jugador si todas sus fortalezas estan en true, cuando suceda esto  
            {                                             //pongo partida en true y finalizo la partida mostrando el ganador
                for (int j = 0; j < 7; j++)
                {
                    if (Player[i].fortalezas[j] == false)
                    {
                        partida = false;
                        break;
                    }
                    else
                        partida = true;
                }
                if (partida)
                    break;
                //LANZO ALGO QUE MUESTRE Player[i] Es el ganador se acabo el juego y que enseñe un control o algo asi...
            }

            if (!partida)   //Valido que la partida haya seguido..
            {
                /*if (AyudaCoco==null)
                    invalido un control de compro o algo, asi etc...*/

                //-------------------------------------------------------------------------------------------//
                //Reviso el estado de los salvavidas a que no haya cartas repetidas en todas
                for (int i = 0; i < 5; i++)
                {
                    if (salvavidas[0] != salvavidas[i])     //Cuando un valor (recurso) en un salvavida sea distinto me salgo
                        break;
                    else
                    {
                        if (i == 4) //si no se ha salido del ciclo nunca y estoy en el ultimo salvavida entonces lanzo el cambio de recurso al incial
                            Cambiar();
                    }
                }

                //------------------------------------------------------------------------------------------//
                //Reviso si algun recurso se encuentra en 0 dentro del stock
                for (int i = 0; i < 5; i++)
                {
                    if (recursos[i] <= 0)   //cuando este en 0 lo envio a restaurar con el indice que simboliza el recurso
                        Restaurar(i);
                }

                if (z == (Player.Length - 1))    //muevo el indice del vector del jugador, si esta en el maximo lo reestablezco a jugador 1 (0)
                    z = 0;
                else
                    z++;
            }
        }

        public void Comprar(int x)  //Se ejecuta con un Handler que me envia la compra realizada por el Usuario (jugador)
        {
            switch (x)
            {
                case 1: //Compra de Fortaleza
                    Player[z].recursos[0]--; Player[z].recursos[1]--; Player[z].recursos[2]--; Player[z].recursos[3]--;
                    recursos[0]++;  recursos[1]++;  recursos[2]++;  recursos[3]++;  //Acomodo la compra de recursos
                    for (int i = 0; i < 7; i++)
                    {
                        if (Player[z].fortalezas[i] == false)   //cuando llegue a una fortaleza en falso la cambio a true y rompo el ciclo
                        {                                       //para que guarde una fortaleza mas en el usuario
                            Player[z].fortalezas[i] = true;
                            break;
                        }
                    }
                    break;
                case 2: //Compra de Barco
                    Player[z].recursos[1]--; Player[z].recursos[2]--; 
                    recursos[1]++;  recursos[2]++; //Acomodo la compra de recursos
                    break;
                case 3: //Compra de Ayudas de Coco
                    Player[z].recursos[0]--; Player[z].recursos[3]--; Player[z].recursos[4]--; 
                    recursos[0]++;  recursos[3]++;  recursos[4]++; //Acomodo la compra de recursos
                    Player[z].cartas++;
                    Random rnd = new Random();
                    int valor = rnd.Next(4, 8);
                    Nodo_Carta temp=null ,aux = AyudaCoco;

                    for (int i = 0; i < valor; i++)
                    {
                        temp = aux;
                        aux = aux.siguiente;
                    }

                    /*int*/ carta = aux.tipo;         //Tomo el valor de la CARTA (CUANDO ESTO EJECUTO UN HANDLER O ALGO)
                    if (AyudaCoco == aux)
                        AyudaCoco = aux.siguiente;      //Acomodo ayuda de coco ya que se va a eliminar
                    if ((temp.siguiente == AyudaCoco)&&(temp==AyudaCoco))
                        AyudaCoco = null;       //Borro toda la lista
                    else
                        temp.siguiente = aux.siguiente;    //Elimino la carta
                    
                    if (carta == 3)
                    {
                        Player[z].recursos[3] += 2; recursos[3] -= 2;   //3.-Piña, aumento 2 en jugador y quito 2 del stock
                        Player[z].recursos[2] += 2; recursos[2] -= 2;   //2.-Madera, aumento 2 en jugador y quito 2 del stock
                    }
                    if (carta == 4)
                    {
                        Player[z].recursos[0] += 2; recursos[0] -= 2;   //0.-Sable, aumento 2 en jugador y quito 2 del stock
                        Player[z].recursos[1] += 2; recursos[1] -= 2;   //1.-Oveja, aumento 2 en jugador y quito 2 del stock
                    }
                    break;
            }
        }

        public void Intercambio(int x, int a, int b)    //X = opcion de cambio //a= Recurso del Jugador // b= Recurso del Salvavida o Banco
        {
            if (x == 1)     //Intercambio entre Salvavida y Jugador
            {
                int aux = salvavidas[b]; //aux graba el entero que siboliza el recurso que esta en el indice b;
                salvavidas[b] = a;      //cambio el recurso de la posicion (b) por el que envia el Jugador
                Player[z].recursos[aux]++;      //Incremento el recurso que intercambie
                Player[z].recursos[a]--;        //Decremento el recurso que intercambie
            }
            else           //Intercambio entre el Stock (Banco) y Jugador
            {
                recursos[a] += 2; //Incremento a dos el recurso del banco segun envie el Jugador
                Player[z].recursos[b]++;    //Incremento a uno el recurso que intercambie para el Jugador
                Player[z].recursos[a] -= 2;     //Decremento a dos el recurso que intercambie  para el Jugador
                recursos[b]--;
            }
        }

        public void Lanzamiento(int x, int a)  //Metodo que se invoca en el Handler de lanzar Dado //x = el valor del dado 
        {                                                                                          //a= indice de la isla donde se pondra el pirata
            if (x == 6)     //Si el valor del dado es igual a 6
            {
                for (int i = 0; i < isla.Length; i++)   //Reviso si alguna isla tiene en su estado al pirata y lo pomgo falso
                {
                    if (isla[i].pirata == true)
                    {
                        isla[i].pirata = false; //quito el pirata de la isla seleccionada
                        break;
                    }
                }
                isla[a].pirata = true;      //coloco el pirata en la isla seleccionada
                Player[z].recursos[isla[a].material] += 2;  //Aumento a dos el recurso del jugador segun el material que tenga la isla seleccionada
                recursos[isla[a].material] -= 2;           //disminuyo a 2 el recurso del Banco

                if (recursos[isla[a].material] <= 0)        //chequeo que el recurso no haya quedado en 0.. sino lo arreglo
                    Restaurar(isla[a].material);            //isla[a].material = al indice del recurso segun se establecio al principio
            }
            else    //Cualuier valor distinto a 6 del dado
            {
                for (int i = 0; i < isla.Length; i++)
                {
                    if ((isla[i].dado == x) && (isla[i].pirata == false))   //Si la isla es del mismo valor del dado y no tiene el pirata
                    {
                        for (int j = 0; j < 6; j++) //Recorro sus fortalezas buscando fortalezas de jugadores
                        {
                            if (isla[i].Fortalezas[j] != 0)  //Si es diferente a 0 quiere decir que tiene un jugador grabado en una fortaleza
                            {
                                int aux = isla[i].Fortalezas[j] - 1;    //aux es el indice del usuario.. (resto 1 ya que necesito poner el indice bien)
                                Player[aux].recursos[isla[i].material]++;   //aumento el recurso segun el material.. 
                                recursos[isla[i].material]--;           //decremento uno el recurso del stock... (isla[i].material {indice del recurso})
                            }
                        }
                        if (recursos[isla[i].material] <= 0)        //Chequeo que el recurso no haya quedado en 0.. sino lo arreglo
                            Restaurar(isla[i].material);            //isla[i].material = al indice del recurso segun se establecio al principio
                    }
                }
            }
        }

    }
}
