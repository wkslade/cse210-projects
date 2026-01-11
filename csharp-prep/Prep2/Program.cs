using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter in your grade in the class");
        string userInputGrade = Console.ReadLine();
        int userGrade = int.Parse(userInputGrade);
        string letterGrade = "A"; 
        if (userGrade >= 90) {
            letterGrade = "A";
        }
        else if (userGrade >= 80 && userGrade < 90 ) {
            letterGrade = "B";
        }
        else if (userGrade < 80 && userGrade >= 70) {
            letterGrade = "C";
        }
        else if (userGrade < 70 && userGrade >= 60) {
            letterGrade = "D";
        }
        else {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter grade in the class in the class is {letterGrade}"  );
        if (userGrade >= 70){
            Console.WriteLine("Congradualations! you passed your class. Well done :)");
        }
        else {
            Console.WriteLine("Better luck next time.");
        }
    }
}