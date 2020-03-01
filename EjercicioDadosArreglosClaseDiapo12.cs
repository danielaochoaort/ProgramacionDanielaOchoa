using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDadosArreglosClaseDiapo12
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Ingrese el número de n datos que se tienen: ");
           int n = int.Parse(Console.ReadLine());

           
            string [] nombres = new string[n];
            int [] edades = new int[n];
            double total = 0;
           

            Console.WriteLine("Ingrese las edades: ");

            for (int i = 0; i < edades.Length; i += 1) {

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                edades[i] = edad;

                total += edades[i];
            }
            

            Console.WriteLine("Ingrese los nombres: ");

            for (int i = 0; i < nombres.Length; i += 1){

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                nombres[i] = nombre;
            }


            //Máximo

            int max = 0;
            int min = 200;
            double min2 = 200;
            int indicemax = 0;
            int indicemin = 0;
            int indicer = 0;
            double cercano = 0;

            for(int i = 0; i < edades.Length; i += 1){

                if (edades [i] > max){

                    max = edades[i];
                    indicemax = i;
                } 

            }
            Console.WriteLine("El nombre es: "+nombres[indicemax] + " y la edad del mayor es:" + max);

            for (int i = 0; i < edades.Length; i += 1){

                if (edades[i] < min)
                {

                    min = edades[i];
                    indicemin = i;
                }

            }
            Console.WriteLine("El nombre es: " + nombres[indicemin] + " y la edad del menor es:" + min);

            double promedio = total / edades.Length;

            Console.WriteLine("El promedio de las edades es: " + promedio);


            double desviacion = Math.Sqrt(Math.Pow((total-promedio), 2)/n);
            Console.WriteLine("La desviación estandar es: " + desviacion);


            for (int i = 0; i < edades.Length; i += 1){

                cercano = Math.Sqrt(Math.Pow((edades[i]-promedio), 2));
                if (cercano <= min2) {

                    min2 = cercano;
                    indicer= i;
                }

            }

            Console.WriteLine("El nombre de la persona con la edad más cercana al promedio :" + nombres [indicer]);
        }
    }
}
