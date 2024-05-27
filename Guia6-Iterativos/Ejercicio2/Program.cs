using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Recuadro(int X1, int Y1, int X2, int Y2) 
        {
            int i=0;

            //parte superior
            Console.SetCursorPosition(X1,Y1);
            for (i = X1; i <= X2; i++) 
            {
                Console.Write("*");
            }
            
            //parte media/columnas
            for (i=Y1+1;i<Y2;i++) 
            {
                Console.SetCursorPosition(X1, i);
                Console.Write("*");
                Console.SetCursorPosition(X2, i);
                Console.Write("*");
            }
            
            //parte inferior
            Console.SetCursorPosition(X1, Y2);
            for (i = X1; i <= X2; i++)
            {
                Console.Write("*");
            }



        }



        static void Main(string[] args)
        {
            /*Realizar un marco de pantalla con signos asteriscos desde la posición (5,2) a (75,22)*/

            Recuadro(5,2,75,22);
            Console.ReadKey();
        }
    }
}
