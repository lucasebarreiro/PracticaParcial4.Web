using Microsoft.AspNetCore.Mvc;
using PracticaParcial4.Web.Interfaces;
using PracticaParcial4.Web.Models;

namespace PracticaParcial4.Web.Controllers
{
    public class PañalesController(IPañalesService pañalesService, ITallaService tallaService) : Controller
    {
        public IActionResult Agregar()
        {
            return View();
        }

        public IActionResult Listar()
        {
            return View(pañalesService.GetBebes());
        }

        [HttpPost]
        public IActionResult Agregar(Bebe bebe)
        {
            if (ModelState.IsValid)
            {
                bebe.TallaPañal = tallaService.ObtenerTalla(bebe.Peso).ToString();
                pañalesService.AddBebe(bebe);
                return RedirectToAction("Listar");
            }
            return View(bebe);
        }
    }
}
