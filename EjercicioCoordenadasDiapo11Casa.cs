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
           
            double mayor = 0;

            //Cálculo de pendientes (y-y1/x-x1)

            //1-0/2-0  
            double pendiente = ((coordsY[1] - coordsY[0]) / (coordsX[1] - coordsX[0]));
            //5-1/3-2
            double pendiente1 = ((coordsY[2] - coordsY[1]) / (coordsX[2] - coordsX[1]));
            //6-5/7-3
            double pendiente2 = ((coordsY[3] - coordsY[2]) / (coordsX[3] - coordsX[2]));


            //Cálculo intercepto


            double intercepto = (coordsY[1] - (pendiente * coordsX[1]));
            double intercepto1 = (coordsY[2] - (pendiente1 * coordsX[2]));
            double intercepto2 = (coordsY[3] - (pendiente2 * coordsX[3]));


            //Condiciones 
            if ((intercepto == intercepto1 && pendiente == pendiente1) && (intercepto1 == intercepto2 && pendiente1 == pendiente2)){

                Console.WriteLine("Si pertenecen a la misma recta");
            }
            else{
                Console.WriteLine("No pertenencen a la misma recta");
            }

            //Cálculo distancias
            double distancia = Math.Sqrt((coordsX[1] - coordsX[0]) * (coordsX[1] - coordsX[0]) + (coordsY[1] - coordsY[0]) * (coordsY[1] - coordsY[0]));
            double distancia1 = Math.Sqrt((coordsX[2] - coordsX[1]) * (coordsX[2] - coordsX[1]) + (coordsY[2] - coordsY[1]) * (coordsY[2] - coordsY[1]));
            double distancia2 = Math.Sqrt((coordsX[3] - coordsX[2]) * (coordsX[3] - coordsX[2]) + (coordsY[3] - coordsY[2]) * (coordsY[3] - coordsY[2]));

            //Condición distancia mayor
            if (distancia > mayor) mayor = distancia;
            if (distancia1 > mayor) mayor = distancia1;
            if (distancia2 > mayor) mayor = distancia2;

            //Distancia mayor
            Console.WriteLine("La distancia mayor es: " + mayor);
        }
    }
}
