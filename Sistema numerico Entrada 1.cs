using System;

namespace Entrada_1_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio
            Console.Write("Ingrese b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese Z: ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Ingrese Y: ");
            double y = double.Parse(Console.ReadLine());

            //Calculo
            double c = Math.Atan(z / y);
            
            double e = 180 - c;
            
            double d = 180 - b - e;
            
            double dRad = d * Math.PI / 180;
            
            double bRad = b * Math.PI / 180;
            
            double w = z / (Math.Sin(dRad));
            
            double W = w * w;
            
            double Z = z * z;

            double x = (Math.Sqrt(W - Z)) - y;

            Console.WriteLine("Valor de x es : " + x);
        }
    }
}
