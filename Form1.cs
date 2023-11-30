using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "start")
            {
                timer1.Start();
                button1.Text = "stop";
            }
            else
            {
                timer1.Stop();
                button1.Text = "start";
            }
        }
        int m = 0;
        int sec = 0;
        private void timer_tick(object sender, EventArgs e)
        {
            if (m < 23)
            {
                if (sec < 60)
                {
                    if (sec < 10)
                    {
                        label3.Text = "0" + sec.ToString();
                        sec++;
                    }
                    else
                    {
                        label3.Text = sec.ToString();
                        sec++;
                    }
                }
                else
                {
                    sec = 0;
                    if (m < 9)
                    {
                        m++;
                        label1.Text = "0" + m.ToString();
                    }
                    else
                    {
                        m++;
                        label1.Text = m.ToString();
                    }
                }
            }
            else
            {
                sec = 0;
                m = 0;
            }
            if (m > -1 & m < 6 || m > 22)
            {
                pictureBox1.ImageLocation = @"C:\Users\ilezt\OneDrive\Рабочий стол\time_moscow\samyye_krasivyye_mesta_vecherney_i_nochnoy_moskvy_1_IS.jpg";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\ilezt\OneDrive\Рабочий стол\time_moscow\c0411b564a3d712445c9018b8cff4ed19d41da16.jpeg";
            }
        }
    }
}
