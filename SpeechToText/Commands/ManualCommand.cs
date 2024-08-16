namespace SpeechToText.Commands;

public static class ManualCommand
{
    public static Dictionary<string, (WhereNextCommandLocation, string)> ManualCommandDict = new()
    {
        {"x", (WhereNextCommandLocation.SameStage, "0") },
        {"y", (WhereNextCommandLocation.SameStage, "1") }

    };
}