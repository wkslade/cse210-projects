class Eternal : Goal
{
    public Eternal(string name, string smallDes, int pointValue, bool compleat)

       : base(name, smallDes, pointValue, compleat)
    {

    }
    public override int TallyPoints()
    {

        return _pointValue;
    }
    public override string GoalStatus()
    {
        if (_compleat == false)
        {
            return $"[ ] {_name} ({_shortDes})";
        }
        else
        {
            return $"[x] {_name} ({_shortDes})";
        }
    }
    public override int Record()
    {
        return _pointValue;
        
    }
    public override string SaveString()
    {
       return $"{_name}-{_shortDes}-{_pointValue}-{_compleat}- - ";
    }
}