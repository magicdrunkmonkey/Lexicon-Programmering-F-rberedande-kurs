using System;

namespace Programmering_Förberedande_kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuLooping = true;

            //Option 3 prep
            int background = 1;

            while (menuLooping)
            {
                //Menu
                Console.Clear();
                Console.WriteLine("Meny");
                Console.WriteLine("-------------");
                Console.WriteLine("1) Funktion som skriver ut \'Hello World\' i konsolen");
                Console.WriteLine("2) Funktion som tar in input från användaren (Förnamn, Efternamn, Ålder) och sedan skriver ut dessa i konsolen");
                Console.WriteLine("3) Funktion som ändrar färgen på texten i konsolen (och ändrar tillbaka om man använder funktionen igen");
                Console.WriteLine("4) Funktion för att skriva ut dagens datum");

                Console.WriteLine("\n0) Avsluta");

                //Menu input
                Console.WriteLine("\nType option and press [Enter]");
                int menuOption = Convert.ToInt32(Console.ReadLine());

                //Switch for menu option
                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("\nHello World!");

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        string firstName;
                        string lastName;
                        string age;

                        Console.WriteLine("\nFörnamn: ");
                        firstName = Console.ReadLine();
                        Console.WriteLine("\nEfternamn: ");
                        lastName = Console.ReadLine();
                        Console.WriteLine("\nÅlder: ");
                        age = Console.ReadLine();

                        Console.WriteLine("\nNamn: " + firstName + " " + lastName + "\nÅlder: " + age);

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:

                        if(background == 1)
                        {
                            background = 0;

                            // Set the Foreground color to blue
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else
                        {
                            background = 1;

                            // Reset forground color
                            Console.ResetColor();
                        }
                                                
                        break;

                    case 4:

                        DateTime thisDay = DateTime.Today;
                        Console.WriteLine("\nIdag är det "+thisDay.ToString("D"));

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 0:

                        menuLooping = false;
                        break;

                    default:
                        Console.WriteLine("Alternativet finns inte i urvalet.");

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
