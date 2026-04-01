class RLCBandRejectDown : RLCFilter
{

    public RLCBandRejectDown(float c, float l, float r, string name)
       : base(c, l, r, name)
    {
        _c = c;
        _l = l;
        _r = r;
        // _scmatic = scmatic;
        _name = name;
        _bandwidth = _r/_l;
        _w = MathF.Sqrt(1/_l*_c);



        _scmatic = [$"      L = {_r}Ω                ",
                    "Vin_____MMMMM______._____Vout   ",
                    "                   |            ",
                    "                   3  L = {_l} H",
                   $"                   3            ",
                    "                   3            ",
                   $"                  _|_  C = {_c}f",
                    "                   T            ",
                    "                   |            ",
                    "                   |            ",
                    "                   V            "];
    
    }
    public override float GetBandwidth()
    {
        return _bandwidth;


    }
    public override float GetLowCutoff()
    {
        throw new NotImplementedException();
    }
    public override float GetMiddleFrequency()
    {
        return _w;
    }
    public override float GetUpperCutoff()
    {
        throw new NotImplementedException();
    }

}