using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Naves_final
{
    public class Juego
    {
        public nave nave1, Enemy;

        public List<nave> enemigo;
        public int vida = 1;
        public int  score = 0;
        public bool salir = false;
        public string player;


        public const int INC = 1;
        
        public Juego(int x1, int y1, char car1, char disparo1, ConsoleColor color1)
        {
            Console.Write($"Introduzca su nombre de usuario: {player}");
            player = Console.ReadLine();
            Console.Clear();
            nave1 = new nave(x1, y1, car1, disparo1, color1);
            Enemy = new nave(x1, y1, car1, disparo1, color1);

            enemigo = new List<nave>();
            CrearEnemigo(); // Añade las naves a la lista

        }

        public void inicia()
        {
            Console.CursorVisible = false;
           
         ConsoleKeyInfo car;

            do
            {
                Console.SetCursorPosition(0, 27);
                Console.Write($"Jugador: {player}\tPuntuacion: {score}");

                if (Console.KeyAvailable)
                {
                    car = Console.ReadKey(true);                    
                    switch (car.Key)
                    {

                        case ConsoleKey.LeftArrow:
                            nave1.MoverInc(-2, 0);                         
                            break;

                        case ConsoleKey.RightArrow:
                            nave1.MoverInc(2, 0);                         
                            break;

                        case ConsoleKey.Spacebar:                          
                            Dispara();
                            ComprobarDisparo();

                            break;

                        case ConsoleKey.Escape:
                            salir = true;
                            break;

                    }
                }
                nave1.visualizar();
                Thread.Sleep(15);
                MoverEnemigo();

                if (vida < 1)
                {
                    nave1.borrar();
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.WriteLine(" Has Perdido Paquete  ");
                    
                    Console.ReadLine();
                    break;
                }
                if (score == 12)
                {
                    Console.Clear();                    
                    for (  int i = 0; i < 15; i++)
                    {
                        Thread.Sleep(10);
 
                    }
                    Console.SetCursorPosition(37, 15);
                    Console.WriteLine("█░█ ▄▀▀▄ █░░█ . █░░░█ ▀█▀ █▄░█");
                    Console.SetCursorPosition(37, 16);
                    Console.WriteLine("▀█▀ █░░█ █░░█ . █▄█▄█ ░█░ █▀██ ");
                    Console.SetCursorPosition(37, 17);
                    Console.WriteLine("░▀░ ░▀▀░ ░▀▀░ . ▀▀░▀▀ ▀▀▀ ▀░░");
                    
                    Console.Write($"Su puntuación es: {score} \nPulse Enter para continuar...");
                    Console.ReadLine();                 
                    salir = true;
                }
   
            } while (salir == false);

        }

        public void MoverEnemigo()
        {
            foreach (nave Enemy in enemigo)
                {
                  
                    Enemy.MoverInc(1, 0);
                   
                    if (Enemy.X == Enemy.finx)
                    {
                        Enemy.borrar();
                        Enemy.X = 1;
                        Enemy.Y = Enemy.y + 3;

                    }
                    if (Enemy.Y >= 25)
                    {
                        vida--;
                        break;
                    }
                   

                }
            
        }

        public  void CrearEnemigo()
        {
            int fila = 2, columna = 6;

            for (int i = 1; i <= fila; i++)
            {
                for (int j = 1; j <= columna; j++)
                {
                    Enemy = new nave(j*columna, 2*(i*fila), 'o', '*', ConsoleColor.Red);
                 enemigo.Add(Enemy);

                }
            }
        }

        public void Dispara()
        {
            for (int i = 25; i > 0; i--)
            {

                Console.SetCursorPosition(nave1.x, i);
                Thread.Sleep(5);
                Console.Write(nave1.disparo);
                
                Thread.Sleep(5);
                Console.SetCursorPosition(nave1.x, i);
                Console.Write(' ');

            }
        }

        public void ComprobarDisparo()
         {
            for (int i = enemigo.Count-1 ; i >= 0; i--)
            {
                nave Enemy2 = enemigo[i];
                if (nave1.X==Enemy2.X-1 || nave1.X == Enemy2.X ||nave1.X==Enemy2.X+1  )
                {
                    Enemy2.borrar();                    
                    enemigo.RemoveAt(i);
                    score++;
                    break;
                }
                
            }
         }

    }
}