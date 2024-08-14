namespace SpeechToText
{
    public static class WritingCommand
    {
        public static Dictionary<string, WhereNextCommandLocation> WritingCommandDict = new()
        {
            {"line", WhereNextCommandLocation.SameStage },
            {"word", WhereNextCommandLocation.SameStage },
            {"deleteword", WhereNextCommandLocation.SameStage },
            {"deleteline", WhereNextCommandLocation.SameStage },
            {"rephraseword", WhereNextCommandLocation.SameStage },
            {"movetoline", WhereNextCommandLocation.SameStage },
            {"movetoword", WhereNextCommandLocation.SameStage },
            {"movetoletter", WhereNextCommandLocation.SameStage },
            {"exit", WhereNextCommandLocation.FinalStage }
        };
    }
}
