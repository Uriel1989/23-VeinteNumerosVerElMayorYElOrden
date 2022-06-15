using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23_VeinteNumerosVerElMayorYElOrden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[20];
            vector[00] = 12;
            vector[01] = 13;
            vector[02] = 25;
            vector[03] = 36;
            vector[04] = 74;
            vector[05] = 86;
            vector[06] = 53;
            vector[07] = 56;
            vector[08] = 88;
            vector[09] = 99;
            vector[10] = 24;
            vector[11] = 35;
            vector[12] = 39;
            vector[13] = 21;
            vector[14] = 17;
            vector[15] = 90;
            vector[16] = 82;
            vector[17] = 65;
            vector[18] = 30;
            vector[19] = 29;

            int posicion;



            int mayor = vector[00];

            for (posicion = 0; posicion < vector.Length; posicion++)
            {
                Console.WriteLine("El numero de la posicion " + posicion + " es: " + vector[posicion]);
            }

            for (int i = 0; i < 20; i++)
            {
                if (vector[i] > mayor)

                    mayor = vector[i];

            }

            Console.WriteLine("El mayor es: " + mayor);



            Console.ReadKey();
        }
    }
}
