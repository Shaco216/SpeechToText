namespace SpeechToText
{

    public static class NavigateCommand
    {
        public static Dictionary<string, (WhereNextCommandLocation,string)> NavigateCommandDict = new()
        {
            {"manual", (WhereNextCommandLocation.NextStage, "0")},
            {"system", (WhereNextCommandLocation.NextStage, "1")}
        };
    }
}
