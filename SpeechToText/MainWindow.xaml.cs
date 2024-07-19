using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpeechToText
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SpeachRecognizer _speachRecognizer;
        public MainWindow()
        {
            InitializeComponent();
            _speachRecognizer = new SpeachRecognizer();
        }

        private void start_click(object sender, RoutedEventArgs e)
        {
            _speachRecognizer.StartRecording();
        }

        private void stop_click(object sender, RoutedEventArgs e)
        {

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
}