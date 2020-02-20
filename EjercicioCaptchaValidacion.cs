using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCaptcha
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            //Variables

            int oportunidades = 3;

            string respuesta = "s";

            while (respuesta == "s"){
                Console.Write("-------------------Oportunidades = " + oportunidades + "-------------------");

                int a = aleatorio.Next(0, 10);
                int b = aleatorio.Next(0, 10);

                //Suma Correcta
                Console.WriteLine("\nA: " + a + "\nB: " + b);
                int sumaC = a + b;

                //Entrada Valor Suma
                Console.Write("\nIngrese la suma entre a y b: ");
                int suma = int.Parse(Console.ReadLine());


                while (sumaC != suma) { //ERROR

                    oportunidades--; //Menos una oportunidad


                    //Salida Mensaje Error
                    Console.WriteLine("\n----------Incorrecto. Perdiste una oportunidad------------");
                    Console.Write("Oportunidades = " + oportunidades);
                    Console.WriteLine("\nLa suma correcta era: " + sumaC);

                    Console.WriteLine("\n---------------------Intenta de nuevo---------------------");

                    //Nuevo Intento
                    a = aleatorio.Next(0, 10);
                    b = aleatorio.Next(0, 10);

                    Console.WriteLine("\nA: " + a + "\nB: " + b);
                    Console.WriteLine("\nIngresa la suma entre a y b: ");

                    //Operación
                    sumaC = a + b;
                    suma = int.Parse(Console.ReadLine()); //Entrada nuevo intento

                    //CondicionPerder

                    if (oportunidades == 1 && sumaC != suma)
                    {
                        Console.WriteLine("---------------------Se te acabaron las oportunidades---------------------");
                        Console.WriteLine("---------------------PERDISTE---------------------");
                        respuesta = "n";
                        break;
                    }

                }


                //Condición Seguir
                if (sumaC == suma)
                {
                    Console.WriteLine("\n------------------Lo lograste------------------");
                    Console.WriteLine("\nLa suma correcta era: " + sumaC);

                    Console.WriteLine("\n¿Deseas intentarlo otra vez (s/n)?");
                    if (Console.ReadLine() != "s") respuesta = "n";

                }else //De lo contrario
                {
                    Console.WriteLine("\n------------------FIN DEL JUEGO------------------");
                    respuesta = "n";
                }

            }
        }

    }
}