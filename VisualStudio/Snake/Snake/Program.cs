using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Snake
{
    static class Program
    {
        const int INC = 1;
        static void Main(string[] args)
        {
            int xi, yi, xi2, yi2, tamañocuerpo = 4;
            
            punto arroba, cuerpo;
            arroba = crearComida();

            ConsoleKeyInfo car;


            List<punto>serpiente = new List<punto>();//creamos una lista a la clase punto


            for (int i = 0; i <= tamañocuerpo; i++) // Creamos el cuerpo  y le damos tamaño
            {
                cuerpo = new punto(10 - i, 10, '*');//Coordenadas iniciales de la serpiente
                serpiente.Add(cuerpo);
            }
            //arroba = new punto(aleatorio(3, 51), aleatorio(3, 21), '@'); // Crea la posición y la comida
            crearComida();


            do
            {


                xi = serpiente[0].X; //Posción x de la cabeza de la serpiente

                yi = serpiente[0].Y;// Posición y de la cabeza de la serpiente

                // Con el switch movemos el primer punto 

               

                car = Console.ReadKey(true);
                switch (car.Key)
                {
                    case ConsoleKey.DownArrow:
                        serpiente[0].mover(0, INC);
                        break;
                    case ConsoleKey.UpArrow:
                        serpiente[0].mover(0, -INC);
                        break;

                    case ConsoleKey.LeftArrow:
                        serpiente[0].mover(-INC, 0);
                        break;

                    case ConsoleKey.RightArrow:
                        serpiente[0].mover(INC, 0);
                        break;
                }

                // Con el for movemos el resto de cadena
                serpiente[serpiente.Count - 1].borrar();

                for (int i = 1; i < serpiente.Count(); i++) //Recorre la longitud de la lista
                {
                    xi2 = serpiente[i].X;
                    yi2 = serpiente[i].Y;

                    serpiente[i].mover(xi - serpiente[i].X, yi - serpiente[i].Y);

                    yi = yi2; // Contiene las posiciones modificadas que contienen el resto de los elementos que siguen a la cabeza
                    xi = xi2;
                }

                


                /*Comparamos coordenadas de la serpiente*/

                //Comidagenerada--; // Restamos el valor para que no creen dos comidas

                // {
                //(aleatorio(1,51) arroba);//Añade un punto encima de la posición donde estaba la comida


            } while (car.Key != ConsoleKey.Escape);

        }
        static punto crearComida()
        {
            punto arroba;

            arroba = new punto(aleatorio(3, 51), aleatorio(3, 21), '@');
            return (arroba);


        }

        static bool come(List<punto>serpiente )
        {

            if (serpiente.X comecoco.)


                return true;


            else

                return false;

        }
            static int aleatorio(int min, int max)
        {
            Random rnd = new Random();
            int resu;
            resu = rnd.Next(min, max + 1);
            return (resu);

            
        }

    }
    
}
