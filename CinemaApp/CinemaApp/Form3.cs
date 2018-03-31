using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaApp
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Name.Text != "" && Surname.Text != "")
            {
                foreach (var item in Movie.Film)
                {
                    var user = new User(Name.Text, Surname.Text, item.Name, item.Salon, item.Seans, Form1.YerCount.ToString(), item.Qiymet);
                    MessageBox.Show("Salam" + " " + user.Name + " " + user.Surname
                        + " " + "Siz" + " " + user.Movie + " " + "Filmine" + " " + user.Salon + " " + "Zalinda" + " " + user.SeansTime + " " + "da " + " " + user.YerSayi + " yer sifrais etmisiniz." + " " + "Mebleg" + " " + user.Qiymet);
                    this.Hide();

                }
            }
        }
    }
}
