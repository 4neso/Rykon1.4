using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RykonServer.Classes
{
    public class RemoteAdmin
    {


        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public static  string  MuteSystemSound(IntPtr Handle)
        {

            try
            {
                SendMessageW(Handle, WM_APPCOMMAND, Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
                return "muted";
            }
            catch { }
            return "fail";
        }


        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int WM_APPCOMMAND = 0x319;
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        public static void Move(int xDelta, int yDelta)
        {
            mouse_event(MOUSEEVENTF_MOVE, xDelta, yDelta, 0, 0);
        }
        public static void MoveTo(int x, int y)
        {
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, 0);
        }
        public static void LeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }

       
        public static void MouseMove(int x, int y)
        {
            MouseMover.MOVEMouse(x, y);
        }
        public static void PerformMouseLeftClick()
        {
            LeftClick();
        }

    }

   public class MouseMover
   {
       public static void ShiftMouseRigth(int shifted)
       {

           Cursor.Position = new Point(Cursor.Position.X + shifted, Cursor.Position.Y);
       }
       public static void ShiftMouseLeft(int shifted)
       {

           Cursor.Position = new Point(Cursor.Position.X - shifted, Cursor.Position.Y);
       }
       public static void ShiftMousedown(int shifted)
       {

           Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + -shifted);
       }
       public static void ShiftMouseup(int shifted)
       {

           Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + shifted);
       }
       public static void ShiftMouseupLeft(int up,int lef)
       {

           Cursor.Position = new Point(Cursor.Position.X-lef, Cursor.Position.Y -up);
       }
       public static void ShiftMouseupRight(int up, int rit)
       {

           Cursor.Position = new Point(Cursor.Position.X + rit, Cursor.Position.Y - up);
       }
       public static void ShiftMouseDownRight(int up, int rit)
       {

           Cursor.Position = new Point(Cursor.Position.X + rit, Cursor.Position.Y + up);
       }
       public static void ShiftMouseDownLeft(int up, int rit)
       {

           Cursor.Position = new Point(Cursor.Position.X - rit, Cursor.Position.Y + up);
       }
       public static void MOVEMouse(int x, int y)
       {
          
           Cursor.Position = new Point(x,y);
       }
       public static void MOVEMouse(  Point x)
       {

           Cursor.Position =x;
       }
   }
}
