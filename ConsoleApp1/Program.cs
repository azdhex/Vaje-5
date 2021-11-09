using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sirina = 3;
            int visina = 3;

            int[,] tab = new int[sirina, visina];

            for (int x = 0; x < sirina; x++)
            {
                for (int y = 0; y < visina; y++)
                {
                    tab[x, y] = 0;
                }
            }

            while (true)
            {
                Console.Clear();

                Console.WriteLine("╔═══╦═══╦═══╗");

                for (int y = 0; y < visina; y++)
                {
                    Console.Write("║");

                    for (int x = 0; x < sirina; x++)
                    {
                        switch (tab[x, y])
                        {
                            case 0: 
                                Console.Write("   ");
                                break;
                            case 1:
                                Console.Write(" X ");
                                break;
                            case 2:
                                Console.Write(" O ");
                                break;
                        }

                        Console.Write("║");
                    }

                    Console.WriteLine();

                    if (y < visina - 1)
                    {
                        Console.WriteLine("╠═══╬═══╬═══╣");
                    }
                }

                Console.WriteLine("╚═══╩═══╩═══╝");

                Console.WriteLine("Kam želite dati svoj simbol?");
                Console.ReadLine();
            }
        }
    }
}
