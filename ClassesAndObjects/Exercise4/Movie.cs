using System;

namespace Exercise4
{
    public class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }
        public string Rating
        {
            get { return _rating; }
        }

        public override string ToString()
        {
            return $"Title: {_title}, Studio: {_studio}, Rating: {_rating}";
        }

    }
}