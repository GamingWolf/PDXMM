using System;
using System.Drawing;
using System.Drawing.Text;

namespace PDXMM
{
    class CustomFont
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private static PrivateFontCollection fonts = new PrivateFontCollection();

        public static Font myFont;

        public static void FontInt(float size)
        {
            byte[] fontData = Properties.Resources._01_Digitall;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources._01_Digitall.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources._01_Digitall.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], size);
        }
    }
}
