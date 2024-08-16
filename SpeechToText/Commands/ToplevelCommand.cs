namespace SpeechToText.Commands
{
    public static class TopLevelCommand
    {
        public static Dictionary<string, (WhereNextCommandLocation, string)> TopLevelDict = new Dictionary<string, (WhereNextCommandLocation, string)>()
        {
            {"steuern", (WhereNextCommandLocation.NextStage,"00")},
            {"schreiben", (WhereNextCommandLocation.NextStage, "01")},
            {"programmieren", (WhereNextCommandLocation.NextStage,"10")}
        };
    }
}
