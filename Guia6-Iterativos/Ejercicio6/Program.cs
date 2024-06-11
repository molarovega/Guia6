using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {

        static int ConvertirAS (string dur) 
        {
            int ss, mm;
            int stotal;
            ss = Convert.ToInt32(dur.Substring(dur.IndexOf(':') + 1));//segundos
            mm = Convert.ToInt32(dur.Substring(0, dur.IndexOf(':')));//minutos
            //Console.WriteLine("ss: {0}\nmm: {1}", ss, mm);
            stotal = ss + (mm * 60);
            //Console.WriteLine("stotal: {0}", stotal);
            return stotal;
        }

        static string Desconvertir(int ds)
        {
            int HH=0,//horas
                MM=0,//minutos
                SS=0;//segundos
            int aux=0;//variable auxiliar
            string DUR;//duracion en formato HH:MM:SS

            MM = Math.DivRem(ds,60,out aux);
            SS = aux;
            if (MM >= 60) 
            {
                HH =Math.DivRem(MM,60,out aux);
                MM = aux;
            }
            
            DUR= string.Concat(Convert.ToString(HH), ":" ,Convert.ToString(MM), ":" ,Convert.ToString(SS));
            return DUR;
        }


        static void Main(string[] args)
        {
            /*Codifique una aplicación de consola que permita el ingreso de una lista de canciones grabadas
              en un CD y sus tiempos en formato MM:SS y muestre el tiempo total de la lista y el nombre de la
              canción con mayor duración.
              La aplicación debe solicitar la cantidad de canciones a procesar al inicio. */

            int cc = 0;//cantidad de canciones a procesar
            string nom;//nombre de la cancion ingresada
            string sdu;//string duracion de la cancion
            string NM="";//nombre cancion con mayor duracion

            int DM=0;//segundos cancion mayor duracion
            int dss = 0,//duracion en segundos de una cancion
                DST=0;//duracion en segundos de todas las canciones



            Console.WriteLine("Ingrese cantidad de canciones a procesar");
            cc = Convert.ToInt32(Console.ReadLine());

            for (int i=1;i<=cc; i++)
            {
                
                Console.WriteLine("Ingrese nombre de la {0}° cancion",i);
                nom = Console.ReadLine();
                Console.WriteLine("Ingrese duracion de la cancion en formato MM:SS");
                sdu = Console.ReadLine();
                dss = ConvertirAS(sdu);

                if (i == 1)
                {
                    NM = nom;
                    DM = dss;
                }
                if (dss > DM)
                {
                    NM = nom;
                    DM = dss;
                }

                DST += dss;


            }
            
            sdu=Desconvertir(DST);
            Console.WriteLine($"Cancion con mayor duracion: \"{NM}\"");
            Console.WriteLine($"Tiempo total de la lista: {sdu}");

            Console.ReadKey();
        }
    }
}
