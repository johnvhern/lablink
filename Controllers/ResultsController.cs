using lablink.app.Data;
using lablink.app.Enums;
using lablink.app.Helpers;
using lablink.app.Models;
using lablink.app.ViewModels.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lablink.app.Controllers
{
    public class ResultsController : Controller
    {
        private readonly AppDbContext _context;
        public ResultsController(AppDbContext context)
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
        [FromQuery] ResultStatus? status = null,
        [FromQuery] DateOnly? fromDate = null,
        [FromQuery] DateOnly? toDate = null,
        [FromQuery(Name = "order[0][column]")] int sortColumn = 1,
        [FromQuery(Name = "order[0][dir]")] string sortDirection = "asc",
        CancellationToken cancellationToken = default)
        {
            if (!ModelState.IsValid ||
                draw < 0 ||
                start < 0 ||
                length < 1 ||
                length > 100 ||
                sortColumn < 1 ||
                sortColumn > 5 ||
                (sortDirection != "asc" && sortDirection != "desc"))
            {
                return BadRequest();
            }

            search = search?.Trim();

            if (search?.Length > 150)
                return BadRequest();

            var query = _context.Results.AsNoTracking();

            // Apply any clinic/user access restrictions here,
            // before counting, searching, or returning records.
            var recordsTotal = await query.CountAsync(cancellationToken);

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(r =>
                    r.Patients.FullName.Contains(search) ||
                    r.ReferenceNo.Contains(search));
            }

            if (status.HasValue)
            {
                query = query.Where(r => r.ResultStatus == status.Value);
            }

            if (fromDate.HasValue)
            {
                var startDate = fromDate.Value.ToDateTime(TimeOnly.MinValue);
                query = query.Where(r => r.CreatedAt >= startDate);
            }

            if (fromDate.HasValue && toDate.HasValue && fromDate.Value > toDate.Value)
            {
                return BadRequest();
            }

            if (toDate == DateOnly.MaxValue)
            {
                return BadRequest();
            }

            if (toDate.HasValue)
            {
                var endDate = toDate.Value
                    .AddDays(1)
                    .ToDateTime(TimeOnly.MinValue);

                query = query.Where(r => r.CreatedAt < endDate);
            }

            var recordsFiltered = await query.CountAsync(cancellationToken);

            var descending = sortDirection == "desc";

            // Match the table indexes: column 0 is the selection checkbox.
            var ordered = (sortColumn, descending) switch
            {
                (2, false) => query.OrderBy(r => r.Patients.FullName),
                (2, true) => query.OrderByDescending(r => r.Patients.FullName),
                (3, false) => query.OrderBy(r => r.TestType),
                (3, true) => query.OrderByDescending(r => r.TestType),
                (4, false) => query.OrderBy(r => r.ResultStatus),
                (4, true) => query.OrderByDescending(r => r.ResultStatus),
                (5, false) => query.OrderBy(r => r.CreatedAt),
                (5, true) => query.OrderByDescending(r => r.CreatedAt),
                (1, true) => query.OrderByDescending(r => r.ReferenceNo),
                _ => query.OrderBy(r => r.ReferenceNo)
            };

            var results = await ordered
                .ThenBy(r => r.Id)
                .Skip(start)
                .Take(length)
                .Select(r => new
                {
                    r.Id,
                    r.ReferenceNo,
                    r.Patients.FullName,
                    r.TestType,
                    r.ResultStatus,
                    r.CreatedAt
                })
                .ToListAsync(cancellationToken);

            return Json(new
            {
                draw,
                recordsTotal,
                recordsFiltered,
                data = results.Select(r => new
                {
                    id = r.Id,
                    refNo = r.ReferenceNo,
                    name = r.FullName,
                    testType = r.TestType,
                    resultStatus = r.ResultStatus,
                    createdAt = r.CreatedAt.ToString(
                        "MMM dd, yyyy", System.Globalization.CultureInfo.InvariantCulture)
                })
            });
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> Create(int? id)
        {
            if (id == null) return NotFound();
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null) return NotFound();

            var patientDetails = new NewViewModel
            {
                PatientsId = patient.Id,
                FullName = patient.FullName,
                DOB = patient.DOB,
                PhoneNumber = patient.PhoneNumber
            };

            return PartialView("_NewResult", patientDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Create(int id, NewViewModel model)
        {
            if (id != model.PatientsId) return NotFound();
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null) return NotFound();

            var patientTest = new Models.Results
            {
                ReferenceNo = RefNoGenerator.ResultRefNoGen(),
                PatientsId = patient.Id,
                TestType = model.TestType,
                ResultStatus = Enums.ResultStatus.Pending,
                CreatedAt = DateTime.UtcNow
            };

            _context.Results.Add(patientTest);
            await _context.SaveChangesAsync();

            Response.Headers["HX-Trigger"] = System.Text.Json.JsonSerializer.Serialize(new
            {
                dataUpdated = new { },
                showToast = new
                {
                    message = "New test has been added successfully!",
                    type = "success"
                }
            });

            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> ResultDetails(int? id)
        {
            if (id == null) return NotFound();
            var result = await _context.Results.Include(r => r.Patients).FirstOrDefaultAsync(r => r.Id == id);
            if (result == null || result.Patients == null) return NotFound();

            var resultDetails = new ResultDetails
            {
                Id = result.Id,
                RefNo = result.ReferenceNo,
                FullName = result.Patients.FullName,
                TestType = result.TestType,
                PhoneNumber = result.Patients.PhoneNumber,
                SMSConsent = result.Patients.SmsConsent,
                ReadyDate = result.ReadyAt,
                ClaimedDate = result.ClaimedAt,
                resultStatus = result.ResultStatus
            };

            return PartialView("_ResultDetails", resultDetails);
        }
    }
}
