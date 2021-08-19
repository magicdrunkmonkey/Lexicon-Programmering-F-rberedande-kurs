using System;
using System.IO;

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
                Console.WriteLine("7) Funktion där användaren skriver in en textrad, som sedan sparas i en fil på hårddisken (Ej klar)");
                Console.WriteLine("8) Funktion där en fil läses in från hårddisken (Ej klar)");
                Console.WriteLine("9) Funktion där användaren skickar in ett decimaltal och får tillbaka roten ur, upphöjt till 2 och upphöjt till 10");
                Console.WriteLine("10) Funktion där programmet skriver ut en multiplikationstabell från 1 till 10.");

                Console.WriteLine("\n0) Avsluta");

                //Menu input
                Console.Write("\nSkriv meny nummer och tryck [Enter]: ");
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

                    case 7:
                        
                        //Klarar inte uppgiften just nu försöker senare.

                        /*
                        Console.WriteLine("Skriv en textrad att spara till fil.");
                        string text = Console.ReadLine();

                        using (TextWriter writer = File.CreateText('C:\\Users\\%username%\\Desktop\\Uppgift7.txt'))
                        {
                            writer.WriteLine(text);
                        }
                        Console.WriteLine("Texten har sparats i C:\\Skrivbord");

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();*/
                        break;

                    case 8:

                        //Klarar inte uppgiften just nu, försöker senare

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 9:

                        Console.WriteLine("Skriv ett decimaltal och tryck [Enter].");
                        double number = Convert.ToDouble(Console.ReadLine());
                        double number10 = number;

                        Console.WriteLine("\nRoten ur " + number + " är " + Math.Sqrt(number));
                        Console.WriteLine(number + " upphöjt med 2 är " + number * number);

                        for (int i = 0; i < 9; i++)
                        {
                            number10 = number10 * number;
                        }

                        Console.WriteLine(number + " upphöjt med 10 är "+number10);

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 10:

                        {
                            int value = 10;

                            Console.Write("\n\n   |");
                            for (int x = 1; x <= value; ++x)
                            Console.Write(" {0, 4}", x);
                            Console.WriteLine("   ");
                            Console.WriteLine("________________________________________________________");

                            /*for (int x = 1; x <= value; ++x)

                                Console.WriteLine("{0, 2} |", x);
                            */
                            for (int row = 1; row <= value; ++row)
                            {
                                Console.Write("{0, 2} |", row);
                                for (int column = 1; column <= value; ++column)
                                {

                                    Console.Write("{0, 5}", row * column);

                                }
                                Console.WriteLine();

                            }
                            //Console.ReadLine();
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
            Environment.Exit(0);
        }
    }
}
