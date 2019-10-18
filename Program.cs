using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();//creo un objeto de la clase el cual
                                        //hereda sus argumentos y metodos
            menu();

        }
        public static void menu()
        {

            Console.Clear();
            Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t LOOR ZAMBRANO ROBERTH DAVID");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t TERCER NIVEL PARALELO B");

            Console.WriteLine("\t\t--------------------------------------------------------");

            Console.WriteLine("\n\t\t\t\t\tTAREA 1" +
                "\n\t\t\tESCOJA EL EJERCICIO A REALIZAR: " +
                "\n\t\t |1.-  Leer N numeros y dictar cual es el mayor" +
                "\n\t\t |2.-  Crear un cuadrado a partir de un numero entero: " +
                "\n\t\t |3.-  Calcular factura: " +
                "\n\t\t |4.-  Ingresar el numero de horas laboradas para obtener " +
                "\n\t\t       el sueldo respectivo: " +
                "\n\t\t |5.-  Apartir de un numero entero, formar la figura de un Triangulo " +
                "\n\t\t |6.-  Apartir de un numero entero, formar la figura de un rombo " +
                "\n\t\t |7.-  Columnas del 1 al 100 y del 100 al 1:  " +
                "\n\t\t |8.-  Columnas hasta el numero indicado   :  " +
                "\n\t\t |9.-   Tabla de multiplicar " +
                "\n\t\t |10.- Programa que muertra un menu calculador de un sumatorio" +
                "\n\t\t     o factorial");
            Console.Write("\t\t\t\tOpcion: ");
            double op = Convert.ToDouble(Console.ReadLine());

            opciones(op);

        }
        public static void opciones(double op)
        {
            switch (op)
            {
                case 1 : Ejercicio1.nummayor(); break;
                case 2: Ejercicio2.cuadrado(); break;
                case 3: Ejercicio3.nombre(); break;
                case 4: Ejercicio4.sueldo(); break;
                case 5: Ejercicio5.triangulo(); break;
                case 6: Ejercicio6.rombo(); break;
                case 7: Ejercicio7.columna(); break;
                case 8: Ejercicio8.ejercicio8(); break;
                case 9: Ejercicio9.tabla();break;
                case 10: Ejercicio10.ejercicio10(); break;


            }
        }


    }
}

