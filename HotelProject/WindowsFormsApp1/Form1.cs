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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Height = guna2Button1.Height;
            panel2.Top = guna2Button1.Top;
            home1.BringToFront();
           


        }

       

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            panel2.Height = guna2Button1.Height;
            panel2.Top = guna2Button1.Top;
            //home1.BringToFront();
            home1.Visible = true;
            
            

         
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel2.Height = guna2Button2.Height;
            panel2.Top = guna2Button2.Top;
            home1.Visible = false;           
            //book1.BringToFront();
                                
        }

       

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panel2.Height = guna2Button4.Height;
            panel2.Top = guna2Button4.Top;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            panel2.Height = guna2Button5.Height;
            panel2.Top = guna2Button5.Top;
        }

        private void home1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
