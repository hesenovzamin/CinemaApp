using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp
{
    public class Hall
    {
        public static List<Hall> Zal = new List<Hall>();
        public int Id;
        public string Name;
        public Hall(int _Id,string _Name)
        {
            Id = _Id;
            Name = _Name;
            Zal.Add(this);
        }
    }
}
