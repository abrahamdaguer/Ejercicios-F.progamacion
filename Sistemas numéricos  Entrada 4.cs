using System;

namespace Entrada_4Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese W: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese T: ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Ingrese c: ");
            double c = double.Parse(Console.ReadLine());

           
            double cRad = c * Math.PI / 180;
           
            double a = 90 - c;
            
            double aRad = a * Math.PI / 180;
            
            double z = t * (Math.Sin(cRad));
            
            double y = t * (Math.Sin(aRad));
            
            double W = w * w;
            
            double Z = z * z;

            double x = (Math.Sqrt(W - Z)) - y;

            Console.WriteLine(" El valor de y: " + y);
        }
    }
}
