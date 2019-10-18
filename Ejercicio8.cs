using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3B
{
    class Ejercicio8
    {
        public static void ejercicio8()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.Write("\t\tIngrese le numero a llegar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 0, n3 = 0, k = 0;
            while (n1 < num && n2 < num && n3 < num)
            {
                n1++;
                n2 = n2 + 2;
                n3 = n3 + 3;
                if (n2 <= num && n3 <= num)
                {
                    if (n2 >= 10)         
               /*Este if lo unico que hace es ordenar las columnas, sino se imprimirian asi: 
                * 1    3
                * 2    6
                * 10     9
                * 11     12
                * quedando un espacio nada estetico... osea*/
                    {
                        Console.WriteLine("\t " + n1 + "     " + n2 + "    " + n3);
                    }
                    else
                    {
                        Console.WriteLine("\t " + n1 + "     " + n2 + "     " + n3);
                    }

                }
                else
                {
                    Console.WriteLine("\t " + n1 + "     " + n2);
                }

            }
            while (n1 < num && n2 < num)
            {
                n1++;
                n2 = n2 + 2;
                if (n2 <= num)
                {
                    /*Este if lo unico que hace es ordenar las columnas, sino se imprimirian asi: 
               * 1    3
               * 2    6
               * 10     9
               * 11     12
               * quedando un espacio nada estetico*/

                    if (n1 >= 10)
                    {
                        Console.WriteLine("\t " + n1 + "    " + n2);
                    }
                    else
                    {
                        Console.WriteLine("\t " + n1 + "     " + n2);
                    }
                }
                else
                {
                    Console.WriteLine("\t " + n1);
                }

            }
            while (n1 < num)
            {
                n1++;
                Console.WriteLine("\t " + n1);
            }
            Console.ReadKey();
            Program.menu();
        }
    }
}
