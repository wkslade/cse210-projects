class RLCBandRejectUP : RLCFilter
{


    

    public RLCBandRejectUP(float c, float l, float r,  string name)
   : base(c, l, r, name)
    {
        _c = c;
        _l = l;
        _r = r;
      //  _scmatic = scmatic;
        _name = name;



        _scmatic = [$"         c = {_c} f             ",
                    "Vin---.-------||------.--Vout    ",
                    "      L______mmmmm____|          ",
                    "                      |          ",
                   $"                      | L = {_l}H ",
                    "                      |          ",
                   $"                      Z R = {_r}Ω",
                    "                      Z          ",
                    "                      Z          ",
                    "                      |          ",
                    "                      V          "];
    }
    public override float GetBandwidth()
    {
        throw new NotImplementedException();


    }
    public override float GetLowCutoff()
    {
        throw new NotImplementedException();
    }
    public override float GetMiddleFrequency()
    {
        throw new NotImplementedException();
    }
    public override float GetUpperCutoff()
    {
        throw new NotImplementedException();
    }
}