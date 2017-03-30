using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naves_final
{
    public class nave
    {
        public int x, y; // Ponemos todo público 
        public char caracter; //  para facilitarnos el 
        public char disparo; //  proceso
        public int finx, finy;
        public ConsoleColor colorActivo;
        public bool vivo;
        public bool direccion;
        internal static float forward;

        public nave(int x1, int y1, char car1, char disparo0, ConsoleColor color5)
        {
            x = x1;
            y = y1;
            caracter = car1;
            disparo = disparo0;
            colorActivo = color5;
            finx = 70;
            finy = 27;
            vivo = true;
            visualizar();
            direccion = false;

        }

        public void visualizar()
        {
            if (vivo == true)
            {
                Console.ForegroundColor = colorActivo;
                Console.SetCursorPosition(x - 1, y);
                Console.Write(caracter);
                Console.Write(caracter);
                Console.Write(caracter);
                Console.SetCursorPosition(x, y - 1);
                Console.Write(caracter);
            }
        }

        public void MoverInc(int incx, int incy)
        {
            borrar();
            x = x + incx;
            y = y + incy;
            if (x < 1 || y < 1 || x > finx || y > finy)
            {
                x = x - incx;
                y = y - incy;
            }
            visualizar();
        }


        public void borrar()
        {
            Console.SetCursorPosition(x, y - 1);
            Console.Write(' ');
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
            Console.SetCursorPosition(x - 1, y);
            Console.Write(' ');
            Console.SetCursorPosition(x + 1, y);
            Console.Write(' ');
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public bool comprueba
        {
            get { return vivo; }
            set { vivo = value; }
        }
       
    }
}
