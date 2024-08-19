using Microsoft.AspNetCore.Mvc;

namespace UI_Draft.Controllers // Tama na ang namespace name ay 'Controllers'
{
    public class HomeController : Controller // Inherit mula sa 'Controller' class
    {
        public IActionResult Index()
        {
            return View(); // I-return ang View para sa action na ito
        }
    }
}
