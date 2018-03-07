using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackgroundImage = Resources.cennik1;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Resources._4273e10572a8d833d646446f0521a766__sprites_hd_wallpaper;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackgroundImage = Resources.cennik3;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Resources.Milka_Oreo_300g_Chocolate_jpg_350x350;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackgroundImage = Resources.cennik2;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Resources.maxresdefault;
        }


        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackgroundImage = Resources.cennik4;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = Resources._69995fcebd9e233c74fc127cfb64421a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(label1.Text);
            num += 1;
            label1.Text = Convert.ToString(num);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(label1.Text);
            num += 2;
            label1.Text = Convert.ToString(num);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(label1.Text);
            num += 5;
            label1.Text = Convert.ToString(num);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(label1.Text);
            if (num - 12 >= 0)
            {
                num -= 12;
                label1.Text = Convert.ToString(num);
                pictureBox1.BackgroundImage = Resources.sprite__1_;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(label1.Text);
            if (num - 15 >= 0)
            {
                num -= 15;
                label1.Text = Convert.ToString(num);
                pictureBox1.BackgroundImage = Resources._205652;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(label1.Text);
            if (num - 7 >= 0)
            {
                num -= 7;
                label1.Text = Convert.ToString(num);
                pictureBox1.BackgroundImage = Resources._43049;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(label1.Text);
            if (num - 5 >= 0)
            {
                num -= 5;
                label1.Text = Convert.ToString(num);
                pictureBox1.BackgroundImage = Resources._1928_large;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Resources.foodbox_long;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
