using System.Runtime;
using System.Runtime.Intrinsics.Arm;

public abstract class RLCFilter
{
    protected float _c;
    protected float _l;
    protected float _r;

    protected string _scmatic;
    protected string _name;
public RLCFilter(float c, float l, float r, string scmatic, string name)
    {
        _c = c;
        _l = l;
        _r = r;
        _scmatic = scmatic;
        _name = name;

    }


    public abstract float GetMiddleFrequency();
    public abstract float GetBandwidth();
    public abstract float GetLowCutoff();
    public abstract float GetUpperCutoff();




}