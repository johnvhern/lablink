using lablink.app.Data;
using lablink.app.Helpers;
using lablink.app.Models;
using lablink.app.ViewModels.Patients;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lablink.app.Controllers
{
    public class PatientsController : Controller
    {
        private readonly AppDbContext _context;
        public PatientsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        #region -- DataTable --
        [HttpGet]
        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
        public async Task<IActionResult> Data(
        [FromQuery] int draw,
        [FromQuery] int start = 0,
        [FromQuery] int length = 15,
        [FromQuery(Name = "search[value]")] string? search = null,
        [FromQuery(Name = "order[0][column]")] int sortColumn = 0,
        [FromQuery(Name = "order[0][dir]")] string sortDirection = "asc",
        CancellationToken cancellationToken = default)
        {
            if (!ModelState.IsValid ||
                draw < 0 ||
                start < 0 ||
                length < 1 ||
                length > 100 ||
                sortColumn < 0 ||
                sortColumn > 3 ||
                (sortDirection != "asc" && sortDirection != "desc"))
            {
                return BadRequest();
            }

            search = search?.Trim();

            if (search?.Length > 150)
                return BadRequest();

            var query = _context.Patients.AsNoTracking();

            // Apply any clinic/user access restrictions here,
            // before counting, searching, or returning records.
            var recordsTotal = await query.CountAsync(cancellationToken);

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(p =>
                    p.FullName.Contains(search) ||
                    p.PhoneNumber.Contains(search));
            }

            var recordsFiltered = string.IsNullOrEmpty(search)
                ? recordsTotal
                : await query.CountAsync(cancellationToken);

            var descending = sortDirection == "desc";

            // Only these explicitly allowed columns can be sorted.
            var ordered = (sortColumn, descending) switch
            {
                (1, false) => query.OrderBy(p => p.PhoneNumber),
                (1, true) => query.OrderByDescending(p => p.PhoneNumber),
                (2, false) => query.OrderBy(p => p.SmsConsent),
                (2, true) => query.OrderByDescending(p => p.SmsConsent),
                (3, false) => query.OrderBy(p => p.ConsentDate),
                (3, true) => query.OrderByDescending(p => p.ConsentDate),
                (0, true) => query.OrderByDescending(p => p.FullName),
                _ => query.OrderBy(p => p.FullName)
            };

            var patients = await ordered
                .ThenBy(p => p.Id)
                .Skip(start)
                .Take(length)
                .Select(p => new
                {
                    p.Id,
                    p.FullName,
                    p.PhoneNumber,
                    p.SmsConsent,
                    p.ConsentDate
                })
                .ToListAsync(cancellationToken);

            return Json(new
            {
                draw,
                recordsTotal,
                recordsFiltered,
                data = patients.Select(p => new
                {
                    id = p.Id,
                    name = p.FullName,
                    phoneNumber = p.PhoneNumber,
                    smsConsent = p.SmsConsent,
                    consentDate = p.ConsentDate?.ToString(
                        "MMM dd, yyyy",
                        System.Globalization.CultureInfo.InvariantCulture)
                })
            });
        }
        #endregion

        public IActionResult Create()
        {
            return PartialView("_NewPatient");
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewViewModel model)
        {
            if (!ModelState.IsValid) return PartialView("_NewPatient", model);

            var phoneNumber = PhoneNumberConverter.FormatNumber(model.PhoneNumber);

            if (!PhoneNumberConverter.IsValidMobileNumber(phoneNumber))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), "Invalid mobile number format. Please check and try again");
            }

            var patient = new Patients
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                NormalizeFName = model.FirstName.Trim().ToUpper(),
                NormalizeMName = model.MiddleName?.Trim().ToUpper(),
                NormalizeLName = model.LastName.Trim().ToUpper(),
                FullName = model.FirstName + " " + model.MiddleName + " " + model.LastName,
                PhoneNumber = phoneNumber,
                SmsConsent = model.SmsConsent,
                ConsentDate = model.SmsConsent ? DateTime.UtcNow : null
            };

            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();

            Response.Headers["HX-Trigger"] = System.Text.Json.JsonSerializer.Serialize(new
            {
                dataCreated = new { },
                showToast = new
                {
                    message = "Patient added successfully!",
                    type = "success"
                }
            });

            return NoContent();
        }
    }
}
