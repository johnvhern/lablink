using lablink.app.Data;
using lablink.app.Models;
using lablink.app.ViewModels.Patients;
using Microsoft.AspNetCore.Mvc;

namespace lablink.app.Controllers
{
    public class PatientsController : Controller
    {
        private readonly AppDbContext _context;
        public PatientsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return PartialView("_NewPatient");
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewViewModel model)
        {
            if (!ModelState.IsValid) return PartialView("_NewPatient", model);

            var patient = new Patients
            {
                Name = model.Name,
                PhoneNumber = model.PhoneNumber,
                SmsConsent = model.SmsConsent,
                ConsentDate = model.SmsConsent ? DateTime.UtcNow : null
            };

            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();

            return PartialView("_PatientCreated");
        }
    }
}
