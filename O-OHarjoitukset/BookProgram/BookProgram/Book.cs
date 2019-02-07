using System;
using System.Collections.Generic;
using System.Text;

namespace BookProgram
{
    class Book
    {
        public string title;
        public string author;
        public string id;
        public double price;

        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Nimi: {title}\nKirjailija: {author}" +
                $"\nSarjanumero: {id}\nHinta: {price:C}");
        }

        public string CompareBook(Book book)
        {
            string text = "";
            if (this.price > book.price)
            {
                Console.WriteLine($"{this.title} on kalliimpi kuin {book.title}.");
            }
            else if(this.price == book.price)
            {
                Console.WriteLine($"{this.title} on yhtä kallis kuin {book.title}.");
            }
            else
            {
                Console.WriteLine($"{this.title} on halvempi kuin {book.title}.");
            }
            return text;
        }
    }
}
