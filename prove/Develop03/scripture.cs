class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _Words = new List<Word>();
    private string _fullString;
    private int _wordCount;
    //private string _blankString;
    
    public void SetWords()
    {
    string[] words = _fullString.Split(" ");
    foreach (string word in words)
        {
            Word wordle = new Word();
            wordle.SetWord(word);
            wordle.SetBlank();
            wordle.TurnOn();
            _Words.Add(wordle);
        }
        _wordCount = _Words.Count;
    }
    public void Blanker()
    {
        Random num = new Random();
        for (int i = 1; i <= 5; i++)
        {
        int ran = num.Next(0, _Words.Count); 
        bool ifTrue = _Words[ran].GetON();
        if (ifTrue == true)
            {
                _wordCount-= 1;
                _Words[ran].TurnOff();
            }
       
        }

        

    }
    public void SetFullString(string full)
    {
        _fullString = full;
    }
    public void SetReference(int chapter, int verce, string book, int verce2 = 0)
    {
        _reference.SetBook(book);
        _reference.SetChapter(chapter);
        _reference.SetVerce(verce);
        _reference.SetVerce2(verce2);
    }
    public void GetDisplay()
    {
        string reference = _reference.GetReferenceString();
        Console.Write($"{reference} ");
        foreach (Word word in _Words)
        {
           string printWord = word.GetDisplay();
           Console.Write($"{printWord} ");
        }
        Console.WriteLine("");
    }
    public int GetWordCount()
    {
        return _wordCount;
    }
        
    
}