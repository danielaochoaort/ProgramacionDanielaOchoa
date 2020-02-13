using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstudiado
{
    class Program
    {
        static void Main(string[] args)
        {


            Random aleatorio = new Random();


            //Variables

            int dado1 = 0, dado2 = 0;
            int dobles = 0;
            int total = 0; //Puntaje
            int cont = 0; //Turnos
            int contseis = 0; //Porcentaje de turnos

            //Respuesta (entrada)

            string siguiente = "s";
            Console.WriteLine("Incio de juego");

            //Los dados sean diferentes de 1 para seguir:
            while (siguiente == "s" && dado1 != 1 || dado2 != 1){

                dado1 = aleatorio.Next(1, 7); //Valor aleatorio entre 1-7
                dado2 = aleatorio.Next(1, 7);

                if (siguiente == "n") {
                    Console.WriteLine("Gracias por participar");
                    Console.WriteLine("Fin de la partida");
                    break;
                }
                else
                {
                    //Mostrar valores dados
                    Console.WriteLine("El valor del DADO 1 = " + dado1 + "  y el valor del DADO 2 = " + dado2);
                }
               

                if (dado1 == 1 && dado2 == 1){

                    total = 0; //Se pierde
                    Console.WriteLine("Perdiste. Fin del juego ");
                    siguiente = "n";
                }
                else{
                   //De lo contrario mostrar puntaje
                    total += (dado1 + dado2);
                    Console.WriteLine("Total = " + total);

                    //Dobles
                    if (dado1 == dado2) {
                        dobles += 1;
                    }
                    else {
                        dobles = 0;
                    }

                    //Suma entre dados superior a 6
                    if ((dado1 + dado2) > 6){

                        contseis += 1;
                    }

                    //Puntaje de 100 o 3 dobles para ganar
                    if (total >= 100 || dobles >= 3)
                    {

                        Console.WriteLine("Ganaste el juego");
                        siguiente = "n";
                    }
                    else {
                        Console.WriteLine("Desea seguir(s/n): ");
                        siguiente = Console.ReadLine();
                    }
                }
                cont += 1;
            }


            //Salidas

            //Mostrar puntaje final
            Console.WriteLine("Su total fue " + total + " puntos obtenidos");

            //Porcentaje

            double porcentaje = 100 * (((double)(contseis)) / cont);
            Console.WriteLine("El porcentaje de turnos donde consiguió más de fue de: " + porcentaje);

            Console.WriteLine("Fin de la partida");
        
        }

    }
}
