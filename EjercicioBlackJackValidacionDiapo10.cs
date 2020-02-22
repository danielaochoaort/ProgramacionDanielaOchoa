using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCasaDiapo10
{
    class Program{
        static void Main(string[] args){

            Random aleatorio = new Random();

            //Variables

            int jugador = 0;
            int carta1 = 0;
            int carta2 = 0;
            string mascarta = "";


            Console.WriteLine("¡¡¡¡¡¡¡¡¡¡¡¡¡¡Incio!!!!!!!!!!!!!");


            Console.WriteLine("Desea seguir(s/n): ");
            string respuesta = Console.ReadLine();

            while (respuesta != "s" && mascarta != "s") {
                Console.WriteLine("\nError. Respuesta incorrecta. Solo permitido s/n");
                Console.WriteLine("------------Por favor ingrese nuevamente los datos---------");
                respuesta = Console.ReadLine();
            }

            if (respuesta == "n") { 
                Console.WriteLine("Gracias por participar");
                Console.WriteLine("Fin");
            }

            while (respuesta =="s" && mascarta != "s" && mascarta !="n"){
                 
                //Validación de cantidad de jugadores.
                Console.WriteLine("\nIngrese el número de jugadores (mínimo 2 jugadores y máximo 5)");
                int n = int.Parse(Console.ReadLine());

                while (n < 2 || n > 5) {//Si es menor que 2 y mayor que 5

                    Console.WriteLine("\nError. Respuesta incorrecta.Solo permitido número de jugadores entre 2 y 5");
                    Console.WriteLine("------------Por favor ingrese nuevamente los datos---------");
                    n = int.Parse(Console.ReadLine());
                }

                while (jugador <n){

                    Console.WriteLine("\n-----------------Bienvenido al juego----------------- ");
                    Console.WriteLine("\n                 (Jugador #" + (jugador + 1) +")");


                    carta1 = aleatorio.Next(1, 11);
                    carta2 = aleatorio.Next(1, 11);

                    //Valores cartas (salida)
                    Console.WriteLine("\nSu primera carta fue: " + carta1);
                    Console.WriteLine("Su segunda carta fue: " + carta2);

                    //Varialble nueva carta y puntaje
                    int ncarta;
                    int total = carta1 + carta2;

                    Console.WriteLine("\nTotal: " + total); //Salida total

                    //Mientras el total sea menor que 21
                    while ((respuesta == "s" || mascarta == "s") && total < 21){

                        ncarta = aleatorio.Next(1, 11); //Nueva carta aleatoria
                        Console.Write("\n¿Desea una nueva carta? (s/n): ");
                        mascarta = Console.ReadLine();

                        total += ncarta;

                        //Validación respuesta más carta (s/n)
                        while (mascarta != "s" && mascarta != "n") {

                            Console.WriteLine("\n----------Error. Respuesta incorrecta. Solo permitido s/n------------");
                            Console.WriteLine("------------Por favor ingrese nuevamente los datos---------");
                            mascarta = Console.ReadLine();
                        }

                        if (mascarta == "n") {
                            mascarta = "n"; 
                            break;
                        }

                        Console.WriteLine("\nNueva carta: " + ncarta); //Salida nueva carta
                        Console.WriteLine("Total: " + total); //Salida total

                        //Condición de ganar

                        if (total == 21){

                            Console.WriteLine("\n        ¡GANASTE!");
                            break;
                        }

                        //Condición de perder

                        if (total > 21){

                            Console.WriteLine("\n     ¡Te pasaste de 21!");
                            Console.WriteLine("        Fin del juego");
                            break;
                        }

                        if (respuesta == "n") break;

                    }

                    jugador++;
                    Console.WriteLine("\nGracias por participar jugador #" + jugador);
                }
            }
        } 
    }
}

