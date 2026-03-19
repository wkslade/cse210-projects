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
                            Console.Write("How many points is this goal worth when compleat:");
                            int point2 = int.Parse(Console.ReadLine());
                            Checklist Checklist = new Checklist(name2, smallDes2, point2, false);

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
                    for (int i1 = 0; i1 < goal.Count; i1++)
                    {
                        
                        Console.WriteLine(goal[i1].GetName());
                    }

                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
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
