using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMenu
{
    public class Menu
    {

        public string[] titles = { "Hovedmenu", "1)  Variabler", "2)  Strings", "3)  Arimetiske udtryk", "4)  Variabler i udtryk", "5)  Boolske variabler", "6)  If-else statements", "7)  Switch Case", "8)  Loops", "9)  Udvidet kontrolskrukturer", "10) Metoder og instanser", "11) Returtyper og parametre", "12) Instancevariabler", "13) Nedarvning", "14) Konstruktors", "15) Arrays", "16) Gennemløb af arrays", "17) Exit menu"};
        public string[] subtitles = { "1)  Opgave 1", "2)  Opgave 2", "3)  Opgave 3", "4)  Opgave 4", "5)  Opgave 5", "6)  Opgave 6", "7)  Opgave 7", "8)  Opgave 8", "9)  Opgave 9", "10) Opgave 10", "11) Opgave 11", "Hovedmenu" };
        public string str_choice1;
        public string str_choice2;
        public int int_choice1;
        public int int_choice2;
        public bool bool_choice1;
        public bool bool_choice2;

        public void MyMenu(int x)
        {

            Console.SetCursorPosition(40, 0);
            Console.WriteLine(titles[0] + "\n");
            Console.SetCursorPosition(0, 5);

            for (int i = 1; i < x; i++)
            {
                Console.WriteLine(titles[i]);
            }
            Console.WriteLine("\nTryk 0 for at exit Hovedmenu\n");
        }

        public void Sub_Menu(int y)
        {

            for (int i = 0; i < y ; ++i)
            {
                Console.WriteLine(subtitles[i]);                               
            }
            Console.WriteLine("\nTryk 0 for at komme retur til Hovedmenu\n");
        }
    }
}

