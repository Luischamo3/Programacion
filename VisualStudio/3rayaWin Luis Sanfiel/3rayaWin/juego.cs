using System;
using System.Windows.Forms;

namespace _3rayaWin
{
    /// <summary>
    /// Estructura que contiene todas las variables que necesitamos en la clase
    /// </summary>
    public struct devolucion
    {
        public int fila;
        public int columna;
        public bool ganajugador;
        public bool ganamaquina;
        public bool empate;
        public bool fin;
        public char caracterjuador;
        public char caractermaquina;
        public int turno;

    }
    /// <summary>
    /// Clase que se encarga de toda la mecánica del juego es decir los movimiento de la máquina y jugador
    /// </summary>
    class juego
    {
        public devolucion devol;
        int filas, columnas;
        private char[,] tabla1;

        public juego(int f, int c)
        {
            /*Este bucle recorre la tabla y pone guiones en todas sus casillas*/
            devol.caracterjuador = 'X';
            devol.caractermaquina = 'O';
            filas = f;
            columnas = c;
            tabla1 = new char[f, c];
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    tabla1[i, j] = '-';
        }
        
        /// <summary>
        /// Función se encarga de que el jugador pueda escribir su caracter.
        /// </summary>
        /// <param name="fila"></param>
        /// <param name="columna"></param>
        /// <param name="turno"></param>
        public void movimientojugador(int fila, int columna, int turno)
        {
            /* En esta función escribimos el caracter del jugador en la fila y la columna
             Donde clikemos, llamamos a la función que comprobará si ganamos */
            devol.fila = fila;
            devol.columna = columna;
            tabla1[fila, columna] = devol.caracterjuador;
            devol.turno = turno;
            checkwinner();
        }
        /// <summary>
        /// Con esta función reseteamos el juego al ganar para poder reiniciar la partida
        /// </summary>
        public void reset()
        {
            // Una vez ganada la partida volvemos a
            //poner todas las variables a falso.
            // Además volvemos a poner la tabla en blanco
            devol.ganajugador = false;
            devol.ganamaquina = false;
            devol.empate = false;
            devol.fin = false;

            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    tabla1[i, j] = '-';
        }

