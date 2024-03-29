/*
ASCII - Windows 1252 character panel with numerical values and SendKeys funcionality
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

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ASCII {
    public partial class ASCIIWindow : Form {
        Color PenColor = Color.Black;
        float PenWidth = 0.2f;

        readonly Pen AccentPen = new Pen(Methods.GetAccentColor(), 1);

        bool changing = false;

        readonly int[] lexicoid = { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 65, 192, 193, 194, 195, 196, 197, 198, 66, 67, 199, 68, 69, 200,
            201, 202, 203, 70, 71, 72, 73, 204, 205, 206, 207, 74, 208, 75, 76, 77, 78, 209, 79, 210, 211, 212, 213, 214, 216, 140, 80, 81,
            82, 83, 138, 84, 222, 85, 217, 218, 219, 220, 86, 87, 88, 89, 221, 159, 90, 142, 97, 224, 225, 226, 227, 228, 229, 230, 98, 99,
            231, 100, 101, 232, 233, 234, 235, 102, 103, 104, 105, 236, 237, 238, 239, 106, 240, 107, 108, 109, 181, 110, 241, 111, 242, 243,
            244, 245, 246, 248, 156, 112, 113, 114, 115, 154, 223, 116, 254, 117, 249, 250, 251, 252, 118, 119, 120, 121, 253, 255, 122, 158,
            32, 160, 46, 58, 44, 59, 33, 161, 63, 191, 39, 130, 145, 146, 34, 132, 147, 148, 139, 155, 171, 187, 96, 180, 136, 152, 168, 35,
            38, 64, 167, 182, 36, 128, 162, 163, 164, 165, 43, 45, 42, 47, 61, 37, 60, 62, 94, 126, 176, 177, 215, 247, 137, 40, 41, 91, 93,
            123, 125, 92, 124, 166, 95, 172, 173, 150, 151, 175, 184, 183, 149, 133, 170, 186, 185, 178, 179, 188, 189, 190, 131, 134, 135,
            169, 174, 153, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
            31, 127, 129, 141, 143, 144, 157 };

        readonly string[] names = { "NULL", "SOH", "STX", "ETX", "EOT", "ENQ", "ACK", "BEL", "BS", "TAB", "LF", "VT", "FF", "CR", "SO", "SI",
            "DLE", "DC1", "DC2", "DC3", "DC4", "NAK", "SYN", "ETB", "CAN", "EM", "SUB", "ESC", "FS", "GS", "RS", "US", "Space", "!", "\"",
            "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ":", ";", "<",
            "=", ">", "?", "@", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
            "W", "X", "Y", "Z", "[", "\\", "]", "^", "_", "`", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
            "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "{", "|", "}", "~", "DEL", "€", "HOP", "‚", "ƒ", "„", "…", "†", "‡", "ˆ", "‰",
            "Š", "‹", "Œ", "RI", "Ž", "SS3", "DCS", "‘", "’", "“", "”", "•", "–", "—", "˜", "™", "š", "›", "œ", "OSC", "ž", "Ÿ", "NBSP", "¡",
            "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "¬", "­", "®", "¯", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "»",
            "¼", "½", "¾", "¿", "À", "Á", "Â", "Ã", "Ä", "Å", "Æ", "Ç", "È", "É", "Ê", "Ë", "Ì", "Í", "Î", "Ï", "Ð", "Ñ", "Ò", "Ó", "Ô", "Õ",
            "Ö", "×", "Ø", "Ù", "Ú", "Û", "Ü", "Ý", "Þ", "ß", "à", "á", "â", "ã", "ä", "å", "æ", "ç", "è", "é", "ê", "ë", "ì", "í", "î", "ï",
            "ð", "ñ", "ò", "ó", "ô", "õ", "ö", "÷", "ø", "ù", "ú", "û", "ü", "ý", "þ", "ÿ" };

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x08000000;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(AccentPen, charPanel.BorderBounds());
            e.Graphics.DrawRectangle(AccentPen, description.BorderBounds());
            e.Graphics.DrawRectangle(AccentPen, tableOptions.BorderBounds());
        }

        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x0320) {
                AccentPen.Color = Methods.GetAccentColor();
                Invalidate();
            }
            base.WndProc(ref m);
        }

        public ASCIIWindow() {
            InitializeComponent();
            RefreshCharPanel();
            Height = charPanel.Items[16].Bounds.Y + 2;
            Width = (columnHeaderHex.Width + columnHeaderValue.Width + columnHeaderChar.Width + SystemInformation.VerticalScrollBarWidth + 2) * 2;
        }

        private void RefreshCharPanel() {
            charPanel.Items.Clear();
            for (int i = 0; i < 256; i++) {
                int id = checkBox2.Checked ? lexicoid[i] : i;
                if (!checkBox1.Checked && names[id].Length > 1 && id != 32 && id != 160) continue;
                charPanel.Items.Add(new ListViewItem(new string[] { $"{id:X2}", $"{id}", names[id] }) {
                    ForeColor = names[id].Length == 1 || id == 32 || id == 160 ? Color.Black : Color.Crimson
                });
            }
        }

        private void CharPanel_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) {
            e.NewWidth = charPanel.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void CharPanel_DoubleClick(object sender, EventArgs e) {
            string letter = names[int.Parse(charPanel.SelectedItems[0].SubItems[1].Text)];
            if (letter.Equals("Space")) {
                SendKeys.Send(" ");
                return;
            }
            if (letter.Equals("NBSP")) {
                SendKeys.Send(" ");
                return;
            }
            if (letter.Length > 1) {
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            SendKeys.Send("%()+[]^{}~".Contains($"{letter}") ? $"{{{letter}}}" : $"{letter}");
        }

        private void CheckBox_CheckStateChanged(object sender, EventArgs e) {
            if (!sender.Equals(checkBox3)) RefreshCharPanel();
            else if (!changing) trackOpaque.Value = checkBox3.Checked ? 70 : 100;
        }

        private void CloseButton_Click(object sender, EventArgs e) => Application.Exit();

        private void CloseButton_MouseEnter(object sender, EventArgs e) {
            PenColor = Color.White;
            PenWidth = 0.3f;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e) {
            PenColor = Color.Black;
            PenWidth = 0.2f;
        }

        private void CloseButton_Paint(object sender, PaintEventArgs e) {
            Rectangle bounds = new Rectangle(closeButton.Width / 2 - 5, closeButton.Height / 2 - 5, 9, 9);
            GraphicsPath closeX = new GraphicsPath();

            closeX.AddPolygon(new PointF[] { new PointF(bounds.Left, bounds.Top), new PointF(bounds.Left + PenWidth, bounds.Top),
                new PointF(bounds.Right, bounds.Bottom - PenWidth), new PointF(bounds.Right, bounds.Bottom),
                new PointF(bounds.Right - PenWidth, bounds.Bottom), new PointF(bounds.Left, bounds.Top + PenWidth) });
            closeX.AddPolygon(new PointF[] { new PointF(bounds.Left, bounds.Bottom), new PointF(bounds.Left + PenWidth, bounds.Bottom),
                new PointF(bounds.Right, bounds.Top + PenWidth), new PointF(bounds.Right, bounds.Top),
                new PointF(bounds.Right - PenWidth, bounds.Top), new PointF(bounds.Left, bounds.Bottom - PenWidth) });

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.None;
            e.Graphics.DrawPath(new Pen(PenColor, 1), closeX);
        }

        private void PanelDrag_MouseDown(object sender, MouseEventArgs e) {
            NativeMethods.ReleaseCapture();
            NativeMethods.SendMessage(Handle, 0xA1, 0x2, 0);
            int i = charPanel.TopItem.Index;
            if (i > 0) charPanel.TopItem = charPanel.Items[i - 1];
            else charPanel.TopItem = charPanel.Items[1];
            charPanel.TopItem = charPanel.Items[i];
        }

        private void TrackOpaque_ValueChanged(object sender, EventArgs e) {
            changing = true;
            labelOpaque.Text = $"{trackOpaque.Value} %";
            checkBox3.Checked = (Opacity = trackOpaque.Value / 100.0) != 1.0;
            changing = false;
        }

        [System.STAThread]
        static void Main() {
            new System.Threading.Mutex(true, "AE0C75E0-47CE-4112-8FEA-E9DED9C748C0", out bool created);
            if (!created) return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ASCIIWindow());
        }
    }
}
