using Microsoft.AspNetCore.Mvc;

namespace TechnoSewa.Controllers
{
    public class Technician_Homepage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
