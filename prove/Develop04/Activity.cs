class Activity
{
    protected string _name;
    protected string _startString;

    protected double _timerInt;
    protected string _endString;

    public int TimeTravle()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_timerInt);

        Thread.Sleep(3000);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
        }
        return 1;


    }
    public void setTimer()
    {
        Console.WriteLine("How much time in seconds would you like for your session");
        double timer = Convert.ToDouble(Console.ReadLine());
        _timerInt = timer;
    }
    public void displayStart()
    {
        Console.WriteLine(_startString);
    }
    public void displayEndString()
    {
        Console.WriteLine($"You compleated another {_timerInt} of the {_name} seconds activity");
    }
    public void SetEndString()
    {
        _endString = _endString = $"congradualations you have compleated another {_timerInt} seconds of the {_name}"; ;
    }
    public Activity(string start, string name)
    {
        _startString = start;
        _name = name;


    }
    public void GetReady()
    {
        Console.Write("Get Ready (:");
        for (int i = 4; i >= 0; i--) // this for loop runs the winky face animation
        {

            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write(";");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write(":");
        }
        Console.WriteLine("");
    }

}

