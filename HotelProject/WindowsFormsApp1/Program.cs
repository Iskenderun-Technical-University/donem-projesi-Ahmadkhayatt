using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        public static HomeForm home ;
        public static BookForm book1 ;
        public static LoginForm login1 ;
        public static admin admin1 ;
        public static LoginForm loginForm1 ;
        public static Form1 form1 ;
        public static about about1 ;
        


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            home = new HomeForm();
            book1 = new BookForm();
            login1 = new LoginForm();
            admin1 = new admin();
            loginForm1 = new LoginForm();
            admin1 = new admin();
            form1  = new Form1();
            about1 = new about();
             
            
            Application.Run(form1);
        }
    }
}
