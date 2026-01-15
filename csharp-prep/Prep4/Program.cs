using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>(); // sets up an empty list
        Console.Write("Give me a number for the list: "); // ask the user for a number
        int number = int.Parse(Console.ReadLine()); // saves that number in a variable
        while (number != 0) // sets up a loop to keep asking for numbers until they put in 0
        {
            numbers.Add(number); // adds the last number the user inputer on the end of the list
            Console.Write("Give me an aditional number for the list: "); // asks again for a number
            number = int.Parse(Console.ReadLine());// saves the using to the variable number
        }
        numbers.Add(number);// adds the last number the user inputed
        int total = 0; // sets up a variable total
        foreach (int numberes in numbers) // a for loop that cycles through the list numbers and adds them all together to get a total
        {
            //total += numbers[numberes];
            Console.WriteLine(numberes);
            total += numberes;// adds the number in the list to the total
        }
        int biggestNumber = 0; // sets up a variable for the biggest number
        foreach (int numberes in numbers)// sets up a for loop that will check to see if a number in the list is bigger than the biggest number see so far starting at zero. in the end the larges number will be strored in the variable
        {
           if (numberes > biggestNumber) // checks to see if the current number is bigger than the bigges
            {
                biggestNumber = numberes;// If yes, it will replace the biggest number. 
            }
        }
        // the next few lines will display the results. 
        Console.WriteLine($"The sum is: {total}");
        float average = total/numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The biggest number is: {biggestNumber}");

    }
}