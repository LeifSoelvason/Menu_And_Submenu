using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_And_Submenu
{
    internal class Furniture
    {
        protected double cost;
        protected string manufacturer;

        public void SetCost(double cost)
        { this.cost = cost; }

        public void SetManufacturer(string manufacturer)
        { this.manufacturer = manufacturer; }      

        public void PrintInfo()
        {
            Console.WriteLine("[Furniture] er af mærket: " + manufacturer + ". Den koster " + cost + " kr.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
