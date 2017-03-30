 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_menú
{
    class Program
    {   

        struct alumno
        {
            public int Num;
            public string Nombre;
            public int Nota;
        }

        const int N = 5;

        static void Main(string[] args)
        {
            
            int opcion = 0;
            alumno[] tabla = new alumno[N];

            Inicializar(tabla); // Función para poner todo a cero, antes del do while, para no perder todo cada vez que mostremos menú

            do
            {
                Console.Clear();
                Console.WriteLine("\t|─────────MENÚ──────────|");
                Console.WriteLine("\t─────────────────────────");
                Console.WriteLine("\t|1.- Altas\t\t|");
                Console.WriteLine("\t|2.- Bajas\t\t|");
                Console.WriteLine("\t|3.- Modificaciones\t|");
                Console.WriteLine("\t|4.- Consultas\t\t|");
                Console.WriteLine("\t|5.- Listado\t\t|");
                Console.WriteLine("\t|6.- Ordenar\t\t|");
                Console.WriteLine("\t|7.- Búsqueda Binaria\t|");
                Console.WriteLine("\t|8.- Mezclar\t\t|");
                Console.WriteLine("\t|0.- Salir\t\t|");
                Console.WriteLine("\t─────────────────────────");
                Console.Write("\nElija una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Altas(tabla);
                        break;
                    case 2:
                        Bajas(tabla);
                        break;
                    case 3:
                        Modificaciones(tabla);
                        break;
                    case 4:
                        Console.Clear();
                        Consultas(tabla);
                        Console.Write("\nPresione Enter para continuar...");
                        Console.ReadLine();
                        break;
                    case 5:
                        Listado(tabla);
                        break;
                    case 6:
                    //Ordenar();
                    //break;
                    case 7:
                    //Busquedabinaria();
                    //break;
                    case 8:
                    //Mezclar();
                    //break;
                    case 0:
                    //Salir();
                        break;
                }

            } while (opcion != 0);

            Console.ReadLine();
        }

//------------------------------------------------------------------------------------------//
        static void Inicializar(alumno[] tabla)     // Finalizado
        {
            for (int i = 0; i < N; i++)
            {
                tabla[i].Num = 0;
                tabla[i].Nombre = "";
                tabla[i].Nota = 0;
            }
        }
//------------------------------------------------------------------------------------------//
        static int BuscaAltas(alumno[] tabla, int numero)    //Finalizado
        {
            for (int i = 0; i < N; i++)
            {
                if (tabla[i].Num == numero)     //Comparamos el valor de la tabla con el número introducido por el usuario. Si coincide retornamos la posición, si no retornamos -1.
                {
                    Console.Write("El número de lista {0} ya está almacenado, en la posición {1}. Introduzca otro número de lista.", numero, i);
                    return (i);
                }
            }
            return (-1);
        }
//------------------------------------------------------------------------------------------//
        static int Busca2(alumno[] tabla)       //Finalizado
        {
            for (int i = 0; i < N; i++)
            {
                if (tabla[i].Num == 0)      //Comparamos el valor de la tabla con el número 0, buscando un espacio para escribir. Y escribiremos en la posición i que retornamos. Si retorna -1 daremos error.
                    return (i);
            }
            return (-1);
        }
//------------------------------------------------------------------------------------------//
        static int Busca(alumno[] tabla, int numero)    //Finalizado
        {
            for (int i = 0; i < N; i++)
            {
                if (tabla[i].Num == numero)
                    return (i);
            }
            return (-1);
        }
//------------------------------------------------------------------------------------------//
        static int Consultas(alumno[] tabla)
        {

            int posi, numero;
            Console.Write("Introduzca el número que quiera consultar: ");
            numero = Convert.ToInt32(Console.ReadLine());
            posi = Busca(tabla, numero);
            if (posi >= 0)
                Console.Write("Los datos son: {0}. {1}. {2}", tabla[posi].Num, tabla[posi].Nombre, tabla[posi].Nota);
            else
                Console.Write("Dato no encontrado.");
            return (posi);
        }
//------------------------------------------------------------------------------------------//
        static void Altas(alumno[] tabla)       //Finalizado
        {
            int numero = 0, posi, posi2;
            char cont = 'Y';
            Console.Clear();

            while (cont == 'Y')     //Bucle para salir de Altas.
            {
                Console.Write("\nIntroduzca número de lista del alumno: ");
                numero = Convert.ToInt32(Console.ReadLine()); //Recogemos número y mandamos a la función Busca para que compare.
                posi = BuscaAltas(tabla, numero); //Con BuscaAltas buscamos un número repetido, y devolverá -1 en la variable posi si el número NO está repetido.
                posi2 = Busca2(tabla);  //Con Busca2 buscamos un espacio para escribir y lo guardamos en la variable posi2.

                if (posi == -1 && posi2 >= 0)   //Si posi es -1 es que no hay repetición de número, y si posi2 es mayor o igual que cero es que tenemos posición para escribir.
                {
                    tabla[posi2].Num = numero;  //Guardamos en el espacio de la tabla que está dentro de posi2 el número que está en la variable numero.
                    Console.Write("Introduzca el nombre del alumno: ");
                    tabla[posi2].Nombre = Console.ReadLine();
                    Console.Write("Introduzca la nota del alumno: ");
                    tabla[posi2].Nota = Convert.ToInt32(Console.ReadLine());

                    //Si no quiere seguir introduciendo va a cambiar cont a No, y va a salir del for y por lo tanto salir de la función.
                    Console.Write("Si quiere seguir dando de alta a más alumnos escriba Y, en caso contrario escriba N: ");
                    cont = Convert.ToChar(Console.ReadLine());
                    if (cont == 'N')
                        break;

                }
                else if (posi2 == -1)
                    Console.Write("La tabla está llena");
            }
        }
//------------------------------------------------------------------------------------------//
        static void Bajas(alumno[] tabla)       //Finalizado
        {
            int posi;
            char cont = 'Y', cont2 = 'B';

            Console.Clear();    //Colocamos aquí para que solo se borre una vez, no cada vez que entre al bucle.
            while (cont2 == 'B')    //Mientras cont2 sea B, nos mantenemos, si es M, saldrá al Menú principal
            {
                posi = Consultas(tabla);        //Desde la función busca, viene la posición de la coincidencia en la variable posi.
                if (posi >= 0)                  //Si posi es una posición entra
                {
                    Console.Write("\nSi desea eliminar este registro pulse Y, en caso contrario pulse N: ");
                    cont = Convert.ToChar(Console.ReadLine());
                    if (cont == 'Y')    //Ejecutamos la baja
                    {
                        tabla[posi].Num = 0;
                        tabla[posi].Nombre = "";
                        tabla[posi].Nota = 0;
                        Console.Write("\nBaja realidaza correctamente.");

                        Console.Write("\nSi desea volver al Menú Principal, pulse M, en caso de querer seguir dando de Baja, pulse B: ");
                        cont2 = Convert.ToChar(Console.ReadLine());
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
//------------------------------------------------------------------------------------------//
        static void Modificaciones(alumno[]tabla)   //Finalizado
        {
            int posi;
            char cont = 'Y', cont2 = 'Y';   //La variable cont, maneja el bucle principal de modificación de registros, y la variable cont2 maneja el bucle interno de repetición de modificación de los campos.
            Console.Clear();
            while (cont == 'Y')     // Mientras cont, sea yes...
            {
                cont2 = 'Y';    //Esto es una asignación para que cuando se ejecute el bucle por segunda vez cont2 vuelva a ser Y, ya que antes se habrá cambiado a N.
                posi = Consultas(tabla);
                Console.Write("Introduzca el nombre modificado: ");
                tabla[posi].Nombre = Console.ReadLine();
                Console.Write("\nIntroduzca la nota modificada: ");
                tabla[posi].Nota = Convert.ToInt32(Console.ReadLine());

                while (cont2 == 'Y')    //Segundo bucle para repetición de campos
                {
                    Console.Write("\nSi desea volver a modificar otro dato de este registro, pulse Y, en caso contrario pulse N: ");
                    cont2 = Convert.ToChar(Console.ReadLine());
                    if (cont2 == 'N')
                        break;          //Este break sale del while interno, no del externo.
                    else if (cont2 == 'Y')
                    {
                        Console.Write("\nIntroduzca el nombre modificado: ");
                        tabla[posi].Nombre = Console.ReadLine();
                        Console.Write("\nIntroduzca la nota modificada: ");
                        tabla[posi].Nota = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("\nSi desea modificar otro registro, pulse Y, en caso contrario pulse N: ");
                cont = Convert.ToChar(Console.ReadLine());
            }    
        }
//------------------------------------------------------------------------------------------//
        static void Listado(alumno[]tabla)      //Finalizado
        {
            Console.Clear();
            for (int i = 0; i < N; i++)
            {
                if (tabla[i].Num != 0)
                    Console.WriteLine("{0}. {1}. {2}",tabla[i].Num, tabla[i].Nombre, tabla[i].Nota);
            }
            Console.Write("Pulse Enter para continuar...");
            Console.ReadLine();
        }
//------------------------------------------------------------------------------------------//
    }
}
