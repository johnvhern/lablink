using lablink.app.Models;
using System.ComponentModel.DataAnnotations;

namespace lablink.app.ViewModels.Results
{
    public class NewViewModel
    {
        public int PatientsId { get; set; }
        public string FullName { get; set; } = null!;
        public DateOnly DOB { get; set; }
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(120)]
        public string TestType { get; set; } = null!;
    }
}
