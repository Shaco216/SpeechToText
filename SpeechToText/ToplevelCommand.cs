namespace SpeechToText
{
    public static class TopLevelCommand
    {
        public static Dictionary<string, (WhereNextCommandLocation,)> TopLevelDict = new Dictionary<string, (WhereNextCommandLocation,int)>()
        {
            {"navigate", WhereNextCommandLocation.NextStage},
            {"write", WhereNextCommandLocation.NextStage},
            {"code", WhereNextCommandLocation.NextStage}
        };
    }
}
