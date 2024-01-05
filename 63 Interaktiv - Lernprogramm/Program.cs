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
            // Logik einfügen
            // 1. Frage stellen // for each(Frage in fragen) {  while(Frage falsch) { stelle frage }   }
            // 2. Antwort einlesen
            // 3. Antwort mit Lösung vergleichen bei falsch weiter probieren oder ende sagen bei richtig punkte erhöhen und weiter machen // 2tes array mit antworten mitgeben

            foreach (string frage in thema)
            {

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
            Console.ReadKey();

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
