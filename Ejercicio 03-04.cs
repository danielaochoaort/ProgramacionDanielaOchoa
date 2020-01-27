using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos

            Console.WriteLine(" Ingrese los valores de w:");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese los valores de d:");
            double dGrados = double.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese los valores de x:");
            double x = double.Parse(Console.ReadLine());


            // Conversión de grados a radianes

            double d = dGrados * (Math.PI / 180.0);

            //Operaciones

            double y =((w*Math.Cos(d)) - x);

            //Mostrar salida

            Console.WriteLine("El valor de y es: " + y);




        }
    }
}
