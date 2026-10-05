using lablink.app.Data;
using lablink.app.Helpers;
using lablink.app.Models;
using lablink.app.ViewModels.Patients;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
                (1, false) => query.OrderBy(p => p.DOB),
                (1, true) => query.OrderByDescending(p => p.DOB),
                (2, false) => query.OrderBy(p => p.PhoneNumber),
                (2, true) => query.OrderByDescending(p => p.PhoneNumber),
                (3, false) => query.OrderBy(p => p.SmsConsent),
                (3, true) => query.OrderByDescending(p => p.SmsConsent),
                (4, false) => query.OrderBy(p => p.ConsentDate),
                (4, true) => query.OrderByDescending(p => p.ConsentDate),
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
                    p.DOB,
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
                    dob = p.DOB,
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
                return PartialView("_NewPatient", model);
            }

            if (await DupPatient(null, model.FirstName, model.LastName, model.DOB))
            {
                ModelState.AddModelError(string.Empty, "Patient with this details already exists.");
                return PartialView("_NewPatient", model);
            }

            var fName = model.FirstName.Trim().Replace(" ", "").ToUpper();
            var mName = model.MiddleName?.Trim().Replace(" ", "").ToUpper();
            var lName = model.LastName.Trim().Replace(" ", "").ToUpper();

            var patient = new Patients
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                NormalizeFName = fName,
                NormalizeMName = mName,
                NormalizeLName = lName,
                FullName = model.FirstName + " " + model.MiddleName + " " + model.LastName,
                DOB = model.DOB,
                PhoneNumber = phoneNumber,
                SmsConsent = model.SmsConsent,
                ConsentDate = model.SmsConsent ? DateTime.UtcNow : null
            };

            var patientTest = new Models.Results
            {
                ReferenceNo = RefNoGenerator.ResultRefNoGen(),
                Patients = patient,
                TestType = model.TestType,
                ResultStatus = Enums.ResultStatus.Pending
            };

            _context.Patients.Add(patient);
            _context.Results.Add(patientTest);

            try
            {
                await _context.SaveChangesAsync();
            } catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 547)
            {
                ModelState.AddModelError(nameof(model.DOB), "Please check your date of birth and try again.");
                return PartialView("_NewPatient", model);
            }

            Response.Headers["HX-Trigger"] = System.Text.Json.JsonSerializer.Serialize(new
            {
                dataUpdated = new { },
                showToast = new
                {
                    message = "Patient added successfully!",
                    type = "success"
                }
            });

            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null) return NotFound();

            var patientDetails = new EditViewModel
            {
                Id = patient.Id,
                FirstName = patient.FirstName,
                MiddleName = patient.MiddleName,
                LastName = patient.LastName,
                DOB = patient.DOB,
                PhoneNumber = patient.PhoneNumber,
                SmsConsent = patient.SmsConsent
            };

            return PartialView("_EditPatient", patientDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditViewModel model)
        {
            if (id != model.Id) return NotFound();
            if (!ModelState.IsValid) return PartialView("_EditPatient", model);

            var patient = await _context.Patients.FindAsync(id);

            if (patient == null) return NotFound();

            var phoneNumber = PhoneNumberConverter.FormatNumber(model.PhoneNumber);

            if (!PhoneNumberConverter.IsValidMobileNumber(phoneNumber))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), "Invalid mobile number format. Please check and try again");
                return PartialView("_EditPatient", model);
            }

            if (await DupPatient(model.Id, model.FirstName, model.LastName, model.DOB))
            {
                ModelState.AddModelError(string.Empty, "Patient with this details already exists.");
                return PartialView("_EditPatient", model);
            }

            var fName = model.FirstName.Trim().Replace(" ", "").ToUpper();
            var mName = model.MiddleName?.Trim().Replace(" ", "").ToUpper();
            var lName = model.LastName.Trim().Replace(" ", "").ToUpper();

            patient.FirstName = model.FirstName;
            patient.MiddleName = model.MiddleName;
            patient.LastName = model.LastName;
            patient.NormalizeFName = fName;
            patient.NormalizeMName = mName;
            patient.NormalizeLName = lName;
            patient.FullName = model.FirstName + " " + model.MiddleName + " " + model.LastName;
            patient.DOB = model.DOB;
            patient.PhoneNumber = phoneNumber;
            patient.SmsConsent = model.SmsConsent;
            patient.ConsentDate = model.SmsConsent ? DateTime.UtcNow : null;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 547)
            {
                ModelState.AddModelError(nameof(model.DOB), "Please check your date of birth and try again.");
                return PartialView("_EditPatient", model);
            }

            Response.Headers["HX-Trigger"] = System.Text.Json.JsonSerializer.Serialize(new
            {
                dataUpdated = new { },
                showToast = new
                {
                    message = "Patient updated successfully!",
                    type = "success"
                }
            });

            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null) return NotFound();

            var patientDetails = new DeleteViewModel
            {
                Id = patient.Id,
                FullName = patient.FullName
            };

            return PartialView("_DeletePatient", patientDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, DeleteViewModel model)
        {
            if (id != model.Id) return NotFound();
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null) return NotFound();

            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();

            Response.Headers["HX-Trigger"] = System.Text.Json.JsonSerializer.Serialize(new
            {
                dataUpdated = new { },
                showToast = new
                {
                    message = "Patient deleted successfully!",
                    type = "success"
                }
            });

            return NoContent();
        }

        #region -- Dup Patient Checker --
        public async Task<bool> DupPatient(int? id, string fName, string lName, DateOnly dob)
        {
            string formattedFName = fName.Trim().Replace(" ", "").ToUpper();
            string formattedLName = lName.Trim().Replace(" ", "").ToUpper();

            return await _context.Patients.AnyAsync(p => p.Id != id && p.NormalizeFName == formattedFName && p.NormalizeLName == formattedLName && p.DOB == dob);
        }
        #endregion
    }
}
