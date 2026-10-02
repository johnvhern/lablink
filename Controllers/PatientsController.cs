using Microsoft.AspNetCore.Mvc;

namespace lablink.app.Controllers
{
    public class PatientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
