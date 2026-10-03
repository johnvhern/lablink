using System.ComponentModel.DataAnnotations;

namespace lablink.app.ViewModels.Patients
{
    public class NewViewModel
    {
        [Required]
        [StringLength(150)]
        [Display(Name = "name")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(15)]
        [Display(Name = "phone number")]
        [RegularExpression(@"^(\+63|0)9\d{9}$", ErrorMessage = "Invalid Philippine mobile number format.")]
        public string PhoneNumber { get; set; } = null!;

        public bool SmsConsent { get; set; }
    }
}
