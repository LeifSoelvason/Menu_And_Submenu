using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_And_Submenu
{
    internal class Bil
    {

        public void StartMotor()
        {
            Console.WriteLine("Motoren er startet");
            Console.ReadKey();
            Console.Clear();
        }
        public void SLukMotor()
        {
            Console.WriteLine("Motoren er slukket");
            Console.ReadKey();
            Console.Clear();
        }

        public void FillGas1(double liters)
        {
            Console.Write("Filled tank with: " + liters + " liters");
            Console.ReadKey();
            Console.Clear();
        }

        public void FillGas2(double liters, bool isDiesel)
        {
            Console.Write("Filled tank with: " + liters + " liters of ");

            if (isDiesel)
            {
                Console.WriteLine("diesel");
            }

            else
            {
                Console.WriteLine("benzin");
            }

            Console.ReadKey();
            Console.Clear();
        }

        public double RemaningGas() //returner en double, da metode er oprettet som double.
        {
            return 5;
        }
    }
}