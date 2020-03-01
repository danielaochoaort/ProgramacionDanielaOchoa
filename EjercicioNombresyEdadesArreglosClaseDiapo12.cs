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
            //Ingrese cantidad n de datos
           Console.WriteLine("Ingrese el número de n datos que se tienen: ");
           int n = int.Parse(Console.ReadLine());

            //Variables entrada
            string [] nombres = new string[n];
            int [] edades = new int[n];
            double total = 0; //Para sacar promedio de edades
          
            //Arreglo edades
            Console.WriteLine("Ingrese las edades: ");
            for (int i = 0; i < edades.Length; i += 1) {

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                edades[i] = edad;
                total += edades[i];
            }
           
            //Arreglo nombres
            Console.WriteLine("Ingrese los nombres: ");
            for (int i = 0; i < nombres.Length; i += 1){

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                nombres[i] = nombre;
            }

            //Valores máximo y mínimo

            int max = 0;
            int min = 200;
            double min2 = 200;
            int indicemax = 0; //posición máx
            int indicemin = 0; //posición min
            int indicer = 0;   //posición cercano

            //Arreglo máximo
            for(int i = 0; i < edades.Length; i += 1){
                
                if (edades [i] > max){
                    max = edades[i];
                    indicemax = i; 
                } 
            }
            Console.WriteLine("El nombre es: "+nombres[indicemax] + " y la edad del mayor es:" + max);
            
            //Arreglo mínimo
            for (int i = 0; i < edades.Length; i += 1){

                if (edades[i] < min) {
                    min = edades[i];
                    indicemin = i;
                }
            }
            Console.WriteLine("El nombre es: " + nombres[indicemin] + " y la edad del menor es:" + min);

            //Promedio edades
            double promedio = total / edades.Length;
            Console.WriteLine("El promedio de las edades es: " + promedio);

            //Desviación
            double desviacion = Math.Sqrt(Math.Pow((total-promedio), 2)/n);
            Console.WriteLine("La desviación estandar es: " + desviacion);

            //Arreglo nombre con la edad más cercana al promedio
            for (int i = 0; i < edades.Length; i += 1){

                double cercano = Math.Sqrt(Math.Pow((edades[i]-promedio), 2));
                if (cercano <= min2) {
                    min2 = cercano;
                    indicer= i;
                }
            }
            Console.WriteLine("El nombre de la persona con la edad más cercana al promedio :" + nombres [indicer]);
        }
    }
}
