using System;

namespace BookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kirjat:");

            Book firstBook = new Book("Aapinen", "Mikael Agricola", "22222", 15.89);
            //firstBook.Author();
            //firstBook.Id();
            //firstBook.Price();
            firstBook.PrintInfo();
            Console.WriteLine("--------------------");

            Book secondBook = new Book("Peppi Pitkätossu", "Astrid Lindgren", "12345", 29.99);
            //secondBook.Author();
            //secondBook.Id();
            //secondBook.Price();
            secondBook.PrintInfo();
            Console.WriteLine("--------------------");

            firstBook.CompareBook(secondBook);
        }
    }
}
