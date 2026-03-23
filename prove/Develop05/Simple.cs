class Simple : Goal
{
    public Simple(string name, string smallDes, int pointValue, bool compleat)

       : base(name, smallDes, pointValue, compleat, 1)
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
        _compleat = true;
        return _pointValue;
        throw new NotImplementedException();
    }
    public override string SaveString()
    {
        return $"{_type}-{_name}-{_shortDes}-{_pointValue}-{_compleat}- - ";
    }
}