using Microsoft.AspNetCore.Mvc;

namespace lablink.app.Controllers
{
    public class ResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
