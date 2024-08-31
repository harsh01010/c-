using System;
//getters and setters

namespace Oop
{
    internal class GetSet
    {
        public string movieName;
        
        private string rating;
        /*
         //verbose version
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        */
        // shortcut for above code:(auto implemented property)
        public int Id  {get; set; }
        // variable
        // property

        public GetSet() { }
        public GetSet(string movieName, string rating, int id) : this()
        {
            this.movieName = movieName;
            this.Id = id;
            this.Rating = rating;
        }
        public string Rating
        {
            get { return this.rating; }
            set
            {
                if (value == "A" || value == "B" || value == "C")
                { this.rating = value; }
            }
        }
    }
}
/*
 *  in auto implemented property: 
 *  The compiler automatically generates a private backing field for the property Id.
    This backing field is not explicitly named or accessible in the code.
 * 
 * the private backing field is not derivable and the Id property that is 
 * public is derived by the child classes
 * 
 * 
 * 
 * 
 * */