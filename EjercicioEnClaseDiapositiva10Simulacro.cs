using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEnClaseDiapositiva10Simulacro
{
    class Program
    {
        static void Main(string[] args)
        {


            Random aleatorio = new Random();

            //Variables

            int dado = 0;
            int vidas = 3;
            int total = 0; //Puntaje
            int jugador = 0;
            int turno = 0;
            int contador1s = 0;

            Console.WriteLine("¡¡¡¡¡¡¡¡¡¡¡¡¡¡Incio de juego!!!!!!!!!!!!!");

            Console.WriteLine("Desea seguir(s/n): ");
            string respuesta = Console.ReadLine();

            while (respuesta != "s" && respuesta != "n"){
                Console.WriteLine("Desea seguir(s/n): ");
                respuesta = Console.ReadLine();
            }

            //Ingrese cantidad de jugadores
            Console.WriteLine("Ingrese el número de jugadores ");
            int n = int.Parse(Console.ReadLine());

            while (jugador < n)  {

                Console.WriteLine("\nError. Respuesta incorrecta.");
                Console.WriteLine("------------Por favor ingrese nuevamente los datos---------");
                n = int.Parse(Console.ReadLine());

            }

            while (respuesta == "s")
            {

                turno++;
                Console.WriteLine("(Turno:  #" + turno + ")");


                //Vidas iniciales
                Console.WriteLine("CANTIDAD DE VIDAS : " + vidas);


                dado = aleatorio.Next(1, 13);
                Console.WriteLine("El valor del dado1 : " + dado);

                total += dado;
                Console.WriteLine("Total = " + total);

                
                //Condición de ganar 
                if (total >= 100)
                {

                    Console.WriteLine("-------------Ganaste el juego :P"+ (jugador+1) +"------------");
                    break;
                }

                //Condición de perder

                if (dado == 1)
                {
                    contador1s ++;

                } else
                {
                    contador1s = 0; //Consecutivos
                }

                //Condición de perder
                if (vidas == 0 || contador1s ==3)
                {

                    Console.WriteLine("------------Perdiste el juego :(" + +(jugador + 1) + "------------");
                    break;
                }


                //Condición de ni ganar ni de perder
                Console.WriteLine("Desea seguir(s/n): ");
                if (Console.ReadLine() == "n") break;

            }

            //Mostrar puntaje final
            Console.WriteLine("Jugador " +(jugador + 1) + "Tu total es de" + total + " puntos obtenidos");

            Console.WriteLine("------------Fin de la partida------------");

            jugador++;
        }
    }
}
