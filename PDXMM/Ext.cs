using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
    public static class Extensions
    {
        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, uint Msg);

        private const uint SW_RESTORE = 0x09;

        public static void Restore(this Form MainWindow)
        {
            if (MainWindow.WindowState == FormWindowState.Minimized)
            {
                ShowWindow(MainWindow.Handle, SW_RESTORE);
            }
        }
    }
}