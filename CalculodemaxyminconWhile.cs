using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculodemaxyminconWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0; //Resultado de la sumatoria
            int i = 0, max = 0, min = 200;

            Console.WriteLine("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());

            while (i < n) { //Mientras n sea mayor que i

                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine()); //Ingrese edad

                if (edad > max) max = edad;
                if (edad < min) min = edad;

                total += edad;
                i++;
            }

            double promedio = total / n;
            Console.WriteLine("Promedio = " + promedio);
            Console.WriteLine("Mayor = " + max);
            Console.WriteLine("Menor = " + min);


        }
    }
}
