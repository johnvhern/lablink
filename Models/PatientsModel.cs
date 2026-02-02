using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabLink.Models
{
    public class PatientsModel
    {
        public int PatientID { get; set; }
        [Required(ErrorMessage = "Name of the patient is required.")]
        [StringLength(100, MinimumLength = 2)]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Phone number of the patient is required.")]
        [RegularExpression(@"^(\+63|0)9\d{9}$", ErrorMessage = "Invalid mobile number format (+639XXXXXXXXX)")]
        public string PhoneNumber { get; set; }
        public bool ConsentToSMS { get; set; }

    }
}
