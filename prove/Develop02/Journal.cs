using System;
using System.IO;




public class Journal
{
    public List<string> _prompts = new List<string>();
    public string _currentPrompt;

    public List<string> _userEntry = new List<string>();

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
    public void Save(string filename)
    {


        //filename = "Journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            for (int i = 0; i < _userEntry.Count; i++)
            //foreach(JournalEntry i in _userEntry)
            {
                // You can add text to the file with the WriteLine method
                // outputFile.WriteLine("This will be the first line in the file.");
                Console.WriteLine($" {_userEntry[i]}");
               // string text = i.makeThePrompt();
                outputFile.WriteLine($" {_userEntry[i]} \n");
                
            }
            outputFile.WriteLine("test 1");
            outputFile.WriteLine("test 2");
            Console.WriteLine("itWorked");

        }
    }
    public void LoadFile(string fileName)
    {
        string filename = fileName;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            JournalEntry loadedEntry = new JournalEntry();
            loadedEntry._date = parts[0];
            loadedEntry._prompt = parts[1];
            loadedEntry._entry = parts[2];
            _userEntry.Add(loadedEntry.makeThePrompt());

        }
    }
    public void Display()
    {
        for (int i = 0; i < _userEntry.Count; i++)
        {
            Console.WriteLine($" {_userEntry[i]}");
        }

    }
}
