/*
ASCII - Windows 1252 character panel with numerical values and character insertion
Copyright (C) 2018  voltavidTony

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>
*/

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
