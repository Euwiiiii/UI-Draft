using Microsoft.AspNetCore.Mvc;

namespace UI_Draft.Controllers
{
    public class ProductionController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ActivePage"] = "Production";
            return View();
        }
    }
}
