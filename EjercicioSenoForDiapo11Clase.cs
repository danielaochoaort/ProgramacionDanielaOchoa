using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSenoForDiapo11Clase
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 0.5;
            double seno = 0;

            
            for (int i = 0; i < 100; i++)
            {
                //Nombrar variable Factorial
                double faci = Factorial(i);
                //fórmula seno
                seno += ((Math.Pow(-1, i)) / (Factorial(2 * i + 1)) * Math.Pow(x, 2 *i + 1));
                
                //Salida seno
                Console.WriteLine("Seno: " + seno);

            }
        }
                //Creación de nuestra propia fórmula para el factorial
                static double Factorial(double smfactorial){

                         if (smfactorial <= 1) return 1;
                         return smfactorial * Factorial(smfactorial - 1);

        }

    }
}
