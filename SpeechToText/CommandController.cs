namespace SpeechToText;

public class CommandController
{
    public void WriteString(string text)
    {
        foreach (char t in text)
        {
            KeyboardController.KeyDown((byte)t);
            KeyboardController.KeyUp((byte)t);
        }
    }
}