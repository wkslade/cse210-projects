class NonInvertingOpAmp : Opamp
{
    public NonInvertingOpAmp(float r1, float r2, string name, int Vin)
      : base(r1, r2, name, Vin)
    {
        _r1 = r1;
        _r2 = r2;
        _name = name;
        _Vin = Vin;
        _Vout = _Vin * (1 + _r2 / _r1);
        _scmatic = [$"         R2 = {_r2}Ω                                 ",
                    "               .___MMMMM_________________.               ",
                   $"               |             |^          |              ",
                    "               |             |   ^       |              ",
                   $"               |       ._____|+    ^     |              ",
                   $"               |       |     |       > --.---Vout {_Vout}",
                   $" <|_______MMMM_|_______)_____|-     v                    ",
                    "                       |     |     v                    ",
                   $"                       |     |    v                     ",
                   $"    R1 = {_r1}Ω        |     |  v                     ",
                    "                       |      V                       ",
                $"                     {Vin}V                              "];
    }
    public override float GetOutputVoltage()
    {
        return _Vout;
    }
}