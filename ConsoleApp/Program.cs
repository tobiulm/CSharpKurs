namespace ItSchulungen.CSharpKurs.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine
            //    (
            //        "Hello, World!"
            //    );
            //Console.WriteLine("Das ist noch eine Ausgabe");
            //Console.WriteLine("Bitte geben Sie Ihren Vornamen ein:");

            //System.Boolean b1;
            //bool b2;
            ////Dim b3 as Boolean
            //System.Int32 i1;
            //int i2;
            ////Dim i3 as Integer

            //string firstName = Console.ReadLine();
            //Console.WriteLine($"Hallo, {firstName}!");

            const float pi = 3.141516f;

            Console.WriteLine("++++++++++++++++ FLOAT und Runden +++++++++++++++++++++++");
            float f1 = 10.0f;
            float f2 = 9.9f;
            float floatResult = f1 - f2;
            float floatResult2 = (float)Math.Round(floatResult, 2);
            Console.WriteLine(floatResult);
            Console.WriteLine(floatResult2);


            Console.WriteLine("++++++++++++++++ double und Floor, Ceiling +++++++++++++++++++++++");
            double d1 = 10.0;
            double d2 = 9.9;
            double doubleResult = d1 - d2;
            double doubleResult2 = Math.Floor(doubleResult);
            double doubleResult3 = Math.Ceiling(doubleResult);
            Console.WriteLine(doubleResult);
            Console.WriteLine(doubleResult2);
            Console.WriteLine(doubleResult3);

            Console.WriteLine("++++++++++++++++ Decimal +++++++++++++++++++++++");
            decimal dec1 = 10.0m;
            decimal dec2 = 9.9m;
            decimal decResult = dec1 - dec2;
            float decResult2 = (float)(dec1 -dec2);
            Console.WriteLine(decResult);

            Console.WriteLine("++++++++++++++++ Arrays +++++++++++++++++++++++");

            string[] names = new string[3];
            names[0] = "Sebastian";
            names[1] = "Alexander";
            names[2] = "Joe";

            Console.WriteLine(names[2]);
            //names[3] = "Jens";

            int[,] tabelle = new int[2, 3];

            int[,,] würfel = new int[3, 4, 5];



        }
    }
}