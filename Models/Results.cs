using lablink.app.Enums;

namespace lablink.app.Models
{
    public class Results
    {
        public int Id { get; set; }
        public string ReferenceNo { get; set; } = null!;

        public int PatientId { get; set; }
        public Patients Patients { get; set; } = null!;

        public string TestType { get; set; } = null!;
        public ResultStatus ResultStatus { get; set; }
        public DateTime? ReadyAt { get; set; }
        public DateTime? ClaimedAt { get; set; }

    }
}
