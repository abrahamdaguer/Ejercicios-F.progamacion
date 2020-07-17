using System;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Cuantos gana mensualmente ");
            double salario = double.Parse(Console.ReadLine());

            double TarifaA = 3400;
            double TarifaB = 13500;
            double TarifaC = 35800;

            if (salario <= 1755606)
                Console.WriteLine("Su valor a pagar es:" + TarifaA);
            else if (1755607 <= salario && salario <= 4389015)
                Console.WriteLine("Su valor a pagar es:" + TarifaB);
            else if (salario >= 4389015)
                Console.WriteLine("Su valor a pagar es:" + TarifaC);
        }
    }
}
