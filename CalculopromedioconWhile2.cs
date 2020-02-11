using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculopromedioconWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0; //Resultado de la sumatoria
            int i = 0; //Contador

            Console.WriteLine("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());

            while (i < n) { //Mientras n sea mayor que i

                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine()); //Ingrese edad
                total += edad;
                i++;
            }

            double promedio = total / n;
            Console.WriteLine("Promedio = " + promedio);
        }
    }
}
