using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {

       
        
        static void Main(string[] args)
        {
            /*Implemente una aplicación que dados dos valores enteros ingresados por el usuario muestre en pantalla
              todos los valores divisibles por 2 y por 3 en el intervalo formado por los números ingresados. 
              No realice ninguna suposición sobre el orden en el que se ingresan los valores y su magnitud.*/

            int ing1,//1° valor ingresado
                ing2;//2° valor ingresado
            int i=0;//contador
            int a = 0;//resto de la division
            int d2=0,//contador de numeros divisibles  por 2
                d3 =0;//contador de numeros divisibles  por 3
            int[] div2 = new int[100];
            int[] div3 = new int[100];

            Console.WriteLine("Ingrese 1° valor");
            ing1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese 2° valor");
            ing2 = Convert.ToInt32(Console.ReadLine());

            if (ing1 < ing2)        // 1° numero es menor al 2°. Ej: -10 al -1, 1 al 10, -10 al 10
            {
                for (i = ing1; i <= ing2; i++)
                {
                    Math.DivRem(i, 2,out a);
                    if (a==0) 
                    {
                        div2[d2] =i;
                        ++d2;
                    }
                    Math.DivRem(i, 3, out a);
                    if (a == 0)
                    {
                        div3[d3] = i;
                        ++d3;                    
                    }
                }
            }
            else                    // 2° numero es menor al 1°.Ej: -1 al -10, 10 al 1, 10 al -10
            {
                for (i = ing1; i >= ing2; i--)
                {
                    Math.DivRem(i, 2, out a);
                    if (a == 0)
                    {
                        div2[d2] = i;
                        ++d2;
                    }
                    Math.DivRem(i, 3, out a);
                    if (a == 0)
                    {
                        div3[d3] = i;
                        ++d3;
                    }
                }
            }

            Console.WriteLine("Numeros divisibles por 2");
            for (i=0;i<=d2-1;i++) 
            {
                Console.WriteLine(" {0}", div2[i]);
            }

            Console.WriteLine("Numeros divisibles por 3");
            for (i = 0; i <= d3-1; i++)
            {
                Console.WriteLine(" {0}", div3[i]);
            }

            Console.ReadKey();
        }
    }
}
