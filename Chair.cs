using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_And_Submenu
{
    internal class Chair : Furniture
    {
        protected string color;

        public void SetColor(string color)
        { this.color = color; }

        public void PrintInfo()
        {
            Console.WriteLine("[Chair] er af mærket : " + manufacturer + ". Den koster " + cost + " kr. og har farven " + color);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
