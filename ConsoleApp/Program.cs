using System.Runtime.ConstrainedExecution;

namespace ItSchulungen.CSharpKurs.ConsoleApp
{
    internal class Program
    {

        /// <summary>
        /// Der Einstiegs- oder Startpunkt unserer Konsolenanwendung
        /// </summary>
        /// <param name="args">Optionale Startargumente um Werte in das Program zu übergeben</param>
        static void Main(string[] args)
        {
            // Der Start unserer Anwendung

            //Console.WriteLine
            //    (
            //        "Hello, World!"
            //    );
            //Console.WriteLine("Das ist noch eine Ausgabe");
            //Console.WriteLine("Bitte geben Sie Ihren Vornamen ein:");

            //// Datentypsystem und anlegen von Variablen

            //System.Boolean b1;
            //bool b2;
            ////Dim b3 as Boolean
            //System.Int32 i1;
            //int i2;
            ////Dim i3 as Integer

            //string firstName = Console.ReadLine();
            //Console.WriteLine($"Hallo, {firstName}!");

            //// Konstanten
            //const float pi = 3.141516f;

            /* Mehrzeiliger
             * Kommentar
             * der
             * hier aufhört
             */


            // Datentypgenauigkeit und Typkonvertierung
            //Console.WriteLine("++++++++++++++++ FLOAT und Runden +++++++++++++++++++++++");
            //float f1 = 10.0f;
            //float f2 = 9.9f;
            //float floatResult = f1 - f2;
            //float floatResult2 = (float)Math.Round(floatResult, 2);
            //Console.WriteLine(floatResult);
            //Console.WriteLine(floatResult2);


            //Console.WriteLine("++++++++++++++++ double und Floor, Ceiling +++++++++++++++++++++++");
            //double d1 = 10.0;
            //double d2 = 9.9;
            //double doubleResult = d1 - d2;
            //double doubleResult2 = Math.Floor(doubleResult);
            //double doubleResult3 = Math.Ceiling(doubleResult);
            //Console.WriteLine(doubleResult);
            //Console.WriteLine(doubleResult2);
            //Console.WriteLine(doubleResult3);

            //Console.WriteLine("++++++++++++++++ Decimal +++++++++++++++++++++++");
            //decimal dec1 = 10.0m;
            //decimal dec2 = 9.9m;
            //decimal decResult = dec1 - dec2;
            //float decResult2 = (float)(dec1 - dec2);
            //Console.WriteLine(decResult);

            //Console.WriteLine("++++++++++++++++ Arrays +++++++++++++++++++++++");

            // Arrays

            //string[] names = new string[3];
            //names[0] = "Sebastian";
            //names[1] = "Alexander";
            //names[2] = "Joe";

            //Console.WriteLine(names[2]);
            ////names[3] = "Jens";

            //int[,] tabelle = new int[2, 3];

            //int[,,] würfel = new int[3, 4, 5];

            //// Programmfluss steuern
            //Console.WriteLine("Bitte gib Deinen Vornamen ein:");
            //string name = Console.ReadLine();

            //// Entscheidungen (if statement)
            //if (name == "Adam")
            //{
            //    Console.WriteLine("Das ist der Bereich von true, also die Bedingung ist wahr");
            //}

            //if(name == "Eva")
            //{
            //    Console.WriteLine("Das ist der Bereich von true, in der ja/nein Entscheidung");
            //}
            //else
            //{
            //    Console.WriteLine("Das ist der Bereich von false, in der ja/nein Entscheidung");
            //}

            //if(name == "Tobi")
            //{
            //    Console.WriteLine("Das ist der Bereich von true, also die Bedingung ist wahr in der maximalen Fallunterscheidung (if/elseif/else");
            //}
            //else if(name == "Tine")
            //{
            //    Console.WriteLine("Das ist der zweite Bereich von true in der maximalen Fallunterscheidung (if/elseif/else)");
            //}
            //else
            //{
            //    Console.WriteLine("Das ist der Bereich von false in der maximalen Fallunterscheidung (if/elseif/else)");
            //}


            //// Mehrfachauswahl mit switch
            //switch(name)
            //{
            //    case "Adam":
            //        Console.WriteLine("Mehrfachauswahl switch: Der Wert ist exakt Adam!");
            //        break;
            //    case "Eva":
            //        Console.WriteLine("Mehrfachauswahl switch: Der Wert ist exakt Eva!");
            //        break;
            //    case "Tobi":
            //        Console.WriteLine("Mehrfachauswahl switch: Der Wert ist exakt Tobi!");
            //        break;
            //    case "Tine":
            //        Console.WriteLine("Mehrfachauswahl switch: Der Wert ist exakt Tine!");
            //        break;
            //    default:
            //        Console.WriteLine("Mehrfachauswahl switch: Der Wert ist nicht aus den andern Fällen!");
            //        break;

            //}

            //// Programmfluss steuern mit Iterationen / Schleifen

            //Console.WriteLine("Zählerbasierende Schleife for:");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    if (i > 8)
            //    {
            //        break;//return;
            //    }
            //    Console.WriteLine($"Der Zähler hat den Wert {i}");
            //}

            //Console.WriteLine("Kopfgesteuerte Schleife mit while:");
            //bool abbruchBedingung = false;
            //int zähler = 0;
            //while (!abbruchBedingung)
            //{
            //    zähler++;
            //    if (zähler > 5)
            //    {
            //        abbruchBedingung = true;
            //    }
            //    Console.WriteLine($"Die Abbruchbedingung ist auf dem Wert {abbruchBedingung} der Zähler auf dem Wert {zähler}");
            //}

            //Console.WriteLine("Fußgesteuerte Schleife mit do-while:");
            //abbruchBedingung = false;
            //do
            //{
            //    zähler--;
            //    if (zähler <= 0)
            //    {
            //        abbruchBedingung = true;
            //    }
            //    Console.WriteLine($"Die Abbruchbedinung ist auf dem Wert {abbruchBedingung} der Zähler auf dem Wert {zähler}");
            //} while (abbruchBedingung);

            //// for each statement- Schleife?
            //string[] namen = { "Sebastian", "Alexander", "Sören", "Jens", "Joel", "Tobi" };
            //for(int zähler = 0; zähler <= namen.GetUpperBound(0); zähler++)
            //{
            //    string name = namen[zähler];
            //    Console.WriteLine(name);
            //}

            //foreach(string name in namen)
            //{
            //    Console.WriteLine(name);
            //}

            //DemoRoutine();
            //DemoRoutine();

            //Begrüße("Tobi");
            //string name = "Sebastian";
            //Begrüße(name);

            //int i = 1;
            //ParameterByValueDemo(i);
            //Console.WriteLine($"Main(Hauptprogramm): i hat den Wert {i}");
            //ParameterByReferenceDemo(ref i);
            //Console.WriteLine($"Main(Hauptprogramm): i hat den Wert {i}");

            // Beispiele für Methodenüberladung (Methodoverloading)
            Begrüße();
            Begrüße("Josef");
            Begrüße("Tobi", "Ulm");
           
        }

