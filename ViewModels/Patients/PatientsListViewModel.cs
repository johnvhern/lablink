using System.ComponentModel.DataAnnotations;

namespace lablink.app.ViewModels.Patients
{
    public class PatientsListViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public bool SmsConsent { get; set; }
        public DateTime? ConsentDate { get; set; }
    }
}
