using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        public static double m { get; private set; }

        static void Main(string[] args)
        {

            //Ingreso de datos

            Console.WriteLine(" Ingrese los valores de y y los valores de z:");

            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            //Operaciones
            double a = (Math.Atan(y / z));

            double c = Math.PI - (Math.PI / 2) - a;
            double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));

            //Mostrar salida


            //Conversión de grados a radianes
            Console.WriteLine("El valor de a es: " + a * (180.0 / Math.PI));
            //Conversión de grados a radianes
            Console.WriteLine("El valor de c es: " + c * (180.0 / Math.PI));
            Console.WriteLine("El valor de t es:" + t);



        }
    }
}
