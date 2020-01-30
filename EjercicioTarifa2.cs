using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTarifa2
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
            // 5 smmlv = 4.389.015


            //Condicionales

            if (salario < 1755603){    //Menos de 2 smmlv

                Console.WriteLine("Su tarifa es: A");
                Console.WriteLine("Su cuaota moderadora es de: $3.400");
            }

            else if (1755603 <= salario && salario <= 4389014){  //2 smmlv y menos de 5 smmlv

                Console.WriteLine("Su tarifa es: B");
                Console.WriteLine("Su cuaota moderadora es de: $13.500");
            }

            else if (salario >= 4329015 ){   //5 smmlv o más

                Console.WriteLine("Su tarifa es: C");
                Console.WriteLine("Su cuaota moderadora es de: $35.600");
            }


            Console.WriteLine("Fin del programa");




        }
    }
}
