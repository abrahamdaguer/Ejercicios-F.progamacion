using System;

namespace Do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, vida = 3, total = 0, especial = 2,turno = 0;
            Console.WriteLine("Bienvenido al juego");
            string continuar = "s";

            while (continuar == "s")
            {
                dado = aleatorio.Next(1, 7);
                total += dado;

                bool seis = dado == 6 && turno < (turno + 1);
                bool uno = dado == 1 && turno < (turno + 1);


                Console.WriteLine("\nSu dado es: " + dado + " | su total es: " + total + " | Cuenta con " + vida + " vidas");


                if (1 <= especial && especial <= 2)
                {
                    Console.WriteLine("\nDesea usar su dado especial si/no");
                    string dadoespecial = Console.ReadLine();
                    if (dadoespecial == "si")
                    {
                        dado = aleatorio.Next(1, 13);
                        especial = especial - 1;
                        Console.WriteLine("\nSu dado especial es: " + dado + " |  le quedan:  " + especial + " Dado especial");
                        total += dado;
                    }
                    else continue;
                }

                

            
                if (uno)
                {
                    
                    dado = aleatorio.Next(1, 7);
                    
                    total += dado;
                    Console.WriteLine("Su dado es : " + dado);
                    if (dado == 1)
                    {
                      
                        Console.WriteLine("\nHa sacado dos 1s consecutivos y ha penalizado" );
                        vida = vida - 1;
                        total = total - 10;
                        if (total < 0) total = 0;
                       
                    }
                }

                if (seis)
                {
                   
                    dado = aleatorio.Next(1, 7);
                    total += dado;
                    Console.WriteLine("Su dado es : " + dado);
                    if (dado == 6)
                    {
                        
                        Console.WriteLine("\nHaz ganado una vida extra!");
                        vida = vida + 1;
                        if (vida > 3) vida = 3;
                        
                    }
                   
                }

                if (total >= 100)
                {
                    Console.WriteLine("\nHa ganado !Felicidades!");
                    break;
                }
                else if(vida == 0)
                {
                    Console.WriteLine("\nTe quedastes sin vidas");
                    break;
                }
                turno++;
                Console.WriteLine("\nDesea continuar s/n");
                continuar = Console.ReadLine();
            }
        }
    }
}
