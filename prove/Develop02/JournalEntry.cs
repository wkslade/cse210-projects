using System;
using System.IO;



public class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _entry;

    public string makeThePrompt()
    {
        return $"{_date}|{_prompt}|{_entry}";
    }

  
    public void readThePrompt()
    {

    }
}