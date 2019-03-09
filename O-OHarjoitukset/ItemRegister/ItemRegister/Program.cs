using System;

namespace ItemRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tuoterekisterihomma");
            Items items = new Items();
            //string fPath = string.Empty;
            FileManager fileManager = new FileManager(@"C:\\temp\items.Json");
            string msg = "";
            string userInput = null;

            do
            {
                userInput = Choise();
                switch (userInput.ToUpper())
                {
                    case "1":
                        Console.WriteLine(fileManager.WholeList());
                        break;
                    case "2":
                        Console.WriteLine("[A] Lajittelu ja säilytys\n[B] Paperit ja lehtiöt\n[C] Kynät\n[D] Kortit ja kirjekuoret");
                        Console.WriteLine("Valitse tuoteryhmä: ");
                        string group = Console.ReadLine().ToUpper();
                        Console.WriteLine(fileManager.PrintGroup(group));
                        break;
                    case "3":
                        fileManager.RanOutItems();
                        break;
                    //case "4":
                    //    fileManager.AddComment();
                        break;
                    case "5":
                        msg = "Ohjelma lopetetaan...";
                        break;
                    default:
                        msg = "Virheellinen syöte";
                        break;
                }
                Console.WriteLine(msg);
            }
            while (userInput.ToUpper() != "5");
        }

        public static string Choise()
        {
            Console.WriteLine("[1] Tulosta kaikki tuotteet\n[2] Tulostetaan halutun tuotteen tiedot" +
                "\n[3] Tulosta loppuneet tuotteet\n[4] Lisää tuotteelle kommentti\n[5] Poistu");
            Console.Write("Valitse mitä tehään: ");
            string choise = Console.ReadLine();
            return choise;
        }
    }
}
