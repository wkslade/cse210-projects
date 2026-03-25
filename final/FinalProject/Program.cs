using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcom to OpAmp RCl filter Calculator");
        int i = 0;
        int j = 0;
        int i2 = 0;
        while (i != 3)
        {
            Console.WriteLine("Menu options");  // sets up a main menu for the user to pick what circut they are looking at.
            Console.WriteLine("1) Calculate an op amp circut");
            Console.WriteLine("2) Calculate a RLC Filter circut");
            Console.WriteLine("3) Quit program");
            Console.WriteLine("Pick a menu item");
            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1: // case one is to calculate an Op amp circut. chosing it will bring the user to the op amp menu
                    while (j != 3)
                    {
                        Console.WriteLine("OP amp menu");
                        Console.WriteLine("1) Inverting Op amp output calculator");
                        Console.WriteLine("2) non inverting op amp output calculator");
                        j = int.Parse(Console.ReadLine());
                        switch (j)
                        {



                            case 1:
                                Console.WriteLine("Non inverting Output calculation");
                                break;
                            case 2:
                                Console.WriteLine("invertin Output calucation");
                                break;
                            case 3:
                                Console.WriteLine("Returning to main menu");
                                break;
                            default:
                                Console.WriteLine("Im sorry the value you entered in is out of range. pleas try again.");

                                break;
                        }
                    }



                    break;
                case 2:

                    while (i2 != 3)
                    {
                        Console.WriteLine("OP amp menu");
                        Console.WriteLine("1) band Pass LC ground");
                        Console.WriteLine("2) band pass R ground");
                        Console.WriteLine("3) band rejec LC ground");
                        Console.WriteLine("4) band reject R ground");
                        i2 = int.Parse(Console.ReadLine());
                        switch (i2)
                        {
                            case 1:
                                Console.WriteLine("Non inverting Output calculation");
                                break;
                            case 2:
                                Console.WriteLine("Non invertin Output calucation");
                                break;
                            case 3:
                                Console.WriteLine("Returning to main menu");
                                break;
                            default:
                                Console.WriteLine("Im sorry the value you entered in is out of range. pleas try again.");

                                break;
                        }
                    }



                        break;
                case 3:
                            Console.WriteLine("Thank you for choosing us as you personal calculator!");



                            break;
                        default:

                            Console.WriteLine("I'm sorry the value you entered in is not an option. Pleas try again");
                            break;






                        }
                    }
                    Console.WriteLine("Have a nice day :)");
            }
        }
        
        