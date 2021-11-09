using System;
using System.Drawing;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TabelnaIgra igra = new TabelnaIgra(3, 3, 2);

            //while (true)
            //{
            //    igra.ZacniIgro();

            //    while (!igra.JeKonecIgre())
            //    {
            //        igra.IzpisiStanje();

            //        Console.WriteLine("Kam želite dati svoj simbol?");
            //        string vnos = Console.ReadLine();

            //        if (vnos.Length < 2)
            //        {
            //            continue;
            //        }

            //        int vnosX = vnos[0] - '1';
            //        int vnosY = vnos[1] - 'A';

            //        if (vnosX >= 3 || vnosX < 0)
            //        {
            //            continue;
            //        }

            //        if (vnosY >= 3 || vnosY < 0)
            //        {
            //            continue;
            //        }

            //        igra.Igraj(vnosX, vnosY);
            //    }

            //    Console.WriteLine("Zmagal je igralec: " + igra.KdoJeZmagal());
            //    Console.ReadLine();
            //}

            Zival lev = new Lev()
            {
                Barva = Color.Beige,
                DolzinaGrive = 20,
                Ime = "Levko",
                SteviloNog = 4,
                Teza = 300,
                Velikost = 100
            };

            Zival volk = new Volk()
            {
                Barva = Color.Beige,
                VelikostPaka = 5,
                Ime = "Vuk",
                SteviloNog = 4,
                Teza = 250,
                Velikost = 80
            };

            volk.OglasiSe();
            lev.OglasiSe();

            volk.IzpisiLastnosti();
            lev.IzpisiLastnosti();

            Console.ReadLine();
        }
    }
}
