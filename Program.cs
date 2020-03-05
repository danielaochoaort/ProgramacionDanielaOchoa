using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace EjercicioStringDiapo14Clase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la frase");
            string frase = Console.ReadLine();
            frase = frase.ToUpper(); //Convertir las palabras en Mayúscula

            Console.WriteLine("Ingrese la palabra a buscar");
            string  palabra = Console.ReadLine();
            palabra = palabra.ToUpper();

            int contpalabras = 0; //Contador
                            
                                             //hasta en contrar la palabra + 1
            for  (int i=0; i < frase.Length - palabra.Length +1; i++){

                string palabraencontrada = "";
                for (int j=0; j < palabra.Length; j++){

                    palabraencontrada += frase[i + j]; 
                }

                if (palabraencontrada == palabra){

                    Console.WriteLine("La palabra " + palabra + " encontrada en la posición " + i);
                    contpalabras++;
                    
                }
               
            }
        }
        Console.WriteLine("Cantidad de veces encontrada " + contpalabras);
    }
}
