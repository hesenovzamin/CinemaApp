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
        public static int YerCount;
        public List<string> Time = new List<string>() { "12:00", "15:00", "19:00", "21:00", "23:00" };
        public List<string> Hall = new List<string>() { "Nar Mobile", "Vip Salon", "Ergen Salon", "Sevgililer Salon"};
        public Form1()
        {
            InitializeComponent();
            Halls();
            Seans();
           // Combobox();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in CinemaApp.Seans.Vaxt)
            {
                Movie1ComboBox1.Items.Add(item.Time);
                Movie2ComboBox2.Items.Add(item.Time);
                Movie3ComboBox3.Items.Add(item.Time);
                Movie4ComboBox4.Items.Add(item.Time);
            }
            foreach (var item in CinemaApp.Hall.Zal)
            {               
                Movie1ComboBox.Items.Add(item.Name);
                Movie2ComboBox.Items.Add(item.Name);
                Movie3ComboBox.Items.Add(item.Name);
                Movie4ComboBox.Items.Add(item.Name);
            }
        }
      

       private void Movie1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
          
            if (Movie1ComboBox1.SelectedItem != null && Movie1ComboBox.SelectedItem != null)
            {
                switch (Movie1ComboBox.SelectedItem.ToString())
                {
                    case "Nar Mobile":
                        YerCount = 8;
                        break;
                    case "Vip Salon":
                        YerCount = 16;
                        break;
                    case "Ergen Salon":
                        YerCount = 10;
                        break;
                    case "Sevgililer Salon":
                        YerCount = 12;
                        break; 
                    default:
                        break;
                }
                var Film = new Movie("Dag2", "5Azn", Movie1ComboBox.SelectedItem.ToString(),Movie1ComboBox1.SelectedItem.ToString());
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();
               
            }
           else
          {
               MessageBox.Show("Zal ve ya Seans secmediniz!");
           }
       }
      
        void Halls()
        {
            foreach (string item in Hall)
            {
                int count = 1;
                Hall Zal = new Hall(count,item);
                count++;
            }
        }
        void Seans()
        {
            foreach (string item in Time)
            {
                int count = 1;
                Seans Vaxt = new Seans(count, item);
                count++;
            }
        }

        private void Movie2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();

            if (Movie2ComboBox2.SelectedItem != null && Movie2ComboBox.SelectedItem != null)
            {
                switch (Movie2ComboBox.SelectedItem.ToString())
                {
                    case "Nar Mobile":
                        YerCount = 8;
                        break;
                    case "Vip Salon":
                        YerCount = 16;
                        break;
                    case "Ergen Salon":
                        YerCount = 10;
                        break;
                    case "Sevgililer Salon":
                        YerCount = 12;
                        break;
                    default:
                        break;
                }
                var Film = new Movie("Game Of Thrones", "5Azn", Movie2ComboBox.SelectedItem.ToString(), Movie2ComboBox2.SelectedItem.ToString());
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();

            }
            else
            {
                MessageBox.Show("Zal ve ya Seans secmediniz!");
            }
        }

        private void Movie3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();

            if (Movie3ComboBox3.SelectedItem != null && Movie3ComboBox.SelectedItem != null)
            {
                switch (Movie3ComboBox.SelectedItem.ToString())
                {
                    case "Nar Mobile":
                        YerCount = 8;
                        break;
                    case "Vip Salon":
                        YerCount = 16;
                        break;
                    case "Ergen Salon":
                        YerCount = 10;
                        break;
                    case "Sevgililer Salon":
                        YerCount = 12;
                        break;
                    default:
                        break;
                }
                var Film = new Movie("Gladiator", "5Azn", Movie3ComboBox.SelectedItem.ToString(), Movie3ComboBox3.SelectedItem.ToString());
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();

            }
            else
            {
                MessageBox.Show("Zal ve ya Seans secmediniz!");
            }
        }

        private void Movie4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();

            if (Movie4ComboBox4.SelectedItem != null && Movie4ComboBox.SelectedItem != null)
            {
                switch (Movie4ComboBox.SelectedItem.ToString())
                {
                    case "Nar Mobile":
                        YerCount = 8;
                        break;
                    case "Vip Salon":
                        YerCount = 16;
                        break;
                    case "Ergen Salon":
                        YerCount = 10;
                        break;
                    case "Sevgililer Salon":
                        YerCount = 12;
                        break;
                    default:
                        break;
                }
                var Film = new Movie("Spiderman", "5Azn", Movie4ComboBox.SelectedItem.ToString(), Movie4ComboBox4.SelectedItem.ToString());
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();

            }
            else
            {
                MessageBox.Show("Zal ve ya Seans secmediniz!");
            }
        }
    }
}
