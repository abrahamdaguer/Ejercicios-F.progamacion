using System;

namespace Ecuacion_Cuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir valor de a");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Introducir valor de b");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Introducir valor de c");
            float c = float.Parse(Console.ReadLine());


           float D = (b * b - (4 * a * c));
            

            if (D == 0)
            {
                double x1 = (-b / (2 * a));
                Console.WriteLine("X1:" + x1);
            }else if (D > 0)
            {
                D = MathF.Sqrt(D);
                double x1 = ((-b + D )/ (2 * a));
                double x2 = ((-b - D)/ (2 * a));

                Console.WriteLine("X1:" + x1);
                Console.WriteLine("X2:" + x2);
            }
            if (D < 0)
            {
                Console.WriteLine("No es posible calcular la solucion");
            }
        }
    }
}
