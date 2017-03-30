using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace Practicar_Mover_Punto
{
    class Program
    {
        static void Main(string[] args)
        {
            int xi, yi, Comidagenerada = 1;
            int objetocomida, objetocomida2; 
            const int INC = 1;
            punto arroba, arrobanew, cuerpo;
            ConsoleKeyInfo car;



            Random comida = new Random(); //  creas el numero aleatorio para la primera comida creada

            objetocomida = comida.Next(1, 51); // Almacenamos el resultado aleatorio de ramdon en odjetocomida y objetocomida 2
            objetocomida2 = comida.Next(1, 21); /* Se hacen dos variables de objeto comida por que generamos cordenadas aleatorias */
                                                /* Y necesitamos el fin de x y el fin de Y */


            //for (int i = 0; i <= 1; i++) // Creamos el cuerpo  y le damos tamaño
            //{
                cuerpo = new punto(10 , 10, '*');//Coordenadas iniciales de la serpiente
               
           // }
            arroba = new punto(objetocomida, objetocomida2, '@'); // Crea la posición y la comida


           

            do
            {
                int movercomida = 0, movercomida2 = 0;
                Random AleatorioComida = new Random();
                movercomida = AleatorioComida.Next(-1, 1);
                movercomida2 = AleatorioComida.Next(-1, 1);
                //Random comidanueva = new Random(); //Generamos un Número aleatorio para el resto de la comidas que vamos a crear
                // int objetocomidarx, objetocomidary;
                // objetocomidarx = comidanueva.Next(1, 51);
                // objetocomidary = comidanueva.Next(1, 21);


                // Con el switch movemos el primer punto 


                car = Console.ReadKey(true);
                switch (car.Key)
                {
                    case ConsoleKey.DownArrow:
                       cuerpo.mover(0, INC);
                        arroba.mover(movercomida, movercomida2);
                        break;
                    case ConsoleKey.UpArrow:
                       cuerpo.mover(0,-INC);
                        arroba.mover(movercomida, movercomida2);
                        break;

                    case ConsoleKey.LeftArrow:
                        cuerpo.mover(-INC, 0);
                        arroba.mover(movercomida, movercomida2);
                        break;

                    case ConsoleKey.RightArrow:
                        cuerpo.mover(INC, 0);
                        arroba.mover(movercomida, movercomida2);
                        break;
                }


                
               
                if (cuerpo.x==arroba.x && cuerpo.y==arroba.y)
                { 
                    ; // Restamos el valor para que no creen dos comidas
                    Comidagenerada--;
                    while (Comidagenerada <1)
                    {
                        

                        arrobanew = new punto(objetocomida, objetocomida2, '@'); // creamos la comida aleatoria con el caracter arroba
                        Comidagenerada++;     
                        

                    }
                    //objetocomida = objetocomidarx; //Almacenamos el objetocomida las cordenadas aleatorias para igualarlas
                    //objetocomida2 = objetocomidary;
              }
                
            } while (car.Key != ConsoleKey.Escape);
        }
    }


    class punto
    {
        public int x, y;
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

       


        public void visualizar()
        {
            
            Console.SetCursorPosition(x, y);
            Console.Write(caracter);
        }

        public void borrar()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        public void mover(int incx, int incy)
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
        public int X
        {
            get { return x; }
            set { x = value; }
        }  // Para poder modificar y ver la X desde fuera
        public int Y
        {
            get { return y; }
            set { x = value; }
        } // Para poder modificar y ver la Y desde fuera
    }
}