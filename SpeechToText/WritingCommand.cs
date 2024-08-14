namespace SpeechToText
{
    public static class WritingCommand
    {
        public static Dictionary<string, WhereNextCommandLocation> WritingCommandDict = new()
        {
            {"Line", WhereNextCommandLocation.SameStage },
            {"Word", WhereNextCommandLocation.SameStage },
            {"DeleteWord", WhereNextCommandLocation.SameStage },
            {"DeleteLine", WhereNextCommandLocation.SameStage },
            {"RephraseWord", WhereNextCommandLocation.SameStage },
            {"MoveToLine", WhereNextCommandLocation.SameStage },
            {"MoveToWord", WhereNextCommandLocation.SameStage },
            {"MoveToLetter", WhereNextCommandLocation.SameStage },
            {"Exit", WhereNextCommandLocation.FinalStage }
        };
    }
}
