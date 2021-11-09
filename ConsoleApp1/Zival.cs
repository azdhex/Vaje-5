using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Zival
    {
        public string Ime { get; set; }
        public abstract string Vrsta { get; }
        public int SteviloNog { get; set; }
        public Color Barva { get; set; }
        public double Velikost { get; set; }
        public double Teza { get; set; }

        public abstract void OglasiSe();

        public virtual void IzpisiLastnosti()
        {
            Console.WriteLine("Ime: " + Ime);
            Console.WriteLine("Vrsta: " + Vrsta);
            Console.WriteLine("SteviloNog: " + SteviloNog);
            Console.WriteLine("Barva: " + Barva);
            Console.WriteLine("Velikost (cm): " + Velikost);
            Console.WriteLine("Teza (kg): " + Teza);
        }
    }
}
