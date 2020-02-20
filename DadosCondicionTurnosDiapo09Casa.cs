using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosCondicionTurnosDiapo09Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            //Variables

            int dado1 = 0, dado2 = 0;
            int vidas = 3;
            int total = 0; //Puntaje
            double turno = 0;

            string siguiente = "s";
            Console.WriteLine("¡¡¡¡¡¡¡¡¡¡¡¡¡¡Incio de juego!!!!!!!!!!!!!");

            //Vidas iniciales
            Console.WriteLine("CANTIDAD DE VIDAS : " + vidas);

            while (siguiente == "s")
            {

                turno++;
                Console.WriteLine("(Turno:  #" + turno + ")");

                dado1 = aleatorio.Next(1, 13);
                Console.WriteLine("El valor del dado1 : " + dado1);

                total += dado1;
                Console.WriteLine("Total = " + total);

                //Cada dos turnos
                if (turno % 2 == 0)
                {

                    Console.WriteLine("------------Perdiste una vida :(------------");
                    vidas -= 1;
                    Console.WriteLine("VIDAS : " + vidas);
                }

                //Cada tres turnos
                if (turno % 3 == 0)
                {

                    dado2 = aleatorio.Next(1, 13);

                    Console.WriteLine("---------NUEVO DADO----------");
                    Console.WriteLine("Valor del dado2 :" + dado2);

                    total += (dado1 + dado2);
                    Console.WriteLine("Total = " + total);

                    //Dobles
                    if (dado1 == dado2)
                    {

                        Console.WriteLine("---Obtuviste un doble. Ganaste una vida!---");
                        vidas += 1;
                        Console.WriteLine("VIDAS: " + vidas);
                    }

                }
                //Condición de ganar 
                if (total > 100)
                {

                    Console.WriteLine("-------------Ganaste el juego :P------------");
                    break;
                }

                //Condición de perder
                if (vidas == 0)
                {

                    Console.WriteLine("------------Perdiste el juego :(------------");
                    break;
                }


                //Condición de ni ganar ni de perder
                Console.WriteLine("Desea seguir(s/n): ");
                if (Console.ReadLine() != "s") break;

            }

            //Mostrar puntaje final
            Console.WriteLine("Su total fue " + total + " puntos obtenidos");

            Console.WriteLine("------------Fin de la partida------------");





        }
    }
}
