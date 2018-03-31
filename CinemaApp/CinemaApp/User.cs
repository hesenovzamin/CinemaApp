using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp
{
    public class User
    {
        public List<User> user = new List<User>();
        public string Name;
        public string Surname;
        public string Movie;
        public string Salon;
        public string SeansTime;
        public string YerSayi;
        public string Qiymet;

        public User(string _Name,string _Surname,string _Movie,string _Salon,string _Seans,string _YerSayi,string _Qiymet)
        {
            
            Name = _Name;
            Surname = _Surname;
            Movie = _Movie;
            Salon = _Salon;
            SeansTime = _Seans;
            YerSayi = _YerSayi;
            Qiymet = _Qiymet;
            user.Add(this);
        }
    }
}
