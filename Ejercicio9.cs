using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3B
{
    class Ejercicio9
    {
        public static void tabla() {
            Console.Clear();
            int numero, conta = 0, mult;
            Console.Write("\t\t\nIngrese un numero entero positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());
            
            while (conta<15) {
                conta++;
                mult = numero * conta;
                Console.WriteLine("\t"+numero+" x "+conta+" = "+mult);
            }
            Console.ReadKey();
        }
    }
}
