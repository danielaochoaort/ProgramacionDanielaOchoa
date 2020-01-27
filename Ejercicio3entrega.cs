using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicioclase3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos

            Console.WriteLine(" Ingrese los valores de c y los valores de z:");

            double cGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            //Conversión de grados a radianes

            double c = cGrados * (Math.PI / 180.0);

            //Operaciones
            double a = Math.PI - (Math.PI / 2) - c;
            double t = z / Math.Sin(c);
            double y = t * Math.Cos(c);
            
            //Mostrar salida


            //Conversión de grados a radianes
            Console.WriteLine("El valor del ángulo de a es: " + a * (180.0 / Math.PI));
           
            Console.WriteLine("El valor del lado t es:" + t);
            Console.WriteLine("El valor del lado y es:" + y);


        }
    }
}
