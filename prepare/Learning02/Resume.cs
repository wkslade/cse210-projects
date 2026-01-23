namespace ResumeClass;
using jobClass;
public class Resume
{
    public string _Name;
    public List<Job> _listOfJobs = new List<Job>();
    
    
    public void DisplayResume(){
    //Console.WriteLine($" Job Title: {_jobTitle} ( {_company}) {_startYear}-{_endYear}");
    
    int jobListLength = _listOfJobs.Count;
    Console.WriteLine($"Name: {_Name}");
     for (int i = 0; i <= jobListLength; i++ ) {
    
     _listOfJobs[i].DisplayJobDetails();
     }
        
    }
}
