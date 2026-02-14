using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Scripture favorite = new Scripture();
        favorite.SetFullString("Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.");
        favorite.SetWords();
        favorite.SetReference(31, 20, "2 Nephi");
        favorite.GetDisplay();
        int wordCount = favorite.GetWordCount();

        wordCount = favorite.GetWordCount();
        Console.WriteLine($"{wordCount}");
        while (wordCount > 0)
        {
        Console.WriteLine($"{wordCount}");
        favorite.GetDisplay();   
        favorite.Blanker();
        Console.ReadLine();
        Console.Clear();
        wordCount = favorite.GetWordCount();
        Console.WriteLine($"{wordCount}");
        }
    }
}