class WritingAssignment : Assignment
{
    private string _title;
       public void SetWrite(string name, string topic, string title){
    _title = title;
    setAssignment(name, topic);
   }
   public string GetTitleName()
    {
        string name = GetName();
        return _title + " By: " + name;
    }
}