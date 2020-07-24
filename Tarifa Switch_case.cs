using System;

namespace Swicht_case
{
    class Program
    {
        static void Main(string[] args)
        {

            double pension = 0, eps = 0, deducciones = 0;
            Console.WriteLine("Cuanto gana mensualmente");

            int salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba su tipo de contrato( Dependiente, Independiente)");

            string contrato = (Console.ReadLine());

            int smlv = 877803;

            double ibc = salario * 0.40;
           
            if (ibc < smlv) ibc = smlv; // si el ibc es menor a un salario minimo

            switch (contrato)
            {
                case "Dependiente":
                    pension = 0.04;
                    eps = 0.04;
                    deducciones = (ibc*(pension + eps));
                    int Sreal = (int)(salario - deducciones);
                    int Sanual = (Sreal * 12 + salario);
                    Console.WriteLine("Salario real: "+ Sreal +"| Salario anual:"+ Sanual + "| Sus deducciones:" + deducciones );
                 
                    break;

                case "Independiente":
               Console.WriteLine("Elija un numero del 1 al 5");
            double arl = double.Parse(Console.ReadLine());

             

            switch (arl)
            {

                case 1:
                    arl = 0.00522;
                    break;

                case 2:
                    arl = 0.01044;
                    break;
                case 3:
                    arl = 0.02436;
                    break;
                case 4:
                    arl = 0.04350;
                    break;
                default:
                    arl = 0.06960;
                    break;


            }
                    pension = 0.16;
                    eps = 0.125;
                    deducciones = (ibc * (pension + eps + arl));
                    int sreal = (int)( salario - deducciones);
                    int sanual = (sreal * 12);
                    Console.WriteLine("Salario real:" + sreal + "| Salario anual:" + sanual + "| Sus deducciones:" + deducciones);


                    break;
            }
               
            

         


            Console.ReadKey();

          

        }
    }
}
