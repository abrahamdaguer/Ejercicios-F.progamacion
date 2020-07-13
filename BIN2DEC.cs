using System;

namespace BIN2DEC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese valor en binario 1");
            String s1 = Console.ReadLine();

            Console.WriteLine("Ingrese valor en binario 2");
            String s2 = Console.ReadLine();

            Console.WriteLine("Ingrese valor en binario 3");
            String s3 = Console.ReadLine();

            Console.WriteLine("Ingrese valor en binario 4");
            String s4 = Console.ReadLine();

            Console.WriteLine("Ingrese valor en binario 5");
            String s5 = Console.ReadLine();

            // Conversion de binario a decimal

            int b1 = Convert.ToInt32(s1, 2);
            int b2 = Convert.ToInt32(s2, 2);
            int b3 = Convert.ToInt32(s3, 2);
            int b4 = Convert.ToInt32(s4, 2);
            int b5 = Convert.ToInt32(s5, 2);
            //Resultado
            Console.WriteLine("Valor en decimales = " + b1);
            Console.WriteLine("Valor en decimales = " + b2);
            Console.WriteLine("Valor en decimales = " + b3);
            Console.WriteLine("Valor en decimales = " + b4);
            Console.WriteLine("Valor en decimales = " + b5);


        }
    }
}
