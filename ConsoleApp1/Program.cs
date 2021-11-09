using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sirina = 3;
            int visina = 3;
            int steviloIgralcev = 2;
            int trenutniIgralec = 1;

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

                Console.WriteLine("   1   2   3  ");
                Console.WriteLine(" ╔═══╦═══╦═══╗");

                for (int y = 0; y < visina; y++)
                {
                    Console.Write((char)((byte)'A' + y) + "║");
                    
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
                        Console.WriteLine(" ╠═══╬═══╬═══╣");
                    }
                }

                Console.WriteLine(" ╚═══╩═══╩═══╝");

                Console.WriteLine("Kam želite dati svoj simbol?");
                string vnos = Console.ReadLine();

                if (vnos.Length < 2)
                {
                    continue;
                }

                int vnosX = vnos[0] - '1';
                int vnosY = vnos[1] - 'A';

                if (vnosX >= sirina || vnosX < 0)
                {
                    continue;
                }

                if (vnosY >= visina || vnosY < 0)
                {
                    continue;
                }

                tab[vnosX, vnosY] = trenutniIgralec;

                trenutniIgralec = trenutniIgralec + 1;
                if (trenutniIgralec > steviloIgralcev)
                {
                    trenutniIgralec = 1;
                }
            }
        }
    }
}
