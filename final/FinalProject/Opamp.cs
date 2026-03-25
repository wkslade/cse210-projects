public abstract class Opamp
{
    protected float _r1;
    protected float _r2;
    protected string _name;
    protected string _scmatic;
    protected float _Vin;

    public Opamp(float r1, float r2, string name, int Vin)
    {
        _r1 = r1;
        _r2 = r2;
        _name = name;
        _Vin = Vin;
    }
    public abstract float GetOutputVoltage();
    public abstract string GetScmatic();
}