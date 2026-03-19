class Checklist : Goal
{
    protected int _Frequency;
    protected int _Bonus;
    public Checklist(string name, string smallDes, int pointValue, bool compleat)
    
        :base(name, smallDes, pointValue, compleat){
            
        }
    public void SetBonus(int bonus)
    {
        _Bonus = bonus;
    }
    




     public override int TallyPoints()
{

    return _pointValue * _Frequency + _Bonus;
}
}