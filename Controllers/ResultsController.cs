using lablink.app.Data;
using lablink.app.Enums;
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
                query = query.Where(r => r.ClaimedAt >= startDate);
            }

            if (toDate.HasValue)
            {
                var endDate = toDate.Value
                    .AddDays(1)
                    .ToDateTime(TimeOnly.MinValue);

                query = query.Where(r => r.ClaimedAt < endDate);
            }

            var recordsFiltered = await query.CountAsync(cancellationToken);

            var descending = sortDirection == "desc";

            // Only these explicitly allowed columns can be sorted.
            var ordered = (sortColumn, descending) switch
            {
                (1, false) => query.OrderBy(r => r.Patients.FullName),
                (1, true) => query.OrderByDescending(r => r.Patients.FullName),
                (2, false) => query.OrderBy(r => r.TestType),
                (2, true) => query.OrderByDescending(r => r.TestType),
                (3, false) => query.OrderBy(r => r.ResultStatus),
                (3, true) => query.OrderByDescending(r => r.ResultStatus),
                (4, false) => query.OrderBy(r => r.ReadyAt),
                (4, true) => query.OrderByDescending(r => r.ReadyAt),
                (5, false) => query.OrderBy(r => r.ClaimedAt),
                (5, true) => query.OrderByDescending(r => r.ClaimedAt),
                (0, true) => query.OrderByDescending(p => p.ReferenceNo),
                _ => query.OrderBy(p => p.ReferenceNo)
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
                    r.ReadyAt,
                    r.ClaimedAt
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
                    readyAt = r.ReadyAt?.ToString(
                        "MMM dd, yyyy", System.Globalization.CultureInfo.InvariantCulture),
                    claimedAt = r.ClaimedAt?.ToString(
                        "MMM dd, yyyy", System.Globalization.CultureInfo.InvariantCulture),
                })
            });
        }
        #endregion
    }
}
