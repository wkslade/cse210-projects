class Eternal : Goal
{
     public Eternal(string name, string smallDes, int pointValue, bool compleat)
    
        :base(name, smallDes, pointValue, compleat){
            
        }
         public override int TallyPoints()
{

    return _pointValue;
}
}