namespace SpeechToText.Commands
{
    public static class WritingCommand
    {
        public static Dictionary<string, (WhereNextCommandLocation, string)> WritingCommandDict = new()
        {
            //TODO: deutsch übersetzen
            {"line", (WhereNextCommandLocation.SameStage, "0000") },
            {"word", (WhereNextCommandLocation.SameStage, "0001") },
            {"deleteword", (WhereNextCommandLocation.SameStage, "0010") },
            {"deleteline", (WhereNextCommandLocation.SameStage, "0011") },
            {"rephraseword", (WhereNextCommandLocation.SameStage, "0100") },
            {"movetoline", (WhereNextCommandLocation.SameStage, "0101") },
            {"movetoword", (WhereNextCommandLocation.SameStage, "0110") },
            {"movetoletter", (WhereNextCommandLocation.SameStage, "0111") },
            {"exit", (WhereNextCommandLocation.FinalStage, "1000") }
        };
    }
}
