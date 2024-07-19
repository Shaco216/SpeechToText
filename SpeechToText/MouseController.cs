using System;
using System.Runtime.InteropServices;

namespace SpeechToText;
public static class MouseController
{
    [DllImport("user32.dll")]
    private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

    private const int MOUSEEVENTF_MOVE = 0x0001;
    private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
    private const int MOUSEEVENTF_LEFTUP = 0x0004;

    public static void Move(int xDelta, int yDelta)
    {
        mouse_event(MOUSEEVENTF_MOVE, xDelta, yDelta, 0, 0);
    }

    public static void LeftClick()
    {
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
    }
}
