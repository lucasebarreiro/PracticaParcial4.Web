using PracticaParcial4.Web.Enums;
using PracticaParcial4.Web.Interfaces;

namespace PracticaParcial4.Web.Helpérs;

public class TallaHelper : ITallaService
{
    public TallaBebe ObtenerTalla(int peso)
    {
        return peso switch
        {
            <= 3 => TallaBebe.RN,
            > 3 and < 5 => TallaBebe.XS,
            >= 5 and < 7 => TallaBebe.S,
            >= 7 and < 9 => TallaBebe.M,
            >= 9 and < 12 => TallaBebe.G,
            >= 12 and <= 15 => TallaBebe.XG,
            > 15 => TallaBebe.XXG,
        };
    }
}
