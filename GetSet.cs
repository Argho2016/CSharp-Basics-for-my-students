using System;

namespace Get_Set
{
    class GetSet
    {
        static void Main(string[] args)
        {
            Movie Avengers = new Movie("The Avengers", "Iron Man", "PG-13");
            Movie Spiderman = new Movie("No Way Home", "Spider Man", "PG");
            //G, PG, PG-13, R, NR
            //Avengers.rating = "Dog";
            Avengers.Rating = "Cat";
            Console.WriteLine(Avengers.Rating);
            Console.ReadLine();

        }
    }
}
