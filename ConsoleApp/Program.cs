using ItSchulungen.CSharpKurs.ClassLibrary;

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
            //Begrüße();
            //Begrüße("Josef");
            //Begrüße("Tobi", "Ulm");

            // Ausnahmenbehandlung
            //ExceptionDemo();

            //Enumerationen();

            //Strukturen();

            // ObjektOrientierteProgrammierung();
            CollectionsDemo();
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

        static void ExceptionDemo()
        {
            string message = "";
            try
            {
                string file = System.IO.File.ReadAllText(@"C:\test.txt");

            }
            catch (FileNotFoundException fex)
            {

                message = "Die Datei konnte nicht gefunden werden... Bitte geben sie den korrekten Pfad an....";

            }
            catch (Exception ex)
            {
                message = $"Ein Fehler ist aufgetreten: {ex.Message}";
            }
            finally
            {
                Console.WriteLine(message);
                Console.WriteLine("Der Inhalt der Textdatei folgt jetzt....");
            }
        }

        public static void Enumerationen()
        {
            //ItSchulungen.CSharpKurs.ClassLibrary.Wochentag meinTag = ClassLibrary.Wochentag.Freitag;
            Wochentag meinTag = Wochentag.Freitag;
            Console.WriteLine($"Mein Tag: {meinTag}");
            ZeigeEnumerationAuswahl(meinTag);
            ZeigeEnumerationAuswahl(Wochentag.Sonntag);
        }

        public static void ZeigeEnumerationAuswahl(Wochentag wochentag)
        {
            Console.WriteLine(wochentag.ToString());
        }

        public static void Strukturen()
        {
            double x;
            double y;

            Punkt2D p1;
            p1.X = 12.09;
            p1.Y = 21.90;

            Punkt2D p2;
            p2.X = 34.98;
            p2.Y = 43.89;


            Punkt2D p3 = p1.AddiereVektor(23.21, 78.89);
            Console.WriteLine($"Neuer Punkt p3.X={p3.X}\tp3.Y={p3.Y}");

            Punkt2D p4 = p2.AddiereVektor(p3);
            Console.WriteLine($"Neuer Punkt p4.X={p4.X}\tp4.Y={p4.Y}");

        }

        public static void ObjektOrientierteProgrammierung()
        {
            Employee emp1;
            emp1 = new Employee();
            emp1.FirstName = "Max";
            emp1.LastName = "Mustermann";
            emp1.Department = Department.Management;
            emp1.DateOfBirth = new DateOnly(1975, 5, 12);
            emp1.Sex = Gender.Male;

            Console.WriteLine(emp1.Greet());
            Console.WriteLine($"emp1 hat ein Gehalt von {emp1.Salary:C}");

            Console.WriteLine($"Human.NumberOfPeople: {Human.NumberOfPeople}");
            emp1.Dispose();


            Employee emp2 = new Employee("Eva", "Musterfrau", new DateOnly(1980, 8, 21), Department.Sales, Gender.Female);
            Console.WriteLine(emp2.Greet());
            Console.WriteLine($"emp2 hat ein Gehalt von {emp2.Salary:C}");

            Console.WriteLine($"Human.NumberOfPeople: {Human.NumberOfPeople}");


            Employee emp3 = new Employee("Tobi", "Ulm");
            Console.Write(emp3.Greet());

            Console.WriteLine($"Human.NumberOfPeople: {Human.NumberOfPeople}");

            Human james = new Human("James", "Bond");
            Console.WriteLine(james.Greet());

            Console.WriteLine($"Human.NumberOfPeople: {Human.NumberOfPeople}");

            Customer cust1 = new Customer();
            Console.WriteLine($"Human.NumberOfPeople: {Human.NumberOfPeople}");


            Employee emp4 = new Employee();
            try
            {
                emp4.DateOfBirth = new DateOnly(2016, 1, 1);
                emp4.FirstName = "Dummy";
                emp4.LastName = "AgeTest";
            }
            catch(EmployeeToYoungException ex)
            {
                Console.WriteLine("Der Mitarbeiter kann nicht erstellt werden da er zu jung ist. Das Mindestalter beträgt 16 Jahre!");
            }

            Console.WriteLine(emp4.Greet());

            Console.WriteLine($"Human.NumberOfPeople: {Human.NumberOfPeople}");

            Console.WriteLine(Human.PrintNumberOfPeople());
            

        }


        static void CollectionsDemo()
        {
            string[] names = new string[3];
            
            System.Collections.ArrayList myList = new System.Collections.ArrayList();
            myList.Add("Tobi");
            Console.WriteLine(myList[0]);

            myList.Add(42);

            // myList[1]

            System.Collections.Generic.List<int> newList = new List<int>();
            List<Employee> employees = new List<Employee>();

            Employee emp1 = new Employee("Max", "Mustermann", new DateOnly(1970, 1, 1), Department.Management, Gender.Male);


            employees.Add(emp1);



        }
    }
}