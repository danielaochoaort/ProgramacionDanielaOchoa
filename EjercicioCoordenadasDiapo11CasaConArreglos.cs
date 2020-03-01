using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCoordenadasDiapo11Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables coordenadas X y Y

            //posición        0, 1, 2, 3
            int[] coordsX = { 0, 2, 3, 7 };
            int[] coordsY = { 0, 1, 5, 6 };

            double[] pendiente = new double[3];
            double[] intercepto = new double[3];
            double[] distancia = new double[3];
            double mayor = 0;

            //Cálculo de pendientes (y-y1/x-x1)

           for (int i =0; i < pendiente.Length; i++){

                pendiente[i] = ((coordsY[i+1] - coordsY[i]) / (coordsX[i+1] - coordsX[i]));
           }


            bool colineales = true;
            //Arreglo colineales
            for (int i = 0; i < pendiente.Length; i++){

                if (pendientes [i] != pendientes[i + 1]){
                    colineales = false;
                    break;
                }
            }

            //Arreglo distancia mayor
            for (int i = 0; i < distancia.Length; i++){
                distancia = Math.Sqrt((coordsX[i+1] - coordsX[i]) * (coordsX[i+1] - coordsX[i]) + (coordsY[i+1] - coordsY[i]) * (coordsY[i+1] - coordsY[i]));

            }

            //Condición distancia mayor
            if (distancia[i] > mayor) mayor = distancia;
            Console.WriteLine("La distancia mayor es: " + mayor);
        }
    }
}
