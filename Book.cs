using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor2
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {

        }

        public Book(string aTitle, string aAuthor, int apages) //a = argument
        {
            // Console.WriteLine("Creating Books");
            this.title = aTitle;
            this.author = aAuthor;
            this.pages = apages;
        }
    }
}
