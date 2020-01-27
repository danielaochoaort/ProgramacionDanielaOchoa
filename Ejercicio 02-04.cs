using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos

            Console.WriteLine(" Ingrese los valores de d:");
            double dGrados = double.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese los valores de b:");
            double bGrados = double.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese los valores de y:");
            double y = double.Parse(Console.ReadLine());


            // Conversión de grados a radianes

            double d = dGrados * (Math.PI / 180.0);
            double b = bGrados * (Math.PI / 180.0);

            //Operaciones

            double a = Math.PI - (Math.PI / 2) - d - b;

            double z = (y / Math.Tan(a));

            //Mostrar salida

            Console.WriteLine("El valor de z es: " + z);
        }

    }
}
