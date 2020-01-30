using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos

            Console.WriteLine(" Ingrese su salario:");
            double salario = double.Parse(Console.ReadLine());


            // 1 smmlv= 877.803
            // 2 smmlv = 1.755.603
            // 3 smmlv = 2.633.403
            // 4 smmlv = 3.511.212


            //Condicionales

            if (salario < 1755603) {  //Menos de 2 smmlv

                Console.WriteLine("Su tarifa es: A");
            }

            else if (1755603 <= salario && salario <= 3511211) {  //2 o más  y menos de 4 smmlv

                Console.WriteLine("Su tarifa es: B");
            }

            else if (salario >= 3511212) {   //4 smmlv o más

                Console.WriteLine("Su tarifa es: C");
            }


            Console.WriteLine("Fin del programa");
        }
    }
}
