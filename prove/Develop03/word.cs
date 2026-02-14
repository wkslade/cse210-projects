class Word
{
    private string _word;
    private string _blank;
    private bool _On;
public void SetBlank()
    {
    //int i = _word.Length;
    for (int i = 1; i <= _word.Length; i++)
        {
                _blank += "_";
        }
    }
public void SetWord(string word)
    {
        _word = word;
    }
public void TurnOff()
    {
        _On = false;
    }
public void TurnOn()
    {
        _On = true;
    }
public string GetDisplay()
    {
        if (_On == true)
        {
            return _word;
        }
        else
        {
            return _blank;
        }
    }
public bool GetON()
    {
        return _On;
    }
}