using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndWriterProgram
{
    class Author
    {
        private string _name;
        private string _birthday;
        public Book _book;

        public Author()
        {
            this._name = "";
            this._birthday = "";
            this._book = new Book();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        public Book Book
        {
            get { return _book; }
            set { _book = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Syntymäpäivä: {this.Birthday}");
            this.Book.BookInfoPrinter();
        }  
    }
}
