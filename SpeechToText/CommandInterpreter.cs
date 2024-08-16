using SpeechToText.Commands;

namespace SpeechToText
{
    public class CommandInterpreter
    {
        List<KeyValuePair<string, (WhereNextCommandLocation, string)>>AllCommands = new List<KeyValuePair<string, (WhereNextCommandLocation,string)>>();
        bool _endOfCommand;

        public static string Trennzeichen { get { return "T"; } }
        public CommandInterpreter()
        {
            foreach (var tld in TopLevelCommand.TopLevelDict)
            {
                AllCommands.Add(tld);
            }
            foreach(var wcd in WritingCommand.WritingCommandDict)
            {
                AllCommands.Add(wcd);
            }
            foreach(var ncd in NavigateCommand.NavigateCommandDict)
            {
                AllCommands.Add(ncd);
            }
            foreach(var mcd in ManualCommand.ManualCommandDict)
            {
                AllCommands.Add(mcd);
            }
        }

        public string Interpret(string spoken)
        {
            _endOfCommand = false;
            string byteCombination = string.Empty;
            foreach (var word in spoken.Split(' '))
            {
                var foundWord =
                    AllCommands.FirstOrDefault(x => x.Key.Contains(word, StringComparison.OrdinalIgnoreCase));
                if (foundWord.Key == null || foundWord.Value.Item2 == null || foundWord.Value.Item2 == string.Empty)
                {
                    return string.Empty;
                }
                (WhereNextCommandLocation w, string binaryData) = foundWord.Value;
                byteCombination += binaryData;
                //wurde bereits addiert
                byteCombination += Trennzeichen;

            }
            _endOfCommand = true;
            return byteCombination;
        }
    }
}
