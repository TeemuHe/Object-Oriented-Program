using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndWriterProgram
{
    class Book
    {
        public string name;
        public string author;
        public string publisher;
        public double price;
        public static string theme;
        public string dateOfBirth;

        public Book()
        {
            this.name = "";
            this.author = "";
            this.publisher = "";
            this.price = 0;
            this.dateOfBirth = "";
        }

        public Book(string name, string author, string publisher, double price, string theme, string dateOfBirth)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.price = price;
            this.dateOfBirth = dateOfBirth;
        }

        public void BookInfoPrinter()
        {
            Console.WriteLine($"Kirja: {this.name}\n" +
                $"Kirjalija: {this.author}\n" +
                $"Kustantaja: {this.publisher}\n" +
                $"Teema: {theme}\n" +
                $"Hinta: {this.price} €");
        }

        public void FindBook(string name)
        {
            if (this.name == name)
            {
                Console.WriteLine($"Kirja: {this.name}\nKirjailija: {this.author}\n" +
                $"Julkaisija: {this.publisher}\nHinta: {this.price:C}");
            }
            else
            {
                Console.WriteLine("Kirjaa ei löytynyt");
            }
        }

        public static void ChangeTheme()
        {
            Console.Write("Syötä teema: ");
            theme = Console.ReadLine();
        }

        public double Price
        {
            get { return price; }

            set
            {
                if (price > 30)
                {
                    Console.WriteLine($"Kirjan uusi hinta on {price * 0.9:C}");
                }
            }
        }

        public string Author
        {
            get { return author; }
        }
    }
}
