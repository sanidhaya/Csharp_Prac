/*
You have a list of books and a list of reviews for those books. 
Each review has a rating (1-5). You need to find the average rating
for each book and then list the books that have an average rating
of 4.0 or higher.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    public class Books
    {
        public string name { get; set; }
        public string title { get; set; }
        public List<double> rating { get; set; }

        public Books(string _name,string _title, List<double> _rating){
            name = _name;
            title = _title;
            rating = _rating;
            SetRatings(rating);
        }

        private void SetRatings(List<double> ratings)
        {
            rating = new List<double>();
            foreach(var r in ratings)
            {
                if (r > 5.0 || r < 1.0)
                {
                    throw new Exception("Invalid rating");
                }
                else
                {
                    rating.Add(r);
                }
            }
        }

        private double avgRating(List<double> rating)
        {
            double avg_rating = rating.Average();
            return avg_rating;
        }

        public double GetAverageRating()
        {
            double avg_rating = avgRating(this.rating);
            return avg_rating;
        }
    }
}
