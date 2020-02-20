using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackJuegoEntre2y5
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();

            //Respuesta (entrada)
            string mascarta = "s";


            Console.WriteLine("-----------------Bienvenido al juego----------------- ");
            Console.WriteLine("¿Deseas inciar? (s/n) ");

             string respuesta = Console.ReadLine();

            while (respuesta != "s") {

                if (respuesta == "n"){
                    Console.WriteLine("Gracias por participar");
                    break;
                }
                else { 
                  Console.WriteLine("\nError. Respuesta incorrecta. Solo permitido s/n");
                  Console.WriteLine("------------Por favor ingrese nuevamente los datos---------");
                    respuesta = (Console.ReadLine());
                }
            }



            while (respuesta == "s" && mascarta != "n") {

                Console.WriteLine("Ingrese el número de jugadores (mínimo 2 jugadores y máximo 5) ");
                int n = int.Parse(Console.ReadLine());


                while ((2 > n || n > 5)){

                    Console.WriteLine("\nError. Respuesta incorrecta. Solo permitido número de jugadores entre 2 y 5");
                    Console.WriteLine("------------Por favor ingrese nuevamente los datos---------");
                    n = int.Parse(Console.ReadLine());
                    
                }

                int carta1 = aleatorio.Next(1, 11);
                int carta2 = aleatorio.Next(1, 11);


                //Valores cartas (salida)
                Console.WriteLine("\nSu primera carta fue: " + carta1);
                Console.WriteLine("Su segunda carta fue: " + carta2);

                //Varialble nueva carta y puntaje
                int ncarta;
                int total = carta1 + carta2;

                Console.WriteLine("Total: " + total); //Salida total


                //El total sea menor que 21

                while (respuesta == "s" && mascarta== "s" && total < 21){

                    ncarta = aleatorio.Next(1, 11); //Nueva carta aleatoria
                    Console.Write("\n¿Desea una nueva carta? (s/n): ");
                    mascarta = Console.ReadLine();

                    while (mascarta != "s"){

                        if (mascarta == "n")
                        {
                            Console.WriteLine("\nGracias por participar");
                            Console.WriteLine("\nFin del juego");
                            break;
                        }
                            Console.WriteLine("\nError. Respuesta incorrecta. Solo permitido s/n");
                        Console.WriteLine("------------Por favor ingrese nuevamente los datos---------");
                        mascarta = (Console.ReadLine());
                        
                    }


                    while (mascarta == "s" && mascarta != "n" && total <= 21) { 
                    
                        
                        total += ncarta;


                        //Si el nuevo total sigue siendo menos o igual que 21
                        if (mascarta == "s" && mascarta != "n" && total < 21){

                            ncarta = aleatorio.Next(1, 11); //Nueva carta aleatoria
                            Console.WriteLine("\nNueva carta: " + ncarta); //Salida nueva carta
                            Console.WriteLine("Total: " + total); //Salida total
                            Console.Write("\n¿Desea una nueva carta? (s/n): ");
                            mascarta = Console.ReadLine();


                            while (mascarta != "s"){

                                if (mascarta == "n") {
                                    Console.WriteLine("\nGracias por participar");
                                    Console.WriteLine("\nFin del juego");
                                    break;
                                }
                                Console.WriteLine("\nError. Respuesta incorrecta. Solo permitido s/n");
                                Console.WriteLine("------------Por favor ingrese nuevamente los datos---------");
                                mascarta = (Console.ReadLine());

                            }
                        }

                        //Condición de ganar

                        if (total == 21){
                            Console.WriteLine("Total: " + total); //Salida total
                            Console.WriteLine("\nGANASTE");
                            mascarta = "n";
                        }

                        //Condición perder
                        if (total > 21)
                        {
                            Console.WriteLine("\nNueva carta: " + ncarta); //Salida nueva carta
                            Console.WriteLine("Total: " + total); //Salida total
                            Console.WriteLine("\n-----------------Te pasaste de 21----------------");

                            Console.WriteLine("\nFin del juego");
                            mascarta = "n";
                        }

                    }
                }

            }

            Console.WriteLine("Adiós");
        }
    }
}
