using System;
using System.Runtime.ExceptionServices;


namespace _63_Interaktiv___Lernprogramm
{
    internal class Program
    {

        static int ShowMenu()
        {
            Console.Clear();
            bool eingabeIstKorrekt = false;
            int eingabe = 0;
            // Console.Clear(); // Löscht den Bildschirm für eine saubere Darstellung

            while (!eingabeIstKorrekt)
            {
                Console.ForegroundColor = ConsoleColor.Cyan; // Setzt die Textfarbe auf Cyan für das Menü
                                                             // Ausgabe der Menüoptionen
                Console.WriteLine("Hauptmenü:");
                Console.WriteLine("1. Verzweigungen");
                Console.WriteLine("2. Schleifen");
                Console.WriteLine("3. Arrays");
                Console.WriteLine("4. Datentypen");
                Console.WriteLine("5. Strings");
                Console.WriteLine("6. Programm beenden");
                Console.Write("Wählen Sie eine Option: ");
                Console.ResetColor();
                bool eingabeIstZahl = int.TryParse(Console.ReadLine(), out eingabe);

                if (eingabe > 1 && eingabe < 6 || !eingabeIstZahl)
                {
                    eingabeIstKorrekt = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Eingabe ist falsch");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter zum fortfahren");
                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    break;
                }

            }
            return eingabe;
        }


