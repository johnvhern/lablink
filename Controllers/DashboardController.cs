using Microsoft.AspNetCore.Mvc;

namespace lablink.app.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
