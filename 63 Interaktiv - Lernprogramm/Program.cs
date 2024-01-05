using System;


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
            bool weitermachen = true;
            int i = 0;
            // Logik einfügen
            // 1. Frage stellen // for each(Frage in fragen) {  while(Frage falsch) { stelle frage }   }
            // 2. Antwort einlesen
            // 3. Antwort mit Lösung vergleichen bei falsch weiter probieren oder ende sagen bei richtig punkte erhöhen und weiter machen // 2tes array mit antworten mitgeben

            foreach (string frage in thema)
            {
                weitermachen = true;
                while (weitermachen)
                {
                    int fragenRichtig = 0;

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Frage {0}: {1}", i + 1, frage);
                    Console.Write("Antwort: ");
                    Console.ResetColor();
                    string antwort = Console.ReadLine();

                    if (antwort == lösung[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Das ist richtig sie haben {0} von {1} Fragen richtig beantwortet", fragenRichtig, i + 1);
                        Console.ResetColor();
                        weitermachen = false;
                        fragenRichtig++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Das ist falsch");
                        Console.ResetColor();
                        weitermachen = true;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter zum fortfahren");
                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();
                }
            }
        }

        static void Main(string[] args)
        {
            string[] fragenVerzweigung = new string[10];
            string[] lösungVerzweigung = new string[10];
            string[] fragenSchleifen = new string[10];
            string[] lösungSchleifen = new string[10];
            string[] fragenArrays = new string[10];
            string[] lösungArrays = new string[10];
            string[] fragenDatentypen = new string[10];
            string[] lösungDatentypen = new string[10];
            string[] fragenStrings = new string[10];
            string[] lösungStrings = new string[10];

            fragenVerzweigung[0] = "Wozu braucht man Verzweigungen in Programmen nicht?\n" +
                                   "A: Um Entscheidungen zu treffen\n" +
                                   "B: Um komplexere Lösungen zu entwickeln\n" +
                                   "C: Um Teil Code mehrmals auszuführen";
            lösungVerzweigung[0] = "C";

            fragenVerzweigung[1] = "Schreiben sie die erste Zeile einer wenn Funktion die wahr ist wenn a den wert 5 hat";
            lösungVerzweigung[1] = "if(a == 5)";

            fragenVerzweigung[2] = "Geben sie den Wert ein den der folgende code ausgibt:\n" +
                                   "    int a = 5;\n" +
                                   "    int b = 2;\n" +
                                   "    int c;\n" +
                                   "\n" +
                                   "    if(a < b)\n" +
                                   "    {\n" +
                                   "        Console.WriteLine(\"7\")\n" +
                                   "    }\n" +
                                   "    else if(a%b == 1)\n" +
                                   "    {\n" +
                                   "        Console.WriteLine(\"A\")\n" +
                                   "    }\n" +
                                   "    \n" +
                                   "    switch(a++)\n" +
                                   "    {\n" +
                                   "        case 1:\n" +
                                   "        case 2:\n" +
                                   "            Console.WriteLine(\"3\")\n" +
                                   "            c = 1\n" +
                                   "            break;\n" +
                                   "\n" +
                                   "        case 3:\n" +
                                   "        case 4:\n" +
                                   "            Console.WriteLine(\"4\")\n" +
                                   "            c = 2;\n" +
                                   "            break;\n" +
                                   "\n" +
                                   "        case 5:\n" +
                                   "        case 6:\n" +
                                   "            Console.WriteLine(\"B\")\n" +
                                   "            c = 3;\n" +
                                   "            break;\n" +
                                   "    }\n" +
                                   "\n" +
                                   "    if(c >= 3)\n" +
                                   "    {\n" +
                                   "        Console.WriteLine(\"B\")\n" +
                                   "    }\n" +
                                   "    else\n" +
                                   "    {" +
                                   "        Console.WriteLine(\"9\")\n" +
                                   "    }";
            lösungVerzweigung[2] = "ABC";

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
        // 6. Interaktive Elemente: Integriere interaktive Elemente wie Übungen oder Quizfragen.
        // 7. Benutzerführung und Navigation: Stelle eine klare und intuitive Benutzerführung sicher.
        // 8. Anpassungsfähigkeit: Ermögliche Anpassungen an verschiedene Lernniveaus und Bedürfnisse.

        // Hinweis: Die Implementierung dieser Ideen würde die Effektivität und den pädagogischen Wert des Programms erhöhen.


        // Hier können zusätzliche Klassen und Methoden für die verschiedenen Module und Funktionen implementiert werden.
        // ...
    }
}
