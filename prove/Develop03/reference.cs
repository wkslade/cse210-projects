class Reference
{
    private string _Book;
    private int _chapter;
    private int _verce;
    private int _verce2;
public string GetReferenceString()
    {
        if (_verce2 == 0)
        {
        return $"{_Book} {_chapter}:{_verce}";
        }
        else
        {
            return $"{_Book} {_chapter}:{_verce}-{_verce2}";
        }
    }
public int GetChapter()
    {
        return _chapter;
    }
public int GetVerce()
    {
        return _verce;
    }
public int GetVerce2()
    {
        return _verce2;
    }
public void SetVerce(int verce)
{
    _verce = verce;
}
public void SetVerce2(int verce2)
{
    _verce2 = verce2;
}
public void SetBook(string book)
    {
        _Book = book;
    }
public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
}
