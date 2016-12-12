using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CrossDomain_Loader
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
            Application.Run(new Form1());
        }

        internal static string Getname()
        {
            return Program.Name + " " + Program.version;
        }

        public static object version ="1"; 

        public static string Name ="CrossDomain Loader";
    }
}
