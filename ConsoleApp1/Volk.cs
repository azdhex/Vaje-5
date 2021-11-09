using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Volk : Zival
    {
        public override string Vrsta
        {
            get
            {
                return "Volk";
            }
        }

        public int VelikostPaka { get; set; }

        public override void OglasiSe()
        {
            Console.WriteLine("Auuuuuuu");
        }

        public override void IzpisiLastnosti()
        {
            base.IzpisiLastnosti();
            Console.WriteLine("Velikost paka: " + VelikostPaka);
        }
    }
}
