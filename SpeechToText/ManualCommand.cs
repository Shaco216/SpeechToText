namespace SpeechToText;

public static class ManualCommand
{
    public static Dictionary<string, WhereNextCommandLocation> ManualCommandDict = new Dictionary<string, WhereNextCommandLocation>()
    {
        {"x", WhereNextCommandLocation.SameStage },
        {"y", WhereNextCommandLocation.SameStage }

    };
}