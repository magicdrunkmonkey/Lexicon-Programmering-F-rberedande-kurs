using System;

namespace Programmering_Förberedande_kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Menu
            Console.WriteLine("Meny");
            Console.WriteLine("-------------");
            Console.WriteLine("1) Funktion som skriver ut \'Hello World\' i konsolen");
            Console.WriteLine("2) Funktion som tar in input från användaren (Förnamn, Efternamn, Ålder) och sedan skriver ut dessa i konsolen");

            //Menu input
            Console.WriteLine("\nType option and press [Enter]");
            int menuOption = Convert.ToInt32(Console.ReadLine());

            //Switch for menu option
            switch (menuOption)
            {
                case 1:
                    Console.WriteLine("Hello World!");
                    break;

                case 2:
                    string firstName;
                    string lastName;
                    string age;

                    Console.WriteLine("Förnamn: ");
                    firstName = Console.ReadLine();
                    Console.WriteLine("Efternamn: ");
                    lastName = Console.ReadLine();
                    Console.WriteLine("Ålder: ");
                    age = Console.ReadLine();

                    Console.WriteLine("\nNamn: "+firstName + " " + lastName + "\nÅlder: " + age);
                    break;

                default:
                    Console.WriteLine("Alternativet finns inte i urvalet.");
                    break;
            }
        }
    }
}
