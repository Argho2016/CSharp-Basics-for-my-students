using System;

namespace constructor2
{
    class Constructors
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            //book1.title = "Harry Potter";
           // book1.author = "JK Rowling";
          //  book1.pages = 400;

            Book book2 = new Book("Lord of the Rings", "Tolkien", 800);
            //book2.title = "Lord of the Ring";
            // book2.author = "Tolkein";
            // book2.pages = 800;

            Book book3 = new Book();

            book2.title = "The Hobbit";

            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}
