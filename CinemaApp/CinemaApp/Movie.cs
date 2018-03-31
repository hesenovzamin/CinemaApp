using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp
{
    public class Movie
    {
        public static List<Movie> Film = new List<Movie>();
        public string Name;
        public string Qiymet;
        public string Salon;
        public string Seans;
        public Movie(string _Name,string _Qiymet,string _Salon, string _Seans)
        {
            Name = _Name;
            Qiymet = _Qiymet;
            Salon = _Salon;
            Seans = _Seans;
            Film.Add(this);
        }
    }
}
