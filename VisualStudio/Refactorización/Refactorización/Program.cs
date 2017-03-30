using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactorización
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, num1, count; // Si tenemos mas una variable entera las declaramos a la vez.
            double resu;

            count = 2;
            num1 = 0;
            resu = 0;

            menu();// Llamada a la función Menú
            op = Convert.ToInt32(Console.ReadLine());
            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        resu = funcion1();
                        visualiza(resu);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("\nIntroduzca num1: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        visualiza(resu);
                        resu = funcion2(num1);
                        Console.ReadLine();
                        break;
                    case 3:
                        for (int i = 0; i < 3; i++)
                        {
                            //Creamos un bucle que multiplica incrementando el número  multiplicador cada vez que se repite el bucle.
                            resu = calculo(count);
                            count++;
                            visualiza(resu);
                        }
                        Console.ReadLine();
                        break;
                }
                menu();
                op = Convert.ToInt32(Console.ReadLine());
            }
        }

        static double funcion1()
        {
            double resu;
            resu = 3.1415 * 2;
            return (resu);
        }

        static int funcion2(int num1)
        {
            /*En lugar de tener varios if agrupamos en uno toda la condición de etrada*/
            if (num1 < 0 || num1 == 0 || num1 == 1 || num1 == 2 || num1 == 3 || num1 == 4 || num1 == 5 || num1 == 6 ||
                num1 == 7)
            {
                for (int i = 0; i < 5; i++)
                    num1 = num1 - i;
            }
            else
                cuadrado(num1);
            return (num1);
        }

        /*Creamos una función para multiplicar el número por dos y luego la llamamos desde la función 2*/
        static int cuadrado(int num1)
        {
            int cuadrado;
            cuadrado = (num1 * 2);
            return cuadrado;
        }
        //Ya quer tenemos un cáculo que se repite tres veces hacemos un bucle que incrementa el número por que el que multiplicamos tres veces y llamamos a la función.
        static double calculo(int count)
        {
            double resultado;
            resultado = (3.1415 * count - 1) / 3.1415;
            for (int i = 0; i < 1; i++)
            {
                resultado = (3.1415 * count - 1) / 3.1415;
                return resultado;
            }
            return resultado;
        }

        static void visualiza(double resu)
        {
            /*Ya que visualizamos varias veces en el resultado las mismas 
            lineas hacemos una fución y luego la llamamos al dar resultado.*/
            Console.WriteLine();
            Console.WriteLine("La visualización del resultado es");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Para ello tenemos que visualizar los valores");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Resu: {resu}");
        }

        static void menu()
        {
            //Podemos meter el menú en una función y luego llamarlo facilmente varias veces.
            Console.Clear();
            Console.WriteLine("1.- Funcion1");
            Console.WriteLine("2.- Funcion2");
            Console.WriteLine("3.- Resultado");
            Console.WriteLine("0.- Salir");
            Console.Write("Opción: ");
        }
    }
    
}
