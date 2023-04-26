using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
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
            Program.home.TopLevel = false;
            panel3.Controls.Add(Program.home);
            Program.home.Show();
        }

       

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            panel2.Height = guna2Button1.Height;
            panel2.Top = guna2Button1.Top;
            panel3.Controls.Clear();
            HomeForm homeForm = new HomeForm();           
            homeForm.TopLevel = false;
            panel3.Controls.Add(homeForm);
            homeForm.Show();         
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel2.Height = guna2Button2.Height;
            panel2.Top = guna2Button2.Top;
            panel3.Controls.Clear();
            BookForm bookForm = new BookForm();
            bookForm.TopLevel = false;
            panel3.Controls.Add(bookForm);
            bookForm.Show();           

        }

       

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panel2.Height = guna2Button4.Height;
            panel2.Top = guna2Button4.Top;
            panel3.Controls.Clear();
            LoginForm loginForm = new LoginForm();
            loginForm.TopLevel = false;
            panel3.Controls.Add(loginForm);
            loginForm.Show();


        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            panel2.Height = guna2Button5.Height;
            panel2.Top = guna2Button5.Top;
            panel3.Controls.Clear();
            about About = new about();
            About.TopLevel = false;
            panel3.Controls.Add(About);
            About.Show();
        }

       

        private void home1_Load(object sender, EventArgs e)
        {
           
        }        

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
