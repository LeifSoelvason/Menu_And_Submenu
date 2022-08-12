using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_And_Submenu
{
    internal class Bog
    {
        private int pris = 225;
        private int saldo = 350;
        private string forfatter;
        private string titel = "'The Dark Tower'";

        public Bog(int pris, string titel, string forfatter)  // Dette er en Set-konstruktor med 3 instans variabler.
        {
            this.pris = pris;
            this.forfatter = forfatter;
            this.titel = titel;
        }

        public Bog(string titel) : this(0, titel, "ukendt") // Dette er en Set-konstruktor med 1 instans variabler.
        {
            this.titel = titel;
        }

        public Bog() : this("ukendt") // Dette er en Set-konstruktor med 1 instans variabler.
        {
            this.titel = titel;
        }



        public void Setpris(int pris)
        { this.pris = pris; }

        public int Getpris()
        { return pris; }

        public int Getsaldo()
        { return saldo; }

        public void Settitel(string titel)
        { this.titel = titel; }

        public string Gettitel()
        { return titel; }


        public void Printinfo()
        {
            Console.WriteLine("Jeg er en bog");
            Console.ReadKey();
            Console.Clear();
        }

        public void Printinfo1()
        {
            Console.WriteLine(titel + " koster" + pris + ". Jeg har " + saldo + " kr på min konto.");
            Console.ReadKey();
            Console.Clear();
        }

        public void HarRåd1(int pris, int saldo)
        {
            if (saldo >= pris)
            {
                Console.WriteLine("Jeg har råd");
            }
            else
            {
                Console.WriteLine("Jeg har ikke råd");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void HarRåd2(int saldo)
        {
            if (saldo >= this.pris)
            {
                Console.WriteLine("Jeg har råd");
            }
            else
            {
                Console.WriteLine("Jeg har ikke råd");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void PrintInfo2()
        {
            Console.WriteLine("Titlen: {0} koster {1} kr og er skrevet af {2}", titel, pris, forfatter);
            Console.ReadKey();
            Console.Clear();
        }
    }
}