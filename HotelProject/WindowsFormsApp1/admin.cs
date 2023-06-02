using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1
{

    public partial class admin : Form
    {
        public string gender;
        public int i;
   
        public string check()
        {  
            
            if (radioButton1.Checked)
                gender = "Male";
            else if (radioButton2.Checked)
                gender = "Female";
            return gender;
    }
        public void AddToTable(string l1, string l2, string t1, string t2, string t3  ,string lN)
        {

            string qwe = check();
            Program.con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into [Table] values(@id ,@Hotel_Name ,@first_name ,@last_name ,@Email ,@Gender ,@days,@Price)",Program.con);
            cmd.Parameters.AddWithValue("@id", i);
            cmd.Parameters.AddWithValue("@Hotel_Name",lN);
            cmd.Parameters.AddWithValue("@first_name", t1);
            cmd.Parameters.AddWithValue("@last_name", t2);
            cmd.Parameters.AddWithValue("@Email", t3);
            cmd.Parameters.AddWithValue("@Gender", qwe);
            cmd.Parameters.AddWithValue("@days",int.Parse( l1));
            cmd.Parameters.AddWithValue("@Price",int.Parse( l2));
            cmd.ExecuteNonQuery();
            Program.con.Close();
            i++;
        }

        public int x = 1, toplam, z, ttoplam;
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddToTable(counter.Text, popPrice.Text, guna2TextBox2.Text, guna2TextBox1.Text, guna2TextBox3.Text, check());
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
                
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
