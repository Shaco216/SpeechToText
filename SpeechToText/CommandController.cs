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

    public void MouseMove(int x, int y)
    {
        MouseController.Move(x,y);
    }

    public void MouseClickLeft()
    {
        MouseController.LeftClick();
    }

    public void MouseClickRight() 
    {
        MouseController.RightClick();   
    }

}