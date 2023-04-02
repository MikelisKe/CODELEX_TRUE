using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private bool _avalible;
        private List<double> _rating;
        public Video(string title)
        {
            Title = title;
            _avalible = true;
            _rating = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _avalible = false;
        }

        public void BeingReturned()
        {
            _avalible = true;
        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);
        }

        public double AverageRating()
        {
            return _rating.Average();
        }

        public bool Available()
        {
            return _avalible;
        }

        public string Title { get; private set; }

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
