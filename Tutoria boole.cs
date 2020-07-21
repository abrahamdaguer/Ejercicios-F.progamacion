using System;

namespace tutoria_boole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Votos por el partido a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos por el partido b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos en blanco:");
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos anulados:");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Poblacion total:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje de mayores de edad:");
            double p = double.Parse(Console.ReadLine());

            // hallar la poblacion mayor de edad 
            double m = n * (p / 100);
            // math.round redondea el resultado
            Console.WriteLine("Poblacion mayor de edad:" + Math.Round(m, 0));

            // total de votantes y abstencion 
            int t = a + b + blanco + anulados;
            double abs = m - t;
            Console.WriteLine("Total de votantes:" + t  );
            Console.WriteLine("Total abstenciones:" + abs);

            bool nu = anulados < ((a + b) * 0.3);
            bool bla = (a + b) > blanco;
            
            if ((nu||bla) && (abs < t)){

                Console.WriteLine("Votaciones Exitosas");
                if (a < b)
                {
                    Console.WriteLine("Ganador de las elecciones: B");
                }
                else
                    Console.WriteLine("Ganador de las elecciones: A");


            }
            else
            {
                Console.WriteLine("Deben repetirse las elecciones");
            }


        }
    }
}
