using System.Diagnostics.CodeAnalysis;

class Checklist : Goal
{
    protected int _Frequency;
    protected int _partFrequency;
    protected int _Bonus;
    public Checklist(string name, string smallDes, int pointValue, bool compleat)

        : base(name, smallDes, pointValue, compleat)
    {

    }
    public void SetBonus(int bonus)
    {
        _Bonus = bonus;
    }
    public void SetFrequency(int f)
    {
        _Frequency = f;
    }
    public void SetPartFrequency(int pf)
    {
        _partFrequency = pf;
    }




    public override int TallyPoints()
    {

        return _pointValue * _Frequency + _Bonus;
    }
    public override string GoalStatus()
    {
        if (_compleat == false)
        {
            return $"[ ] {_name} ({_shortDes}) -- currently compleated {_partFrequency}/{_Frequency}";
        }
        else
        {
            return $"[x] {_name} ({_shortDes}) -- currently compleated {_partFrequency}/{_Frequency}";
        }
    }
    public override int Record()
    {
        _partFrequency ++;
        if (_partFrequency >= _Frequency)
        {
            _compleat = true;
            return _pointValue + _Bonus;
        }
        else
        {
             
            return _pointValue;
        }
        
    }
     public override string SaveString()
    {
       return $"{_name}-{_shortDes}-{_pointValue}-{_compleat}-{_partFrequency}-{_Frequency}";
    }
}