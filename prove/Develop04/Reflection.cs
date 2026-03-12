class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflection(List<string> prompts, List<string> Questions, string name, string start)
    : base(name, start)
    {
        _prompts = prompts;
        _questions = Questions;

    }
    public void Prompttheuser()
    {
        GetReady();
        Random ran = new Random();
        string prompt = _prompts[ran.Next(0, _prompts.Count)];
        Console.WriteLine($"{prompt}");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_timerInt);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            string q = _questions[ran.Next(0, _questions.Count)];
            Console.WriteLine(q);
            // Random ran1 = new Random();
            // string q1 = _questions[ran.Next(0, _questions.Count)];
            // Console.WriteLine($"{prompt}");

            Console.Write(":D");
            for (int i = 4; i >= 0; i--) // this for loop runs the happy face animation
            {

                Thread.Sleep(1000);
                Console.Write("\b");
                Console.Write("|");
                Thread.Sleep(1000);
                Console.Write("\b");
                Console.Write("D");
            }
            Console.WriteLine();

        }
    }
    public void timerType()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_timerInt);
        DateTime currentTime = startTime;

        Console.WriteLine("");
        bool timeEquals = false;
        while (timeEquals != true)
        {





            Console.ReadLine();
            if (currentTime >= futureTime)
            {
                timeEquals = true;
            }
        }

    }
}
