using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class Keyboard
    {

        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public static void Delay(int delay)
        {
            System.Threading.Thread.Sleep(delay);
        }

        public static void KeyDown(byte keycode)
        {
            keybd_event((byte)keycode, 0x0, 0, 0);// presses
        }

        public static void KeyPress(byte keycode, int delay = 0)
        {
            keybd_event((byte)keycode, 0x0, 0, 0);// presses
            System.Threading.Thread.Sleep(delay);
            keybd_event((byte)keycode, 0x0, 2, 0); //releases
        }

        public static void KeyUp(byte keycode)
        {
            keybd_event((byte)keycode, 0, 2, 0); //release
        }

        public static void Type(string message)
        {
            System.Windows.Forms.SendKeys.SendWait(message);
        }

    }
}
