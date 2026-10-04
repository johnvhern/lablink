using System.ComponentModel.DataAnnotations;

namespace lablink.app.Models
{
    public class Patients
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; } = null!;

        [StringLength(50)]
        public string? MiddleName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; } = null!;

        public string NormalizeFName { get; set; } = null!;
        public string? NormalizeMName { get; set; }
        public string NormalizeLName { get; set; } = null!;

        [StringLength(150)]
        public string FullName { get; set; } = null!;

        public DateOnly DOB { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; } = null!;
        public bool SmsConsent { get; set; }
        public DateTime? ConsentDate { get; set; }
    }
}
