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
        public Form2()
        {
            //  btn.FlatAppearance.BorderSize = 5;
            // brn.FlatAppearance.BorderColor = Color.White;
            // btn.FlatStyle = FlatStyle.Flat;
            for (int i = 1; i <= Form1.YerCount * 2; i++)
            {
                for (int j = 0; j < Form1.YerCount; j++)
                {
                    btn = new Button();
                    btn.Height = 40;
                    btn.Width = 80;
                    btn.Left = left;
                    btn.Top = top;
                    btn.Text = seatNumber.ToString();
                    btn.BackColor = Color.Green;
                    Controls.Add(btn);
                    seatNumber++;
                    left += 120;
                    seatNumber++;

                }
                InitializeComponent();
            }   
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
