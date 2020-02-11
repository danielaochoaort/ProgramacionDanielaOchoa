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
            double total = 0;
            string respuesta = "s";

            int i = 0;

            while (respuesta == "s"){ //Mientras sea si

                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine()); //Ingrese edad
                total += edad; 

                Console.WriteLine("¿Existen más datos? (s/n)");
                respuesta = Console.ReadLine();
                i++;
            }

            double promedio = total / i;
            Console.WriteLine("Promedio = " + promedio);

        }
    }
}
