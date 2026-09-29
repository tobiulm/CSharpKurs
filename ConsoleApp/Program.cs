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

            // Programmfluss steuern
            Console.WriteLine("Bitte gib Deinen Vornamen ein:");
            string name = Console.ReadLine();

            // Entscheidungen (if statement)
            if (name == "Adam")
            {
                Console.WriteLine("Das ist der Bereich von true, also die Bedingung ist wahr");
            }

            if(name == "Eva")
            {
                Console.WriteLine("Das ist der Bereich von true, in der ja/nein Entscheidung");
            }
            else
            {
                Console.WriteLine("Das ist der Bereich von false, in der ja/nein Entscheidung");
            }

            if(name == "Tobi")
            {
                Console.WriteLine("Das ist der Bereich von true, also die Bedingung ist wahr in der maximalen Fallunterscheidung (if/elseif/else");
            }
            else if(name == "Tine")
            {
                Console.WriteLine("Das ist der zweite Bereich von true in der maximalen Fallunterscheidung (if/elseif/else)");
            }
            else
            {
                Console.WriteLine("Das ist der Bereich von false in der maximalen Fallunterscheidung (if/elseif/else)");
            }


            // Mehrfachauswahl mit switch
            switch(name)
            {
                case "Adam":
                    Console.WriteLine("Mehrfachauswahl switch: Der Wert ist exakt Adam!");
                    break;
                case "Eva":
                    Console.WriteLine("Mehrfachauswahl switch: Der Wert ist exakt Eva!");
                    break;
                case "Tobi":
                    Console.WriteLine("Mehrfachauswahl switch: Der Wert ist exakt Tobi!");
                    break;
                case "Tine":
                    Console.WriteLine("Mehrfachauswahl switch: Der Wert ist exakt Tine!");
                    break;
                default:
                    Console.WriteLine("Mehrfachauswahl switch: Der Wert ist nicht aus den andern Fällen!");
                    break;

            }

        }
    }
}