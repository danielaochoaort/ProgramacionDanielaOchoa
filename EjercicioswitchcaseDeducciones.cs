using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioswitchcaseDeducciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos

            Console.WriteLine(" Ingrese su salario mensual:");
            double salariomensual = double.Parse(Console.ReadLine());

            Console.WriteLine(" Seleccione (1) Si es trabajador dependiente (2) si es trabajador independiente:");
            double tdc = double.Parse(Console.ReadLine());

            //Operaciones

            double smmlv = 877803, prima = 0;

            double basedecotizacion = (salariomensual * 0.40);

            if (basedecotizacion < smmlv) basedecotizacion = smmlv; //Solo se puede utilizar if acá

            double pension = 0, eps = 0, arl = 0;

            switch (tdc){ //tipo de contrato

                case 1: //Dependiente

                    eps = 0.04 * basedecotizacion;
                    pension = 0.04 * basedecotizacion;
                    prima = salariomensual;

                    double salarioReal = salariomensual - (eps + pension + arl * basedecotizacion);
                    double salarioAnual = salarioReal * 12 + prima;

                    Console.WriteLine("Salario Real " + salarioReal);
                    Console.WriteLine("Salario Anual " + salarioAnual);

                    break;

                case 2: //Independiente

                    eps = 0.125 * basedecotizacion;
                    pension = 0.16 * basedecotizacion;

                    Console.WriteLine("Seleccione el tipo de riesgo (1-5):");
                    double riesgo = double.Parse(Console.ReadLine());

                    switch (riesgo){ //Tipo de riesgo

                        case 1: arl = 0.522 / 100;
                        break;

                        case 2: arl = 1.044 / 100;
                        break;

                        case 3: arl = 2.436 / 100;
                        break;

                        case 4: arl = 4.355 / 100;
                        break;

                        default: arl = 6.960 / 100;
                        break;
                    }

                    double salarioReal2 = salariomensual - (eps + pension + arl * basedecotizacion);
                    double salarioAnual2 = salarioReal2 * 12 + prima;

                    Console.WriteLine("Salario Real " + salarioReal2);
                    Console.WriteLine("Salario Anual " + salarioAnual2);

                    break;

            }

        }
    }
}
