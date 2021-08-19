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

            //Option 6 prep
            bool caseSixLoop = true;

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
                Console.WriteLine("5) Funktion som tar två input värden, sedan skriver ut vilket av dem som är störst.");
                Console.WriteLine("6) Funktion som genererar att slumpmässigt tal mellan 1 och 100.");

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

                    case 5:

                        double num1, num2;

                        Console.WriteLine("Skriv ett valfritt nummer");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("\nSkriv ett till valfritt nummer");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        if (num1 > num2)
                            Console.WriteLine("\n"+num1 + " är större än " + num2);
                        else if (num2 > num1)
                            Console.WriteLine("\n"+num2 + " är större än " + num1);
                        else
                            Console.WriteLine("\nBåda värdena är lika.");

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 6:

                        Random rnd = new Random();
                        int randomNumber = rnd.Next(1, 100);
                        
                        Console.WriteLine("\nGissa på ett tal mellan 1 och 100.");
                        
                        while (caseSixLoop)
                        {
                            int guessNumber = Convert.ToInt32(Console.ReadLine());

                            if (guessNumber > randomNumber)
                                Console.WriteLine("\nGissad number är för högt!");
                            else if (guessNumber < randomNumber)
                                Console.WriteLine("\nGissad number är för lågt!");
                            else
                            {
                                Console.WriteLine("\nRätt gissat!");
                                caseSixLoop = false;
                            }
                            
                        }

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 0:
                        //Environment.Exit(0);

                        menuLooping = false;
                        break;

                    default:
                        Console.WriteLine("Alternativet finns inte i urvalet.");

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
