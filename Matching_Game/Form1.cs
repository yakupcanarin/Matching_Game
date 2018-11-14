using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matching_Game
{
    public partial class Form1 : Form
    {
        static int finalTime = 10;
        static int tick = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer2.Interval = 1000;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";
            pictureBox3.ImageLocation = "";
            pictureBox4.ImageLocation = "";
            pictureBox5.ImageLocation = "";
            pictureBox6.ImageLocation = "";
            pictureBox7.ImageLocation = "";
            pictureBox8.ImageLocation = "";
            timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\ykpcn\Desktop\WP\wallpaper_hd_5a53ed7dc4788.jpg";
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = @"C:\Users\ykpcn\Desktop\WP\Lion-Black-and-White-HD-Desktop-Wallpapers.jpg";
            timer1.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = @"C:\Users\ykpcn\Desktop\WP\wallpaper_hd_5a551fa192ac4.jpg";
            timer1.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = @"C:\Users\ykpcn\Desktop\WP\4352817-thor-wallpapers.jpg";
            timer1.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.ImageLocation = @"C:\Users\ykpcn\Desktop\WP\wallpaper_hd_5a53ed7dc4788.jpg";
            timer1.Start();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.ImageLocation = @"C:\Users\ykpcn\Desktop\WP\wallpaper_hd_5a551fa192ac4.jpg";
            timer1.Start();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.ImageLocation = @"C:\Users\ykpcn\Desktop\WP\Lion-Black-and-White-HD-Desktop-Wallpapers.jpg";
            timer1.Start();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.ImageLocation = @"C:\Users\ykpcn\Desktop\WP\4352817-thor-wallpapers.jpg";
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tick++;
            if (tick == finalTime)
            {
                timer2.Stop();
                MessageBox.Show("Süre Bitti", "", MessageBoxButtons.OK);
            }
            else
            {
                label1.Text = tick.ToString();
            }
        }
    }
}
