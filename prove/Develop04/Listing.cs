class Listing : Activity
{

    private List<string> _questions = new List<string>();

    public Listing(List<string> questions, string name, string start)
    : base(name, start)
    {
        // _prompts = prompts;
        _questions = questions;
        _name = name;
        _startString = start;

    }




    public void ListingAct()
    {

        GetReady();
        Console.WriteLine("List as many responce as you can to the following prompt:");

        Random ran = new Random();
        string q = _questions[ran.Next(0, _questions.Count)];
        Console.WriteLine($"{q}");


        Console.Write("You may beggin in: ");
        for (int i = 5; i >= 0; i--)
        {
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write($"{i}");

        }
        Console.WriteLine("");


        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_timerInt);
        DateTime currentTime = startTime;


        bool timeEquals = false;
        while (timeEquals != true)
        {
            Console.ReadLine();
            currentTime = DateTime.Now;
            if (currentTime >= futureTime)
            {
                timeEquals = true;
            }
        }

    }


}