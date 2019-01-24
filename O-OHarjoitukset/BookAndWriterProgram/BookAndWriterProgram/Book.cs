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
        private string birthDay = "13.4.";

        public Book()
        {
            this.name = "";
            this.author = "";
            this.publisher = "";
            this.price = 0;
        }

        public Book(string name, string author, string publisher, double price, string theme)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.price = price;
        }

        public void FindBook(string name)
        {
            if (this.name == name)
            {
                    Console.WriteLine($"Kirja: {this.name}\nKirjailija: {this.author}\n" +
                    $"Julkaisija: {this.publisher}\nHinta: {this.price:C} €");
            }
            else
            {
                Console.WriteLine("Kirjaa ei löytynyt");
                Environment.Exit(1);
            }              
        }

        public static void ChangeTheme()
        {
            Console.Write("Syötä teema: ");
            theme = Console.ReadLine();
        }

        public double Price
        {
            get{ return price; }

            set
            {
                if (price > 30)
                {
                    Console.WriteLine($"Kirjan uusi hinta on {price * 0.9:C}");
                }
            }
        }

        public string AuthorInfo
        {
            get { return birthDay; }
            set
            {
                birthDay = value;
            }
        }

        public void TulostaTiedot(string author, string name, string birthDay)
        {
            this.AuthorInfo = birthDay;

            Console.WriteLine($"Kirjailija: {this.author}\nKirja: {this.name}\n" +
                    $"Syntymäpäivä: {AuthorInfo}");
        }
    }
}
