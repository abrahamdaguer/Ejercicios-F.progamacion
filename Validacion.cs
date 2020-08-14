using System;

namespace validacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //progama en base al diagrama 
            int a = 0, b = 0, suma=0, sumacorrecta = 0, oportunidad = 0;
            Random aleatorio = new Random();
            
            a = aleatorio.Next(0, 11);
            b = aleatorio.Next(0, 11);
            sumacorrecta = a + b;
            Console.WriteLine("\nValor de A: " + a + " | Valor de B: " + b);
            Console.WriteLine("\nCual es el valor si se suman los terminos");
            suma = int.Parse(Console.ReadLine());

            while (sumacorrecta != suma)
            {
                //nuevo captcha variables
                a = aleatorio.Next(0, 11);
                b = aleatorio.Next(0, 11);
                sumacorrecta = a + b;
               
                 //Mensaje si la validacion no es correcta
                Console.WriteLine("\nValidacion incorrecta no puede continuar");
                Console.WriteLine("\nTiene solo 3 oportunidades, lleva " + (oportunidad + 1 ) + " oportunidades");
                
                // oportunidades 
                if ((oportunidad + 1) >= 3)
                {
                    
                    Console.WriteLine("\nSe ha quedado sin oportunidades");
                    break;
                }
               
                //nuevo captcha

                Console.WriteLine("\nValor de A: " + a + " | Valor de B: " + b);
                Console.WriteLine("\nCual es el valor si se suman los terminos");
                suma = int.Parse(Console.ReadLine());
               
                //si la validacion es correcta
                if (sumacorrecta == suma)
                {
                    Console.WriteLine("\nPuede continuar");
                    break;
                }
                oportunidad++;
            }
            if(sumacorrecta == suma)
            {
                Console.WriteLine("\nInicio del progama ");
            }
            
            Console.ReadKey();
            oportunidad++;
        }
    }
}
