using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3B
{
    class Ejercicio10
    {
        public static void ejercicio10()
        {
            byte op;
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\t\t|1.- SALIR" +
                "\t\t|2.- SUMATORIO" +
                "\t\t|3.- FACTORIAL");
            Console.Write("\tOpcion: "); op = Convert.ToByte(Console.ReadLine());
            eje10op(op);
        }
        public static void eje10op(byte op)
        {
            int sum = 1;
            int i = 0;
            switch (op)
            {
                case 1: Program.menu(); break;
                case 2:
                    Console.Write("\t\tIngrese un valor a tomar el Sumatorio: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int x = 0;
                    int u = num2;
                    sum = 0;
                    while (num2 != 0)
                    {
                        sum = sum + num2;
                        num2--;

                    }
                    Console.WriteLine("\t\t El sumatorio de " + u + " es: " + sum);

                    break;
                case 3:
                    int fac = 1, num = 1;
                    Console.Write("\t\tIngrese un valor a tomar el factorial: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    int v = num;
                    while (num != 0)
                    {
                        fac = fac * num;
                        num--;
                    }
                    Console.WriteLine("\t\t El factorial de " + v + " es: " + fac);
                    break;
            }
            Console.ReadKey();
            ejercicio10();

        }
    }
}
