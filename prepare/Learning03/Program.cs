using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction test = new Fraction();
        test.SetFraction();
        test.DisplayFraction();
        // test.SetTop(5);
        // test.DisplayFraction();
        // test.SetBottom(8);
        // test.DisplayFraction();
        // test.SetTopAndBottom(6,7);
        // test.DisplayFraction();
        // int top = test.GetTop();
        // int bottom = test.GetBottom();
        // Console.WriteLine($"the top is {top}, and the bottom is {bottom}:");
        // string fraction = test.GetFractionString();
        // Console.WriteLine(fraction);
        // double decimole = test.GetDecimalValue();
        // Console.WriteLine($"{decimole}");
        Random num = new Random();
        for (int i = 0; i <= 19; i++){
            int top = num.Next();
            test.SetTop(top);
            int bottom = num.Next();
            test.SetBottom(bottom);
            //int getTop = test.GetTop();
            //int getBottom = test.GetBottom();
            string frac = test.GetFractionString();
            double dec = test.GetDecimalValue();
            Console.WriteLine($"Fraction 1: string: {frac} Number: {dec}");
        }
    }
}