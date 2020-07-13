using System;

namespace ejercicio_3_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input del usuario
            Console.WriteLine("ejercicio 3");
            Console.Write("Ingrese Z: ");
            double z = double.Parse(Console.ReadLine());

            Console.Write("Ingrese c: ");
            double c = double.Parse(Console.ReadLine());

           
            // calular Angulos
            double a = 90 - c;
            
            
            //Conversion de grados a  radianes
            double cRad = c * Math.PI / 180;
            double aRad = a * Math.PI / 180;
            
            
            //hallar catetos y la hipotenusaa
            double y = (z * Math.Sin(aRad)) / (Math.Sin(cRad));
            double t = (y) / (Math.Sin(aRad));


            //consola shows
            Console.WriteLine("El valor de la Hipotenusa: " + t);
            Console.WriteLine("El valo de y: " + y);
            Console.WriteLine("El ángulo interno es: " + a);
        }
    }
}