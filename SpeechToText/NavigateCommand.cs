namespace SpeechToText
{

    public static class NavigateCommand
    {
        public static Dictionary<string, WhereNextCommandLocation> NavigateCommandDict = new Dictionary<string, WhereNextCommandLocation>()
        {
            {"Manual", WhereNextCommandLocation.NextStage},
            {"System", WhereNextCommandLocation.NextStage}
        };
    }
}
