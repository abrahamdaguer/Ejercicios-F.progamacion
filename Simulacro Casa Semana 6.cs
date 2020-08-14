using System;

namespace casa_S6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, vida = 3, total = 0,  dosturno = 1, tresturnos = 1, dado2 = 0, dado3=0;
            Console.WriteLine("Bienvenido al juego!");
            string continuar = "s";

            while (continuar == "s")
            {
                dado = aleatorio.Next(1, 7);
                
                


                if (dosturno >= 2)
                {
                    
                    vida = vida - 1;
                    Console.WriteLine("\nHan pasado dos turnos y perdiste una vida");
                    if (vida < 0) vida = 0;
                    dosturno = 0;
                }
                
                if (tresturnos >= 3)
                {
                    dado3 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("\n\nSu primer dado es: " + dado3 + " | Su segundo dado es: " + dado2);
                    if (dado3 == dado2)
                    {
                        Console.WriteLine("\n\nHaz sacado un doble y obtienes una vida extra" );
                        vida = vida + 1;
                        if (vida > 3) vida = 3;      
                    }

                    total += dado3 + dado2;
                    tresturnos = 1;
                    Console.WriteLine("\nSu total es: " + total + " | le quedan " + vida + " vidas ");
                    Console.WriteLine("\nDesea continuar s/n");
                    continuar = Console.ReadLine();
                    
                }
                
                
                if (total >= 100 )
                {
                    Console.WriteLine("\nFelicidades ha ganado!");
                    break;
                }
                else if (vida == 0)
                {
                    Console.WriteLine("\nPerdiste!");
                    break;
                }
                
                total += dado;
                Console.WriteLine("\nsu dado es: " + dado + " | Su total es: " + total + " | le quedan " + vida + " vidas ");
                Console.WriteLine("\nDesea continuar s/n");
                continuar = Console.ReadLine();
                
                dosturno++;
                tresturnos++;
            }

            Console.WriteLine("\nFin del juego");
        }
    }
}
