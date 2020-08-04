using System;

namespace Simulacro_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int dado1 = 0, dado2 = 0, total = 0, contador = 0, seis = 0, dobles = 0;
            Random aleatorio = new Random();
            string continuar = "s";
            Console.WriteLine("bienvenido al juego");

            while(continuar == "s" && (dado1 != 1 || dado2 != 1))
            {
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);
                Console.WriteLine("Dado1:" + dado1 + "  |  Dado2:" + dado2);

                if(dado1 == 1 && dado2 == 1)
                {
                    total = 0;
                    Console.WriteLine("ha sido eliminado");
                }
                else
                {
                    total += (dado1 + dado2);
                    Console.WriteLine("Total :" + total);
                    if (dado1 == dado2) dobles += 1;
                    else dobles = 0;
                    if ((dado1 + dado2) > 6) seis += 1;
                    if(total>=100||dobles >= 3)
                    {
                        Console.WriteLine("Felicidades has ganado ");
                        continuar = "n";
                    }
                    else
                    {
                        Console.WriteLine("Desea continuar (s/n)");
                        continuar = Console.ReadLine();
                    }
                }
                contador++;
            }

           
            double porcentaje = 100 * (((double)seis) / contador);
            Console.WriteLine("Porcentaje de turnos en lo que obtuvo  mas de 6 fue:" + Math.Round(porcentaje,2)+"%");
            Console.WriteLine("Su total es:" + total);

            Console.ReadKey();

        }
    }
}
