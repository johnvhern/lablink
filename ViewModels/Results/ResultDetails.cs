using lablink.app.Enums;

namespace lablink.app.ViewModels.Results
{
    public class ResultDetails
    {
        public int Id { get; set; }
        public string? RefNo { get; set; }
        public string? FullName { get; set; }
        public string? TestType { get; set; }
        public string? PhoneNumber { get; set; }
        public bool SMSConsent { get; set; }
        public DateTime? ReadyDate { get; set; } 
        public DateTime? ClaimedDate { get; set; } 
        public ResultStatus resultStatus { get; set; }
    }
}
