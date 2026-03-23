using System.Diagnostics.CodeAnalysis;

class Checklist : Goal
{
    protected int _frequency;
    protected int _partFrequency;
    protected int _bonus;
    public Checklist(string name, string smallDes, int pointValue, bool compleat)

        : base(name, smallDes, pointValue, compleat,3)
    {

    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    public void SetFrequency(int f)
    {
        _frequency = f;
    }
    public void SetPartFrequency(int pf)
    {
        _partFrequency = pf;
    }




    public override int TallyPoints()
    {

        return _pointValue * _frequency + _bonus;
    }
    public override string GoalStatus()
    {
        if (_compleat == false)
        {
            return $"[ ] {_name} ({_shortDes}) -- currently compleated {_partFrequency}/{_frequency}";
        }
        else
        {
            return $"[x] {_name} ({_shortDes}) -- currently compleated {_partFrequency}/{_frequency}";
        }
    }
    public override int Record()
    {
        _partFrequency ++;
        if (_partFrequency >= _frequency)
        {
            _compleat = true;
            return _pointValue + _bonus;
        }
        else
        {
             
            return _pointValue;
        }
        
    }
     public override string SaveString()
    {
       return $"{_type}-{_name}-{_shortDes}-{_pointValue}-{_compleat}-{_bonus}-{_partFrequency}-{_frequency}";
    }
}