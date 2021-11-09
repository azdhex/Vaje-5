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

            while (KdoJeZmagal(tab, sirina, visina) == 0)
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

            Console.WriteLine("Zmagal je igralec: " + KdoJeZmagal(tab, sirina, visina));
            Console.ReadLine();
        }

        public static int KdoJeZmagal(int[,] tabela, int sirina, int visina)
        {
            int jeZmagal = 0;

            // Ali je kdo zmagal po stolpcih?
            for (int x = 0; x < sirina; x++)
            {
                jeZmagal = tabela[x, 0];
                for (int y = 1; y < visina; y++)
                {
                    if (jeZmagal != tabela[x, y])
                    {
                        jeZmagal = 0;
                        break;
                    }
                }

                if (jeZmagal > 0)
                {
                    return jeZmagal;
                }
            }

            // Ali je kdo zmagal po vrsticah?
            for (int y = 0; y < visina; y++)
            {
                jeZmagal = tabela[0, y];
                for (int x = 1; x < sirina; x++)
                {
                    if (jeZmagal != tabela[x, y])
                    {
                        jeZmagal = 0;
                        break;
                    }
                }

                if (jeZmagal > 0)
                {
                    return jeZmagal;
                }
            }

            // Ali je kdo zmagal po diagonalah?
            jeZmagal = tabela[0, 0];
            for (int x = 1; x < sirina; x++)
            {
                if (jeZmagal != tabela[x, x])
                {
                    jeZmagal = 0;
                    break;
                }
            }
            if (jeZmagal > 0)
            {
                return jeZmagal;
            }

            jeZmagal = tabela[sirina - 1, 0];
            for (int x = sirina - 2; x >= 0; x--)
            {
                if (jeZmagal != tabela[x, sirina - 1 - x])
                {
                    jeZmagal = 0;
                    break;
                }
            }

            if (jeZmagal > 0)
            {
                return jeZmagal;
            }

            // Nihče ni zmagal
            return 0;
        }
    }
}
