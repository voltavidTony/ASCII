using System;
using System.Linq;
using System.Windows.Forms;

namespace ASCII
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
            if (System.Diagnostics.Process.GetProcessesByName("ASCII").Count() == 1) Application.Run(new ASCIIWindow());
        }
    }
}
