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
    public partial class Form1 : Form
    {
     
        public static List<Seans> sns = new List<Seans>();
        public static List<Hall> Zal = new List<Hall>();
        public static List<Movie> Film = new List<Movie>();
        public List<string> Time = new List<string>() { "12:00", "15:00", "19:00", "21:00", "23:00" };
        public List<string> Hall = new List<string>() { "Nar Mobile", "Vip Salon", "Ergen Salon", "Sevgililer Salon"};
        public Form1()
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
            InitializeComponent();
            Combobox();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            foreach (var item in Time)
            {
                string A = item;
                Movie1ComboBox1.Items.Add(A);
                Movie2ComboBox2.Items.Add(A);
                Movie3ComboBox3.Items.Add(A);
                Movie4ComboBox4.Items.Add(A);
            }
            foreach (var item in Hall)
            {
                string A = item;
                Movie1ComboBox.Items.Add(A);
                Movie2ComboBox.Items.Add(A);
                Movie3ComboBox.Items.Add(A);
                Movie4ComboBox.Items.Add(A);
            }
        }
      

        private void Movie1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            Form2 frm2 = new Form2();
            if (Movie1ComboBox1.SelectedItem != null && Movie1ComboBox.SelectedItem != null)
            {
               
                var Kino = new Movie();
                Kino.Name = "Dag2";
                Kino.Qiymet = "5Azn";
                Kino.Salon = Movie1ComboBox.SelectedItem.ToString();
                Kino.vaxt = Movie1ComboBox1.SelectedItem.ToString();
                Film.Add(Kino);
                this.Hide();
                frm2.Show();
               
            }
            else
            {
                MessageBox.Show("Zal ve ya Seans secmediniz!");
            }
        }
        void Combobox()
        {
            foreach (var item in Time)
            {
                var seans = new Seans();
                int count = 1;
                seans.Id = count;
                seans.Time = item;
                sns.Add(seans);
                count++;

            }
            foreach (var item in Time)
            {
                var Salon = new Hall();
                int count = 1;
                Salon.Id = count;
                Salon.Name = item;
                Zal.Add(Salon);
                count++;

            }
        }
    }
}
