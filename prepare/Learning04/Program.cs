using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment Will = new Assignment();
        Will.setAssignment("Will", "math");
        string A = Will.GetSummary();
        Console.WriteLine($"{A}");
        MathAssignment WillMath = new MathAssignment();
        WillMath.SetMath("William", "Math 215", "Newton", "1,2,3");
        string m = WillMath.GetSummary();
        Console.WriteLine($"{m}");
        string math = WillMath.GetHomeworkList();
        Console.WriteLine($"{math}");
        WritingAssignment WillPain = new WritingAssignment();
        WillPain.SetWrite("Will", "englis", "a tale of awsome Will");
        string NT = WillPain.GetTitleName();

        String nw = WillPain.GetSummary();
        Console.WriteLine($"{NT}");
        Console.WriteLine($"{nw}");

    }
}