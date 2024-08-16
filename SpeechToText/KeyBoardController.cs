using System.Runtime.InteropServices;

namespace SpeechToText;
public static class KeyboardController
{
    [DllImport("user32.dll")]
    private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

    private const int KEYEVENTF_KEYDOWN = 0x0000;
    private const int KEYEVENTF_KEYUP = 0x0002;

    public static void KeyDown(byte key)
    {
        keybd_event(key, 0, KEYEVENTF_KEYDOWN, 0);
    }

    public static void KeyUp(byte key)
    {
        keybd_event(key, 0, KEYEVENTF_KEYUP, 0);
    }
}
