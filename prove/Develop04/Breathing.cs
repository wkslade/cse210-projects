class Breathing : Activity
{
    private int _inTime;
    private int _outTime;
    public Breathing(int inTime, int outTime, string name, string start)
    :base(name,start)
    {

        _inTime = inTime;
        _outTime = outTime;
    }

    public void BreathingAct()
    {

        // Console.Write("Get Ready (:");
        // for (int i = _inTime; i >= 0; i--) // this for loop runs the winky face animation
        // {

        //     Thread.Sleep(1000);
        //     Console.Write("\b");
        //     Console.Write(";");
        //     Thread.Sleep(1000);
        //     Console.Write("\b");
        //     Console.Write(":");
        // }
        GetReady();
        Console.WriteLine("");
    //    Console.WriteLine($"TimerInt = {_timerInt}");
        DateTime startTime = DateTime.Now; // this sets our timer 
        DateTime futureTime = startTime.AddSeconds(_timerInt);
        DateTime currentTime = startTime;

    //    Console.WriteLine($" current {currentTime}, Future {futureTime}");


        bool timeEquals = false;
        while (timeEquals != true)
        {


            Console.WriteLine("");
            Console.Write($"breath in....");
            for (int i = _inTime; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Console.Write("\b");
                Console.Write($"{i}");

            }
            Console.WriteLine("");
            Console.Write($"Now breath out....");
            for (int i = _outTime; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Console.Write("\b");
                Console.Write($"{i}");

            }
            currentTime = DateTime.Now;
            if (currentTime >= futureTime)
            {
                timeEquals = true;
            }
        }

    }
}