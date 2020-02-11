using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinymaxmasnombreconWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            double total = 0; //Resultado de la sumatoria
            int i = 0, max = 0, min = 200; //minimo debe ser más alto para comparar con los datos que entren
            string nombremax = "" , nombremin = "";
            
            Console.WriteLine("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());//Limite de datos

            while (i < n){ //Mientras n sea mayor que i

                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine()); //Ingrese edad

                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine(); //Ingrese nombre

                if (edad > max){//Condicional max

                    max = edad;
                    nombremax = nombre;
                }
                if (edad < min){//Condicional min

                    min = edad;
                    nombremin = nombre; 
                }

                total += edad;
                i++;
            }

            double promedio = total / n;
            Console.WriteLine("Promedio = " + promedio);
            Console.WriteLine("Mayor = " + max, "Nombre = " + nombremax);
            Console.WriteLine("Menor = " + min, "Nombre = " + nombremin);

        }
    }
}
