using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    public partial class HomeForm : Form
    {
        private int PicNumber = 1;

        public HomeForm()
        {
            InitializeComponent();
        }
        private void slider()
        {
            if (PicNumber == 5)
            {
                PicNumber = 1;
            }
            pictureBox1.ImageLocation = String.Format(@"Image\{0}.jpg", PicNumber);
            PicNumber++;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Program.form1.panel2.Height = Program.form1.guna2Button2.Height;
            Program.form1.panel2.Top = Program.form1.guna2Button2.Top;
            Program.form1.panel3.Controls.Clear();
            Program.book1.TopLevel = false;
            Program.form1.panel3.Controls.Add(Program.book1);
            Program.book1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slider();
        }
    }
}
