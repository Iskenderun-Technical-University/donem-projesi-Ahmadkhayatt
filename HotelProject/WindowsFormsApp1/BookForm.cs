using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Program.admin1.Name1.Text = label1.Text;
            Program.admin1.pictureBox1.BackgroundImage = pictureBox1.BackgroundImage;
            Program.admin1.popPrice.Text = label4.Text.Replace("TL", "");
            Program.admin1.hafiz = label4.Text.Replace("TL", "");
            Program.admin1.ShowDialog();
            
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Program.admin1.Name1.Text = label10.Text;
            Program.admin1.pictureBox1.BackgroundImage = pictureBox2.BackgroundImage;
            Program.admin1.popPrice.Text = label7.Text.Replace("TL", "");
            Program.admin1.hafiz = label7.Text.Replace("TL", "");
            Program.admin1.ShowDialog();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Program.admin1.Name1.Text = label15.Text;
            Program.admin1.pictureBox1.BackgroundImage = pictureBox3.BackgroundImage;
            Program.admin1.popPrice.Text = label12.Text.Replace("TL", "");
            Program.admin1.hafiz = label12.Text.Replace("TL", "");
            Program.admin1.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Program.admin1.Name1.Text = label20.Text;
            Program.admin1.pictureBox1.BackgroundImage = pictureBox4.BackgroundImage;
            Program.admin1.popPrice.Text = label17.Text.Replace("TL", "");
            Program.admin1.hafiz = label17.Text.Replace("TL", "");
            Program.admin1.ShowDialog();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Program.admin1.Name1.Text = label30.Text;
            Program.admin1.pictureBox1.BackgroundImage = pictureBox6.BackgroundImage;
            Program.admin1.popPrice.Text = label27.Text.Replace("TL", "");
            Program.admin1.hafiz = label27.Text.Replace("TL", "");
            Program.admin1.ShowDialog();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Program.admin1.Name1.Text = label35.Text;
            Program.admin1.pictureBox1.BackgroundImage = pictureBox7.BackgroundImage;
            Program.admin1.popPrice.Text = label32.Text.Replace("TL", "");
            Program.admin1.hafiz = label32.Text.Replace("TL", "");
            Program.admin1.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Program.admin1.Name1.Text = label25.Text;
            Program.admin1.pictureBox1.BackgroundImage = pictureBox5.BackgroundImage;
            Program.admin1.popPrice.Text = label22.Text.Replace("TL", "");
            Program.admin1.hafiz = label22.Text.Replace("TL", "");
            Program.admin1.ShowDialog();
        }
    }
}
