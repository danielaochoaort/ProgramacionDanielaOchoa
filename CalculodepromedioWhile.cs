using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculodepromedioWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0; //Total de la sumatoria
            string respuesta = "s";//Primera vez

            int i = 0; //Contador de cuántas veces entran en el ciclo while

            while (respuesta == "s"){ //Mientras sea si

                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine()); //Ingrese edad
                total += edad; //Acumular cada edad nueva que entra

                Console.WriteLine("¿Existen más datos? (s/n)");
                respuesta = Console.ReadLine();
                i++;//Se le suma +1 al contador
            }

            double promedio = total / i;
            Console.WriteLine("Promedio = " + promedio);

        }
    }
}
