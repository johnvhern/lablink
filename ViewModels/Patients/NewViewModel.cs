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
        [StringLength(15)]
        [Display(Name = "phone number")]
        public string PhoneNumber { get; set; } = null!;

        public bool SmsConsent { get; set; }
    }
}
