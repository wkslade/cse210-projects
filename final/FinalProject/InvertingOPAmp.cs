using System.Security.Cryptography;

class InvertingOPAmp : Opamp
{
    public InvertingOPAmp(float r1, float r2, string name, int Vin)
    : base(r1, r2, name, Vin)
    {
        _r1 = r1;
        _r2 = r2;
        _name = name;
        _Vin = Vin;
        _Vout = -_Vin*_r2/_r1;
        _scmatic = [$"         R2 = {_r2}Ω                                  ",
                    "               .___MMMMM______________.                ",
                   $"               |             |^       |                ",
                    "               |             |  ^     |                ",
                   $"               |       ._____|+  ^    |                ",
                   $"               |       |     |    > --.---Vout {_Vout} ",
                   $" {Vin}V___MMMM_|_______)_____|-  7                     ",
                    "                       |     |  7                      ",
                   $"                       |     | 7                       ",
                   $"    R1 = {_r1}Ω        |     |7                        ",
                    "                       |      V                        ",
                    "                       V                               "];
    }
    public override float GetOutputVoltage()
    {
        return _Vout;
    }
}