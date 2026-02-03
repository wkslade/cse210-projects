using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Enumeration;
class Program
{
    static void Main(string[] args)
    {
        List <string> journalFileNames = ["studyJournal.txt", "Journal.txt"];
        Journal scripturStudy = new Journal();
        Journal WillJournal = new Journal();
        DateTime theCurrentTime = DateTime.Now;
        //List<string> entries = new List<string>();
        // string prompt = "You havent written anything yet";
        // string entry = "";
        WillJournal.InitializePrompts(["What is one highlight of today?", "Who is someone new or special you met today?", "what did you do today?", "how did you see the hand of the lord today?", "what is something funny that happened today?", "What is the strongest fealing you had today, where and why did you have it?"]);
        scripturStudy.InitializePrompts(["What did you study today?", "What is somthing the spirit taught you today?", "How are you going to applie what you learned this week?"]);
        Console.WriteLine($"{scripturStudy._currentPrompt}");
        Console.WriteLine("it ran");
        string i = "0";
        while (i != "6")
        {
            Console.WriteLine("1. Write in Scriptur Jurnal");
            Console.WriteLine("2. Write in Jurnal Jurnal");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Quit");
            Console.Write("Which would you like to do? ");
            i = Console.ReadLine();
            switch (i)
            {
                case "1":
                    // statement sequence
                    Console.WriteLine("Write in your scripture jurnal. ");

                    JournalEntry currentResponceScript = new JournalEntry();
                    theCurrentTime = DateTime.Now;
                    currentResponceScript._date = theCurrentTime.ToShortDateString();
                    currentResponceScript._prompt = scripturStudy.PromptTheUser();
                    currentResponceScript._entry = Console.ReadLine();
                    //scripturStudy._userEntry.Add(currentResponceScript.MakeThePrompt());
                    scripturStudy._userEntry.Add(currentResponceScript);
                    break;
                case "2":
                    Console.WriteLine("Write in your dayly jurnal. ");
                    //prompt = WillJournal.PromptTheUser();
                    //entry = Console.ReadLine();
                    JournalEntry currentResponce = new JournalEntry();
                    theCurrentTime = DateTime.Now;
                    currentResponce._date = theCurrentTime.ToShortDateString();
                    currentResponce._prompt = WillJournal.PromptTheUser();
                    currentResponce._entry = Console.ReadLine();
                    //WillJournal._userEntry.Add(currentResponce.MakeThePrompt());
                    WillJournal._userEntry.Add(currentResponce);
                    // statement sequence
                    break;
                case "3":
                    Console.WriteLine("Here is what you wrote today: ");
                    // statement sequence
                    WillJournal.Display();
                    scripturStudy.Display();
                    break;
                case "4":
                    Console.WriteLine("Which file do you want to load from?");
                    string fileName = Console.ReadLine();
                    WillJournal.LoadFile(fileName);
                    scripturStudy.LoadFile(fileName);
                    // statement sequence
                    break;
                case "5":
                    Console.WriteLine("In which file do you want to save your study entries?");
                   // Console.WriteLine($"{journalFileNames}");
                 fileName = Console.ReadLine();
                    scripturStudy.Save(fileName);
                    Console.WriteLine("In which file do you want to save your Journal entries?");
                   // Console.WriteLine($"{journalFileNames}");
                    fileName = Console.ReadLine();
                    WillJournal.Save(fileName);

                    // statement sequence
                    break;
                case "6":
                    Console.WriteLine("case 6");
                    // statement sequence
                    break;
                default:
                    // default statement sequence
                    break;
            }
        }

        Console.WriteLine("Have a nice Day :) ");

    }
}
