using Microsoft.AspNetCore.Mvc;

namespace PracticaParcial4.Web.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }
    }
}
