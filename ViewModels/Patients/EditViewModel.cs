using System.ComponentModel.DataAnnotations;

namespace lablink.app.ViewModels.Patients
{
    public class EditViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "first name")]
        public string FirstName { get; set; } = null!;

        [StringLength(50)]
        [Display(Name = "middle name")]
        public string? MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "last name")]
        public string LastName { get; set; } = null!;

        [Required]
        [Display(Name = "date of birth")]
        public DateOnly DOB { get; set; }

        [Required]
        [MaxLength(15)]
        [Display(Name = "phone number")]
        [RegularExpression(@"^(\+63|0)9\d{9}$", ErrorMessage = "Invalid Philippine mobile number format.")]
        public string PhoneNumber { get; set; } = null!;

        public bool SmsConsent { get; set; }
    }
}
