using TestMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Menu_And_Submenu
{
    internal class TestMenu
    {
        public static bool Done = false;
        public static bool AllDone = false;

        static void Main(string[] args)
        {
            do
            {
               ///                                                         
                Menu Obj = new Menu();
                Obj.MyMenu(17);
                Obj.str_choice1 = Console.ReadLine();
                Console.Clear();
                Obj.bool_choice1 = int.TryParse(Obj.str_choice1, out Obj.int_choice1);
                

                if (Obj.int_choice1 >= 0 && Obj.int_choice1 < 17 && Obj.bool_choice1)

                {
                        switch (Obj.int_choice1)
                        {
                        case 0:
                            {
                                Done = true;
                            }
                            break;

                            case 1:
                            {
                                
                                do
                                {                                  
                                    Obj.Sub_Menu(6);                         
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 7 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;
                                            case 1:
                                                {//Variabler - Opgave 1.

                                                    int tal1 = 5;
                                                    int tal2 = 3;

                                                    Console.WriteLine(tal1);
                                                    Console.WriteLine(tal2);
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;
                                            case 2:
                                                {//Variabler - Opgave 2.

                                                    int tal1 = 5;
                                                    int tal2 = 3;

                                                    Console.WriteLine("tal1 er " + tal1);
                                                    Console.WriteLine("tal2 er " + tal2);
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;

                                            case 3:
                                                {//Variabler - Opgave 3.

                                                    string Navn = "Søren";
                                                    int Alder = 16;
                                                    double Penge = 1234.34;

                                                    Console.WriteLine("Jeg hedder " + Navn + " er " + Alder + " år gammel og har tjent " + Penge + " kr. på at lappe cykler.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;

                                            case 4:
                                                {//Variabler - Opgave 4.

                                                    double Kage = 23.56;
                                                    double Øl = 34.67;
                                                    double Pølse = 65.34;
                                                    double ialt = Kage + Øl + Pølse;

                                                    Console.WriteLine("Kage  " + Kage);
                                                    Console.WriteLine("Øl    " + Øl);
                                                    Console.WriteLine("Pølse " + Pølse);
                                                    Console.WriteLine("\nIalt " + ialt);
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                }
                                                break;

                                            case 5:
                                                {//Variabler - Opgave 5.

                                                    string Navn;
                                                    int Alder;

                                                    Console.WriteLine("Hvad er dit navn?  ");
                                                    Navn = Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("Hvad er din alder? ");
                                                    //Alder = Convert.ToInt32(Console.ReadLine());
                                                    var succes = Int32.TryParse(Console.ReadLine(), out Alder);

                                                    if (!succes) Console.WriteLine("InValidt Value in \"Alder\"");

                                                    Console.Clear();
                                                    Console.WriteLine("Jeg hedder " + Navn + " og er " + Alder + " år gammel.");
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                }
                                                break;

                                            case 6:
                                                {//Variabler - Opgave 6.



                                                    //Opret variabler.
                                                    //Bruger double, da der kan være decimaltal i formlen for Areal.

                                                    double radius;


                                                    //Modtag input fra bruger og omregn string (radius) til tal.

                                                    Console.Write("Hvad er cirklens radius angivet i cm?: ");
                                                    radius = double.Parse(Console.ReadLine());
                                                    Console.Clear();


                                                    //Beregning.
                                                    // Formlen for en cirkels areal: A = pi * r².   

                                                    double areal = Math.PI * Math.Pow(radius, 2);

                                                    //Skriv til skærm.
                                                    //I anden potens tegnet findes ved: Alt + 253.

                                                    Console.Write("Når cirklens radius er: {0:N2} cm   så er dens areal: {1:N2} cm².", radius, areal);
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;                                            
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 1-6");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);

                            }
                            break;
                        case 2:
                            {
                                do
                                {

                                    Obj.Sub_Menu(4);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 5 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;

                                            case 1:
                                                {//Strings - Opgave 1.
                                                    string Navn = "Peter";
                                                    int Alder = 50;
                                                    double Højde = 1.85;

                                                    Console.WriteLine(Navn);
                                                    Console.WriteLine(Alder);
                                                    Console.WriteLine(Højde);
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                }
                                                break;

                                            case 2:
                                                {//Strings - Opgave 2.

                                                    string Navn = "Peter";
                                                    int Alder = 50;
                                                    double Højde = 1.85;

                                                    Alder = 55;

                                                    Console.WriteLine(Alder);
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;

                                            case 3:
                                                {//Strings - Opgave 3.

                                                    string Dato = "I dag har vi den 24. December.";

                                                    Console.WriteLine(Dato);
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;

                                            case 4:
                                                {//Strings - Opgave 4.

                                                    double Saldo = 200.50;
                                                    string txt1 = "Jeg har ";
                                                    string txt2 = "kr. i banken";

                                                    Console.WriteLine("{0}{1:N2}{2}", txt1, Saldo, txt2);
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;                                            
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 1-4");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);

                            }
                            break;

                        case 3:
                            {
                                do
                                {
                                    Obj.Sub_Menu(1);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 2 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;

                                            case 1:
                                                {//Arimetiske udtryk - Opgave 1.

                                                    int a = 2 + 1 * 2;
                                                    int b = (2 + 1) * 2;
                                                    double c = 5 / 2;    // Da begge variabler er hele tal, bliver resultatet også helt tal på trods af variablen er af typen double.
                                                    int d = 8 % 3;
                                                    int e = 1 - 5;

                                                    Console.WriteLine(a);
                                                    Console.WriteLine(b);
                                                    Console.WriteLine(c);
                                                    Console.WriteLine(d);
                                                    Console.WriteLine(e);
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;                                            
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 1-2");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);

                            }
                            break;
                        
                        case 4:
                            {
                                do
                                {
                                    Obj.Sub_Menu(2);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 3 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;

                                            case 1:
                                                {//Variabler i udtryk - Opgave 1.

                                                    int x = 2;
                                                    int y = 3;
                                                    int z = 4;
                                                    int result;

                                                    result = x + y * z;
                                                    Console.WriteLine(result);



                                                    result = (x + y) * z;
                                                    Console.WriteLine(result);



                                                    result = (x + z) / y;
                                                    Console.WriteLine(result);



                                                    result = x + y - z;
                                                    Console.WriteLine(result);


                                                    result = (y + z) % x;
                                                    Console.WriteLine(result);
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;

                                            case 2:
                                                {//Variabler i udtryk - Opgave 2.

                                                    int Alder = 55;
                                                    int Vægt = 75;
                                                    double Højde = 1.85;
                                                    string Navn = "Peter";

                                                    Console.WriteLine("Jeg hedder " + Navn + ", og jeg er " + Højde + " cm høj. Jeg vejer " + Vægt + " kg og jeg er " + Alder + " år gammel.");
                                                    Console.ReadKey();
                                                    Console.Clear();


                                                }
                                                break;
                                          
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 1-2");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);

                            }
                            break;

                        case 5:
                            {
                                do
                                {
                                    Obj.Sub_Menu(1);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 2 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;

                                            case 1:
                                                {//Boolske variabler - Opgave 1.

                                                    int var1 = 2;
                                                    int var2 = 3;
                                                    bool result = var1 > var2;

                                                    Console.WriteLine(result);
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                {
                                                    int var1 = 4;
                                                    int var2 = 3;
                                                    bool result = var1 > var2;

                                                    Console.WriteLine(result);
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;                                
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 0-1");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);
                            }
                            break;
                        case 6:
                            {
                                do
                                {
                                    Obj.Sub_Menu(7);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 8 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;

                                            case 1:
                                                {//If-else statements - Opgave 1.

                                                    int tal1 = 42;
                                                    int tal2 = 64;
                                                    int resultat = tal1 + tal2;

                                                    if (resultat > 100)
                                                    {
                                                        Console.WriteLine("Summen er større end 100!");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }
                                                    else if (resultat < 100)
                                                    {
                                                        Console.WriteLine("Summen er mindre end 100");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Summen er 100");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }

                                                }
                                                break;

                                            case 2:
                                                {//If-else statements - Opgave 2.

                                                    int alder;

                                                    Console.WriteLine("Hvad er din alder? ");
                                                    alder = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    if (alder > 57)
                                                    {
                                                        Console.WriteLine("Du er for gammel.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Du er ikke for gammel");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }

                                                }
                                                break;

                                            case 3:
                                                {//If-else statements - Opgave 3.

                                                    int alder;

                                                    Console.WriteLine("Hvad er din alder? ");
                                                    alder = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    if (alder > 60)
                                                    {
                                                        Console.WriteLine("Du er for gammel");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }

                                                    else if (alder >= 50 && alder <= 60)
                                                    {
                                                        Console.WriteLine("Du er hverken for gammel eller for ung.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }

                                                    else
                                                    {
                                                        Console.WriteLine("Du er for ung.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }
                                                }
                                                break;

                                            case 4:
                                                {//If-else statements - Opgave 4.

                                                    string navn = "Peter";
                                                    string brugernavn = "PP";
                                                    int password = 1020;

                                                    Console.WriteLine("Indtast dit navn ");
                                                    navn = Console.ReadLine();
                                                    Console.Clear();

                                                    Console.WriteLine("Indtast dit brugernavn ");
                                                    brugernavn = Console.ReadLine();
                                                    Console.Clear();

                                                    Console.WriteLine("Indtast dit password ");
                                                    password = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    if (brugernavn == "pp" && password == 1020)
                                                    {
                                                        Console.WriteLine("Velkommen " + navn);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }

                                                    else
                                                    {
                                                        Console.WriteLine("brugernavn eller password er forkert");
                                                        Console.ReadKey();
                                                        Console.Clear();

                                                    }

                                                }
                                                break;

                                            case 5:
                                                {//If-else statements - Opgave 5.

                                                    string navn = "Peter";
                                                    string brugernavn = "PP";
                                                    int password = 1020;

                                                    Console.WriteLine("Indtast dit brugernavn ");
                                                    brugernavn = Console.ReadLine();
                                                    Console.Clear();

                                                    if (brugernavn != "pp")
                                                    {
                                                        Console.WriteLine("Brugernavnet er forkert");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }

                                                    else
                                                    {
                                                        Console.WriteLine("Venligst indtast dit password ");
                                                        password = Convert.ToInt32(Console.ReadLine());
                                                        Console.Clear();

                                                        if (password != 1020)
                                                        {
                                                            Console.WriteLine("Passwordet er forkert");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        }

                                                        else
                                                        {
                                                            Console.WriteLine("Velkommen " + navn);
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        }
                                                    }
                                                }
                                                break;

                                            case 6:
                                                {//If-else statements - Opgave 6.

                                                    int antalKm;
                                                    double fradrag1;
                                                    double fradrag2;

                                                    Console.WriteLine("Hvor mange km kører du hver dag til og fra arbejde? ");
                                                    antalKm = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    if (antalKm <= 24)
                                                    {
                                                        Console.WriteLine("Du får ikke noget fradrag");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }

                                                    else if (antalKm >= 25.00 && antalKm <= 120.00)
                                                    {
                                                        fradrag1 = (antalKm - 24) * 1.93;
                                                        Console.WriteLine("Dit fradrag er på " + fradrag1 + " kr.");
                                                        Console.ReadKey();
                                                        Console.Clear();

                                                    }

                                                    else
                                                    {
                                                        fradrag2 = 96 * 1.93 + (antalKm - 120) * 0.97;
                                                        Console.WriteLine("Dit fradrag er på " + fradrag2 + " kr.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }


                                                }
                                                break;

                                            case 7:
                                                {//If-else statements - Opgave 7.

                                                    Console.Title = "Festen";

                                                    string ynglingsfarve;
                                                    string alder;
                                                    int minAlder;
                                                    string baggrundsfarve;


                                                    Console.WriteLine("Vælg en farve (rød, grøn, blå eller gul)");
                                                    ynglingsfarve = Console.ReadLine();
                                                    Console.Clear();

                                                    if (ynglingsfarve == "rød")

                                                    {
                                                        Console.BackgroundColor = ConsoleColor.Red;
                                                        Console.Clear();
                                                    }

                                                    else if (ynglingsfarve == "grøn")
                                                    {
                                                        Console.BackgroundColor = ConsoleColor.Green;
                                                        Console.Clear();
                                                    }

                                                    else if (ynglingsfarve == "blå")
                                                    {
                                                        Console.BackgroundColor = ConsoleColor.Blue;
                                                        Console.Clear();
                                                    }

                                                    else if (ynglingsfarve == "gul")
                                                    {
                                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                                        Console.Clear();
                                                    }

                                                    Console.WriteLine("Hvad er din alder? ");
                                                    alder = Console.ReadLine();
                                                    minAlder = Convert.ToInt32(alder);
                                                    Console.Clear();

                                                    if (minAlder >= 18)
                                                    {
                                                        Console.WriteLine("Velkommen til cocktailbaren");
                                                        Thread.Sleep(10000);
                                                        Console.ResetColor();
                                                        Console.Clear();

                                                    }

                                                    else
                                                    {
                                                        Console.WriteLine("Velkommen til sodavandsbaren");
                                                        Thread.Sleep(10000);
                                                        Console.ResetColor();
                                                        Console.Clear();

                                                    }
                                                }
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 1-7");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);

                            }
                            break;
                        case 7:
                            {
                                do
                                {
                                    Obj.Sub_Menu(2);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 3 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {                                                
                                                    {
                                                        AllDone = true;
                                                    }
                                                    break;
                                        }
                                            case 1:
                                                {//Switch Case - Opgave 1.

                                                    int myChoice;

                                                    Console.WriteLine("Indtast et tal imellem 1-6 ");
                                                    myChoice = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    switch (myChoice)
                                                    {



                                                        case 1:
                                                            {
                                                                Console.WriteLine("Du har tastet " + myChoice);
                                                                Console.ReadKey();
                                                                Console.Clear();

                                                            }
                                                            break;

                                                        case 2:
                                                            {
                                                                Console.WriteLine("Du har tastet " + myChoice);
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            break;

                                                        case 3:
                                                            {
                                                                Console.WriteLine("Du har tastet " + myChoice);
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            break;

                                                        case 4:
                                                            {
                                                                Console.SetCursorPosition(45, 15);
                                                                Console.WriteLine("TILLYKKE DU HAR VUNDET!");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            break;

                                                        case 5:
                                                            {
                                                                Console.WriteLine("Du har tastet " + myChoice);
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            break;

                                                        case 6:
                                                            {

                                                            }
                                                            break;

                                                        default:
                                                            {
                                                                Console.WriteLine("Du har tastet forkert.Tallet skal være mellem 1 og 6");
                                                                Thread.Sleep(10000);
                                                                Console.Clear();
                                                            }
                                                            break;
                                                    }
                                                }
                                                break;

                                            case 2:
                                                {//Switch Case - Opgave 2.

                                                    int menuChoice;
                                                    int[] drinkPris = { 45, 50, 55, 60, 75, 80 };
                                                    string[] drinkName = { "Isbjørn", "Champagnebrus", "Tequila Sunrise", "Mojito", "Brandbil", "Filur" };

                                                    Console.WriteLine("Vælg en drink \n");
                                                    Console.WriteLine("1) " + drinkName[0]);
                                                    Console.WriteLine("2) " + drinkName[1]);
                                                    Console.WriteLine("3) " + drinkName[2]);
                                                    Console.WriteLine("4) " + drinkName[3]);
                                                    Console.WriteLine("5) " + drinkName[4]);
                                                    Console.WriteLine("6) " + drinkName[5]);
                                                    Console.WriteLine("\n");
                                                    menuChoice = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    switch (menuChoice)
                                                    {
                                                        
                                                        case 1:
                                                            {
                                                                Console.WriteLine("Du har valgt en " + drinkName[0] + " som koster " + drinkPris[0] + " kr.");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            break;

                                                        case 2:
                                                            {
                                                                Console.WriteLine("Du har valgt en " + drinkName[1] + " som koster " + drinkPris[1] + " kr.");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            break;

                                                        case 3:
                                                            {
                                                                Console.WriteLine("Du har valgt en " + drinkName[2] + " som koster " + drinkPris[2] + " kr.");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            break;

                                                        case 4:
                                                            {
                                                                Console.WriteLine("Du har valgt en " + drinkName[3] + " som koster " + drinkPris[3] + " kr.");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            break;

                                                        case 5:
                                                            {
                                                                Console.WriteLine("Du har valgt en " + drinkName[4] + " som koster " + drinkPris[4] + " kr.");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            break;

                                                        case 6:
                                                            {
                                                                Console.WriteLine("Du har valgt en " + drinkName[5] + " som koster " + drinkPris[5] + " kr.");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            break;
                                                    }
                                                }
                                                break;                                      
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 1-2");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);
                            }
                            break;
                        case 8:
                            {
                                do
                                {
                                    Obj.Sub_Menu(9);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 10 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;

                                            case 1:
                                                {//Loops - Opgave 1.

                                                    for (int i = 1; i <= 10; i++)
                                                    {
                                                        Console.WriteLine(i);
                                                    }
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                    {
                                                        int i = 1;
                                                        while (i <= 10)
                                                        {
                                                            Console.WriteLine(i);
                                                            i++;
                                                        }

                                                    }
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;

                                            case 2:
                                                {//Loops - Opgave 2.

                                                    for (int i = 100; i > 0; i--)
                                                    {
                                                        Console.WriteLine(i);
                                                    }
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                    {
                                                        int i = 100;
                                                        while (i > 0)
                                                        {
                                                            Console.WriteLine(i);
                                                            i--;
                                                        }
                                                    }
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                }
                                                break;

                                            case 3:
                                                {//Loops - Opgave 3.

                                                    for (int i = 0; i <= 50; i += 5)
                                                    {
                                                        Console.WriteLine(i);
                                                    }
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;

                                            case 4:
                                                {//Loops - Opgave 4.

                                                    for (int i = 20; i >= 0; i--)
                                                    {
                                                        Console.WriteLine(i);
                                                    }
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                    {
                                                        int i = 20;
                                                        while (i >= 0)
                                                        {
                                                            Console.WriteLine(i);
                                                            i--;
                                                        }
                                                    }
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;

                                            case 5:
                                                {//Loops - Opgave 5.

                                                    int i;
                                                    int num = 7;

                                                    for (i = 1; i <= 10; i++)
                                                    {

                                                        Console.Write("{0,2} X {1,2} =  {2,2} \n", num, i, num * i);
                                                    }
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;

                                            case 6:
                                                {//Loops - Opgave 6.

                                                    int i;
                                                    int tal;


                                                    Console.WriteLine("Vælg et tal og udskriv dens tabel: \n");
                                                    tal = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    for (i = 0; i <= 10; i++)
                                                    {

                                                        Console.Write("{0,2} X {1,2} = {2,2} \n", tal, i, tal * i);
                                                    }
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                }
                                                break;

                                            case 7:
                                                {//Loops - Opgave 7.
                                                    {

                                                        int x;
                                                        int y;


                                                        for (x = 20; x <= 30; x++)
                                                        {
                                                            Console.SetCursorPosition(x, 4);
                                                            Console.Write('*');

                                                            for (y = 4; y <= 8; y++)
                                                            {
                                                                Console.SetCursorPosition(30, y);
                                                                Console.Write('*');
                                                            }

                                                        }
                                                        for (y = 4; y <= 8; y++)
                                                        {
                                                            Console.SetCursorPosition(20, y);
                                                            Console.Write('*');

                                                            for (x = 20; x <= 30; x++)
                                                            {
                                                                Console.SetCursorPosition(x, 8);
                                                                Console.Write('*');
                                                            }
                                                        }
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }
                                                }
                                                break;

                                            case 8:
                                                {//Loops - Opgave 8.

                                                    {
                                                        int x;
                                                        int y;

                                                        for (x = 20; x <= 30; x++)
                                                        {
                                                            Console.SetCursorPosition(x, 4);
                                                            Console.Write('*');

                                                            for (y = 4; y <= 8; y++)
                                                            {
                                                                Console.SetCursorPosition(30, y);
                                                                Console.Write('*');

                                                            }

                                                        }
                                                        for (y = 4; y <= 8; y++)
                                                        {
                                                            Console.SetCursorPosition(20, y);
                                                            Console.Write('*');

                                                            for (x = 20; x <= 30; x++)
                                                            {
                                                                Console.SetCursorPosition(x, 8);
                                                                Console.Write('*');

                                                            }

                                                            Console.SetCursorPosition(23, 6);
                                                            Console.WriteLine("Leif");

                                                        }
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }
                                                }
                                                break;

                                            case 9:
                                                {//Loops - Opgave 9.

                                                    int x;
                                                    int bredde;
                                                    int y;
                                                    int højde;
                                                    string navn;

                                                    Console.WriteLine("Angiv bredden på rammen: ");
                                                    bredde = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine("Angiv højde på rammen: ");
                                                    højde = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine("Angiv dit navn: ");
                                                    navn = Console.ReadLine();
                                                    Console.Clear();

                                                    for (x = 0; x <= bredde; x++)

                                                    {
                                                        Console.SetCursorPosition(x, 0);
                                                        Console.WriteLine("x");
                                                        Console.SetCursorPosition(x, højde);
                                                        Console.WriteLine("x");
                                                    }

                                                    for (y = 0; y <= højde; y++)

                                                    {
                                                        Console.SetCursorPosition(0, y);
                                                        Console.WriteLine("x");
                                                        Console.SetCursorPosition(bredde, y);
                                                        Console.WriteLine("x");
                                                    }

                                                    int z = (bredde / 2) - 2;
                                                    int w = højde / 2;
                                                    Console.SetCursorPosition(z, w);
                                                    Console.WriteLine(navn);
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;                                          
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 1-9");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);
                            }
                            break;

                        case 9:
                            {
                                do
                                {
                                    Obj.Sub_Menu(5);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 6 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;

                                            case 1:
                                                {//Udvidet kontrolskrukturer - Opgave 1.

                                                    for (int i = 0; i <= 30; i += 3)
                                                    {
                                                        if (i == 21)
                                                        {
                                                            Console.WriteLine("Loopen er nu stoppet.");
                                                            break;
                                                        }
                                                        Console.WriteLine(i);
                                                    }
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;

                                            case 2:
                                                {//Udvidet kontrolskrukturer - Opgave 2.

                                                    int i = 0;
                                                    while (i <= 40)
                                                    {

                                                        if (i == 16)
                                                        {
                                                            i += 4;
                                                            continue;

                                                        }
                                                        if (i == 40)
                                                        {

                                                            Console.WriteLine(i + " Loopen er nu slut");
                                                            break;
                                                        }

                                                        Console.WriteLine(i);
                                                        i += 4;

                                                    }
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                }
                                                break;

                                            case 3:
                                                {//Udvidet kontrolskrukturer - Opgave 3.

                                                    int antalKm;
                                                    double fradrag1;
                                                    double fradrag2;

                                                    Console.WriteLine("Hvor mange km kører du hver dag til og fra arbejde? ");
                                                    antalKm = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    if (antalKm <= 24)
                                                    {
                                                        Console.WriteLine("Du får ikke noget fradrag");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }

                                                    else if (antalKm >= 25.00 && antalKm <= 100.00)
                                                    {
                                                        fradrag1 = (antalKm - 24) * 1.54;
                                                        Console.WriteLine("Dit fradrag er på " + fradrag1 + " kr.");
                                                        Console.ReadKey();
                                                        Console.Clear();

                                                    }

                                                    else
                                                    {
                                                        fradrag2 = (76 * 1.54) + (antalKm - 100) * 0.77;
                                                        Console.WriteLine("Dit fradrag er på " + fradrag2 + " kr.");
                                                        Console.ReadKey();
                                                        Console.Clear();

                                                    }
                                                }
                                                break;

                                            case 4:
                                                {//Udvidet kontrolskrukturer - Opgave 4.

                                                    int indkomst;
                                                    double skat1;
                                                    double skat2;
                                                    double skat3;

                                                    Console.WriteLine("Angiv indkomst: ");
                                                    indkomst = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    if (indkomst <= 42000)
                                                    {
                                                        Console.WriteLine("Der skal ikke betales skat.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }

                                                    else if (indkomst >= 42000 && indkomst < 280000)
                                                    {
                                                        skat1 = (indkomst - 42000) * 0.30;
                                                        Console.WriteLine("Der skal betales " + skat1 + " kr. i skat");
                                                        Console.ReadKey();
                                                        Console.Clear();

                                                    }

                                                    else if (indkomst >= 280000 && indkomst < 390000)
                                                    {
                                                        skat2 = 238.000 * 0.3 + (indkomst - 280000) * 0.06;
                                                        Console.WriteLine("Der skal betales " + skat2 + " kr. i skat");
                                                        Console.ReadKey();
                                                        Console.Clear();

                                                    }

                                                    else
                                                    {
                                                        skat3 = (238.000 * 0.3) + (110000 * 0.06) + (indkomst - 390000) * 0.15;
                                                        Console.WriteLine("Der skal betales " + skat3 + " kr. i skat");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }
                                                }
                                                break;

                                            case 5:
                                                {//Udvidet kontrolskrukturer - Opgave 5.

                                                    int saldo;
                                                    double rente1;
                                                    double rente2;
                                                    double rente3;

                                                    Console.WriteLine("Angiv saldo på din rente-konto: ");
                                                    saldo = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    if (saldo < 25000)
                                                    {
                                                        rente1 = saldo * 0.0025;
                                                        Console.WriteLine("Du får {0:N2} kr. i renter på din konto pr. år.", rente1);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }

                                                    else if (saldo >= 25000 && saldo < 150000)
                                                    {
                                                        rente2 = (25000 * 0.0025) + (saldo - 25000) * 0.0125;
                                                        Console.WriteLine("Du får {0:N2} kr. i renter på din konto pr. år.", rente2);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }

                                                    else if (saldo > 150000)
                                                    {
                                                        rente3 = 150000 * 0.0125 + (saldo - 150000) * 0.005;
                                                        Console.WriteLine("Du får {0:N2} kr. i renter på din konto pr. år.", rente3);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }
                                                }
                                                break;                                          
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 1-5");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);
                            }
                            break;

                        case 10:
                            {
                                do
                                {
                                    Obj.Sub_Menu(2);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 3 && Obj.bool_choice2)                                        
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;

                                            case 1:
                                                {//Metoder og instanser - Opgave 1.

                                                    Bog SherlockHolmes = new Bog();
                                                    {
                                                        SherlockHolmes.Printinfo();        
                                                    }

                                                }
                                                break;

                                            case 2:
                                                {//Metoder og instanser - Opgave 2.

                                                    Bog SherlockHolmes = new Bog();
                                                    {
                                                       SherlockHolmes.HarRåd1(150, 200);
                                                    }

                                                }
                                                break;                                         
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 1-2");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);

                            }
                            break;

                        case 11:
                            {
                                do
                                {
                                    Obj.Sub_Menu(4);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 5 && Obj.bool_choice2)                                        
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;

                                            case 1:
                                                {//Returtyper og parametre - Opgave 1.


                                                    Bil myCar = new Bil();      

                                                    myCar.StartMotor();
                                                    myCar.SLukMotor();

                                                }
                                                break;

                                            case 2:
                                                {//Returtyper og parametre - Opgave 2.

                                                    Bil myCar = new Bil();

                                                    double liters = 2.5;

                                                   myCar.FillGas1(liters);

                                                }
                                                break;

                                            case 3:
                                                {//Returtyper og parametre - Opgave 3.


                                                    Bil myCar = new Bil();

                                                    double liters = 2.5;

                                                    myCar.FillGas2(liters, true);


                                                }
                                                break;

                                            case 4:
                                                {//Returtyper og parametre - Opgave 4.

                                                    Bil myCar = new Bil();

                                                    myCar.RemaningGas();

                                                    /* : "Fang" return værdien (5) fra metoden oprettet under Class Bil:
                                                          gas = Console.WriteLine(myObj.RemaningGas(). 
                                                          Console.WriteLine(gas + " L remaining");
                                                          Alternativt brug metoden med den returneret værdi/variabel direkte i udskrivning:
                                                    */

                                                    Console.WriteLine(myCar.RemaningGas() + " L remaining");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 1-4");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);
                            }
                            break;

                        case 12:
                            {
                                do
                                {
                                    Obj.Sub_Menu(1);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 2 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;
                                            case 1:
                                                {//Instancevariabler - Opgave 1.

                                                    Bog SherlockHolmes = new Bog();
                                                    {
                                                        SherlockHolmes.Setpris(240);          //Udskift instancevariabel pris ved hjælp af set-metoden for pris.
                                                        SherlockHolmes.Settitel("Moby Dick"); //Udskift instancevariabel title ved hjælp af set-metoden for titel.
                                                        SherlockHolmes.HarRåd2(350);
                                                        Console.WriteLine("Titlen " + SherlockHolmes.Gettitel() + " koster " + SherlockHolmes.Getpris() + " kr. og jeg har " + SherlockHolmes.Getsaldo() + " kr. på min konto.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }
                                                }
                                                break;                                          
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 0-1");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);

                            }
                            break;

                        case 13:
                            {
                                do
                                {
                                    Obj.Sub_Menu(1);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 2 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;

                                            case 1:
                                                {//Nedarvning - Opgave 1.

                                                    Furniture myF = new Furniture();
                                                    myF.SetCost(150.55);
                                                    myF.SetManufacturer("Apple");
                                                    myF.PrintInfo();

                                                    Chair myChair = new Chair();
                                                    myChair.SetCost(175.75);
                                                    myChair.SetManufacturer("Wood");
                                                    myChair.SetColor("rød");
                                                    myChair.PrintInfo();

                                                    Computer myComputer = new Computer();
                                                    myComputer.SetCost(875.25);
                                                    myComputer.SetManufacturer("HP");
                                                    myComputer.SetColor("sort");
                                                    myComputer.SetVægt(8);
                                                    myComputer.PrintInfo();
                                                }
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 0-1");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);
                            }
                            break;

                        case 14:
                            {
                                do
                                {
                                    Obj.Sub_Menu(1);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 2 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;

                                            case 1:
                                                {//Konstruktors - Opgave 1.

                                                    Bog myBook = new Bog(240, "'Moby Dick'", "Herman Melville");
                                                    myBook.PrintInfo2();

                                                    Bog myNewBook = new Bog("'The Dark Tower'");
                                                    myNewBook.PrintInfo2();

                                                    Bog myNextBook = new Bog();
                                                    myNextBook.PrintInfo2();
                                                }
                                                break;                                         
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 0-1");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);
                            }
                            break;

                        case 15:
                            {
                                do
                                {
                                    Obj.Sub_Menu(1);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 2 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;

                                            case 1:
                                                {//Arrays - Opgave 1.

                                                    /*   int[] tal = { -2, -1, 0, 10 };

                                                       Console.WriteLine(tal[1]);
                                                       Console.ReadKey();
                                                       Console.Clear();
                                                    */

                                                    int[] tal = new int[4];
                                                    tal[0] = -2;
                                                    tal[1] = -1;
                                                    tal[2] = 0;
                                                    tal[3] = 10;

                                                    Console.WriteLine(tal[3]);
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                    Console.WriteLine(tal[1]);
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                    int sum = tal.Sum();
                                                    Console.WriteLine(sum);
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;                                         
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 0-1");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);
                            }
                            break;

                        case 16:
                            {
                                do
                                {
                                    Obj.Sub_Menu(1);
                                    Obj.str_choice2 = Console.ReadLine();
                                    Console.Clear();
                                    Obj.bool_choice2 = int.TryParse(Obj.str_choice2, out Obj.int_choice2);

                                    if (Obj.int_choice2 >= 0 && Obj.int_choice2 < 2 && Obj.bool_choice2)
                                    {
                                        switch (Obj.int_choice2)
                                        {
                                            case 0:
                                                {
                                                    AllDone = true;
                                                }
                                                break;

                                            case 1:
                                                {//Gennemløb af arrays - Opgave 1.

                                                    int[] tal = { 1, 2, 3, 4, 5, 6 };

                                                    for (int i = 0; i < tal.Length; i++)
                                                    {

                                                    }
                                                    int sum = tal.Sum();
                                                    Console.WriteLine(sum);
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                    string[] farve = { "rød", "hvid", "sort", "blå", "gul" };

                                                    for (int i = 0; i < farve.Length; i++)
                                                    {
                                                        Console.WriteLine(farve[i]);
                                                    }
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;                 
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a number between 0-1");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                while (!AllDone);


                            }
                            break;                       
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1-16");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (!Done);
        }
    }
}

