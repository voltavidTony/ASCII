using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static ASCII.NativeMethods;

namespace ASCII {
    public static class Methods {
        public static Rectangle BorderBounds(this Control c) {
            Rectangle rect = c.Bounds;
            rect.X--;
            rect.Y--;
            rect.Width++;
            rect.Height++;
            return rect;
        }

        public static Color GetAccentColor() {
            DwmGetColorizationParameters(out DWMCOLORIZATIONcolors colors);
            return Color.FromArgb((int)colors.ColorizationColor | ~0xFFFFFF);
        }
    }

    public static class NativeMethods {
        [DllImport("dwmapi.dll", EntryPoint = "#127")]
        public static extern void DwmGetColorizationParameters(out DWMCOLORIZATIONcolors colors);
        public struct DWMCOLORIZATIONcolors {
            public uint ColorizationColor,
                ColorizationAfterglow,
                ColorizationColorBalance,
                ColorizationAfterglowBalance,
                ColorizationBlurBalance,
                ColorizationGlassReflectionIntensity,
                ColorizationOpaqueBlend;
        }

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
    }
}
