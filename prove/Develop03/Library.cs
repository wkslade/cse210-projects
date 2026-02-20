class Library
{
    private List<Scripture> _ScripturList = new List<Scripture>();
    //private List<Reference> _RefList = new List<Reference>();
    public Scripture GetScripture()
    {
        Random  num = new Random();
        int ran = num.Next(0, _ScripturList.Count);
        return _ScripturList[ran];
    }
    //     public Reference GetRef()
    // {
    //     Random  num = new Random();
    //     int ran = num.Next(0, _RefList.Count);
    //     return _RefList[ran];
    // }
    public void SetScripture(Scripture script)
    {
        _ScripturList.Add(script);
    }
    // public void SetRef(Reference TheRef)
    // {
    //     _RefList.Add(TheRef);
    // }
}
