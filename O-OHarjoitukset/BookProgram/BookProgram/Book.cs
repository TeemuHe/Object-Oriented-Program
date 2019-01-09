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

        public Book(string title)
        {
            this.title = title;
            Console.WriteLine($"Nimi: {this.title}.");
        }
        public void Author(string author)
        {
            this.author = author;
            Console.WriteLine($"Kirjailija: {this.author}.");
        }
        public void Id(string id)
        {
            this.id = id;
            Console.WriteLine($"Sarjanumero: {this.id}.");
        }
        public void Price(double price)
        {
            this.price = price;
            Console.WriteLine($"Hinta: {this.price}.");
        }
        /*public string PrintInfo()
        {
            Console.WriteLine($"Nimi: {title}\nKirjoittaja: {author}\nSarjanumero{id}\nHinta: {price}");
        }*/
        public string CompareBook(Book book)
        {
            string text = "";
            //Console.WriteLine(this.price);
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
