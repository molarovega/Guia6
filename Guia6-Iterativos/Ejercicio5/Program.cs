using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static bool Primo (int a) 
        {
            bool pri = true;
            int i = 0,
                c = 0;

            if (a > 1)
            {
                for (i = a; i >= 1; i--)
                {

                    if (Math.IEEERemainder(a, i) == 0)
                    {
                        ++c;
                    }
                }
                if (c > 2)
                {
                    pri = false;
                }
            }
            else
                pri = false;

            
            return pri;
        }
        
        static void Main(string[] args)
        {
            /*Una forma de determinar si un número es primo consiste en verificar si es divisible por sí mismo y por uno.
             Implemente una aplicación que determine si un valor entero ingresado por el usuario es o no un número primo */

            int num = 0;

            Console.WriteLine("Ingrese numero");
            num = Convert.ToInt32(Console.ReadLine());

            if (Primo(num) == true)
                Console.WriteLine("El numero {0} es primo", num);
            else
                Console.WriteLine("El numero {0} NO es primo", num);

            Console.ReadKey();
            
        }
    }
}
