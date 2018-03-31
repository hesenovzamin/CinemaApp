using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp
{
    public class Seans
    {
        public static List<Seans> Vaxt = new List<Seans>();
        public int Id;
        public string Time;
        public Seans(int _Id, string _Time)
        {
            Id = _Id;
            Time = _Time;
            Vaxt.Add(this);
        }

    }
}
