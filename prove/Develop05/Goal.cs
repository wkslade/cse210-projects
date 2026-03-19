public abstract class Goal
{
    protected string _name; // this is the name of the goal
    protected string _shortDes; // this is a string for a short description of a goal. 
    protected int _pointValue; // this is the amout of points a person will receave by compleating the goal.
    protected bool _compleat;
    public string GetName()
    {
        return _name;
    }
    public Goal(string name, string shortDes, int pointValue, bool compleat)
    {
        _name = name;
        _shortDes = shortDes;
        _pointValue = pointValue;
        _compleat = compleat;
        
    }

    public abstract int TallyPoints();
}