using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                Console.WriteLine("3) Funktion som ändrar färgen på texten i konsolen (och ändrar tillbaka om man använder funktionen igen).");
                Console.WriteLine("4) Funktion för att skriva ut dagens datum");
                Console.WriteLine("5) Funktion som tar två input värden, sedan skriver ut vilket av dem som är störst.");
                Console.WriteLine("6) Funktion som genererar att slumpmässigt tal mellan 1 och 100.");
                Console.WriteLine("7) Funktion där användaren skriver in en textrad, som sedan sparas i en fil på hårddisken (Ej klar)");
                Console.WriteLine("8) Funktion där en fil läses in från hårddisken (Ej klar)");
                Console.WriteLine("9) Funktion där användaren skickar in ett decimaltal och får tillbaka roten ur, upphöjt till 2 och upphöjt till 10");
                Console.WriteLine("10) Funktion där programmet skriver ut en multiplikationstabell från 1 till 10.");
                Console.WriteLine("11) Funktion som skapar två arrayer.");
                Console.WriteLine("12) Funktion som tar en input från användaren och kontrollerar ifall det är en palindrom.");
                Console.WriteLine("13) Funktion som tar två inputs från användaren och skriver sedan ut alla siffror som är mellan de två inputsen.");
                Console.WriteLine("14) Funktion där användaren skickar in ett antal värden (komma-separerade siffror) som");
                Console.WriteLine("    sedan sorteras och skrivs ut efter udda och jämna värden.");
                Console.WriteLine("15) Funktion där användaren skriver in ett antal värden (komma-separerade siffor) som sedan adderas och skrivs ut.");
                Console.WriteLine("16) Funktion där användaren ska ange namnet på sin karaktär och namnet på en motståndare. ");
                Console.WriteLine("    Funktionen skall sedan själv lägga till slumpmässiga värden för Hälsa, Styrka och Tur, som sparas");
                Console.WriteLine("    i en instans av en klass.");

                Console.WriteLine("\n0) Avsluta");

                //Menu input
                Console.Write("\nSkriv meny nummer och tryck [Enter]: ");
                int menuOption = Convert.ToInt32(Console.ReadLine());

                //Switch for menu option
                switch (menuOption)
                {
                    case 1:
                        {
                            Console.WriteLine("\nHello World!");
                        }
                            
                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 2:
                        {
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
                        }
                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        {
                            if (background == 1)
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
                        }                     
                        break;

                    case 4:
                        {
                            DateTime thisDay = DateTime.Today;
                            Console.WriteLine("\nIdag är det " + thisDay.ToString("D"));
                        }
                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 5:
                        {
                            double num1, num2;

                            Console.WriteLine("Skriv ett valfritt nummer");
                            num1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("\nSkriv ett till valfritt nummer");
                            num2 = Convert.ToDouble(Console.ReadLine());

                            if (num1 > num2)
                                Console.WriteLine("\n" + num1 + " är större än " + num2);
                            else if (num2 > num1)
                                Console.WriteLine("\n" + num2 + " är större än " + num1);
                            else
                                Console.WriteLine("\nBåda värdena är lika.");
                        }
                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 6:
                        {
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
                        }
                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 7:
                        {
                            string dir = @"C:\George\Uppgift7";
                            // Skapa mappen om den inte finns
                            if (!Directory.Exists(dir))
                            {
                                Directory.CreateDirectory(dir);
                            }

                            using (TextWriter writer = File.CreateText("C:\\George\\Uppgift7\\textraden.txt"))
                            {
                                Console.Write("Skriv en kort mening: ");
                                string text = Console.ReadLine();
                                
                                writer.WriteLine(text);
                                
                            }
                            Console.WriteLine("Texten sparad under C:\\George\\Uppgift7 i filen textraden.txt");
                        }
                                                
                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 8:
                        {
                            using (TextReader tr = File.OpenText("C:\\George\\Uppgift7\\textraden.txt"))
                            {
                                Console.WriteLine(tr.ReadToEnd());
                            }
                        }
                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 9:
                        {
                            Console.WriteLine("Skriv ett decimaltal och tryck [Enter].");
                            double number = Convert.ToDouble(Console.ReadLine());
                            double number10 = number;

                            Console.WriteLine("\nRoten ur " + number + " är " + Math.Sqrt(number));
                            Console.WriteLine(number + " upphöjt med 2 är " + number * number);

                            for (int i = 0; i < 9; i++)
                            {
                                number10 = number10 * number;
                            }

                            Console.WriteLine(number + " upphöjt med 10 är " + number10);
                        }
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

                    case 11:
                        {
                            int[] randomArray = new int[5];
                            int[] sortedArray = new int[5];

                            //Skapar en "randomArray" med slumpade tal.
                            Random randNum = new Random();
                            for (int i = 0; i < randomArray.Length; i++)
                            {
                                randomArray[i] = randNum.Next(1, 100);
                            }

                            //Skriver ut de slumpade talen
                            Console.WriteLine("Slumpade osorterade nummer i \"array.\"");
                            for(int i=0; i < randomArray.Length; i++)
                            {
                                Console.Write(randomArray[i]+", ");
                            }

                            //Sorterar "randomArray"
                            for (int i = 0; i < randomArray.Length; i++)
                            {
                                for(int j=i+1; j < randomArray.Length; j++)
                                {
                                    if(randomArray[i] > randomArray[j])
                                    {
                                        int temp = randomArray[i];
                                        randomArray[i] = randomArray[j];
                                        randomArray[j] = temp;
                                    }
                                }
                            }

                            Console.WriteLine();

                            //Skriver ut sorterade nummer
                            Console.WriteLine("Sorterade nummer i \"array.\"");
                            for (int i = 0; i < randomArray.Length; i++)
                            {
                                Console.Write(randomArray[i] + ", ");
                            }


                        }
                        
                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 12:
                        {
                            string wordTest, wordTemp = "";
                            
                            Console.WriteLine("\n\nPalindrom kollen");
                            Console.WriteLine("________________\n");
                            Console.Write("Skriv ordet: ");
                            wordTest = Console.ReadLine();

                            for (int i = wordTest.Length - 1; i >= 0; i--) //Tar ut en bokstav i taget från testordet och  
                            {
                                wordTemp += wordTest[i].ToString();        //placeras omvänd ordning en bokstav i taget i annan variabel temporärt.
                            }
                            if (wordTemp == wordTest) // Kontrollera om testordet och det omvända tempordet är lika.  
                            {
                                Console.WriteLine("\n\nOrdet är palindrom \n\n Inskrivna ordet var {0} och omvänt är ordet {1}", wordTest, wordTemp);
                            }
                            else
                            {
                                Console.WriteLine("\n\nOrdet är inte palindrom \n\n Inskrivna ordet var {0} och omvänt är ordet {1}", wordTest, wordTemp);
                            }                                                        
                        }

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 13:
                        {
                            int startNum, endNum;
                            
                            Console.WriteLine("\n\nRäkna upp alla siffrorna från ett startnummer och ett slutnummer");
                            Console.WriteLine("________________________________________________________________\n\n");
                            Console.Write("Skriv in startnumret: ");
                            startNum = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Skriv in slutnumret: ");
                            endNum = Convert.ToInt32(Console.ReadLine());

                            for (int i = startNum; i <= endNum; i++)
                            {
                                Console.Write(i); // + ", ");
                                if (i == endNum)
                                {
                                    break;
                                }
                                Console.Write(", ");
                            }                                                        
                        }

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 14:
                        {
                            //Inmatning av siffror från användaren med komma separering
                            Console.WriteLine("Skriv i raden under, komma separerade värden.");
                            string commaSepratedString = Console.ReadLine();
                            string[] inputTemp = commaSepratedString.Split(",");

                            int[] inputTemp2 = inputTemp.Select(int.Parse).ToArray();

                            //Sorterar array
                            for (int i = 0; i < inputTemp2.Length; i++)
                            {
                                for (int j = i + 1; j < inputTemp2.Length; j++)
                                {
                                    if (inputTemp2[i] > inputTemp2[j])
                                    {
                                        int temp = inputTemp2[i];
                                        inputTemp2[i] = inputTemp2[j];
                                        inputTemp2[j] = temp;
                                    }
                                }
                            }

                            //Kontrollerar om siffran är jämn eller udda och skriver ut bredvid vilket det är
                            for (int i=0 ; i < inputTemp2.Length; i++)
                            {
                                //int tempNumber = Convert.ToInt32(inputTemp[i]);
                                Console.Write(inputTemp2[i]);

                                if (inputTemp2[i] % 2 == 0) //Kontrollera om siffran är jämn
                                {
                                    Console.WriteLine(" <-- Jämn siffra");
                                }
                                else
                                {
                                    Console.WriteLine(" >-- Udda siffra");
                                }
                            }
                            
                        }

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 15:
                        {
                            //Inmatning av siffror från användaren med komma separering
                            Console.WriteLine("Skriv i raden under komma separerade värden.");
                            string commaSepratedString = Console.ReadLine();
                            string[] inputTemp = commaSepratedString.Split(",");

                            int[] inputTemp2 = inputTemp.Select(int.Parse).ToArray();
                                                        
                            int sum = 0;
                            for (int i = 0; i < inputTemp2.Length; i++)
                            {
                                sum += inputTemp2[i];
                            }

                            Console.WriteLine("\n\nSumman av alla värdena är " + sum);

                        }

                        Console.WriteLine("\nTryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        break;

                    case 16:
                        {
                            // Funktion där användaren ska ange namnet
                            // på sin karaktär och namnet på en motståndare.
                            // Funktionen skall sedan själv lägga till
                            // slumpmässiga värden för Hälsa, Styrka och
                            // Tur, som sparas i en instans av en klass.

                            PLayerSheet player1 = new PLayerSheet();
                            PLayerSheet opponent = new PLayerSheet();

                            Console.Write("\n\nVad är namnet på din karaktär: ");
                            player1.playerName = Console.ReadLine();

                            Console.Write("Vad är namnet på din monståndare: ");
                            opponent.opponentName = Console.ReadLine();

                            Console.WriteLine("\n\nSpelare 1");
                            Console.WriteLine("----------");
                            Console.WriteLine("Namn:   "+player1.playerName);
                            Console.WriteLine("Hälsa:  "+player1.health);
                            Console.WriteLine("Styrka: "+player1.strength);
                            Console.WriteLine("Tur:    "+player1.luck);

                            Console.WriteLine("\n\nSpelare 2");
                            Console.WriteLine("-----------");
                            Console.WriteLine("Namn:   " + opponent.opponentName);
                            Console.WriteLine("Hälsa:  " + opponent.health);
                            Console.WriteLine("Styrka: " + opponent.strength);
                            Console.WriteLine("Tur:    " + opponent.luck);
                                                                                   
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

        public class PLayerSheet
        {
            Random rand = new Random();
                        
            public string playerName 
            { 
                get; 
                set; 
            }
            public string opponentName 
            { 
                get; 
                set; 
            }
            public int health 
            { 
                get 
                { 
                    return rand.Next(0, 100); 
                } 
            }
            public int strength 
            { 
                get
                {
                    return rand.Next(0, 100);
                }
                set
                {

                }
            }
            public int luck 
            { 
                get 
                { 
                    return rand.Next(0, 100); 
                } 
            }
        }
    }
}
