class MathAssignment : Assignment
{
   private string _textbookSection;
   private string _problems;

   public void SetMath(string name, string topic, string textbook, string problems){
    _textbookSection = textbook;
    _problems = problems;
    setAssignment(name, topic);
   }

public string GetHomeworkList()
    {
        string sum = GetSummary();
       return sum + " " + _textbookSection +" "+ _problems;
    }

}