using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosDiferentesa1Diapo08Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int total = 0; //Puntos
            int turno = 0; 
            int cond10 = 0; //Condición de dado 10
            int dado = 0;

            string siguiente = "s";

            Console.WriteLine("-----------------INICIO DEL JUEGO-------------");

            while (siguiente =="s") {

                turno++;
                Console.WriteLine("(Turno: " + turno + ")");

                dado = aleatorio.Next(1, 13);
                Console.WriteLine("El valor del dado: " + dado);

                //Condición de 10 cumplida
                if (dado == 10) cond10 += 1;

                if (turno <= 3){ //Primeros 3 turnos

                    if (dado == 12 && cond10 == 1) { //Condición 12 y 10

                        Console.WriteLine("----------Ganaste la partida.----------");
                        Console.WriteLine("Total: " + total);
                        break;
                    } 
                        total += dado;
                        Console.WriteLine("Total: " + total);
                        Console.WriteLine("¿Deseas seguir (s/n)?");
                        if (Console.ReadLine() != "s") break;

                } else if (dado % 2 == 0){ //Números pares
                
                    total += dado;
                    Console.WriteLine("Total: " + total);

                    if (dado == 12 && cond10 == 1 || total >= 100){ //Condición 12-10 y más de 100

                        Console.WriteLine("----------Ganaste la partida.----------");
                        Console.WriteLine("Total: " + total);
                        break;
                    }
                        Console.WriteLine("¿Deseas seguir (s/n)?");
                        if (Console.ReadLine() != "s") break;
                }
                else{
                    total += dado;
                    Console.WriteLine("-------------Sacaste un dado con número impar. Termina el juego.---------");
                    break;
                }
            }
            Console.WriteLine("Total: " + total);
            Console.WriteLine("----------Fin del Juego------------");

        }
    }
}
