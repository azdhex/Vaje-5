using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TabelnaIgra igra = new TabelnaIgra(3, 3, 2);

            while (true)
            {
                igra.ZacniIgro();

                while (!igra.JeKonecIgre())
                {
                    igra.IzpisiStanje();

                    Console.WriteLine("Kam želite dati svoj simbol?");
                    string vnos = Console.ReadLine();

                    if (vnos.Length < 2)
                    {
                        continue;
                    }

                    int vnosX = vnos[0] - '1';
                    int vnosY = vnos[1] - 'A';

                    if (vnosX >= 3 || vnosX < 0)
                    {
                        continue;
                    }

                    if (vnosY >= 3 || vnosY < 0)
                    {
                        continue;
                    }

                    igra.Igraj(vnosX, vnosY);
                }

                Console.WriteLine("Zmagal je igralec: " + igra.KdoJeZmagal());
                Console.ReadLine();
            }
        }
    }
}
