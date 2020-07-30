using System;

namespace Valores_Extremos
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("Ingrese el numero de datos ");
            int datos = int.Parse(Console.ReadLine());
            int contador = 0, max = 0, min = 200;
            string nombreMayor = "nombreMayor";
            string nombreMenor = "nombreMenor";
            while (contador < datos)
            {
                Console.WriteLine("Ingrese el nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Edad:");
                int edad = int.Parse(Console.ReadLine());

                if (edad > max)
                {
                    max = edad;
                    nombreMayor = nombre;



                }
                if (edad < min)
                {
                    min = edad;
                    nombreMenor = nombre;

                }
                total += edad;
                contador++;

            }
            double promedio = total / datos;
            Console.WriteLine("\n Promedio:" + promedio + "| Mayor" + max + "| Menor:" + min);
            Console.WriteLine("\nNombre Mayor:" + nombreMayor);
            Console.WriteLine("\nNombre Menor:" + nombreMenor);

            Console.ReadKey();
        }
    }
}
