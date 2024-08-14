namespace SpeechToText
{
    public class CommandInterpreter
    {
        List<KeyValuePair<string,WhereNextCommandLocation>>AllCommands = new List<KeyValuePair<string, WhereNextCommandLocation>>();
        bool endOfCommand;
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

        public void Interpret(string spoken)
        {
            endOfCommand = false;
            foreach (var word in spoken.Split(' '))
            {
                var foundWord = 
                    AllCommands.FirstOrDefault(x => x.Key.Contains(word,StringComparison.OrdinalIgnoreCase))
                if (foundWord.Key == null)
                {
                    return;
                }
                
            }
        }
    }
}
