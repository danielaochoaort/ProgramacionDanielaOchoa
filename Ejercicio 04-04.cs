using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04_04
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ingreso de datos

            Console.WriteLine(" Ingrese los valores de w:");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese los valores de t:");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese los valores de c:");
            double cGrados = double.Parse(Console.ReadLine());


            // Conversión de grados a radianes

            double c = cGrados * (Math.PI / 180.0);

            //Operaciones

            double a = Math.PI - (Math.PI / 2) - c;
            double z = t * Math.Sin(c);
            double d = Math.Asin(z / w);
            double b = Math.PI - (Math.PI / 2) - d - a;
            double y = t * Math.Sin(a);

            double x = ((w * Math.Sin(a + b)) - y);

            //Mostrar salida

            Console.WriteLine("El valor de x es: " + x);

        }
    }
}
