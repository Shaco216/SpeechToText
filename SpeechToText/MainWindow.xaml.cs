using System.Windows;

namespace SpeechToText;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    SpeechRecognizer _speachRecognizer;
    public MainWindow()
    {
        InitializeComponent();
        _speachRecognizer = new SpeechRecognizer();
    }

    private void Start_click(object sender, RoutedEventArgs e)
    {
        _speachRecognizer.StartRecording();
        Start_Button.IsEnabled = false;
        Aufnahme_Status.Text = "Aufnahme läuft...";
    }

    private void Stop_click(object sender, RoutedEventArgs e)
    {
        _speachRecognizer.StopRecording();
        Start_Button.IsEnabled=true;
        Aufnahme_Status.Text = "Aufnahme gestoppt.";
    }

    /*
     class Program
{
static void Main()
{
    // Move the mouse by 100 pixels to the right and 100 pixels down
    MouseController.Move(100, 100);

    // Perform a left click
    MouseController.LeftClick();

    // Simulate pressing the 'A' key
    KeyboardController.KeyDown(0x41); // 0x41 is the virtual key code for 'A'
    KeyboardController.KeyUp(0x41);
}
}
     */
}