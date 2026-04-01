class RLCBandpassDown : RLCFilter
{




    public RLCBandpassDown(float c, float l, float r, string name)
    : base(c, l, r, name)
    {
        _c = c;
        _l = l;
        _r = r;
        // _scmatic = scmatic;
        _name = name;
        _bandwidth = 1/(_r*_c);
        _w = MathF.Sqrt(1/(_l*_c));
        _lowerCutoff = MathF.Sqrt(MathF.Pow(_bandwidth, 2)/2+MathF.Pow(_w,2))-_bandwidth/2;
        _upperCutOff = MathF.Sqrt(MathF.Pow(_bandwidth, 2)/2+MathF.Pow(_w,2))+_bandwidth/2;


        _scmatic = [$"      r = {_r}Ω                  ",
                    "Vin____MMMM___.____.______Vout",
                    "              |    |          ",
                    "              |    |          ",
                   $"              3    |  L ={l}H ",
                    "              3   _|_         ",
                   $"              3   _._ C = {c}f",
                    "              |    |          ",
                    "              L____|          ",
                    "                 |            ",
                    "                 V            "];
    }


    public override float GetBandwidth()
    {
        return _bandwidth;


    }
    public override float GetLowCutoff()
    {
        
        return _lowerCutoff;
    }
    public override float GetMiddleFrequency()
    {
        return _w;
    }
    public override float GetUpperCutoff()
    {
        return _upperCutOff;
    }
}