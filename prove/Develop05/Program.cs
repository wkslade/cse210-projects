using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Develop05 World!");
        int i = 0;
        int points = 0;
        List<Goal> goal = new List<Goal>();















        while (i != 6)
        {
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    int j;
                    Console.WriteLine("The types of Goals are: ");
                    Console.WriteLine("1) Simple Goal");
                    Console.WriteLine("2) Eternal Goal");
                    Console.WriteLine("3) Checklist Goal");
                    j = int.Parse(Console.ReadLine());
                    switch (j)
                    {
                        case 1:
                            Console.Write("Simple Goal!");
                            Console.Write("What would you like to call your goal: ");
                            string name = Console.ReadLine();
                            Console.Write("Write a small description of your goal: ");
                            string smallDes = Console.ReadLine();
                            Console.Write("How many points is this goal worth when compleat:");
                            int point = int.Parse(Console.ReadLine());
                            Simple simp = new Simple(name, smallDes, point, false);
                            goal.Add(simp);
                            break;
                        case 2:
                            Console.Write("Eternal Goal!");
                            Console.Write("What would you like to call your goal: ");
                            string name1 = Console.ReadLine();
                            Console.Write("Write a small description of your goal: ");
                            string smallDes1 = Console.ReadLine();
                            Console.Write("How many points is this goal worth when compleat:");
                            int point1 = int.Parse(Console.ReadLine());
                            Eternal Eternal = new Eternal(name1, smallDes1, point1, false);
                            goal.Add(Eternal);
                            break;
                        case 3:
                            Console.Write("Cheacklist Goal!");
                            Console.Write("What would you like to call your goal: ");
                            string name2 = Console.ReadLine();
                            Console.Write("Write a small description of your goal: ");
                            string smallDes2 = Console.ReadLine();
                            Console.Write("How many points is assosiated with this goal:");
                            int point2 = int.Parse(Console.ReadLine());
                            Checklist Checklist = new Checklist(name2, smallDes2, point2, false);

                            Console.Write("How many times does it take to recive a bonus?");
                            int frequency = int.Parse(Console.ReadLine());
                            Checklist.SetFrequency(frequency);

                            Console.Write("How many bonus points will this be worth when you compleat all the checklist.");
                            int bonus = int.Parse(Console.ReadLine());
                            Checklist.SetBonus(bonus);

                            goal.Add(Checklist);



                            break;
                        default:

                            break;

                    }


                    break;
                case 2:
                    Console.WriteLine("List Goals");
                    Console.WriteLine("The Goals are: ");
                    for (int i1 = 0; i1 < goal.Count; i1++)
                    {
                        string GS = goal[i1].GoalStatus();
                        Console.WriteLine($"{i1}. {GS}");

                    }

                    break;
                case 3:
                    Console.WriteLine("Save Goals!");
                    Console.Write("Which file would you like to save to: ");
                    string filename = Console.ReadLine();
                    Console.WriteLine("");



                    using (StreamWriter outputFile = new StreamWriter(filename, false))
                    {
                        outputFile.WriteLine($"{points}");
                        for (int i1 = 0; i1 < goal.Count; i1++)
                        //foreach(JournalEntry i in _userEntry)
                        {
                            // You can add text to the file with the WriteLine method
                            // outputFile.WriteLine("This will be the first line in the file.");
                            Console.WriteLine($"{goal[i1].SaveString()}");
                            // string text = i.makeThePrompt();
                            //outputFile.WriteLine($" {_userEntry[i]} \n");
                            outputFile.WriteLine($"{goal[i1].SaveString()}");
                        }
                        //outputFile.WriteLine("test 1");
                        //outputFile.WriteLine("test 2");
                        Console.WriteLine("Save succesful");

                    }



                    break;
                case 4:
                    Console.Write("From what file you you like to load from: ");
                    filename = Console.ReadLine();

                    string[] lines = System.IO.File.ReadAllLines(filename);

                    foreach (string line in lines)
                    //for (int l = 1; l < lines.Count(); l++)
                    {
                        string[] parts = line.Split('-');
                        if (parts[0] == "1")
                        {
                             string name = parts[1];
                            string smallDes = parts[2];
                            int Pointval = int.Parse(parts[3]);
                            bool com = bool.Parse(parts[4]);
                            Simple loadedGoal = new Simple(name, smallDes, Pointval,com );
                          
                            //_userEntry.Add(loadedEntry.MakeThePrompt());
                            goal.Add(loadedGoal);
                        }
                        else if (parts[0] == "2")
                        {
                            
                             string name = parts[1];
                            string smallDes = parts[2];
                            int Pointval = int.Parse(parts[3]);
                            bool com = bool.Parse(parts[4]);
                            Eternal loadedGoal = new Eternal(name, smallDes, Pointval,com );
                          
                            //_userEntry.Add(loadedEntry.MakeThePrompt());
                            goal.Add(loadedGoal);
                        }
                        else if (parts[0] == "3")
                        {
                            
                             string name = parts[1];
                            string smallDes = parts[2];
                            int Pointval = int.Parse(parts[3]);
                            bool com = bool.Parse(parts[4]);
                            int bon = int.Parse(parts[5]);
                            int pf = int.Parse(parts[6]);
                            int f = int.Parse(parts[7]);
                            Checklist loadedGoal = new Checklist(name, smallDes, Pointval,com );
                            loadedGoal.SetBonus(bon);
                            loadedGoal.SetPartFrequency(pf);
                            loadedGoal.SetFrequency(f);
                            //_userEntry.Add(loadedEntry.MakeThePrompt());
                            goal.Add(loadedGoal);
                        }
                        else
                        {
                            points = int.Parse(parts[0]);
                        }

                    }
                    break;
                case 5:
                    Console.WriteLine("Record Event");
                    for (int i1 = 0; i1 < goal.Count; i1++)
                    {
                        string itemname = goal[i1].GetName();
                        Console.WriteLine($"{i1}. {itemname}");


                    }
                    int r = int.Parse(Console.ReadLine());
                    int p = goal[r].Record();
                    points += p;
                    Console.WriteLine("Pick a goal to record: ");
                    break;
                case 6:
                    Console.WriteLine("Thank you for setting goals with us!");
                    break;
                default:
                    Console.WriteLine("I'm sorry the number you entered in is not an option plese try again.");
                    break;





            }






        }
        Console.WriteLine("Have a nice day :)");







    }
}
