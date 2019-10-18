using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3B
{
    class Ejercicio7
    {
        public static void columna()
        {
            int k = 0, k2 = 101, k3;

            do
            {
                k++;
                k2--;
                Console.WriteLine(k + "     " + k2);
            } while (k < 100);
            Console.ReadKey();
            Program.menu();
        }

    }
}
