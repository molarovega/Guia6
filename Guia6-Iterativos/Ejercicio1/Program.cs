using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un estudiante de matemáticas requiere una aplicación que permita calcular la suma 
           de los números naturales hasta un valor determinado. Implemente una solución con C#*/

            int ni = 0; //numero ingresado
            int i = 0;//contador
            int su = 0;//suma

            Console.WriteLine("Ingrese valor");
            ni = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= ni; i++)
            {
                su += i;
            }

            Console.WriteLine("Suma de los naturales hasta el numero {1}: {0}", su,ni);
            Console.ReadKey();

        }
    }
}
