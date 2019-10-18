using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3B
{
    class Ejercicio5
    {
        public static void triangulo()
        {
            Console.Write("\t ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= numero; i++){
                for (int espacios = numero - i; espacios > 0; espacios--)
                    Console.Write(" ");
                for (int lineas = 1; lineas < 2 * i; lineas++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
