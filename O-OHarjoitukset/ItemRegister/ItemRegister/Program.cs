using System;

namespace ItemRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tuoterekisterihomma");
            //Console.Write("Valitse mitä tehään:\n[1] Tulosta kaikki tuotteet\n[2] Tulostetaan halutun tuotteen tiedot" +
            //    "\n[3] Muokkaa tuotteen kommenttikenttää");
            string fPath = string.Empty;
            FileManager fileManager = new FileManager(@"C:\\temp\items.Json");
            Console.WriteLine(fileManager.ReadWords());

        }
    }
}
