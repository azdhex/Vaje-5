using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Lev : Zival
    {
        public override string Vrsta
        {
            get
            {
                return "Lev";
            }
        }

        public int DolzinaGrive { get; set; }

        public override void OglasiSe()
        {
            Console.WriteLine("Rawrrrrr");
        }

        public override void IzpisiLastnosti()
        {
            base.IzpisiLastnosti();
            Console.WriteLine("Dolžina grive (cm): " + DolzinaGrive);
        }
    }
}
