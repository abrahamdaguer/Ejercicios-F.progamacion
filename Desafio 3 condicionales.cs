using System;

namespace Desafio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuanto gana mensualmente");
            double salario = double.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Tipo contrato: 1 Dependiente - 2 Indepeniente");
            double Contrato = double.Parse(Console.ReadLine());


            int SMLV = 877803;
           
            
            
            // calculos si es independiente
            if (Contrato == 2)
            {
                Console.WriteLine("Escriba un numero del 1-5");
                double numero = double.Parse(Console.ReadLine());
                double Base = (salario * 0.40);
               
                if (Base < SMLV)
                {
                    Base = SMLV;
                }

                // calculo de las deducciones 
                if (numero == 5)
                {
                   

                    double deduccion = (Base * 0.3546);
                    double real = (salario - deduccion);
                    Console.WriteLine("valor:" + real);

                    double anual = (real * 12);
                    Console.WriteLine("Salario Anual:" + anual);
                }
                if (numero == 4)
                {
                     
                    double deduccion = (Base * 0.3285);
                    double real = (salario - deduccion);
                    Console.WriteLine("valor:" + real);

                    double anual = (real * 12);
                    Console.WriteLine("Salario Anual:" + anual);
                }
                if (numero == 3)
                {
                    
                    double deduccion = (Base * 0.30936);
                    double real = (salario - deduccion);
                    Console.WriteLine("valor:" + real);

                    double anual = (real * 12);
                    Console.WriteLine("Salario Anual:" + anual);
                }
                if (numero == 2)
                {
                   
                    double deduccion = (Base * 0.29544);
                    double real = (salario - deduccion);
                    Console.WriteLine("valor:" + real);

                    double anual = (real * 12);
                    Console.WriteLine("Salario Anual:" + anual);
                }
                if (numero == 1)
                {
                    
                   
                    double deduccion = (Base * 0.29022);
                    double real = (salario - deduccion);
                    Console.WriteLine("valor:" + real);

                    double anual = (real * 12);
                    Console.WriteLine("Salario Anual:" + anual);
                }
            }

            // calculos  si es depediente
            if (Contrato == 1)
            {

                double Base = (salario * 0.40);

                if (Base < SMLV)
                {
                    Base = SMLV;
                }
                double deduccion = (Base * 0.08);
                double real = (salario - deduccion);
                Console.WriteLine("valor:" + real);


                double anual = (real * 12 + salario);
                Console.WriteLine("Salario anual con prima :" + anual);

                


            }

           




            Console.ReadKey();
            

        }
    }
}
