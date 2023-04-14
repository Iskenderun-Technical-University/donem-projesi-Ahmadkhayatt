using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        public static Home home ;
        public static book book1 ;
        public static login login1 ;
        public static admin admin1 ;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            home = new Home();
            book1 = new book();
            login1 = new login();
            admin1 = new admin();
             
            
            Application.Run(new Form1());
        }
    }
}
