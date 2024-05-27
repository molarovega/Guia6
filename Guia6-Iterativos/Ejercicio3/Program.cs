using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que permita ingresar 10 números y calcule su promedio*/
            
            int i = 0;//contador
            double prom = 0.0;//promedio

            for (i=1;i<=10;i++) 
            {
                Console.WriteLine("Ingrese {0}° numero",i);
                prom+=Convert.ToDouble(Console.ReadLine());
            }
            prom = prom/10;

            Console.WriteLine("Promedio: {0}",prom);
            Console.ReadKey();

        }
    }
}
