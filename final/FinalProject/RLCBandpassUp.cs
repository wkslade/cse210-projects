class RLCBandpassUp : RLCFilter
{









    public RLCBandpassUp(float c, float l, float r, string name)
    : base(c, l, r, name)
    {
        _c = c;
        _l = l;
        _r = r;
        //_scmatic = scmatic;
        _name = name;
        _bandwidth = _r/_l;
        _w = 1/(_l*_c);
        _scmatic = [$"      L = {_l}H  c = {_c} f     ",
                    "Vin-------mmmm----||--.--Vout    ",
                    "                      |          ",
                    "                      |          ",
                   $"                      |          ",
                    "                      |          ",
                   $"                      Z  R = {_r}Ω",
                    "                      Z           ",
                    "                      Z           ",
                    "                      |          ",
                    "                      V          "];
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