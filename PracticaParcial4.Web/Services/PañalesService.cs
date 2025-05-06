using PracticaParcial4.Web.Interfaces;
using PracticaParcial4.Web.Models;

namespace PracticaParcial4.Web.Services
{
    public class PañalesService : IPañalesService
    {
        public static List<Bebe> bebes = [];

        public PañalesService()
        {
            if (bebes.Count == 0)
            {
                bebes.Add(new Bebe());
            }
        }
    }
}
