using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheater
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formLogin());
        }
        
    }
    public static class Globals
    {
        public static string Globalusn { get; set; }
        public static int Globaltypeusn { get; set; }
        public static void setglobaltypeusn (int type)
        {
            Globaltypeusn = type;
        }
        public static void setglobalusn(string newusn)
        {
            Globalusn = newusn;
        }
        
    }
}
