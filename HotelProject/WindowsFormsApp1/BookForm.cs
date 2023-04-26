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
    }
}
