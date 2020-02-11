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
            int i = 0; //Contador (cuantos datos son)

            Console.WriteLine("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine()); //Límite de cantidad de datos (n)

            while (i < n) { //Mientras n sea mayor que contador

                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine()); //Ingrese edad
                total += edad;
                i++; //++ es igual a decir +=1
            }

            double promedio = total / n;
            Console.WriteLine("Promedio = " + promedio);
        }
    }
}
