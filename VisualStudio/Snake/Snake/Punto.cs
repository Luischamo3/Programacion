using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class punto
    {
            private int  x, y;
            private char caracter;
            private int finx, finy;

            public punto(int x1, int y1, char car1)
            {
                x = x1;
                y = y1;
                caracter = car1;
                finx = 50;
                finy = 20;
                visualizar();
            }

            public void visualizar() //ver serpiente
            {
            
            Console.SetCursorPosition(x,y);
            Console.WriteLine(caracter);
            }

            public void borrar() //borrar puntos
            {
               Console.SetCursorPosition(x, y);
               Console.Write(' ');
            }

            public void mover(int incx, int incy) // mover la serpiente
            {
                borrar();
                x = x + incx;
                y = y + incy;
                if (x < 0 || y < 0 || x > finx || y > finy)
                {
                    x = x - incx;
                    y = y - incy;
                }
                visualizar();
            }
        public int X {
            get { return x; }
            set { x = value; }
        }  // Para poder modificar y ver la X desde fuera
        public int Y {
            get { return y; }
            set { x = value; }
        } // Para poder modificar y ver la Y desde fuera
       }
    }

