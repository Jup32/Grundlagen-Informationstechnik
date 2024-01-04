using System;

namespace _63_Interaktiv___Lernprogramm
{
    internal class Program
    {
        class Frage
        {
            public string Text;
            public string[] Optionen;
            public char RichtigeAntwort;

            public Frage(string text, string[] optionen, char richtigeAntwort)
            {
                Text = text;
                Optionen = optionen;
                RichtigeAntwort = richtigeAntwort;
            }
        }

        static Frage[] fragenVerzweigungen;
        static Frage[] fragenSchleifen;
        static Frage[] fragenArrays;
        static Frage[] fragenDatentypen;
        static Frage[] fragenStrings;

        static void Main(string[] args)
        {
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

            while (true) // Eine Endlosschleife, um das Menü kontinuierlich anzuzeigen
            {
                // Console.Clear(); // Löscht den Bildschirm für eine saubere Darstellung
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
                string auswahl = Console.ReadLine(); // Liest die Benutzereingabe

                switch (auswahl) // Verarbeitet die Benutzereingabe
                {
                    case "1":
                        ModulVerzweigungen(); // Ruft das Modul Verzweigungen auf
                        break;
                    // Füge hier Aufrufe für weitere Module hinzu...
                    case "6":
                        return; // Beendet das Programm
                    default:
                        Console.ForegroundColor = ConsoleColor.Red; // Fehlermeldung in Rot
                        Console.WriteLine("Ungültige Eingabe. Bitte versuchen Sie es erneut.");
                        Console.ResetColor(); // Setzt die Farbe zurück
                        break;
                }
            }
        }

        static void ModulVerzweigungen()
        {
            // Logik für das Modul Verzweigungen
            Console.Clear(); // Leert die Konsole für das Modul
                             // Logik für das Modul Verzweigungen
                             // Beispielsweise eine Schleife, die 12 Fragen stellt und die Antworten überprüft
                             // Nach Abschluss der Fragen kehrt das Programm zum Hauptmenü zurück
        }

        static void ModulSchleifen()
        {
            // Logik für das Modul Schleifen
        }

        static void ModulArrays()
        {
            // Logik für das Modul Arrays
        }

        static void ModulDatentypen()
        {
            // Logik für das Modul Datentypen
        }

        static void ModulStrings()
        {
            // Logik für das Modul Strings
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