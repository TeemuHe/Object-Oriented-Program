using System;

namespace BookAndWriterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kirja ja kirjailija luokka");
            Book kirja = new Book("Aapinen", "Mikael Agricola", "Joku", 39.95, "joku teema");
            Book toinenKirja = new Book("kirja", "Kirjankirjottaja", "publisheri", 22.22, "teema2");
            Book kolmasKirja = new Book("Kirjanro3", "Heikkinen", "Julkaisija", 11.11, "teemaa");
            kirja.FindBook("Aapinen");
            kirja.ChangeTheme();
            
        }
    }
}
