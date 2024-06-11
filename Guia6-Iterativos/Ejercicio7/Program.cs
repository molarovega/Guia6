using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {

        static void Rectangulo (int bas,int alt)
        {
            // ╔ ═ ╗ ║ ╚ ╝ 48 alto y 167 ancho

            
            
            if ((bas > 167) || (alt > 48))
            {
                Console.SetCursorPosition(73, 22);
                Console.Write("El rectangulo ingresado");
                Console.SetCursorPosition(73, 23);
                Console.Write("no entra en la pantalla");
            }
            else 
            {
                Console.SetCursorPosition(0, 5);
                Console.Write("╔");
                Console.SetCursorPosition(bas, 5);
                Console.Write("╗");
                Console.SetCursorPosition(0, alt);
                Console.Write("╚");
                Console.SetCursorPosition(bas, alt);
                Console.Write("╝");

                for (int i = 1; i <= bas - 1; i++)
                {
                    Console.SetCursorPosition(i, 5);
                    Console.Write("═");
                    Console.SetCursorPosition(i, alt);
                    Console.Write("═");
                }

                for (int i = 6; i <= alt - 1; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("║");
                    Console.SetCursorPosition(bas, i);
                    Console.Write("║");
                }
            }
        }

        static void Main(string[] args)
        {
            /*Realice una aplicación que permita ingresar la base y la altura de un rectángulo y lo dibuje en pantalla.
              Nota: Considerando el tamaño de pantalla el dibujo debe ser siempre en forma horizontal 
              (el lado mayor como columnas) y si no entra en la pantalla debe informarlo con un mensaje 
              aproximadamente en el centro de la misma. */

            int bas = 0,
                alt=0;


            Console.WriteLine("Ingrese base del rectangulo");
            bas=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese altura del rectangulo");
            alt = Convert.ToInt32(Console.ReadLine());

            Rectangulo(bas, alt);



            Console.ReadKey();
        }
    }
}
