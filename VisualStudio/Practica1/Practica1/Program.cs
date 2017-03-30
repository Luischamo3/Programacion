using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        struct Alu
        {
            public int Num;
            public string Nombre;
            public int Notas;

        }

        const int N = 5;
        
        static void Main(string[] args)
        {
            
            int opcion = 0;
            //int Numero=0;
            
            Alu[] tab1 = new Alu[N];
            Alu[] tab2 = new Alu[N];
            Alu[] tab3 = new Alu[tab1.Length+tab2.Length];

            Iniciar(tab1); //  tabla a cero

            do
            {
                Console.Clear();
                Console.WriteLine("-1--Altas");
                Console.WriteLine("-2--Bajas");
                Console.WriteLine("-3--Modificaciones");
                Console.WriteLine("-4--Consultas");
                Console.WriteLine("-5--Listado");
                Console.WriteLine("-6--Ordenar");
                Console.WriteLine("-7--BusquedaBinaria");
                Console.WriteLine("-8--Mezclar");
                Console.WriteLine("-0--Slir");
                Console.Write("Elija Una Opción del menú: ");
                opcion = Comprobar();

                switch (opcion)
                {
                    case 0:
                        Console.Write("Pulse Cualquier Tecla para salir..");
                        Console.ReadKey();
                        break;

                    case 1:
                        Altas(tab1);
                        RellenarTabla(tab2);
                        break;

                    case 2:
                        Bajas(tab1);
                        break;
                    case 3:
                        Modificaciones(tab1);
                        break;
                    case 4:
                        consultas(tab1);
                        break;

                    case 5:                      
                        Listado(tab1, tab2, tab3);
                        break;

                    case 6:
                        Ordenar(tab1);
                        Ordenar(tab2);
                        break;

                    case 7:
                         BusquedaBinaria(tab1);
                         //BusquedaBinaria(tab2);                     
                        break;

                    case 8:
                        Mezclar(tab1, tab2, tab3);
                        break;

                    default:
                        Console.Write("Ha Introducido un Número de Menú Incorrecto, Pulse Cualquier Tecla para volver a introducir una opción de Menú");
                        Console.ReadKey();
                        break;


                }

            } while (opcion != 0);

            Console.ReadLine();
        }
        //--------------------------------------------
        static void Iniciar(Alu[] tab1)  // Llamar la Tabla a cero
        {
            for (int i = 0; i < N; i++)
            {
                tab1[i].Num = 0;
                tab1[i].Nombre = "";
                tab1[i].Notas = 0;
            }
        }

        //------------------------------------------------------

     

        static void Ordenar(Alu[] tabla)
        {
            int fin = tabla.Length;
            int auxnumero,auxnota;
            string auxnombre;
            for (int i = 0; i < fin ; i++)
            {
               
                for (int j = fin - 1; j > i; j--)
                {
                    if (tabla[j - 1].Num > tabla[j].Num)
                    {
                        auxnumero = tabla[j - 1].Num;
                        tabla[j - 1].Num = tabla[j].Num;
                        tabla[j].Num = auxnumero;

                        auxnombre = tabla[j - 1].Nombre;
                        tabla[j - 1].Nombre = tabla[j].Nombre;
                        tabla[j].Nombre = auxnombre;

                        auxnota = tabla[j - 1].Notas;
                        tabla[j - 1].Notas = tabla[j].Notas;
                        tabla[j].Notas = auxnota;


                    }
                    
                }
            }
        }
