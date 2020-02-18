using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDados09Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int dado = 0;
            int Dadoespecial = 0; 
            int Contdadoespeciales = 2;
            int total = 0;
            int turno = 0;
            int anterior = 0;
            int menosVida = 0;
            int masVida = 0;
            int vidas = 3; //Vidas Iniciales
            string respuesta = "s";
            string NuevoDado = "s";

            while (respuesta == "s"){

                //Contador de turnos y puntaje
                turno += 1;
                anterior += 1;
                Console.WriteLine("(Turno=  #" + turno + ")");

                Console.WriteLine("Vidas= " + vidas);


                if (Contdadoespeciales > 0) {
                    Console.WriteLine("¿Deseas usar el dado especial(12 caras)? (s/n)");

                    NuevoDado = Console.ReadLine();

                    if (NuevoDado == "s") {
                        Contdadoespeciales -= 1;
                        Dadoespecial = random.Next(1, 13);
                        Console.WriteLine("Dado especial = " + Dadoespecial);
                        total += Dadoespecial;
                        Console.WriteLine("Total= " + total);
                        Console.WriteLine("-----------------------------------------------------");

                    }
      
                    else if (NuevoDado == "n"){
                        //Se genera el dado

                        Console.WriteLine("---------Dado de 6 caras----------");
                        dado = random.Next(1, 7);
                        Console.WriteLine("Valor del dado=" + dado);
                        total += dado;
                        Console.WriteLine("Total= " + total);

                        Console.WriteLine("-----------------------------------------------------");
                    }

                }
                else {
                    //Se genera el dado entre 1-6

                    Console.WriteLine("Dado de 6 caras.");
                    dado = random.Next(1, 7);
                    Console.WriteLine("Valor del dado= " + dado);
                    total += dado;
                    Console.WriteLine("Total= " + total);

                    Console.WriteLine("-----------------------------------------------------" );

                }


                //Condiciones


                if (dado == 1 || Dadoespecial==1){ // = 1 dado

                        menosVida ++;
                }

                if (menosVida == 2){ //Dos 1s

                    Console.WriteLine("Se le quitó una vida.  ");
                    vidas -= 1;
                    Console.WriteLine("Se le quitó 10 puntos.  ");
                    total -= 10;
                    menosVida = 0; //Se reincia
                }

                if (dado == 6 || Dadoespecial ==6){ // = 6 Dado

                        masVida ++;
                        anterior --;
                }

                if (masVida == 2 && turno == anterior) {

                    Console.WriteLine("Ganaste una vida.  ");
                    vidas ++;
                }

                if (turno != anterior){
                    anterior ++;
                }


                //Condición de ganar
                if (total >= 100) {
                    Console.WriteLine("¡¡¡¡¡¡¡¡¡Has ganado!!!!!!!");
                    Console.WriteLine("Total= " + total);

                    Console.WriteLine("-----------------------------------------------------");
                    break;
                }

                //Condición de perder 
                if (vidas < 0)  {
                    Console.WriteLine(" Te quedaste sin vidas! PERDISTE");
                    break;
                }


                if (total < 100 && respuesta == "s") {
                    Console.WriteLine("¿Deseas continuar?(s/n)");
                    respuesta = Console.ReadLine();
                    Console.WriteLine("-----------------------------------------------------");

                }
                
            }

            Console.WriteLine("Gracias por participar!");

        }
    }
}
