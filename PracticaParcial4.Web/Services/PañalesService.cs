using PracticaParcial4.Web.Interfaces;
using PracticaParcial4.Web.Models;

namespace PracticaParcial4.Web.Services;

public class PañalesService : IPañalesService
{
    public static List<Bebe> bebes = [];



    public void AddBebe(Bebe bebe)
    {
        bebes.Add(bebe);
    }

    public List<Bebe> GetBebes()
    {
        return bebes;
    }




}
