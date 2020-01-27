using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos

            Console.WriteLine(" Ingrese los valores de b:");
            double bGrados = double.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese los valores de z:");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese los valores de y:");
            double y = double.Parse(Console.ReadLine());


            // Conversión de grados a radianes

            double b = bGrados * (Math.PI / 180.0);

            //Operaciones

            double a = Math.Atan(y / z);
            double d = Math.PI - (Math.PI / 2) - (a+b);

            double x = ((z / Math.Tan(d)) - y);

            //Mostrar salida

            Console.WriteLine("El valor de x es: " + x);

        }
    }
}
