public abstract class Opamp
{
    protected float _r1;
    protected float _r2;
    protected string _name;
    protected List<string> _scmatic;
    protected float _Vin;
    protected float _Vout;

    public Opamp(float r1, float r2, string name, int Vin)
    {
        _r1 = r1;
        _r2 = r2;
        _name = name;
        _Vin = Vin;
    }

    public void DisplaySmatic()
    {
        for(int i = 0; i < _scmatic.Count; i++)
        {
            Console.WriteLine($"{_scmatic[i]}");
        }
    }
    public abstract float GetOutputVoltage();
    
    }