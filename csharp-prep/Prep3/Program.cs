using System;

class Program
{
    static void Main(string[] args)
    {
        string keepGoing = "yes";
        while (keepGoing == "yes"){
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        //int magicNumber;
        //Console.Write("What is the magic number?");
        //magicNumber = int.Parse(Console.ReadLine());
                int guess;
                int count = 1;
        Console.Write("What is your guess?");
        guess = int.Parse(Console.ReadLine());
        while (magicNumber != guess) {
        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        Console.Write("What is your guess?");
        guess = int.Parse(Console.ReadLine());
        count ++ ; 
        }
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"it took {count} tries :)");
        Console.Write("Would you like to play again? ");
        keepGoing = Console.ReadLine();
        count = 1;
        }
    }
}