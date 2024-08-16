namespace SpeechToText.Commands
{

    public static class NavigateCommand
    {
        public static Dictionary<string, (WhereNextCommandLocation, string)> NavigateCommandDict = new()
        {
            {"manuell", (WhereNextCommandLocation.NextStage, "0")},
            {"system", (WhereNextCommandLocation.NextStage, "1")}
        };
    }
}
