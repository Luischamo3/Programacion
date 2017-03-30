using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Examen
{
    class Program
    {
        struct Alumno
        {
            public int Num;
            public string nombre;
            public int n1;
            public int n2;
            public int n3;
            public int Media;

        }
        static void Main(string[] args)
        {
            int opcion = 0;
            const int N = 5;
            Alumno[] tabla1 = new Alumno[N];

            inicio(tabla1, N);

            do
            {
                Console.Clear();
                Console.WriteLine("\t|1- Altas          |");
                Console.WriteLine("\t|2- Calcular Media |");
                Console.WriteLine("\t|3- Listado        |");
                Console.WriteLine("\t|                  |");
                Console.WriteLine("\t|0- Salir          |");
                Console.WriteLine("\t|__________________|");
                Console.Write(" Eliga una opción: ");
                opcion = Comprobar();


                switch (opcion)
                {
                    case 1:
                       Altas(tabla1,N);
                        break;

                    case 2:
                       // Media(tabla1);
                        break;

                    case 3:
                       Listado(tabla1,N);
                        break;


                    default:
                        Console.Write("Introduzca un Número Válido");
                        break;
                }



            } while (opcion !=0);

        }
        static void inicio(Alumno[] tabla1, int N)
        {
            for (int i = 0; i < N; i++)
            {
                tabla1[i].Num = 0;
                tabla1[i].nombre = "";
                tabla1[i].n1 = 0;
                tabla1[i].n2 = 0;
                tabla1[i].n3 = 0;
                tabla1[i].Media = 0;
            }
            
        }

        static int Comprobar()  //Comprueba cualquier cosa que no sea string
        {
            int numero = 0;
            bool check = false;

            while (check == false || numero < 0)
                check = int.TryParse(Console.ReadLine(), out numero);


            if (check == false || numero < 0)
            {
                Console.Write("Valor no válido, introduzca un nuevo valor");
            }
            return (numero);
        }
             

            static int Buscar(Alumno[] tabla1, int numero, int N)
        {
            for (int i = 0; i < N; i++)
            {
                if (tabla1[i].Num == numero)
                    return (i);
            }
            return (-1);
        }



        static void Altas(Alumno[] tabla1, int N)
        {
            int posi = 0;


            for (int i = 0; i <N ; i++)
            {
                Console.Write("Introduzca Número: ");
                tabla1[i].Num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduzca Nombre: ");
                tabla1[i].nombre = Console.ReadLine();
                Console.Write("Introduzca Número1: ");
                tabla1[i].n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduzca Número2: ");
                tabla1[i].n2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduzca Número3: ");
                tabla1[i].n3 = Convert.ToInt32(Console.ReadLine());

            }
            
        }       

        //static void Media(Alumno[]tabla1) 
       // {
            //int N = 5;
            //int Media;

            ///Media= ( tabla1[N].n1 +); 
            
       // }

        static void Listado(Alumno[] tabla1 ,int N )      
        {
            
            Console.Clear();
            for (int i = 0; i < N; i++)
            {
                if (tabla1[i].Num != 0)
                    Console.WriteLine("{0}. {1}. {2}", tabla1[i].Num, tabla1[i].nombre,tabla1[i].n1, tabla1[i].n2,tabla1[i].n3, tabla1[i].Media);
                  
            }
            Console.Write("Pulse Enter para continuar...");
            Console.ReadLine();
        }
    }
}
