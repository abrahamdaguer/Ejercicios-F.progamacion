using System;

namespace desafio_2_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");
            Console.Write("Ingrese T: ");
            double t = double.Parse(Console.ReadLine());

            Console.Write("Ingrese a: ");
            double a = double.Parse(Console.ReadLine());

            //conversion de grados a radianes
            double aRad = a * Math.PI / 180;

            // calcular los Catetos
            double y = t * Math.Sin(aRad);
            
            double z = (t * Math.Cos(aRad));

            // Valor angulos 
            double c = 90 - a;

            Console.WriteLine(" El valor del lado y es: " + y);
            
            Console.WriteLine("El valor de lado z es: " + z);
            
            Console.WriteLine("El ángulo interno C es: " + c);
        }
    }
}
