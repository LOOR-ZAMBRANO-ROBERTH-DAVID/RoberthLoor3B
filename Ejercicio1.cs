using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3B
{
    class Ejercicio1
    {
        public static void nummayor() {
            Console.Write("\tIngrese el numero de datos a ingresar: ");
            int datos = Convert.ToInt32(Console.ReadLine());

            int i = 0, mayor = 0;
            while (i < datos) {
                i++;
                Console.Write("\t\tIngrese el termino entero: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > mayor) { mayor = num;  }
            }
            Console.Write("\t\tEl numero mayor es: " +mayor);
            Console.ReadKey();
            Program.menu();

        }

    }
}
