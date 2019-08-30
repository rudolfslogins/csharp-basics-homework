using System.Collections.Generic;

namespace VideoStore
{
    public class Video
    {
        private string _title;
        private bool _isAvailable;
        private List<double> _ratingList;
        //private double _raiting;

        public Video(string title)
        {
            _title = title;
            _isAvailable = true;
            _ratingList = new List<double>();
        }
        public void BeingCheckedOut()
        {
            _isAvailable = false;
        }

        public void BeingReturned()
        {
            _isAvailable = true;
        }

        public void ReceivingARaiting(double rating)
        {
            _ratingList.Add(rating);
        }

        public string Title
        {
            get { return _title; }
        }

        public double AvarageRaiting()
        {
            double sum = 0;
            foreach (var rating in _ratingList)
            {
                sum += rating;
            }

            return sum / _ratingList.Count;
        }

        public bool Avalable()
        {
            return _isAvailable;
        }

        public override string ToString()
        {
            return $"{_title} {AvarageRaiting()} {_isAvailable}";
        }
    }
}