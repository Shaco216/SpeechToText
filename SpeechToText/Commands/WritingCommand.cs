namespace SpeechToText.Commands
{
    public static class WritingCommand
    {
        public static Dictionary<string, (WhereNextCommandLocation, string)> WritingCommandDict = new()
        {
            //TODO: deutsch übersetzen
            {"zeile", (WhereNextCommandLocation.SameStage, "0000") },
            {"wort", (WhereNextCommandLocation.SameStage, "0001") },
            {"löschewort", (WhereNextCommandLocation.SameStage, "0010") },
            {"löschezeile", (WhereNextCommandLocation.SameStage, "0011") },
            {"umbennenenwort", (WhereNextCommandLocation.SameStage, "0100") },
            {"bewegenzuzeile", (WhereNextCommandLocation.SameStage, "0101") },
            {"bewegenzuwort", (WhereNextCommandLocation.SameStage, "0110") },
            {"bewegenzubuchstabe", (WhereNextCommandLocation.SameStage, "0111") },
            {"ende", (WhereNextCommandLocation.FinalStage, "1000") }
        };
    }
}
