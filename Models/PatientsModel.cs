using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabLink.Models
{
    public class PatientsModel : INotifyPropertyChanged
    {
        public int _PatientID;
        public string _FullName;
        public string _PhoneNumber;
        public bool _ConsentToSMS;

        public int PatientID
        {
            get => _PatientID;
            set
            {
                _PatientID = value;
                OnPropertyChanged(nameof(PatientID));
            }
        }

        [Required(ErrorMessage = "Name of the patient is required.")]
        [StringLength(100, MinimumLength = 2)]
        public string FullName
        {
            get => _FullName;
            set
            {
                _FullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }

        [Required(ErrorMessage = "Phone number of the patient is required.")]
        [RegularExpression(@"^(\+63|0)9\d{9}$", ErrorMessage = "Invalid mobile number format (+639XXXXXXXXX)")]
        public string PhoneNumber
        {
            get => _PhoneNumber;
            set
            {
                _PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        public bool ConsentToSMS
        {
            get => _ConsentToSMS;
            set
            {
                _ConsentToSMS = value;
                OnPropertyChanged(nameof(ConsentToSMS));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
