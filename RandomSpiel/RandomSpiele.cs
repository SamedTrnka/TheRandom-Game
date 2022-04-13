using System;
// Thread.Sleep
using System.Threading;
// Listen
using System.Collections.Generic;

namespace RandomSpiel
{
    class Spiele
    {
        static void Main()
        {
            Console.Clear();
            int nummer;

            Menu();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nSpiel: ");
            nummer = Convert.ToInt32(Console.ReadLine());

            Wait();

            // Game selection
            switch (nummer)
            {
                case 1:
                    Spiel1();
                    break;
                case 2:
                    Spiel2();
                    break;
                case 3:
                    Spiel3();
                    break;
                case 4:
                    Spiel4();
                    break;
            }
            
        }
        // Menu UI
        static void Menu()
        {   
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Willkommen ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("zu ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("meinem ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Spiel.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n-----------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welches Spiel wollen Sie spielen?\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Zahlenraten ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("= 1\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Zahlensuche ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("= 2\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Blindekuh ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  = 3\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Lotto ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      = 4\n");
        }


        //Game 1
        static void Spiel1()
        {
            Console.Clear();
            int zähler = 0;
            int antwort;
            // Stellt einen Generator für Pseudozufallszahlen dar.
            Random random = new Random();
            // Deklaration des int Arrays "zahlen".
            int[] zahlen = new int[6];
            for (int i = 0; i < 6; i++)
            {
                // Speicherung von Werten zwischen 1 und 10 in das Array.
                zahlen[i] = (int)random.Next(1, 11);

            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Willkommen ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("zu ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Zahlen");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("raten");          
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n--------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Welche Zahl ist wohl richtig?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("10");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(")");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nZahl: ");
           
            // Eingabe der getippten Zahl,
            antwort = Convert.ToInt32(Console.ReadLine());
            
            foreach(int i in zahlen)
            {

                // Das Array wird auf die getippte Zahl durchsucht.
                if (antwort == i)
                {
                    Console.Clear();
                    zähler = zähler + 1;

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("-------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Sie ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("haben ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Gewonnen!");
                    Console.ForegroundColor = ConsoleColor.White;         
                    Console.WriteLine("-------------------------");      
                    Console.Write("\nDie getippte Zahl ist ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(zähler+".");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" enthalten.");

                    ToMenu();
                }
                
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Sie ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("haben ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Verloren!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            ToMenu();
        }
        //Game 2
        static void Spiel2()
        {
            int getipptezahl;
            int zähler = 11;
            Random random = new Random();
            int gesuchtezahl = random.Next(1, 11);
            List<int> liste = new List<int>();

            do
            {
                Console.Clear();
                zähler = zähler - 1;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Willkommen ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("zu ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Zahlen");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("suche");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n--------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Wie viele Versuche Sie wohl\nbrauchen werden...");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("(");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("-");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("10");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(")");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nSie haben "+ zähler +" Versuche.");

                Console.Write("\nZahl: ");
                getipptezahl = Convert.ToInt32(Console.ReadLine());
                liste.Add(getipptezahl);
                if(zähler == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("-------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Sie ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("haben ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Verloren!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-------------------------");
                    Console.Write("\nDie gesuchte Zahl war: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(gesuchtezahl);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\nIhre Tippergebnisse waren: ");
                    foreach(int i in liste)
                    {
                        Console.Write(" | "+ i + " ");
                    }

                    ToMenu2();
                }

            } while (getipptezahl != gesuchtezahl);

            if(getipptezahl == gesuchtezahl)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Sie ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("haben ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Gewonnen!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------------------");
                Console.Write("\nDie gesuchte Zahl war: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(gesuchtezahl);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\nIhre Tippergebnisse waren: ");
                foreach (int i in liste)
                {
                    Console.Write(" | " + i + " ");
                }

                ToMenu2();
            }

        }
        //Game 3
        static void Spiel3()
        {
            Console.Clear();

            int pluszahlkalt;
            int minuszahlkalt;
            int pluszahlwarm1;
            int minuszahlwarm1;
            int pluszahlwarm2;
            int minuszahlwarm2;
            int pluszahlheiß;
            int minuszahlheiß;
            int pluszahlsehrheiß;
            int minuszahlsehrheiß;

            int versuch = 0;
            
            string temperatur = "";
            int getipptezahl;
            int zähler = 0;
            List<int> liste = new List<int>();
            Random random = new Random();

            foreach(int a in liste)
            {
                liste.Remove(a);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Willkommen ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("zu ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Blinde");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("kuh");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n--------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Geben sie ihre Versuche ein:\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\nVersuche: ");
            Console.ForegroundColor = ConsoleColor.White;
            versuch = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nGeben sie ihre Grenze ein:\n ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\nGrenze: ");
            Console.ForegroundColor = ConsoleColor.White;
            int grenze = Convert.ToInt32(Console.ReadLine());

            int gesuchtezahl = random.Next(1, grenze) ;

            versuch = versuch + 1;
            do
            {
                zähler = zähler + 1;
                versuch = versuch - 1;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Willkommen ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("zu ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Blinde");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("kuh");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n--------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(temperatur);
                Console.WriteLine("Sie haben noch " + versuch + ". versuche");
                Console.Write("\nZahl: ");
                getipptezahl = Convert.ToInt32(Console.ReadLine());
                liste.Add(getipptezahl);

                if(versuch == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("-------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Sie ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("haben ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Verloren!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-------------------------");
                    Console.Write("\nDie gesuchte Zahl war: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(gesuchtezahl);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\nIhre Tippergebnisse waren: ");
                    foreach (int i in liste)
                    {
                        Console.Write(" | " + i + " ");
                    }

                    ToMenu3();
                }

                pluszahlkalt = getipptezahl + 5;
                minuszahlkalt = getipptezahl - 5;

                pluszahlwarm1 = getipptezahl + 4;
                minuszahlwarm1 = getipptezahl - 4;

                pluszahlwarm2 = getipptezahl + 3;
                minuszahlwarm2 = getipptezahl - 3;

                pluszahlheiß = getipptezahl + 2;
                minuszahlheiß = getipptezahl + 2;

                pluszahlheiß = getipptezahl + 1;
                minuszahlsehrheiß = getipptezahl - 1;
                temperatur = "";
                if (pluszahlkalt == gesuchtezahl || minuszahlkalt == gesuchtezahl) 
                {
                    temperatur = "Es ist kalt...";                  
                }
                if (pluszahlwarm1 == gesuchtezahl || minuszahlwarm1 == gesuchtezahl)
                {
                    temperatur = "Es ist warm...";                 
                }
                if (pluszahlwarm2 == gesuchtezahl || minuszahlwarm2 == gesuchtezahl)
                {
                    temperatur = "Es ist warm...";                   
                }
                if (pluszahlheiß == gesuchtezahl || minuszahlheiß == gesuchtezahl)
                {
                    temperatur = "Es ist heiß...";                    
                }
                if (pluszahlheiß == gesuchtezahl || minuszahlsehrheiß == gesuchtezahl)
                {
                    temperatur = "Es ist sehr heiß...";
                }


            } while (getipptezahl != gesuchtezahl);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Sie ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("haben ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gewonnen!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Gewinn nach dem "+ zähler +". Versuch");
            Console.Write("\nDie gesuchte Zahl war: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(gesuchtezahl);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\nIhre Tippergebnisse waren: ");
            foreach (int i in liste)
            {
                Console.Write(" | " + i + " ");
            }
            ToMenu3();
        }
        //Game 4
        static void Spiel4()
        {
            Console.Clear();
            int antwort;
            List<int> liste = new List<int>();

            Random rnd = new Random();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Willkommen ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("zu ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Lot");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("to");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n--------------------------");            
            Console.Write("\nWelche");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Spielvariante");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" hätten sie gerne?\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n6 aus 49 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("= 1");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n7 aus 38 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("= 2\n\n");
            Console.Write("Antwort = ");
            antwort = Convert.ToInt32(Console.ReadLine());

            if(antwort == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Lot");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("to");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n--------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                do
                {
                    int zahl = rnd.Next(1, 49);
                    if (!liste.Contains(zahl))
                        liste.Add(zahl);

                } while (liste.Count < 6);

                foreach (int a in liste)
                {
                    Console.Write(" | " + a + " ");
                }
                Console.ForegroundColor = ConsoleColor.Black;

                ToMenu4();
            }
            if(antwort == 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--------------------------");           
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Lot");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("to");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n--------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                do
                {
                    int zahl = rnd.Next(1, 38);
                    if (!liste.Contains(zahl))
                        liste.Add(zahl);

                } while (liste.Count < 7);
                Console.WriteLine("\nIhre Zahlen: ");
                foreach (int a in liste)
                {
                    
                    Console.Write(" | " + a + " | ");
                    
                }
                Console.ForegroundColor = ConsoleColor.Black;
                ToMenu4();
            }
           

        }


        //Countdown 5 sec.
        static void Wait()
        {
            Console.WriteLine("\nSpiel startet in 5 Sekunden...");
            Thread.Sleep(1000);
            Console.WriteLine("Spiel startet in 4 Sekunden...");
            Thread.Sleep(1000);
            Console.WriteLine("Spiel startet in 3 Sekunden...");
            Thread.Sleep(1000);
            Console.WriteLine("Spiel startet in 2 Sekunden...");
            Thread.Sleep(1000);
            Console.WriteLine("Spiel startet in 1 Sekunden...");
            Thread.Sleep(1000);
        }

        // Back or Repeat
        static void ToMenu()
        {
            String auswahl;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\nWollen Sie nochmal Spielen?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nJa   = Ja");
            Console.WriteLine("Nein = Nein");
            Console.Write("\nAntwort: ");
            auswahl = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;

            if (auswahl == "Ja")
            {

                Console.Clear();
                Spiel1();
            }
            if(auswahl == "Nein")
            {
                Console.Clear();               
                Main();
            }


            
        } 
        static void ToMenu2()
        {
            String auswahl;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\nWollen Sie nochmal Spielen?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nJa   = Ja");
            Console.WriteLine("Nein = Nein");
            Console.Write("\nAntwort: ");
            auswahl = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;

            if (auswahl == "Ja")
            {

                Console.Clear();
                Spiel2();
            }
            if (auswahl == "Nein")
            {
                Console.Clear();
                Main();
            }



        }
        static void ToMenu3()
        {
            String auswahl;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\nWollen Sie nochmal Spielen?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nJa   = Ja");
            Console.WriteLine("Nein = Nein");
            Console.Write("\nAntwort: ");
            auswahl = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;

            if (auswahl == "Ja")
            {

                Console.Clear();
                Spiel3();
            }
            if (auswahl == "Nein")
            {
                Console.Clear();
                Main();
            }



        }
        static void ToMenu4()
        {
            String auswahl;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\nWollen Sie nochmal Spielen?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nJa   = Ja");
            Console.WriteLine("Nein = Nein");
            Console.Write("\nAntwort: ");
            auswahl = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;

            if (auswahl == "Ja")
            {

                Console.Clear();
                Spiel4();
            }
            if (auswahl == "Nein")
            {
                Console.Clear();
                Main();
            }



        }
    }
}
