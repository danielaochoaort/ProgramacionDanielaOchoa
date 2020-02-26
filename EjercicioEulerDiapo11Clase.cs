using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEulerDiapo11Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            //entradas
            int x = 3;
            double euler= 0;

            
            for (int i = 0; i < 100; i++)
            {
                //Nombre de la variable factorial
                double faci = Factorial(i);
                
                //fórmula de euler
                euler += (Math.Pow(x, i) / Factorial(i));
                
                //Salida valor de euler
                Console.WriteLine("Euler: " + euler);
                
            }
        
        }   //Creación de nuestra propia fórmula para el factorial

            static double Factorial(double smfactorial) {
                
                if (smfactorial <= 1) return 1;
                return smfactorial * Factorial(smfactorial- 1);

        }
    }
}

