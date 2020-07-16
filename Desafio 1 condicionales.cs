using System;

namespace Calcular_tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos SMLV gana mensualmente");
            double salario = double.Parse(Console.ReadLine());

            double smlv = (salario * 877803);

            if (smlv < 1755606)
                Console.WriteLine("Debe pagar la tarifa A");
            else if (1755606 <= smlv && smlv < 3511212)
                Console.WriteLine("Debe pagar la tarifa B");
            else if (smlv >= 3511212)
                Console.WriteLine("Debe parar la tarifa C");

            Console.ReadKey();
        }
    }
}
