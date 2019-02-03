using System;

namespace BookAndWriterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kirja ja kirjailija luokka");
            Book kirja = new Book("Aapinen", "A. Korhonen", "WSOY", 32.95, "", "13.4.1995");
            Book toinenKirja = new Book("Ristikkokirja", "B. Koponen", "Otava", 22.22, "", "8.5.1984");
            Book kolmasKirja = new Book("Taskukirja", "C.Virtanen", "Julkaisija", 11.11, "", "1.1.2001");
            kirja.FindBook("Aapinen");
            Book.ChangeTheme();
            kirja.Price = kirja.price;
            Console.WriteLine(kirja.Author);
            Author author = new Author
            {
                Name = "A. Korhonen",
                Birthday = "13.4.1995",
                Book = kirja
            };
            author.PrintInfo();
        }
    }
}
