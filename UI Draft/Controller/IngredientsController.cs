using Microsoft.AspNetCore.Mvc;

namespace UI_Draft.Controllers
{
    public class IngredientsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ActivePage"] = "Ingredients";
            return View();
        }
    }
}
