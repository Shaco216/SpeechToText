namespace SpeechToText.Commands
{
    public static class TopLevelCommand
    {
        public static Dictionary<string, (WhereNextCommandLocation, string)> TopLevelDict = new Dictionary<string, (WhereNextCommandLocation, string)>()
        {
            {"navigate", (WhereNextCommandLocation.NextStage,"00")},
            {"write", (WhereNextCommandLocation.NextStage, "01")},
            {"code", (WhereNextCommandLocation.NextStage,"10")}
        };
    }
}
