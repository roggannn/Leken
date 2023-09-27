using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace något
{

    class Program
    {
        static void Main(string[] args)
        {
            int Sverige = 1;
            int Norge = 2;
            int Finland = 3;
            int Tyskland = 4;
            int Danmark = 5;
            int Ryssland = 6;
            int Kina = 7;
            int Polen = 8;
            int Storbrittannien = 9;
            int Irland = 10;
            int Skottland = 11;
            int Spanien = 12;
            int Frankrike = 13;
            int Belarus = 14;
            int Tjeckien = 15;
            int Schweiz = 16;
            int Portugal = 17;
            int Luxemburg = 18;
            int Brasilien = 19;

            int[] lista = { Sverige, Norge, Finland, Tyskland, Danmark, Ryssland, Kina, Polen, Storbrittannien, Irland, Skottland, Spanien, Frankrike, Belarus, Tjeckien, Schweiz, Portugal, Luxemburg, Brasilien };
            string[] poängen = { };

            int länder = 19;
            string Save = null;
            int Savepoäng = 0;


            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("");

                Console.WriteLine("[S]tarta spelet");

                Console.WriteLine("[H]ighscores");

                Console.WriteLine("[Q]uit");

                string val = Console.ReadLine();

                if (val == "S" || val == "s")
                {
                    int poäng = 0;
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("== VÄLKOMMEN TILL SPELET ==");
                    Console.WriteLine("");
                    Console.WriteLine("Här fortsätter du gissa tills du har lyckats med att gissa alla huvudstäder till alla länder i hela världen.");
                    Console.WriteLine("");

                    Console.WriteLine("Fortsätt genom att trycka på valfri knapp");
                    Console.ReadKey();

                    Console.WriteLine("");
                    Random rnd = new Random();
                    
                    bool använtnr1 = false;
                    bool använtnr2 = false;
                    bool använtnr3 = false;
                    bool använtnr4 = false;
                    bool använtnr5 = false;
                    bool använtnr6 = false;
                    bool använtnr7 = false;
                    bool använtnr8 = false;
                    bool använtnr9 = false;
                    bool använtnr10 = false;
                    bool använtnr11 = false;
                    bool använtnr12 = false;
                    bool använtnr13 = false;
                    bool använtnr14 = false;
                    bool använtnr15 = false;
                    bool använtnr16 = false;
                    bool använtnr17 = false;
                    bool använtnr18 = false;
                    bool använtnr19 = false;

                    while (true)
                    {
                        int index = rnd.Next(1, 19);

                        if (index == 1) // Om index == Sverige
                        {
                            if (använtnr1 == false)
                            {
                                använtnr1 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vad är huvudstaden i Sverige?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Stockholm" || svar == "stockholm")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;  ;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                   
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja")
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();
                                           
                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else 
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                    
                                }
                            }
                            else
                            {
                                // Startar om loopen...
                                
                            }
                        }
                        else if (index == 2)  // Om index == Norge
                        {
                            if (använtnr2 == false)
                            {
                                
                                använtnr2 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vad är huvudstaden i Norge?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Oslo" || svar == "oslo")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1; ;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja")
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }

                            else
                            {
                                // Startar om loopen...
                                
                            }
                        }
                        else if (index == 3) // Om index == Finland
                        {
                            if (använtnr3 == false)
                            {

                                använtnr3 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vad är huvudstaden i Finland?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Helsingfors" || svar == "helsingfors" || svar == "Helsinki" || svar == "helsinki" || svar == "Helsinkii" || svar == "helsinkii")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1; ;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja")
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 4) // Om index == Tyskland
                        {
                            if (använtnr4 == false)
                            {

                                använtnr4 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vad är huvudstaden i Tyskland?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Berlin" || svar == "berlin")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1; ;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja")
                                        {

                                            Console.WriteLine();
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 5) // Om index == Danmark
                        {
                            if (använtnr5 == false)
                            {

                                använtnr5 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vad är huvudstaden i Danmark?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Köpenhamn" || svar == "köpenhamn" || svar == "Copenhagen" || svar == "copenhagen")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1; ;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja")
                                        {

                                            Console.WriteLine();
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 6) // Om index == Ryssland
                        {
                            if (använtnr6 == false)
                            {

                                använtnr6 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vad är huvudstaden i Ryssland?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Moskva" || svar == "moskva")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja")
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 7) // Om index == Kina
                        {
                            if (använtnr7 == false)
                            {

                                använtnr7 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vad är huvudstaden i Kina?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Peking" || svar == "peking")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja")
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 8) // Om index == Polen
                        {
                            if (använtnr8 == false)
                            {

                                använtnr8 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vad är huvudstaden i Polen" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Warszawa" || svar == "warszawa" || svar == "Warsaw" || svar == "warsaw" || svar == "Warzawa" || svar == "warzawa" || svar == "warsawa" || svar == "Warsawa")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja")
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 9) // Om index == Storbrittannien
                        {
                            if (använtnr9 == false)
                            {

                                använtnr9 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vilken huvudstad har England?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "London" || svar == "london")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja")
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 10) // Om index == Irland
                        {
                            if (använtnr10 == false)
                            {
                                
                                använtnr10 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vilken huvudstad har Irland?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Dublin" || svar == "dublin")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja")
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 11) // Om index == Skottland
                        {
                            if (använtnr11 == false)
                            {
                                använtnr11 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vilken huvudstad har Skottland?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Edinburgh" || svar == "edinburgh" || svar == "Edinburg" || svar == "edinburg")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja" || sparning == "ok" || sparning == "Ok" || sparning == "Yes" || sparning == "yes" || sparning == "Japp" || sparning == "japp" || sparning == "Ja." || sparning == "ja." || sparning == "ok." || sparning == "Ok." || sparning == "Yes." || sparning == "yes." || sparning == "Japp." || sparning == "japp.")
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen... (söker alltså efter andra nummer)

                            }
                        }
                        else if (index == 12) // Om index == Spanien
                        {
                            if (använtnr12 == false)
                            {

                                använtnr12 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vilken huvudstad har Spanien?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Madrid" || svar == "madrid")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    ;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja" || sparning == "ok" || sparning == "Ok" || sparning == "Yes" || sparning == "yes" || sparning == "Japp" || sparning == "japp" || sparning == "Ja." || sparning == "ja." || sparning == "ok." || sparning == "Ok." || sparning == "Yes." || sparning == "yes." || sparning == "Japp." || sparning == "japp.")
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 13) // Om index == Frankrike
                        {
                            if (använtnr13 == false)
                            {

                                använtnr13 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vilken huvudstad har Frankrike?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Paris" || svar == "paris")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja" || sparning == "ok" || sparning == "Ok" || sparning == "Yes" || sparning == "yes" || sparning == "Japp" || sparning == "japp" || sparning == "Ja." || sparning == "ja." || sparning == "ok." || sparning == "Ok." || sparning == "Yes." || sparning == "yes." || sparning == "Japp." || sparning == "japp.")
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 14) // Om index == Belarus
                        {
                            if (använtnr14 == false)
                            {

                                använtnr14 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vilken huvudstad har Belarus?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Minsk" || svar == "minsk")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja" || sparning == "ok" || sparning == "Ok" || sparning == "Yes" || sparning == "yes" || sparning == "Japp" || sparning == "japp" || sparning == "Ja." || sparning == "ja." || sparning == "ok." || sparning == "Ok." || sparning == "Yes." || sparning == "yes." || sparning == "Japp." || sparning == "japp.")
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 15) // Om index == Tjeckien
                        {
                            if (använtnr15 == false)
                            {

                                använtnr15 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vad är huvudstaden i Tjeckien?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                
                                if (svar == "Prague" || svar == "prague" || svar == "Prag" || svar == "prag")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja" || sparning == "ok" || sparning == "Ok" || sparning == "Yes" || sparning == "yes" || sparning == "Japp" || sparning == "japp" || sparning == "Ja." || sparning == "ja." || sparning == "ok." || sparning == "Ok." || sparning == "Yes." || sparning == "yes." || sparning == "Japp." || sparning == "japp.")
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 16) // Om index == Schweiz
                        {
                            if (använtnr16 == false)
                            {

                                använtnr16 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vad är huvudstaden i Schweiz?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Bern" || svar == "bern")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja" || sparning == "ok" || sparning == "Ok" || sparning == "Yes" || sparning == "yes" || sparning == "Japp" || sparning == "japp" || sparning == "Ja." || sparning == "ja." || sparning == "ok." || sparning == "Ok." || sparning == "Yes." || sparning == "yes." || sparning == "Japp." || sparning == "japp.")
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 17) // Om index == Portugal
                        {
                            if (använtnr17 == false)
                            {

                                använtnr17 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vad är huvudstaden i Portugal?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Lissabon" || svar == "lissabon" || svar == "Lisbon" || svar == "lisbon" || svar == "Lissabonn" || svar == "lissabonn")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja" || sparning == "ok" || sparning == "Ok" || sparning == "Yes" || sparning == "yes" || sparning == "Japp" || sparning == "japp" || sparning == "Ja." || sparning == "ja." || sparning == "ok." || sparning == "Ok." || sparning == "Yes." || sparning == "yes." || sparning == "Japp." || sparning == "japp.")
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 18) // Om index == Luxemburg
                        {
                            if (använtnr18 == false)
                            {

                                använtnr18 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vad är huvudstaden i Luxemburg?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Luxembourg" || svar == "luxembourg" || svar == "Luxemburg" || svar == "luxemburg" || svar == "Luxembuorg" || svar == "luxembuorg")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja" || sparning == "ok" || sparning == "Ok" || sparning == "Yes" || sparning == "yes" || sparning == "Japp" || sparning == "japp" || sparning == "Ja." || sparning == "ja." || sparning == "ok." || sparning == "Ok." || sparning == "Yes." || sparning == "yes." || sparning == "Japp." || sparning == "japp.")
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 19) // Om index == Brasilien
                        {
                            if (använtnr19 == false)
                            {

                                använtnr19 = true;
                                Console.WriteLine("");
                                Console.WriteLine("Vad är huvudstaden i Brasilien?" + " -- Dina nuvarande poäng är : " + poäng);
                                string svar = Console.ReadLine();
                                if (svar == "Brasilia" || svar == "brasilia" || svar == "Brasília" || svar == "brasília")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("KORREKT!");
                                    Console.WriteLine("+1 poäng");
                                    poäng = poäng + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Fortsätter till nästa fråga...");
                                    Task.Delay(1000).Wait();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("FEL!");
                                    Console.WriteLine("");
                                    if (poäng > Savepoäng)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Vill du spara din score?");
                                        string sparning = Console.ReadLine();
                                        if (sparning == "Ja" || sparning == "ja" || sparning == "ok" || sparning == "Ok" || sparning == "Yes" || sparning == "yes" || sparning == "Japp" || sparning == "japp" || sparning == "Ja." || sparning == "ja." || sparning == "ok." || sparning == "Ok." || sparning == "Yes." || sparning == "yes." || sparning == "Japp." || sparning == "japp.")
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Vilket namn vill du spara det under?");
                                            string sparnamn = Console.ReadLine();

                                            Save = sparnamn;
                                            Savepoäng = poäng;
                                            Console.WriteLine("");
                                            Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                            Task.Delay(1000).Wait();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                            Task.Delay(1000).Wait();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Skickar tillbaka dig till menyn...");
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // Startar om loopen...

                            }
                        }
                        else if (index == 1 || index == 2 || index == 3 || index == 4 || index == 5 || index == 6 || index == 7 || index == 8 || index == 9 || index == 10 || index == 11 || index == 12 || index == 13 || index == 14 || index == 15 || index == 16 || index == 17 || index == 18 || index == 19)
                        {
                            if (använtnr1 == true && använtnr2 == true && använtnr3 == true && använtnr3 == true && använtnr4 == true && använtnr5 == true && använtnr6 == true && använtnr7 == true && använtnr8 == true && använtnr9 == true && använtnr10 == true && använtnr11 == true && använtnr12 == true && använtnr13 == true && använtnr14 == true && använtnr15 == true && använtnr16 == true && använtnr17 == true && använtnr18 == true && använtnr19 == true)
                            {
                                Task.Delay(800).Wait();
                                Console.Clear();
                                Console.WriteLine("G");
                                Console.Clear();
                                Console.WriteLine("GR");
                                Console.Clear();
                                Console.WriteLine("GRA");
                                Console.Clear();
                                Console.WriteLine("GRAT");
                                Console.Clear();
                                Console.WriteLine("GRATT");
                                Console.Clear();
                                Console.WriteLine("GRATTI");
                                Console.Clear();
                                Console.WriteLine("GRATTIS");
                                Console.Clear();
                                Console.WriteLine("GRATTIS!");
                                Console.Clear();

                                Console.WriteLine("GRATTIS!");
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Du klarade av att gissa alla huvudstäder!");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                Console.WriteLine("Vill du spara din score?");
                                string sparning = Console.ReadLine();
                                if (sparning == "Ja" || sparning == "ja" || sparning == "ok" || sparning == "Ok" || sparning == "Yes" || sparning == "yes" || sparning == "Japp" || sparning == "japp" || sparning == "Ja." || sparning == "ja." || sparning == "ok." || sparning == "Ok." || sparning == "Yes." || sparning == "yes." || sparning == "Japp." || sparning == "japp.")
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Vilket namn vill du spara det under?");
                                    string sparnamn = Console.ReadLine();

                                    Save = sparnamn;
                                    Savepoäng = poäng;
                                    Console.WriteLine("");
                                    Console.WriteLine("Toppen! Då har din score sparats under " + sparnamn + ".");
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Task.Delay(1000).Wait();
                                    break;

                                }
                                else
                                {
                                    Console.WriteLine("Okej, skickar tillbaka dig till menyn...");
                                    Task.Delay(1000).Wait();
                                    break;
                                }
                            }
                            else
                            {

                            }
                        }

                        

                    }
                }

                if (val == "H" || val == "h") // Kollar ifall du skriver in "H" eller "h"
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("== HIGHSCORE ==");
                    if (String.IsNullOrEmpty(Save) == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine(Save + " : " + Savepoäng);
                        Console.WriteLine("");
                        Console.WriteLine("---------------");
                        Console.WriteLine("");
                        Console.WriteLine("Tryck på valfri knapp för att gå tillbaka till menyn...");
                        Console.ReadKey();
                    }
                    else
                    {
                        // Inget bör göras här.
                        Console.WriteLine("Inga sparade scores ännu..");
                        Task.Delay(500).Wait();
                        Console.WriteLine("Tryck på valfri knapp för att gå tillbaka till menyn...");
                        Console.ReadKey();
                    }


                }
                if (val == "Q" || val == "q")
                {
                    Console.WriteLine("Qutting..");
                    Task.Delay(500).Wait();
                    break;

                }




            }





        }
    }
}

