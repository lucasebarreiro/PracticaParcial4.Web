using PracticaParcial4.Web.Models;

namespace PracticaParcial4.Web.Interfaces;

public interface IPañalesService
{
    void AddBebe(Bebe bebe);
    List<Bebe> GetBebes();
}
