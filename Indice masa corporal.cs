using System;

namespace Imc
{
    class Program
    {
        static void Main(string[] args)
        {
            

            float peso, altura, Imc;

            Console.WriteLine("Ingresar altura en CM:");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar peso en KG:");
            peso = float.Parse(Console.ReadLine());


            Imc = peso / ((altura/100) * (altura/100));

            if (Imc <= 15)
            
                Console.WriteLine("Delgadez muy severa:" + Imc);
            else if (15 <= Imc && Imc <= 15.9)
                Console.WriteLine("Delgadez severa:" + Imc);
                  else if (16 <= Imc && Imc <= 18.4)
                          Console.WriteLine("Delgadez: " + Imc);
                      else if (18.5 <= Imc && Imc <= 24.9)
                                Console.WriteLine("Peso saludable:" + Imc);
                           else if (25 <= Imc && Imc <= 29.9)

                                    Console.WriteLine("Sobrepeso:" + Imc);
                                 else if (30 <= Imc && Imc <= 34.4)

                                            Console.WriteLine("obvesidad severa:" + Imc);

                                      else if (Imc >= 40)

                                             Console.WriteLine("obvesidad mórbida:" + Imc);


            Console.ReadKey();


        }


    }

}
