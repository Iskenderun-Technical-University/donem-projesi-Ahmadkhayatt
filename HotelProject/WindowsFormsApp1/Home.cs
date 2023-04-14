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
    public partial class Home : UserControl
    {
        private int PicNumber = 1;
        public Home()
        {
            InitializeComponent();
            
        }

        private void slider()
        {
            if (PicNumber == 5)
            {
                PicNumber = 1;
            }
            pictureBox1.ImageLocation = String.Format(@"Image\{0}.jpg",PicNumber);
            PicNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slider();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           // this.Hide();

            Program.book1.Show() ;
           // Program.home.Hide();
            //Program.login1.Visible = false;
           // Program.home.Visible = false;
            
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