        /// <summary>
        /// Función que detecta si el jugador o la máquina alguna de las 
        /// combinaciones necesarias para poder ganar reuniendo  los tres caracteres seguidos        
        /// </summary>
        public void checkwinner()
        {
            /*Buscamos una jugada Ganadora si no la encuentra llama a la función no perder*/
            if (vertical(devol.caractermaquina))
            {
                devol.ganamaquina = true;
                devol.fin = true; return;
            }
            if (horizontal(devol.caractermaquina))
            {
                devol.ganamaquina = true;
                devol.fin = true; return;
            }
            if (diagonal(devol.caractermaquina))
            {
                devol.ganamaquina = true;
                devol.fin = true; return;
            }

            if (vertical(devol.caracterjuador))
            {
                devol.ganajugador = true;
                devol.fin = true; return;
            }

            if (horizontal(devol.caracterjuador))
            {
                devol.ganajugador = true;
                devol.fin = true; return;
            }
            if (diagonal(devol.caracterjuador))
            {
                devol.ganajugador = true;
                devol.fin = true; return;
            }
            int cont = 0;
            //Bucle que busca un espacio libre si el jugador o la máquina no han ganado
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                {
                    if (tabla1[i, j] == '-')
                        cont++;
                }
            // con el blucle anterior podemos saber saber si existe un empate
            if (cont == 0)
            {
                devol.empate = true;
                devol.fin = true; return;
            }
        }
        // Comprobar Vertical 
        bool vertical(char ficha)
        {
            return (tabla1[0, 0] == ficha) && (tabla1[1, 0] == ficha) && (tabla1[2, 0] == ficha) ||
              (tabla1[0, 1] == ficha) && (tabla1[1, 1] == ficha) && (tabla1[2, 1] == ficha) ||
              (tabla1[0, 2] == ficha) && (tabla1[1, 2] == ficha) && (tabla1[2, 2] == ficha);
        }
        // Comprobar Horizontal
        bool horizontal(char ficha)
        {
            return (tabla1[0, 0] == ficha) && (tabla1[0, 1] == ficha) && (tabla1[0, 2] == ficha) ||
                (tabla1[1, 0] == ficha) && (tabla1[1, 1] == ficha) && (tabla1[1, 2] == ficha) ||
                (tabla1[2, 0] == ficha) && (tabla1[2, 1] == ficha) && (tabla1[2, 2] == ficha);
        }
        //Comprobar Diagonal
        bool diagonal(char ficha)
        {
            return (tabla1[0, 0] == ficha) && (tabla1[1, 1] == ficha) && (tabla1[2, 2] == ficha) ||
                (tabla1[0, 2] == ficha) && (tabla1[1, 1] == ficha) && (tabla1[2, 0] == ficha);
        }
        /// <summary>
        /// Función que hace que la máquina busque la posibilidad de ganar al usuario.
        /// </summary>
        /// <returns></returns>
        public devolucion jugadaganadora()
        {
            /*Todas las combinaciones de jugadas ganadoras que puede hacer la máquina*/
            if ((devol.turno == 2) && (tabla1[1, 1] == '-'))
            {
                devol.fila = 1;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }
            //Horizontal fila 1
            if ((tabla1[0, 0] == 'O') && (tabla1[0, 1] == 'O') && (tabla1[0, 2] == '-'))
            {
                devol.fila = 0;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;

            }
            if ((tabla1[0, 0] == 'O') && (tabla1[0, 2] == 'O') && (tabla1[0, 1] == '-'))
            {
                devol.fila = 0;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[0, 1] == 'O') && (tabla1[0, 2] == 'O') && (tabla1[0, 0] == '-'))
            {
                devol.fila = 0;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }
            // horizontal fila 2
            if ((tabla1[1, 0] == 'O') && (tabla1[1, 1] == 'O') && (tabla1[1, 2] == '-'))
            {
                devol.fila = 1;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[1, 0] == 'O') && (tabla1[1, 2] == 'O') && (tabla1[1, 1] == '-'))
            {
                devol.fila = 1;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[1, 1] == 'O') && (tabla1[1, 2] == 'O') && (tabla1[1, 0] == '-'))
            {
                devol.fila = 1;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            // horizontal fila 3
            if ((tabla1[2, 0] == 'O') && (tabla1[2, 1] == 'O') && (tabla1[2, 2] == '-'))
            {
                devol.fila = 2;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[2, 0] == 'O') && (tabla1[2, 2] == 'O') && (tabla1[2, 1] == '-'))
            {
                devol.fila = 2;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[2, 1] == 'O') && (tabla1[2, 2] == 'O') && (tabla1[2, 0] == '-'))
            {
                devol.fila = 2;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            // Vertical columna1
            if ((tabla1[0, 0] == 'O') && (tabla1[1, 0] == 'O') && (tabla1[2, 0] == '-'))
            {
                devol.fila = 2;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[0, 0] == 'O') && (tabla1[2, 0] == 'O') && (tabla1[1, 0] == '-'))
            {
                devol.fila = 1;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[1, 0] == 'O') && (tabla1[2, 0] == 'O') && (tabla1[0, 0] == '-'))
            {
                devol.fila = 0;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            // Vertical Columna 2
            if ((tabla1[0, 1] == 'O') && (tabla1[1, 1] == 'O') && (tabla1[2, 1] == '-'))
            {
                devol.fila = 2;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[0, 1] == 'O') && (tabla1[2, 1] == 'O') && (tabla1[1, 1] == '-'))
            {
                devol.fila = 1;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;

            }

            if ((tabla1[1, 1] == 'O') && (tabla1[2, 1] == 'O') && (tabla1[0, 1] == '-'))
            {
                devol.fila = 0;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;

            }

            // Vertical Columna 3
            if ((tabla1[0, 2] == 'O') && (tabla1[1, 2] == 'O') && (tabla1[2, 2] == '-'))
            {
                devol.fila = 2;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[0, 2] == 'O') && (tabla1[2, 2] == 'O') && (tabla1[1, 2] == '-'))
            {
                devol.fila = 1;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[1, 2] == 'O') && (tabla1[2, 2] == 'O') && (tabla1[0, 2] == '-'))
            {
                devol.fila = 0;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            // Diagonal 1
            if ((tabla1[0, 0] == 'O') && (tabla1[1, 1] == 'O') && (tabla1[2, 2] == '-'))
            {
                devol.fila = 2;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[0, 0] == 'O') && (tabla1[2, 2] == 'O') && (tabla1[1, 1] == '-'))
            {
                devol.fila = 1;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[1, 1] == 'O') && (tabla1[2, 2] == 'O') && (tabla1[0, 0] == '-'))
            {
                devol.fila = 0;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            // Diagonal 2
            if ((tabla1[0, 2] == 'O') && (tabla1[1, 1] == 'O') && (tabla1[2, 0] == '-'))
            {
                devol.fila = 2;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[0, 0] == 'O') && (tabla1[2, 0] == 'O') && (tabla1[1, 1] == '-'))
            {
                devol.fila = 1;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[1, 1] == 'O') && (tabla1[2, 0] == 'O') && (tabla1[0, 2] == '-'))
            {
                devol.fila = 0;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            return noperder();
        }
        /// <summary>
        /// Función que se activa si la máquina no puede ganaar evitando que el jugador lo haga
        /// </summary>
        /// <returns></returns>
        public devolucion noperder()
        {
            if ((devol.turno == 2) && (tabla1[1, 1] == '-'))
            {
                devol.fila = 1;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }
            //Horizontal fila 1
            if ((tabla1[0, 0] == 'X') && (tabla1[0, 1] == 'X') && (tabla1[0, 2] == '-'))
            {
                devol.fila = 0;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[0, 0] == 'X') && (tabla1[0, 2] == 'X') && (tabla1[0, 1] == '-'))
            {
                devol.fila = 0;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[0, 1] == 'X') && (tabla1[0, 2] == 'X') && (tabla1[0, 0] == '-'))
            {
                devol.fila = 0;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            // horizontal fila 2
            if ((tabla1[1, 0] == 'X') && (tabla1[1, 1] == 'X') && (tabla1[1, 2] == '-'))
            {
                devol.fila = 1;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[1, 0] == 'X') && (tabla1[1, 2] == 'X') && (tabla1[1, 1] == '-'))
            {
                devol.fila = 1;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[1, 1] == 'X') && (tabla1[1, 2] == 'X') && (tabla1[1, 0] == '-'))
            {
                devol.fila = 1;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            // horizontal fila 3
            if ((tabla1[2, 0] == 'X') && (tabla1[2, 1] == 'X') && (tabla1[2, 2] == '-'))
            {
                devol.fila = 2;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[2, 0] == 'X') && (tabla1[2, 2] == 'X') && (tabla1[2, 1] == '-'))
            {
                devol.fila = 2;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[2, 1] == 'X') && (tabla1[2, 2] == 'X') && (tabla1[2, 0] == '-'))
            {
                devol.fila = 2;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            // Vertical columna1
            if ((tabla1[0, 0] == 'X') && (tabla1[1, 0] == 'X') && (tabla1[2, 0] == '-'))
            {
                devol.fila = 2;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[0, 0] == 'X') && (tabla1[2, 0] == 'X') && (tabla1[1, 0] == '-'))
            {
                devol.fila = 1;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[1, 0] == 'X') && (tabla1[2, 0] == 'X') && (tabla1[0, 0] == '-'))
            {
                devol.fila = 0;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            // Vertical Columna 2
            if ((tabla1[0, 1] == 'X') && (tabla1[1, 1] == 'X') && (tabla1[2, 1] == '-'))
            {
                devol.fila = 2;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[0, 1] == 'X') && (tabla1[2, 1] == 'X') && (tabla1[1, 1] == '-'))
            {
                devol.fila = 1;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[1, 1] == 'X') && (tabla1[2, 1] == 'X') && (tabla1[0, 1] == '-'))
            {
                devol.fila = 0;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            // Vertical Columna 3
            if ((tabla1[0, 2] == 'X') && (tabla1[1, 2] == 'X') && (tabla1[2, 2] == '-'))
            {
                devol.fila = 2;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[0, 2] == 'X') && (tabla1[2, 2] == 'X') && (tabla1[1, 2] == '-'))
            {
                devol.fila = 1;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;

            }
            if ((tabla1[1, 2] == 'X') && (tabla1[2, 2] == 'X') && (tabla1[0, 2] == '-'))
            {
                devol.fila = 0;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            // Diagonal 1
            if ((tabla1[0, 0] == 'X') && (tabla1[1, 1] == 'X') && (tabla1[2, 2] == '-'))
            {
                devol.fila = 2;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;

            }
            if ((tabla1[0, 0] == 'X') && (tabla1[2, 2] == 'X') && (tabla1[1, 1] == '-'))
            {
                devol.fila = 1;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;

            }
            if ((tabla1[1, 1] == 'X') && (tabla1[2, 2] == 'X') && (tabla1[0, 0] == '-'))
            {
                devol.fila = 0;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            // Diagonal 2
            if ((tabla1[0, 2] == 'X') && (tabla1[1, 1] == 'X') && (tabla1[2, 0] == '-'))
            {
                devol.fila = 2;
                devol.columna = 0;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[0, 0] == 'X') && (tabla1[2, 0] == 'X') && (tabla1[1, 1] == '-'))
            {
                devol.fila = 1;
                devol.columna = 1;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }

            if ((tabla1[1, 1] == 'X') && (tabla1[2, 0] == 'X') && (tabla1[0, 2] == '-'))
            {
                devol.fila = 0;
                devol.columna = 2;
                tabla1[devol.fila, devol.columna] = 'O';
                return devol;
            }
            return jugadaaleatoria();
        }
        /// <summary>
        /// Función que busca una posición aleatoria entre los espacios libre
        ///  para que juege la primera vez la máquina.
        /// </summary>
        /// <returns></returns>
        public devolucion jugadaaleatoria()
        {
            Random aleatorio = new Random();
            bool comprueba = false;

            while (!comprueba)
            {
                int fila = aleatorio.Next(0, 3);
                int columna = aleatorio.Next(0, 3);

                if (tabla1[fila, columna] == '-')
                {
                    tabla1[fila, columna] = 'O';
                    devol.fila = fila;
                    devol.columna = columna;
                    comprueba = true;
                }
            }
            return devol;
        }

        /// <summary>
        /// El movimiento máquina lo utilizamos para llamarlo desde 
        /// el form llamando y a la vez este llama a jugada ganadora y checkwinner
        /// </summary>
        public void movimientomaquina()
        {
            jugadaganadora();
            checkwinner();
        }
    }
}
