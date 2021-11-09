using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class TabelnaIgra
    {
        private int[,] igra;


        public int Visina { get; set; }
        public int Sirina { get; set; }
        public int SteviloIgralcev { get; set; }
        private int TrenutniIgralec { get; set; }

        public TabelnaIgra(int visina, int sirina, int steviloIgralcev)
        {
            this.Visina = visina;
            this.Sirina = sirina;
            this.SteviloIgralcev = steviloIgralcev;
            this.igra = new int[sirina, visina];
        }

        public void ZacniIgro()
        {
            for (int x = 0; x < this.Sirina; x++)
            {
                for (int y = 0; y < this.Visina; y++)
                {
                    this.igra[x, y] = 0;
                }
            }

            this.TrenutniIgralec = 1;
        }

        public void Igraj(int x, int y)
        {
            this.igra[x, y] = this.TrenutniIgralec;
            this.TrenutniIgralec = this.TrenutniIgralec + 1;
            if (this.TrenutniIgralec > this.SteviloIgralcev)
            {
                this.TrenutniIgralec = 1;
            }
        }

        public void IzpisiStanje()
        {
            Console.Clear();
            Console.WriteLine("   1   2   3  ");
            Console.WriteLine(" ╔═══╦═══╦═══╗");

            for (int y = 0; y < this.Visina; y++)
            {
                Console.Write((char)((byte)'A' + y) + "║");

                for (int x = 0; x < this.Sirina; x++)
                {
                    switch (this.igra[x, y])
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

                if (y < this.Visina - 1)
                {
                    Console.WriteLine(" ╠═══╬═══╬═══╣");
                }
            }

            Console.WriteLine(" ╚═══╩═══╩═══╝");
        }

        public bool JeKonecIgre()
        {
            return KdoJeZmagal() > 0 || JeIgraPolna();
        }

        public bool JeIgraPolna()
        {
            for (int x = 0; x < this.Sirina; x++)
            {
                for (int y = 0; y < this.Visina; y++)
                {
                    if (this.igra[x, y] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public int KdoJeZmagal()
        {
            int jeZmagal = 0;

            // Ali je kdo zmagal po stolpcih?
            for (int x = 0; x < this.Sirina; x++)
            {
                jeZmagal = this.igra[x, 0];
                for (int y = 1; y < this.Visina; y++)
                {
                    if (jeZmagal != this.igra[x, y])
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
            for (int y = 0; y < this.Visina; y++)
            {
                jeZmagal = this.igra[0, y];
                for (int x = 1; x < this.Sirina; x++)
                {
                    if (jeZmagal != this.igra[x, y])
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
            jeZmagal = this.igra[0, 0];
            for (int x = 1; x < this.Sirina; x++)
            {
                if (jeZmagal != this.igra[x, x])
                {
                    jeZmagal = 0;
                    break;
                }
            }
            if (jeZmagal > 0)
            {
                return jeZmagal;
            }

            jeZmagal = this.igra[this.Sirina - 1, 0];
            for (int x = this.Sirina - 2; x >= 0; x--)
            {
                if (jeZmagal != this.igra[x, this.Sirina - 1 - x])
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
