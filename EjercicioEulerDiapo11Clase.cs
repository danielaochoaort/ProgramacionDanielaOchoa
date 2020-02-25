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
            int x = 3;
            double euler= 0;

            for (int i = 0; i < 100; i++)
            {
                double faci = Factorial(i);
                
                euler += (Math.Pow(x, i) / Factorial(i));
                Console.WriteLine("Euler: " + euler);
                
            }
        
        }

        static double Factorial(double smfactorial) {

            if (smfactorial <= 1) return 1;
            return smfactorial * Factorial(smfactorial- 1);

        }
    }
}

