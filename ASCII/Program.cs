using System.Threading;
using System.Windows.Forms;

namespace ASCII
{
    static class Program
    {
        private static Mutex mutex = null;

        [System.STAThread]
        static void Main()
        {
            mutex = new Mutex(true, "AE0C75E0-47CE-4112-8FEA-E9DED9C748C0", out bool created);
            if (!created) return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ASCIIWindow());
        }
    }
}
