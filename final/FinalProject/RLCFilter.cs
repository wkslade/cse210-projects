using System.Runtime;
using System.Runtime.Intrinsics.Arm;

public abstract class RLCFilter
{
    protected float _c;
    protected float _l;
    protected float _r;
    protected float _w;
    protected float _bandwidth;
    protected float _upperCutOff;
    protected float _lowerCutoff;

    protected List<string> _scmatic;
    protected string _name;
public RLCFilter(float c, float l, float r, string name)
    {
        _c = c;
        _l = l;
        _r = r;
       // _scmatic = scmatic;
        _name = name;

    }
public void DisplayScmatic()
    {
        for (int i = 0; i <= _scmatic.Count; i++ )
        {
            Console.WriteLine(_scmatic[i]);
        }
    }


    public abstract float GetMiddleFrequency();
    public abstract float GetBandwidth();
    public abstract float GetLowCutoff();
    public abstract float GetUpperCutoff();




}