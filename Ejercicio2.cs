using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3B
{
    class Ejercicio2
    {
        public static void cuadrado() {
            Console.Write("\t\tIngrese un numero entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            //Linea superior del cuadrado
            for (int i = 0; i < numero; i++) { Console.Write("*"); }
            Console.WriteLine();//salto de linea que divide la parte superior de la inferior

            //parte central del la forma
            for (int i = 0; i < numero - 2; i++)/*Muestra un asterisco y el for de abajo
                                                deja dos espacios para imprimir unicamente
                                                los bordes.*/
            {
                Console.Write("*");
                for (int x = 0; x < numero - 2; x++) { Console.Write(" "); }
                Console.WriteLine("*");
            }

            //Linea inferior
            for (int i = 0; i < numero; i++) { Console.Write("*"); }

            Console.ReadKey();
            Program.menu();
        }
    }
}
