using lablink.app.Enums;
using System.ComponentModel.DataAnnotations;

namespace lablink.app.Models
{
    public class Results
    {
        public int Id { get; set; }
        public string ReferenceNo { get; set; } = null!;

        public int? PatientsId { get; set; }
        public Patients Patients { get; set; } = null!;

        [StringLength(120)]
        public string TestType { get; set; } = null!;

        public ResultStatus ResultStatus { get; set; }
        public DateTime? ReadyAt { get; set; }
        public DateTime? ClaimedAt { get; set; }
        public DateTime CreatedAt { get; set; }


    }
}
