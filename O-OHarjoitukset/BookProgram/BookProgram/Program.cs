using System;

namespace BookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjat:");

            Book firstBook = new Book("Aapinen");
            firstBook.Author("Mikael Agricola");
            firstBook.Id("22222");
            firstBook.Price(15.89);
            Console.WriteLine("--------------------");

            Book secondBook = new Book("Peppi Pitkätossu");
            secondBook.Author("Astrid Lindgren");
            secondBook.Id("12345");
            secondBook.Price(9.99);
            Console.WriteLine("--------------------");

            firstBook.CompareBook(secondBook);
        }
    }
}
