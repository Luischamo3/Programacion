using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naves_final
{
    class Program
    {
        static void Main(string[] args)
        {            
            Juego starJuego;
            starJuego = new Juego(20,25, '^', '*', ConsoleColor.White);
            starJuego.inicia();
        }
    }
}
