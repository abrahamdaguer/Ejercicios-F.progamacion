using System;

namespace Calcular_tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos gana mensualmente");
            double salario = double.Parse(Console.ReadLine());

           

            if (salario < 1755606){
                Console.WriteLine("Debe pagar la tarifa A");
            }
            
            else if (1755606 <= salario && salario< 3511212){
                Console.WriteLine("Debe pagar la tarifa B");
            }
            
            else if (salario >= 3511212){
                Console.WriteLine("Debe parar la tarifa C");
            }
            Console.ReadKey();
        }
    }
}
