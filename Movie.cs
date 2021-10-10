using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set
{
    class Movie
    {
        public string title;
        public string hero;
        //public string rating;
        private string rating;

        public Movie(string aTitle, string aHero, string aRating)
        {
            this.title = aTitle;
            this.hero = aHero;
            //this.rating = aRating;
            this.Rating = aRating; //Calling the setter instead or user can change from here

        }
        //Access and Modify 
        public string Rating
        {
            get { return rating; } //Get the rating attribute
            set { 
                   if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR") //Value = whatever got passed, here rating
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
                } //set the rating
        }
    }
}
