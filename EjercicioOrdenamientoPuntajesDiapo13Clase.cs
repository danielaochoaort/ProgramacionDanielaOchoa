using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOrdenamientoPuntajesDiapo13Clase
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


            Console.WriteLine("\nIngrese la cantidad de datos a ingresar");
            int n = int.Parse(Console.ReadLine());

            int[] puntajes = new int[n];
            string[] nombres = new string[n];

            //Arreglo nombres
            for (int i = 0; i < n; i++) {

                respuesta = "s";
                Console.WriteLine("\nIngrese el nombre del jugador");
                nombres[i] = Console.ReadLine();
            
               
                Console.WriteLine("\n-----------------Bienvenido al juego----------------- ");
                Console.WriteLine("\n                 (Jugador " + (i + 1) + " Nombre: " + nombres[i] +")");


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
                while (total < 21)
                {

                    Console.Write("\n¿Desea una nueva carta? (s/n): ");
                    mascarta = Console.ReadLine();
                    if (mascarta == "n")
                    {
                        break;
                    }

                    ncarta = aleatorio.Next(1, 11); //Nueva carta aleatoria
                    total += ncarta;

                    Console.WriteLine("\nNueva carta: " + ncarta); //Salida nueva carta
                    Console.WriteLine("Total: " + total); //Salida total

                    //Condición de ganar
                    if (total == 21)
                    {

                        Console.WriteLine("\n        ¡GANASTE!");
                        break;
                    }

                    //Condición de perder
                    if (total > 21)
                    {

                        Console.WriteLine("\n     ¡Te pasaste de 21!");
                        Console.WriteLine("        Fin del juego");
                        total = 0;
                        Console.WriteLine("Total: " + total);
                        break;
                    }
                }
                puntajes[i] = total;
            }

            //Ordenamiento puntajes de mayor a menor 

            // puntajes.Legth - 1 (comparación), el término 5 no se compara con nadie 

            for (int k = 0; k < puntajes.Length - 1; k++) {

                for (int i = 0; i < puntajes.Length - 1; i++)
                {
                    if (puntajes[i] < puntajes[i + 1]) {

                        //tmp puntajes
                        int tmp = puntajes[i];
                        puntajes[i] = puntajes[i + 1];
                        puntajes[i + 1] = tmp;

                        //tmp2 nombres
                        string tmp2 = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = tmp2;
                    }
                }
            }
            
            //Salida de puntajes y nombres

            for (int d = 0; d < puntajes.Length; d++){

                Console.WriteLine("Nombre: " + nombres[d] + " con un puntaje de: " + puntajes[d]);
            }

        }
    }
}
