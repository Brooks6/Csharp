using System;
namespace _20200724_gettersAndSetters
{
    public class Movies
    {
        public string title;
        public string director;
        private string rating;
        public Movies(string title, string director, string rating)
        {
            this.title = title;
            this.director = director;
            GSRating = rating; //pay attention to this line
        }

        public string GSRating{
            get { return rating; }
            set {
                if (value == "g" || value == "pg" || value == "pg-13" || value == "r" || value == "nr")
                {
                    rating = value; //value represent whatever arguments passed in
                }
                else {
                    rating = "nr";
                }
            }

        }
    }
}
