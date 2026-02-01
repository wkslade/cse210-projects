using System;
using System.IO;



public class Save
{
    public string _date;
    public string _prompt;
    public string _entry;



    public void saveThePrompt() // note I bet I can make it so I can choose which file to save to
    {
        string filename = "Journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
           // outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine
            outputFile.WriteLine($"{_date}, {_prompt}, {_entry}\n");
        }
    }
    public void readThePrompt()
    {
        
    }
}