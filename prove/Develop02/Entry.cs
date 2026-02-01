using System;
using System.IO; 




public class Entry
{
    public List<string> _prompts = new List<string>();
    public string _currentPrompt;
    public string _userEntry;

    public void InitializePrompts(List<string> listOfPrompts)
    {
        _prompts = listOfPrompts;
        
    }
    public string PromptTheUser()
    {

        Random random = new Random();
        _currentPrompt = _prompts[random.Next(0, _prompts.Count)];
        Console.Write(_currentPrompt);
        return _currentPrompt;
    }
    // public void saveThePrompt()
    // {
    //     Save currentPrompt = new Save();
    //     DateTime theCurrentTime = DateTime.Now;
    //     currentPrompt._date = theCurrentTime.ToShortDateString();
    //     currentPrompt._prompt = _currentPrompt;
    //     currentPrompt._entry = _userEntry;
    //     currentPrompt.saveThePrompt();
        
    // }
}
