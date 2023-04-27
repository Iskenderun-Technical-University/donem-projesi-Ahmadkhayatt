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
    public partial class admin : Form
    {

        int x = 1, toplam, z, ttoplam;
        public string hafiz;

        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x++;
            //hafiz string is coming from price lable 
            counter.Text = Convert.ToString(x);
            toplam = x * Int32.Parse(hafiz);

            popPrice.Text = Convert.ToString(toplam);
            counter.Text = x.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x > 1)
            {
                --x;
                counter.Text = Convert.ToString(x);
                toplam = x * Int32.Parse(hafiz);
                popPrice.Text = Convert.ToString(toplam);
                counter.Text = x.ToString();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

           


        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
