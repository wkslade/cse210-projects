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
                        Console.Write("what is the value of R1: ");
                        float r1 = float.Parse(Console.ReadLine());
                        Console.Write("what is the value of R2: ");
                        float r2 = float.Parse(Console.ReadLine());
                        Console.Write("what is the value of the input voltage: ");
                        int Vin = int.Parse(Console.ReadLine());
                        Console.Write("what is the circuts name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("OP amp menu");
                        Console.WriteLine("1) Non Inverting Op amp output calculator");
                        Console.WriteLine("2) inverting op amp output calculator");
                        Console.WriteLine("5) Exit to main menu");
                        j = int.Parse(Console.ReadLine());
                        switch (j)
                        {



                            case 1:
                                Console.WriteLine("Non inverting Output calculation");
                                NonInvertingOpAmp NIOP = new NonInvertingOpAmp(r1, r2, name, Vin);
                                NIOP.DisplaySmatic();
                                break;
                            case 2:
                                Console.WriteLine("invertin Output calucation");
                                InvertingOPAmp Iop = new InvertingOPAmp(r1,r2,name,Vin);
                                Iop.DisplaySmatic();
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

                    while (i2 != 5)
                    {
                        Console.Write("what is the Resistor value in Ω:");
                        float r = float.Parse(Console.ReadLine());
                        Console.Write("what is the Resistor value in f:");
                        float c = float.Parse(Console.ReadLine());
                        Console.Write("what is the Resistor value in H:");
                        float l = float.Parse(Console.ReadLine());
                        Console.Write("what would you like to name you circut:");
                        string name = Console.ReadLine();

                        Console.WriteLine("RLC Filter menu");
                        Console.WriteLine("1) band Pass LC ground");
                        Console.WriteLine("2) band pass R ground");
                        Console.WriteLine("3) band rejec LC ground");
                        Console.WriteLine("4) band reject R ground");
                        Console.WriteLine("5) Exit to main menu");
                        i2 = int.Parse(Console.ReadLine());
                        switch (i2)
                        {
                            case 1:
                                Console.WriteLine("Band Pass LC Ground");
                                RLCBandpassDown BPD = new RLCBandpassDown(c, l, r, name);
                                Console.WriteLine($"The bandwidth of the filter is: {BPD.GetBandwidth()}");
                                Console.WriteLine($"The middle frequency is: {BPD.GetMiddleFrequency()}");
                                BPD.DisplayScmatic();
                                break;
                            case 2:
                                Console.WriteLine("band pass R ground");
                                RLCBandpassUp BPU = new RLCBandpassUp(c, l, r, name);
                                Console.WriteLine($"The bandwidth of the filter is: {BPU.GetBandwidth()}");
                                Console.WriteLine($"The middle frequency is: {BPU.GetMiddleFrequency()}");
                                BPU.DisplayScmatic();
                                break;
                            case 3:
                                Console.WriteLine(" band rejec LC ground");
                                RLCBandRejectDown BRD = new RLCBandRejectDown(c, l, r, name);
                                Console.WriteLine($"The bandwidth of the filter is: {BRD.GetBandwidth()}");
                                Console.WriteLine($"The middle frequency is: {BRD.GetMiddleFrequency()}");
                                BRD.DisplayScmatic();
                                break;
                            case 4:
                                Console.WriteLine(" band rejec R ground");
                                RLCBandRejectUP BRU = new RLCBandRejectUP(c, l, r, name);
                                Console.WriteLine($"The bandwidth of the filter is: {BRU.GetBandwidth()}");
                                Console.WriteLine($"The middle frequency is: {BRU.GetMiddleFrequency()}");
                                BRU.DisplayScmatic();
                                break;
                            case 5:
                                Console.WriteLine("Return to main menu.");
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

