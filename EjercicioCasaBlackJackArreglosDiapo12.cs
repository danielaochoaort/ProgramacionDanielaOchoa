using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBlackJackArreglosDiapo12Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            //Variables
            string mascarta = "";

            //Inicio programa
            Console.WriteLine("¡¡¡¡¡¡¡¡¡¡¡¡¡¡Incio!!!!!!!!!!!!!");


            Console.WriteLine("Desea seguir(s/n): ");
            string respuesta = Console.ReadLine();

            
            Console.WriteLine("\nIngrese el número de jugadores (mínimo 2 jugadores y máximo 5)");
            int n = int.Parse(Console.ReadLine());

            //Arreglo puntajes

            int[] puntajes = new int[n];

            
            for (int i = 0; i < puntajes.Length; i++) {

               Console.WriteLine("\n-----------------Bienvenido al juego----------------- ");
               Console.WriteLine("\n                 (Jugador " + (i + 1) + ")");


               int carta1 = aleatorio.Next(1, 11);
               int carta2 = aleatorio.Next(1, 11);

               //Valores primeras cartas (salida)
               Console.WriteLine("\nSu primera carta fue: " + carta1);
               Console.WriteLine("Su segunda carta fue: " + carta2);

               //Varialble nueva carta y puntaje
                 int ncarta;
                 int total = carta1 + carta2;

                 Console.WriteLine("\nTotal: " + total); //Salida total

                 //Mientras el total sea menor que 21
                 while ( total < 21) {

                        Console.Write("\n¿Desea una nueva carta? (s/n): ");
                        mascarta = Console.ReadLine();
                        if (mascarta == "n"){
                            break;
                        }

                        ncarta = aleatorio.Next(1, 11); //Nueva carta aleatoria
                        total += ncarta;

                        Console.WriteLine("\nNueva carta: " + ncarta); //Salida nueva carta
                        Console.WriteLine("Total: " + total); //Salida total

                        //Condición de ganar
                        if (total == 21) {

                            Console.WriteLine("\n        ¡GANASTE!");
                            break;
                        }

                        //Condición de perder
                        if (total > 21) {

                            Console.WriteLine("\n     ¡Te pasaste de 21!");
                            Console.WriteLine("        Fin del juego");
                            total = 0;
                            Console.WriteLine("Total: " + total);
                            break;
                        }
                 }
                 puntajes[i] = total;
            }

            //Variables máx y min
            int max = 0;
            int max2 = 0;
            int indmax = 0;
            int indmax2 = 0;
           
            //Arreglo puntaje máximo
           for (int i = 0; i < puntajes.Length; i++) {
                if (puntajes[i] > max) {

                    max = puntajes[i];
                    indmax = i;
                }
           }
            //Arreglo segundo puesto
            for (int j = 0; j < puntajes.Length; j++){
                
                if (puntajes[j] > max2 && puntajes[j] < max){

                    max2 = puntajes[j];
                    indmax2 =j;
                }
            }
                Console.WriteLine("\n                                  FINAL FINAL FINAL");
                Console.WriteLine("\n              #1 Puesto. Jugador # " + (indmax + 1) + " con un puntaje de: " + puntajes [indmax]);
                Console.WriteLine("\n              #2 Puesto. Jugador # " + (indmax2 + 1) + " con un puntaje de: " + puntajes[indmax2]);
        }
    } 
}
