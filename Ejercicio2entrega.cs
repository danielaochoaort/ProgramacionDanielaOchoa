using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicioclase
{
    class Program
    {
        static void Main(string[] args)

        {

            //Ingreso de datos

            Console.WriteLine(" Ingrese los valores de t y los valores de a:");

            double t = double.Parse(Console.ReadLine());
            double aGrados = double.Parse(Console.ReadLine());

            //Conversión de grados a radianes

            double a = aGrados * (Math.PI / 180.0);

            //Operaciones

            double c = Math.PI - (Math.PI / 2) - a;
            double y = t * Math.Sin(a);

            double z = t * Math.Sin(c);
            //Mostrar salida

            Console.WriteLine("El valor de c es: " + c * (180.0 / Math.PI));
            Console.WriteLine("El valor de y es: " + y);

            Console.WriteLine("El valor de z es:" + z);

            
        }
    }
}
