using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_And_Submenu
{
    internal class Computer : Chair
    {
        private int vægt;

        public void SetVægt(int vægt)
        { this.vægt = vægt; }

        public void PrintInfo()
        {
            Console.WriteLine("[Computer] er af mærket : " + manufacturer + ". Den koster " + cost + " kr Farven er " + color + ", og den vejer " + vægt + " Kg.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}




