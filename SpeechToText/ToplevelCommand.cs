namespace SpeechToText
{
    public static class TopLevelCommand
    {
        public static Dictionary<string, WhereNextCommandLocation> TopLevelDict = new Dictionary<string, WhereNextCommandLocation>()
        {
            {"Navigate", WhereNextCommandLocation.NextStage},
            {"Write", WhereNextCommandLocation.NextStage},
            {"Code", WhereNextCommandLocation.NextStage}
        };
    }
}
