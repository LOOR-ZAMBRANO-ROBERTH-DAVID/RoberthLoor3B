using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3B
{
    class Ejercicio4
    {
        public static void sueldo()
        {
            Console.Clear();
            double sueldo, horas, horas2;
            Console.WriteLine("\t\tINGRESE LAS HORAS LABORADAS: ");
            Console.Write("\tHoras: ");
            horas = Convert.ToDouble(Console.ReadLine());

            if (horas > 35)
            {
                horas2 = horas - 35;
                sueldo = (horas2 * 22) + (35 * 15);
                Console.Write("\t\tSu sueldo es de: " + "$" + sueldo);
            }
            if (horas <= 35)
            {
                sueldo = horas * 15;
                Console.Write("\t\tSu sueldo es de: " + "$" + sueldo);
            }
            Console.WriteLine("\n\t\tDesea calcular otro sueldo?: " +
                "\n\t1.- SI" +
                "\n\t2.- NO");
            Console.Write("\t   Opcion: "); byte sueldito = Convert.ToByte(Console.ReadLine());
            if (sueldito == 1) { Ejercicio4.sueldo(); }
            if (sueldito == 2) { Program.menu(); }
        }
    }
}
