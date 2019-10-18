using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3B
{
    class Ejercicio6
    {
        public static void rombo()
        {
            Console.Write("\t ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= numero; i++)
            {
                for (int espacios = numero - i; espacios > 0; espacios--)
                    Console.Write(" ");
                for (int lineas = 1; lineas < 2 * i; lineas++)
                    Console.Write("*");
                   Console.WriteLine();
            }
            for (int i = numero; i >= 1; i--)
            {
                for (int espacios = numero - i; espacios > 0; espacios--)
                    Console.Write(" ");
                for (int lineas = 1; lineas < 2 * i; lineas++)
                    Console.Write("*"); ;
                Console.WriteLine(); ;
            }

            Console.ReadKey();
            Program.menu();

        }
    }
}
        
