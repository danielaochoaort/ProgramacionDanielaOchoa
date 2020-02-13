using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackejercicioparaentregar
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            //Variables

            int carta1 = aleatorio.Next(1, 11);
            int carta2 = aleatorio.Next(1, 11);


            //Valores cartas (salida)
            Console.WriteLine("Su primera carta fue: " + carta1);
            Console.WriteLine("Su segunda carta fue: " + carta2);

            //Varialble nueva carta y puntaje
            int ncarta;
            int total = carta1 + carta2;

            //Respuesta (entrada)
            string respuesta = "s";
            string mascarta = "s";

            //El total sea menor que 21

            while (respuesta == "s" && total < 21)
            {
                ncarta = aleatorio.Next(1, 11); //Nueva carta aleatoria
                Console.Write("¿Desea una nueva carta? (s/n): ");
                mascarta = Console.ReadLine();
                Console.WriteLine("Nueva carta: " + ncarta); //Salida nueva carta
                total += ncarta;
                Console.WriteLine("Total: " + total); //Salida total

                //Si el nuevo total sigue siendo menos o igual que 21
                if (mascarta =="S" && total <= 21 ){

                    Console.WriteLine("Nueva carta: " + ncarta); //Salida nueva carta
                    Console.WriteLine("Total: " + total); //Salida total
                    Console.Write("¿Desea una nueva carta? (s/n): ");
                    respuesta = Console.ReadLine();
                }
                if (total > 21) {
                    Console.WriteLine("Fin del juego");
                    mascarta = "n";
                }
            }
            Console.WriteLine("Gracias por participar");
        }

    } 
}  

