using System;

namespace Ejercicos_Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1 ");

            Console.WriteLine(" ");

            // datos de Y y Z
            Console.WriteLine("ingrese Y");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese Z");
            double z = double.Parse(Console.ReadLine());


            //Hipotenusa

            double t = (y * y) + (z * z);

            double h = Math.Sqrt(t);

            Console.WriteLine("La hipotenusa es:" + h);

            //Calular los angulos y pasarlos a radianes

            double c = Math.Asin(z / h);
            double cgrados = c * (180 / Math.PI);
            double a = Math.Asin(y / h);
            double agrados = a * (180 / Math.PI);

            Console.WriteLine("Valores de a en radianes es:" + a);
            Console.WriteLine("valores de a en grados:" + agrados);
            Console.WriteLine("Valores de c en radianes es:" + c);
            Console.WriteLine("Valores de C en grados:" + cgrados);
            Console.WriteLine();

            






        }
    }
}