        static void StarteFragen(string[] thema, string[] lösung)
        {
            // falls die Version von C# unter 8.0 ist das Fragezeichen bei "string? antwort;" löschen
            string? antwort;
            decimal i;
            decimal fragenRichtig = 0;
            int firsTryFragen = 0;
           
            for (i = 0; i < thema.Length; i++)
            {
                bool firstTry = true;
                Console.Clear();
                while (true)
                {
                    Console.Clear();
                    Console.Write("Frage {0}: {1}\n\nAntwort:", i + 1, thema[(int)i]);
                    antwort = Console.ReadLine();
                    if (antwort == lösung[(int)i])
                    {
                        if(firstTry)
                        {
                            firsTryFragen++;
                        }
                        fragenRichtig++;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Das ist richtig");
                        Console.ResetColor();
                        Console.WriteLine("Sie haben {0} von {1} Fragen richtig beantwortet {2} davon mit einen Versuch", fragenRichtig, i + 1, firsTryFragen);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Enter um fortzufahren");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Das ist falsch");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Enter um es erneut zu versuchen\n" +
                                          "skip um zur nächsten frage zu gehen und die Lösung anzuzeigen");
                        Console.ResetColor();
                        antwort = Console.ReadLine();
                        Console.Clear();
                        firstTry = false;
                    }
                    if (antwort == "skip")
                    {
                        Console.WriteLine("Frage:\n{0}",thema[(int)i]);
                        Console.WriteLine("Lösung:\n{0}",lösung[(int)i]);
                        Console.ReadLine();
                        break;
                    }
                }
                Console.Clear();
            }

            Console.WriteLine("Das waren alle fragen zu diesem Thema.\n" +
                              "Sie haben insgesamt {0} von {1} Fragen richtig beantwortet das sind {2:N0}%\n"  +
                              "{3} Fragen davon mit einem Versuch\n" +
                              "Geben sie \"menu\" ein um zum Hauptmenü zurückzukehren.\n" +
                              "Enter zum verlassen", fragenRichtig, i, fragenRichtig / (i / 100), firsTryFragen);

            antwort = Console.ReadLine();
            if(antwort == "menu")
            {
                ShowMenu();
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();
            string[] fragenVerzweigung = new string[3];
            string[] lösungVerzweigung = new string[3];
            string[] fragenSchleifen = new string[10];
            string[] lösungSchleifen = new string[10];
            string[] fragenArrays = new string[10];
            string[] lösungArrays = new string[10];
            string[] fragenDatentypen = new string[10];
            string[] lösungDatentypen = new string[10];
            string[] fragenStrings = new string[10];
            string[] lösungStrings = new string[10];

            fragenVerzweigung[0] = "Was passiert, wenn keine der Bedingungen in einer Falls-Anweisung erfüllt ist?\n" +
                                   "a) Das Programm wird beendet.\n" +
                                   "b) Es wird eine Fehlermeldung angezeigt.\n" +
                                   "c) Der Codeblock unter \"else\" wird ausgeführt, falls vorhanden, ansonsten wird der Programmfluss fortgesetzt.\n";
            lösungVerzweigung[0] = "c";

            fragenVerzweigung[1] = "Schreiben sie die erste Zeile einer wenn Funktion die wahr ist wenn a den wert 5 hat";
            lösungVerzweigung[1] = "if(a == 5)";

            fragenVerzweigung[2] = "Welche sind keine logischen Operatoren?\n" +
                                   "a) +, *, -, /\n" +
                                   "b) &&, ||\n" +
                                   "c) =, !=, <, >";

            lösungVerzweigung[2] = "a";

            // Hauptmenü-Logik wie zuvor
            Console.Title = "63 Interaktiv - Lernprogramm";

            Console.ForegroundColor = ConsoleColor.Yellow; // Setzt die Textfarbe auf Gelb für die Begrüßung
            Console.WriteLine("Willkommen zum interaktiven Lernprogramm!");
            Console.WriteLine("Dieses Programm soll dir dabei helfen, die Grundlagen der Programmierung in C# zu verstehen.");
            Console.WriteLine("Du wirst verschiedene Module durchlaufen, in denen du Fragen zu Themen wie Verzweigungen, Schleifen, Arrays, Datentypen und Strings beantworten kannst.");
            Console.WriteLine("Jede richtige Antwort wird mit Punkten belohnt und bei falschen Antworten erhältst du hilfreiche Erklärungen.");
            Console.WriteLine("Viel Spaß und Erfolg beim Lernen!");
            Console.WriteLine();
            Console.ResetColor();
            Console.ReadLine();

            int themenAuswahl = ShowMenu();

            switch (themenAuswahl)
            {
                case 1:
                    StarteFragen(fragenVerzweigung, lösungVerzweigung);
                    break;
                case 2:
                    StarteFragen(fragenSchleifen, lösungSchleifen);
                    break;
                case 3:
                    StarteFragen(fragenArrays, lösungArrays);
                    break;
                case 4:
                    StarteFragen(fragenDatentypen, lösungDatentypen);
                    break;
                case 5:
                    StarteFragen(fragenStrings, lösungStrings);
                    break;
            }
        }


        // Weitere Methoden und Logik...
        // Hier würde die Hauptlogik des interaktiven Lernprogramms implementiert werden.
        // ...

        // Vorgeschlagene Ideen (als Kommentare):
        // 1. Fragen-Array Initialisieren: Initialisiere Arrays mit spezifischen Fragen und Antworten für jedes Thema.
        // 2. Punktesystem: Implementiere ein Punktesystem, das Punkte für richtige Antworten vergibt.
        // 3. Feedback und Erläuterungen: Gib Feedback und bei Bedarf Erklärungen für jede Antwort.
        // 4. Fortlaufende Bewertung: Führe eine fortlaufende Bewertung der Leistung des Benutzers durch.
        // 5. Modulspezifische Funktionen: Jedes Modul sollte spezifische Fragen und Logik zum Thema enthalten.
        // 6. Interaktive Elemente: Integriere interaktive Elemente wie Übungen oder Quiz Fragen.
        // 7. Benutzerführung und Navigation: Stelle eine klare und intuitive Benutzerführung sicher.
        // 8. Anpassungsfähigkeit: Ermögliche Anpassungen an verschiedene Lernniveaus und Bedürfnisse.

        // Hinweis: Die Implementierung dieser Ideen würde die Effektivität und den pädagogischen Wert des Programms erhöhen.


        // Hier können zusätzliche Klassen und Methoden für die verschiedenen Module und Funktionen implementiert werden.
        // ...
    }
}
