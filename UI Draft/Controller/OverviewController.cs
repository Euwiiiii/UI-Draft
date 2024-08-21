using Microsoft.AspNetCore.Mvc;

namespace UI_Draft.Controllers
{
    public class OverviewController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ActivePage"] = "Overview";
            return View();
        }
    }
}
