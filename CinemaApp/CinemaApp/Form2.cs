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
    public partial class Form2 : Form
    {
       
        public List<Button> seatList = new List<Button>();
        public Button btn;
        public int top = 0;
        public int left = 0;
        public int seatNumber=1;
        public int count = Form1.YerCount;
        public Form2()
        {
            //  btn.FlatAppearance.BorderSize = 5;
            // brn.FlatAppearance.BorderColor = Color.White;
            // btn.FlatStyle = FlatStyle.Flat;
      
                InitializeComponent();
            for (int i = 0; i < Form1.YerCount / 2; i++)
            {
                left = 50 * i;
                
                for (int j = 0; j < count; j++)
                {
                    btn = new Button();
                    btn.Height = 40;
                    btn.Width = 50;
                    btn.Left = left;
                    btn.Top = top;
                    btn.Text = seatNumber.ToString();
                    btn.BackColor = Color.Green;
                    btn.Click += new EventHandler(this.btn_Click);
                    Controls.Add(btn);
                    seatNumber++;
                    left += 50;

                }
                count -= 2;
                top  +=50;
                left = 0;
            }   
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        void btn_Click(object sender, EventArgs e)
        {
            string a = "";
            string b = "";
            int count = 0;
            Button buttonn = sender as Button;
            buttonn.BackColor = Color.Aqua;
            seatList.Add(buttonn);
            
            foreach (var item in seatList)
            {
                if (buttonn.Text == item.Text)
                {
                    count++;
                }
            }
            if (count==1)
            {
                Secilenler.Text += " " + buttonn.Text;
            }
            else
            {
                a = buttonn.Text;
                seatList.Remove(buttonn);
                foreach (var item in seatList)
                {
                    if (a==item.Text)
                    {
                        item.BackColor = Color.Green;
                        seatList.Remove(item);
                        break;
                    }
                }
                foreach (var item in seatList)
                {
                      
                    b += " " + item.Text;
                    Secilenler.Text = b;


                }
                if (seatList.Count==0)
                {
                    Secilenler.Text = "";
                }
            }


          
        }

        private void ChooseSeat_Click(object sender, EventArgs e)
        {
            Ticket frm3 = new Ticket();
            this.Hide();
            frm3.Show();
        }
    }
}
