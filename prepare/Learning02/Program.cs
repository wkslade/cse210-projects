using System;
using jobClass;
using ResumeClass;
class Program
{
    static void Main(string[] args)
    {
        Resume Will = new Resume();
        Will._Name = "William Slade";
        //Will._listOfJobs[0]._jobTitle = 
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2029;
        job1._endYear = 2035;
        //johnsonHome._blinds.Add(kitchen);
        Will._listOfJobs.Add(job1);
        Job job2 = new Job();
        job2._jobTitle = "Pizza Delivery Boy";
        job2._company = "Pizza Hut";
        job2._startYear = 2000;
        job2._endYear = 2026;
        Will._listOfJobs.Add(job2);
        //Console.WriteLine(Will._listOfJobs[0]._jobTitle);
        Will.DisplayResume();
        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

    }
}