//---------------------------------------------------------
        static void RellenarTabla (Alu[]tab2 ) // Esta función autorellena la tabla2
        {
            Random rnd = new Random();    // Número aleatorio para asignar valores a la tabla2        

            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i].Num = rnd.Next(0,20);
                tab2[i].Nombre = "Alumno " + i;
                tab2[i].Notas = rnd.Next(0,20);

            }

        }

        //---------------------------------------------------

        static int BusquedaBinaria(Alu[] tabla)
        {
            int Inicio = 0, Fin = tabla.Length-1, Medio = (Inicio + Fin) / 2;
            int Numero;
            Console.Clear();
            Console.WriteLine("Indique el numero que desea Buscar: ");
            Numero = Comprobar();

            while (tabla[Medio].Num != Numero && Inicio < Fin)
            {             
                    if (Numero > tabla[Medio].Num)
                    {
                        Inicio = Medio +1 ;
                        Medio = (Inicio + Fin) / 2;                                                                                   
                    }
                    else
                    {
                        Fin = Medio-1;
                        Medio = (Inicio + Fin) / 2;                                            
                                               
                    }
                    
                }
            if (tabla[Medio].Num == Numero)
            {
                Console.WriteLine($"Encontrado, Su valor está en la posición: {Medio} ");
                Console.WriteLine("|{0}.\t{1}.\t{2}:|", tabla[Medio].Num, tabla[Medio].Nombre, tabla[Medio].Notas);
                Console.ReadLine();
                return Medio;
            }
            else
            {
                Console.WriteLine("Número no encontrado en ninguna posición");
                Console.ReadLine();
                return -1;
                
            }
            
        }

        //-------------------------------------------------

        static void Mezclar(Alu[] tab1, Alu[] tab2, Alu[] tab3)
        {
            Ordenar(tab1);
            Ordenar(tab2);
            int i = 0, j = 0, k = 0;


            while ( i < tab1.Length && j < tab2.Length)
            {
                if (tab1[i].Num < tab2[j].Num)
                {
                    tab3[k].Num = tab1[i].Num;
                    tab3[k].Nombre = tab1[i].Nombre;
                    tab3[k].Notas = tab1[i].Notas;
                    k++;
                    i++;
                }
                else
                {
                    tab3[k].Num = tab2[j].Num;
                    tab3[k].Nombre = tab2[j].Nombre;
                    tab3[k].Notas = tab2[j].Notas;
                    k++;
                    j++;
                }
                
            } 
                if (j < tab2.Length)
                {
                    for (; j < tab2.Length; j++, k++)
                    {
                        tab3[k].Num = tab2[j].Num;
                        tab3[k].Nombre= tab2[j].Nombre;
                        tab3[k].Notas = tab2[j].Notas;
                    }
                }
                else
                {
                    for (; i < tab1.Length; i++, k++)
                    {
                        tab3[k].Num = tab1[i].Num;
                        tab3[k].Nombre = tab1[i].Nombre;
                        tab3[k].Nombre = tab1[i].Nombre;
                    }
                }
                Listado(tab1,tab2,tab3);
            
        }
        
        //---------------------------------------------------

        static int Comprobar()  //Comprueba cualquier cosa que no sea string
        {
            int numero = -1;
            bool check = false;

            while (check == false || numero < 0)
            {    check = int.TryParse(Console.ReadLine(), out numero);

                if (check == false || numero < 0)
                {
                Console.Write("Valor no válido, introduzca un número: ");
                }

            }
            return (numero);
            
         }
    

       
            static int Buscar(Alu[] tab1, int numero)
        {
            for (int i = 0; i < N; i++)
            {
                if (tab1[i].Num == numero)
                  return (i);

               
            }
            return (-1); // No está Repetida la posición
            
        }
        

        //-------------------------------------------------------

        static int consultas(Alu[] tab1)
        {
            int posi, numero;
            Console.Write("Introduzca el numero de alumno que quiere consular: ");
            numero = Comprobar();
            posi = Buscar(tab1, numero);

            
                if (posi >= 0)
                {
                Console.WriteLine("\t\t\tNumero-Nombre-Nota");
                Console.WriteLine("\t\t\t──────────────────");
                Console.Write("Los datos de alumno son: |{0}.| {1}. |{2}:|", tab1[posi].Num, tab1[posi].Nombre, tab1[posi].Notas);
                    Console.ReadKey();
                   
                    
                }
                else
                {
                    Console.Write("No se ha encontado ningún dato relacionado a este número");
                    Console.ReadLine();
                    
                }
                return (posi);
            
        }
        //----------------------------------------------------
        static void Altas(Alu[] tab)
        {
            int numero = 0, posi, posi2;
            Char cont = 'A' ;
            Console.Clear();

            Console.Write("Si dese dar de alta a un alumno pulse 'A'");
            while (cont == 'A')
            {
                Console.Write("\nIntroduzca el numero de la lista correspondiente al alumno: ");
                numero = Comprobar();   //Recogemos el Número y Llamamos a la función Busca
                posi = Buscar(tab, numero); //para ver si el número está repetido
                posi2 = Buscar(tab, 0); //Devuelve la posición donde encuentra un cero
                if (posi != -1) // si posi es disstinta a -1 quiere decir que busca nos ha devuleto la posición de un numero que está repetido y
                    // Muestra el error
                {
                    Console.Write("Numero Repetido,Introduzca Otro...Pulse una tecla para seguir dando de alta");
                    Console.ReadKey();
                    
                }

                if (posi == -1 && posi2 >= 0)
                {

                        tab[posi2].Num = numero;
                        Console.Write("Escriba el Nombre del Alumno: ");
                        tab[posi2].Nombre = Console.ReadLine();
                        Console.Write("Introduzca la nota del alumno: ");
                        tab[posi2].Notas = Comprobar();

                    Console.Write("\nSi desea volver al Menú Principal, pulse M, en caso de querer seguir dando de Alta, pulse A: ");
                    cont = Convert.ToChar(Console.ReadLine());
                    if (cont != 'A')
                        break;


                }
                else if (posi2==-1)
                {
                    Console.WriteLine("La tabla está llena !Se recomienda dar de baja un registro para poder introducir otro¡ .Pulse cualquier tecla para volver a menú...");
                    Console.ReadKey();
                    break;
                }

            }

        }
        //----------------------------------------------------------------------------------------------------
        static void Bajas(Alu[] tab)   //Finalizado
        {
            int posi;
            char cont = 'Y', cont2 = 'B';
            

            Console.Clear();    // se borre una vez, no cada vez que entre al bucle.

            while (cont2 == 'B')    //Mientras cont2 sea B, nos mantenemos, si es M, saldrá al Menú principal
            {
                posi = consultas(tab);        //Desde la función busca, viene la posición de la coincidencia en la variable posi.
                if (posi >= 0)                  //Si posi es una posición entra
                {
                    Console.Write("\nSi desea eliminar este registro pulse Y, en caso contrario pulse N:   ");
                    
                    cont = Convert.ToChar(Console.ReadLine());

                    while (cont != 'y' && cont != 'Y' && cont != 'n' && cont != 'N')
                    {
                        Console.Write("El valor introducido no es correcto. Solo se permite Y o N: ");
                        cont = Convert.ToChar(Console.ReadLine());
                    }



                    if (cont == 'Y')    //Ejecutamos la baja
                    {
                        tab[posi].Num = 0;
                        tab[posi].Nombre = "";
                        tab[posi].Notas = 0;
                        Console.Write("\nBaja realidaza correctamente.");

                        Console.Write("\nSi desea volver al Menú Principal, pulse M, en caso de querer seguir dando de Baja, pulse B: ");
                        cont2 = Convert.ToChar(Console.ReadLine());
                        while (cont2 != 'M' && cont2 != 'm' && cont2 != 'B' && cont2 != 'b')
                        {
                            Console.Write("El valor introducido no es correcto. Solo se permite Y o N: ");
                            cont2 = Convert.ToChar(Console.ReadLine());
                        }


                        if (cont2 == 'M')
                            break;
                    }
                    else if (cont == 'N')
                    {
                        Console.Write("\nSi desea volver al Menú Principal, pulse M, en caso de querer seguir dando de Baja, pulse B: ");
                        cont2 = Convert.ToChar(Console.ReadLine());
                        if (cont2 == 'M')
                            break;
                    }


                }


            }
        }
        static void Modificaciones(Alu[] tab)   //Finalizado
        {
            int posi;
            char cont = 'Y', cont2 = 'Y';   //La variable cont, maneja el bucle principal de modificación de registros, y la variable cont2 maneja el bucle interno de repetición de modificación de los campos.
            Console.Clear();
            while (cont == 'Y')     // Mientras cont, sea yes...
            {
                cont2 = 'Y';    //Esto es una asignación para que cuando se ejecute el bucle por segunda vez cont2 vuelva a ser Y, ya que antes se habrá cambiado a N.
                posi = consultas(tab);
                Console.Write("Introduzca el nombre modificado: ");
                tab[posi].Nombre = Console.ReadLine();
                Console.Write("\nIntroduzca la nota modificada: ");
                tab[posi].Notas = Convert.ToInt32(Console.ReadLine());

                while (cont2 == 'Y')    //Segundo bucle para repetición de campos
                {
                    Console.Write("\nSi desea volver a modificar otro dato de este registro, pulse Y, en caso contrario pulse N: ");
                    cont2 = Convert.ToChar(Console.ReadLine());
                    if (cont2 == 'N')
                        break;          //Este break sale del while interno, no del externo.
                    else if (cont2 == 'Y')
                    {
                        Console.Write("\nIntroduzca el nombre modificado: ");
                        tab[posi].Nombre = Console.ReadLine();
                        Console.Write("\nIntroduzca la nota modificada: ");
                        tab[posi].Notas = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("\nSi desea modificar otro registro, pulse Y, en caso contrario pulse N: ");
                cont = Convert.ToChar(Console.ReadLine());
            }
        }

        //------------------------------------------------------------------------------------------//
        static void Listado(Alu[] tab1,Alu []tab2,Alu[]tab3)      //Finalizado
        {
            Console.Clear();
            Console.WriteLine("-------Tabla1-----");
            Console.WriteLine("Numero\tNombre\tNota");
            Console.WriteLine("──────────────────┬");
            for (int i = 0; i < tab1.Length; i++)
            {     
                    
                    Console.WriteLine("|{0}.\t{1}.\t{2}:|", tab1[i].Num, tab1[i].Nombre, tab1[i].Notas);
                
            }
            Console.WriteLine("──────────────────┴");

            Console.WriteLine("------Tabla2-----");
            Console.WriteLine("Numero\tNombre\tNota");
            Console.WriteLine("──────────────────┬");
            for (int i = 0; i < tab2.Length; i++)
            {


                Console.WriteLine("|{0}.\t{1}.\t{2}:|", tab2[i].Num, tab2[i].Nombre, tab2[i].Notas);


            }
            Console.WriteLine("──────────────────┴");

            Console.WriteLine("------Tabla3-----");
            Console.WriteLine("Numero\tNombre\tNota");
            Console.WriteLine("──────────────────┬");
            for (int i = 0; i < tab1.Length+tab2.Length; i++)
            {
                
                Console.WriteLine("|{0}.\t{1}.\t{2}:|", tab3[i].Num, tab3[i].Nombre, tab3[i].Notas);

            }
            Console.WriteLine("──────────────────┴");

            Console.Write("Pulse Enter para continuar...");
            Console.ReadLine();
        }
    }
}





