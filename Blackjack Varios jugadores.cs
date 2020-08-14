using System;

namespace Blackjack_Varios_jugadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta_ADC = 0, carta1 = 0, carta2 = 0, total = 0, jugador = 0, n = 0, ganador=0, jugadorWin = 0; 
           
            Console.WriteLine("\nIngrese el numero de jugadores ");
            n = int.Parse(Console.ReadLine());
            //Validar que el numero de jugadores este entre 2 y 5
            while (2 > n || n > 5)
            {
               
              
                Console.WriteLine("\nN");
                Console.WriteLine("\nIngrese el numero de jugadores ");
                n = int.Parse(Console.ReadLine());

            }
            // juego modificado para funcionar con varios jugadores 
            while (2 <= n && n <= 5)
            {
                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                
                Console.WriteLine("\n\n\n\n\nBienvenido al juego jugador " + (jugador + 1));
                Console.WriteLine("\n\nSu primera carta tiene un valor de :  " + carta1 + "  |  Su segunda  carta tiene un valor de : " + carta2);

                total = carta1 + carta2;
                Console.WriteLine("\nSu total es de: " + total);


                while (true)
                {


                    if (total < 21)
                    {
                        carta_ADC = aleatorio.Next(1, 11);

                        Console.WriteLine("\n\n¿Desea tomar una carta adicional? s/n ");

                        if (Console.ReadLine() != "s") break;
                    }
                    else if (total == 21)
                    {
                        Console.WriteLine("\nFelicidades ha ganado");
                        break;
                    }
                    else 
                    {
                        total = 0;
                        Console.WriteLine("\n\nSu total fue mayor a 21 y ha sido eliminado");
                        break;
                    }
                    total += carta_ADC;
                    Console.WriteLine("\n El valor de su carta adicional es: " + carta_ADC + " | Total: " + total);
                }
                jugador++;
                //Determinar quien es el ganador 
                if (total > ganador)
                { 
                     ganador = total;
                    if (jugador > jugadorWin)
                    {
                        jugadorWin = jugador;
                    }
                }
               
                if (jugador >= n) break;
            }
            Console.WriteLine(" \n\n\nEl ganador fue el jugador: " + jugadorWin + "  |  Su puntaje fue de: " + ganador);
            Console.ReadKey();
        }
    }
}
