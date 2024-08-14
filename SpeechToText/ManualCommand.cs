namespace SpeechToText;

public static class ManualCommand
{
    public static Dictionary<string, (WhereNextCommandLocation, string)> ManualCommandDict = new()
    {
        {"x", (WhereNextCommandLocation.SameStage },
        {"y", WhereNextCommandLocation.SameStage }

    };
}