/* string svar = Console.ReadLine();
if (svar == "Stockholm" || svar == "stockholm")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Korrekt!");
    Console.WriteLine("+1 poäng");
    poäng = 1;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("");
    Console.WriteLine("Nästa fråga är... vilken huvudstad har Norge? --- (" + poäng + ") nuvarande poäng");
    string svar2 = Console.ReadLine();
    if (svar2 == "Oslo" || svar2 == "oslo")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Korrekt!");
        Console.WriteLine("+1 poäng");
        poäng = 2;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.WriteLine("Vilken huvudstad har Finland? --- (" + poäng + ") nuvarande poäng");
        string svar3 = Console.ReadLine();
        if (svar3 == "Helsinki" || svar3 == "helsinki" || svar3 == "Helsingfors" || svar3 == "helsingfors")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Korrekt!");
            poäng = 3;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.ReadKey();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FEL!");
            Task.Delay(500).Wait();
            Console.ForegroundColor = ConsoleColor.White;
            if (poäng > Savepoäng) // Kollar ifall dina poäng nu är mer än ditt "rekord".
            {
                while (true)
                {
                    Console.WriteLine("Vill du spara dina poäng?");
                    string sparar = Console.ReadLine();
                    if (sparar == "ja" || sparar == "Ja")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Vilket namn ska de sparas under?");
                        string sparnamn = Console.ReadLine();
                        Save = sparnamn; // Sparar namnet på sparningen på en annan variabel
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Okej, går tillbaka till menyn...");
                        Task.Delay(500).Wait(); // Väntar 500 ms innan den fortsätter
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Tillbaka till menyn...");
                Task.Delay(200).Wait();
            }
        }
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("FEL!");
        Task.Delay(500).Wait();
        Console.ForegroundColor = ConsoleColor.White;
        if (poäng > Savepoäng) // Kollar ifall dina poäng nu är mer än ditt "rekord".
        {
            while (true)
            {
                Console.WriteLine("Vill du spara dina poäng?");
                string sparar = Console.ReadLine();
                if (sparar == "ja" || sparar == "Ja")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Vilket namn ska de sparas under?");
                    string sparnamn = Console.ReadLine();
                    Save = sparnamn; // Sparar namnet på sparningen på en annan variabel
                    break;
                }
                else
                {
                    Console.WriteLine("Okej, går tillbaka till menyn...");
                    Task.Delay(500).Wait(); // Väntar 500 ms innan den fortsätter
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Tillbaka till menyn...");
            Task.Delay(200).Wait();
        }
    }
}


    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("FEL!");
        Task.Delay(500).Wait();
        Console.ForegroundColor = ConsoleColor.White;
        if (poäng > Savepoäng) // Kollar ifall dina poäng nu är mer än ditt "rekord".
        {
            while (true)
            {
                Console.WriteLine("Vill du spara dina poäng?");
                string sparar = Console.ReadLine();
                if (sparar == "ja" || sparar == "Ja")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Vilket namn ska de sparas under?");
                    string sparnamn = Console.ReadLine();
                    Save = sparnamn; // Sparar namnet på sparningen på en annan variabel
                    break;
                }
                else
                {
                    Console.WriteLine("Okej, går tillbaka till menyn...");
                    Task.Delay(500).Wait(); // Väntar 500 ms innan den fortsätter
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Tillbaka till menyn...");
            Task.Delay(200).Wait();
        }
    }
*/

/*                     else
{
    Console.WriteLine("FEL!");
    Task.Delay(500).Wait();
    if (poäng > Savepoäng) // Kollar ifall dina poäng nu är mer än ditt "rekord".
    {
        while (true)
        {
            Console.WriteLine("Vill du spara dina poäng?");
            string sparar = Console.ReadLine();
            if (sparar == "ja" || sparar == "Ja")
            {
                Console.WriteLine("");
                Console.WriteLine("Vilket namn ska de sparas under?");
                string sparnamn = Console.ReadLine();
                Save = sparnamn; // Sparar namnet på sparningen på en annan variabel och dina piäng
                Savepoäng = poäng;
            }
            else
            {
                Console.WriteLine("Okej, går tillbaka till menyn...");
                Task.Delay(500).Wait(); // Väntar 500 ms innan den fortsätter
                break;
            }
        }
    }
    else
    {
        Console.WriteLine("Startar om...");
        Task.Delay(200).Wait();
    }
}*/