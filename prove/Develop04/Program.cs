using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        string startB = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string nameB = "Breathing";
        string startR = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string nameR = "Reflection";
        List<string> prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        List<string> questionsR = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
        List<string> questionL = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
        string startL = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        string nameL = "Listing";


        //breath.activity(start, name);
        //Listing list = new Listing();




        int i = 0;
        while (i != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity ");
            Console.WriteLine("2. Start relflecting activity ");
            Console.WriteLine("3. Start listing activity ");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu ");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    startB = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    nameB = "Breathing";
                    //breath.Activity(start, name);
                    Breathing breath = new Breathing(4, 6, startB, nameB);
                    breath.displayStart();
                    breath.setTimer();
                    //breath.breathing(4, 6);
                    breath.BreathingAct();
                    breath.SetEndString();
                    breath.displayEndString();

                    break;
                case 2:

                    Listing Listing = new Listing( questionL, nameL, startL);
                    Listing.displayStart();
                    Listing.setTimer();
                    Listing.ListingAct();
                    Listing.SetEndString();
                    Listing.displayEndString();




                    break;
                case 3:
                    Reflection reflect = new Reflection(prompts, questionsR, startR, nameR);
                    reflect.displayStart();
                    reflect.setTimer();
                    reflect.Prompttheuser();
                    reflect.SetEndString();
                    reflect.displayEndString();


                    break;

                case 4:
                    Console.WriteLine("Thank you for your time!");
                    break;
                default:
                    Console.WriteLine("I'm sorry the number you entered is not correct pleas try again.");
                    break;






            }
        }
        Console.WriteLine("Have a nice day :) ");

    }
}