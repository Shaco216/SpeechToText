namespace SpeechToText
{

    public static class NavigateCommand
    {
        public static Dictionary<string, WhereNextCommandLocation> NavigateCommandDict = new Dictionary<string, WhereNextCommandLocation>()
        {
            {"manual", WhereNextCommandLocation.NextStage},
            {"system", WhereNextCommandLocation.NextStage}
        };
    }
}
