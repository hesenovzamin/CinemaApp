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
        public Button brn;
        public int top = 0;
        public int left = 20;
        public int count = 10;
        public int seatNumber = 1;
        public Form2()
        {
            InitializeComponent();
            for (int i = 1; i <=count * 2; i++)
            {
                count -= 2;
                if (i>1)
                {
                    left = i * 70;
                }
                if (i==14)
                {
                    left += 120;
                }
                for (int j = 0; j < count; j++)
                {
                    brn = new Button();
                    brn.Height = 40;
                    brn.Width = 80;
                    brn.Left = left;
                    brn.Top = top;
                    brn.Text = seatNumber.ToString();
                    brn.BackColor = Color.Green;
                    brn.FlatAppearance.BorderSize = 5;
                    brn.FlatAppearance.BorderColor = Color.White;
                    brn.FlatStyle = FlatStyle.Flat;
                    Controls.Add(brn);
                    left += 120;
                    seatNumber++;

                }
                left = 0;
                top += 50;

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
