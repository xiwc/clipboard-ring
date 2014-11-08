using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using QQPrintScreen;

namespace DesktopHelper
{
    public class Win32Api
    {
        private Win32Api() { }

        [DllImport("user32.dll")]
        public static extern short GetKeyState(int nVirtKey); 

        [DllImport("User32.DLL")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        //获取当前鼠标位置
        [DllImport("user32.dll")]
        public extern static int GetCursorPos(ref POINT lpPoint);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetScrollInfo(IntPtr hwnd, int fnBar, ref SCROLLINFO lpsi);

        [DllImport("user32.dll", SetLastError = true, EntryPoint = "GetScrollBarInfo")]
        public static extern int GetScrollBarInfo(IntPtr hWnd, int idObject, ref SCROLLBARINFO psbi);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowInfo(IntPtr hwnd, ref WINDOWINFO pwi);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetActiveWindow(IntPtr hWnd);

        // For Windows Mobile, replace user32.dll with coredll.dll 
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        //获得某一窗口的位置信息
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(POINT Point);
        
        //该函数将指定窗口的标题条文本（如果存在）拷贝到一个缓存区内。
        //如果指定的窗口是一个控件，则拷贝控件的文本。
        //但是，GetWindowTeXt不能接收在其他应用程序中的控件的文本
        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder title, int size);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(
         IntPtr hWnd, // handle to window 
         int id // hot key identifier 
        );

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        //根据类名或窗口名查找窗体
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        /*wCmd指定结果窗口与源窗口的关系，它们建立在下述常数基础上：
            GW_CHILD = 5
            寻找源窗口的第一个子窗口
            GW_HWNDFIRST = 0
            为一个源子窗口寻找第一个兄弟（同级）窗口，或寻找第一个顶级窗口
            GW_HWNDLAST = 1
            为一个源子窗口寻找最后一个兄弟（同级）窗口，或寻找最后一个顶级窗口
            GW_HWNDNEXT = 2
            为源窗口寻找下一个兄弟窗口
            GW_HWNDPREV = 3
            为源窗口寻找前一个兄弟窗口
            GW_OWNER = 4
            寻找窗口的所有者
       */
        [DllImport("user32.dll", EntryPoint = "GetWindow")]
        //获取窗体句柄，hwnd为源窗口句柄
        public static extern int GetWindow(int hwnd, int wCmd);

        [DllImport("user32.dll", EntryPoint = "SetParent")]
        //设置父窗体
        public static extern int SetParent(int hWndChild, int hWndNewParent);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern bool BitBlt(HandleRef hdc, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hDC, int XPos, int YPos);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("User32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PrintWindow(IntPtr hwnd, HandleRef hDC, uint nFlags);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr hHandle);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleDC(
         IntPtr hdc // handle to DC
         );

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleBitmap(
         IntPtr hdc,        // handle to DC
         int nWidth,     // width of bitmap, in pixels
         int nHeight     // height of bitmap, in pixels
         );

        [DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(
         IntPtr hdc,          // handle to DC
         IntPtr hgdiobj   // handle to object
         );

        [DllImport("gdi32.dll")]
        public static extern int DeleteDC(
         IntPtr hdc          // handle to DC
         );

        public static IntPtr GetTopParent(IntPtr hw)
        {
            IntPtr h = hw;
            IntPtr th = IntPtr.Zero;
            while ((th = GetParent(h)) != IntPtr.Zero)
            {
                h = th;
            }
            return h;
        }

        //该函数确定给定窗口是否是最小化（图标化）的窗口
        [DllImport("user32.dll")]
        public static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        public static extern bool ClipCursor(ref RECT lpRect);

        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(
            byte bVk,
            byte bScan,
            int dwFlags,
            int dwExtraInfo
        );

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, uint wParam, uint lParam);

    }

}
