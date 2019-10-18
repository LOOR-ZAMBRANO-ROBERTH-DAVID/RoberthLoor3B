using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3B
{
    class Ejercicio3
    {
        public static double subt2 = 0;

        public static void nombre()
        {
            Console.Clear();
            Console.WriteLine("\t\t--------------------------------------------------------");
            Console.WriteLine("\t\t|\t \tBIENVENIDOS A FARMACIAS AYAYAI!: ");
            Console.WriteLine("\t\t--------------------------------------------------------");
            Console.Write("\t\t|Nombre del comprador: ");
            String nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\t\t--------------------------------------------------------");
            productos();
        }
        public static void productos()
        {
            Console.WriteLine("\t\t--------------------------------------------------------");
            Console.Write("\t\t|Cantidad del producto que desea comprar: ");
            int cant = Convert.ToInt32(Console.ReadLine());
            calculo(cant);

        }
        public static void calculo(double cant)
        {
            if (cant != 0)
            {

                Console.Write("\t\t|Producto: ");
                String pro = Convert.ToString(Console.ReadLine());
                Console.Write("\t\t|Precio Unitario: $");
                double preu = Convert.ToDouble(Console.ReadLine());
                double subtotal = cant * preu;

                subt2 = subt2 + subtotal;
                Ejercicio3.productos();

            }
            if (cant == 0)
            {
                double iva = 0.12;
                double casitotal = subt2 * iva;
                double total = casitotal + subt2;
              
                Console.WriteLine("\t\t|-------------------------------------------------------");
                Console.WriteLine("\t\t|Subtotal es: $" + subt2);
                Console.WriteLine("\t\t--------------------------------------------------------");
                Console.WriteLine("\t\t|IVA: 12%");
                Console.WriteLine("\t\t--------------------------------------------------------");
                Console.WriteLine("\t\t|Su total es: $" + total);
                Console.WriteLine("\t\t--------------------------------------------------------");
                Console.ReadKey();
                Program.menu();
            }
        }

    }
}
