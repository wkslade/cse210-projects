

public class Fraction
{
    private int _top;
    private int _bottom;
    public void SetFraction()
    {
        _top = 1;
        _bottom = 1;

    }
    public void SetTop(int userTop)
    {
        _top = userTop;
    }
    public void SetBottom(int bottom){
        if (bottom != 0){
        Console.WriteLine("Line 19 Cannot divide by Zero?");
        }
        else{
            bottom = _bottom;
        }
        
    }
    public void SetTopAndBottom(int userTop,int userBottom)
    {
        _top = userTop;
        _bottom = userBottom;
    }
    public void DisplayFraction(){
        Console.WriteLine($"{_top}/{_bottom}");
    }
    public int GetTop(){
        return _top;
    }
    public int GetBottom(){
        return _bottom;
    }
    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue(){
        double dec = (double)_top / _bottom;
        return dec;
    }
}
