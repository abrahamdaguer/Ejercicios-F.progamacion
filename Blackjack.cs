using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int carta = 2, total = 0, puntos = 0;
            Random aleatorio = new Random();
            string continuar = "Si"; 
            Console.WriteLine("Desea Iniciar el juego (si/no)");
            continuar = Console.ReadLine();
            puntos = aleatorio.Next(2, 21);
            total = puntos;
            Console.WriteLine("\nCartas: " + carta + " | Valor de las cartas: " + total );

            while (continuar == "si")
            {
                puntos = aleatorio.Next(1, 11);
                Console.WriteLine("\nDesea continuar (si/no)");
                continuar  = Console.ReadLine();
                if (continuar == "si")
                {
                    carta = carta + 1;
                    total += puntos;
                    Console.WriteLine("\nCartas:" + carta + " | Valor de la carta " + puntos + "| Total:" + total );
                }
               
                
                if (total > 21)
                {
                    total = 0;
                    Console.WriteLine("\n\nSu total fue mayor a 21 y ha sido eliminado");
                    continuar = "no";

                }
                else if (total == 21)
                {
                    Console.WriteLine("\nFelicidades ha ganado");
                    continuar = "no";
                }
                
               
            }
                Console.Write(" Gracias por jugar  ");
                Console.Write("\nSu total fue: " + total);
            
            Console.ReadKey();
        }
    }
}