        /// <summary>
        /// Unsere erste Methode, eine klassiche Subroutine die einen einfachen begrüßungstext auf der console ausgibt
        /// </summary>
        static void DemoRoutine()
        {
            Console.WriteLine("Hallo aus einer Routine");
        }

        /// <summary>
        /// Diese Methode gibt einen Begrüßungstext mit dem Namen einer Person auf der Konsole aus
        /// </summary>
        /// <param name="namen">Der Name der zu begrüßenden Person</param>
        static void Begrüße(string namen) // Sub Begrueße(namen as string)
        {
            string text = ErstelleBegüßungsText(namen);
            //Console.WriteLine($"Hallo, {namen}!");
            Console.WriteLine(text);
        }

        /// <summary>
        /// Diese Methode ist eine Funktion mit Rückgabewert. Sie erstellt einen Begüßungstext für eine Person und deren Namen
        /// </summary>
        /// <param name="namen">Der Name der Person</param>
        /// <returns>Der auf dem namen der Person personalisierte Begrüßungstext</returns>
        static string ErstelleBegüßungsText(string namen) // Function ErstelleBegueungsText(namen as string) as String
        {
            string ergebnis = $"Hallo, {namen}!";
            return ergebnis;
        }

        /// <summary>
        /// Einfache Subroutine die einen Integerwert erhöht und ausgibt um Wertedatentypen zu erklären
        /// </summary>
        /// <param name="j">Der Integerwert der zu verändern und auszugeben ist.</param>
        static void ParameterByValueDemo(int j)
        {
            // j = j + 1;
            j += 1;
            Console.WriteLine($"ParameterByValueDemo: j hat den Wert {j}");
        }

        /// <summary>
        /// Einfache Subroutine die einen Integerwert erhöht und ausgibt um Refrenzen auf Variablen (Pointer) zu erklären
        /// </summary>
        /// <param name="j">Ein Adresszeiger (ein Pointer) auf das zu übergebene originale Integerfeld</param>
        static void ParameterByReferenceDemo(ref int j)
        {
            j += 1;
            Console.WriteLine($"ParameterByReferenceDemo: j hat den Wert {j}");
        }

        /// <summary>
        /// Einfache Subroutine die eine Person grüßt
        /// </summary>
        static void Begrüße()
        {
            Console.WriteLine("Hi!");
        }

        /// <summary>
        /// Einfache Subroutine um Methodenüberladung zu zeigen, die eine Person anhand des Vornamens und Nachnamens grüßt
        /// </summary>
        /// <param name="vorName">Der Vorname einer Person</param>
        /// <param name="nachName">Der Nachname einer Person</param>
        static void Begrüße(string vorName, string nachName)
        {
            Console.WriteLine($"{vorName}:{nachName}");
        }
    }
}