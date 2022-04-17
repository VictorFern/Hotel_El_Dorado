using Microsoft.AspNetCore.Mvc;

namespace Hotel_El_Dorado.Controllers
{
    public class FacilidadController : Controller
    {
        public IActionResult Index()
        {
            string[,] data = { { "Imagen 1", "Texto 1"}, { "Imagen 2", "Texto 2" } };
            ViewData["data"]  = data;
            return View();
        }
    }
}
