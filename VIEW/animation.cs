using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Go.VIEW
{
    class animation
    {
        //mètodo criado para gerar animação
        public static class util
        {
            public enum effect { Roll, Slide, Center, Blend }

            public static void Animatte(Control ctl, effect effect, int msec, int angle)
            {
                int flags = effmap[(int)effect];

                if (ctl.Visible)
                {
                    flags |= 0x30000; angle += 180;

                }
                else
                {
                    if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                    else if (effect == effect.Blend) throw new ArgumentException();
                }

                flags |= dirmap[angle % 360 / 45];
                bool ok = AnimateWindow(ctl.Handle, msec, flags);
                if (!ok) throw new Exception("Falha na animação");
                ctl.Visible = !ctl.Visible;

            }


            private static int[] dirmap = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

            [DllImport("user32.dll")]

            private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);
        }
    }
}
