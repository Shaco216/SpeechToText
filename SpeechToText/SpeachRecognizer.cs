using System.Speech.Recognition;
using System.Windows;

namespace SpeechToText;

public class SpeachRecognizer
{
    private readonly SpeechRecognitionEngine _recognizer;
    public SpeachRecognizer()
    {
        // Create a new SpeechRecognitionEngine instance
        _recognizer = new SpeechRecognitionEngine();
        // Configure the input to the default audio device
        _recognizer.SetInputToDefaultAudioDevice();
        // Load a dictation grammar
        _recognizer.LoadGrammar(new DictationGrammar());
        // Attach event handlers
        _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Recognizer_SpeechRecognized);
    }

    public void StartRecording()
    {
        // Start asynchronous recognition
        _recognizer.RecognizeAsync(RecognizeMode.Multiple);


        // Keep the console window open
        //Console.WriteLine("Speak into your microphone.");
        //Console.ReadLine();

    }

    static void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
    {
        // Output the recognized text
        MessageBox.Show("Recognized text: " + e.Result.Text);
        //Console.WriteLine("Recognized text: " + e.Result.Text);
        
    }

    public void StopRecording()
    {
        _recognizer.RecognizeAsyncStop();
    }
}

