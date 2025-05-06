using Microsoft.AspNetCore.Mvc;
using PracticaParcial4.Web.Models;

namespace PracticaParcial4.Web.Controllers
{
    public class PañalesController : Controller
    {
        public IActionResult Agregar()
        {
            return View();
        }

        public IActionResult Listar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Bebe bebe)
        {
            return View();
        }
    }
}
