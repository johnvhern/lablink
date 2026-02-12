using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabLink.Models
{
    public class TestTypeModel : INotifyPropertyChanged
    {
        public int _TestTypeID;
        public string _TestTypeName;
        public int _CategoryID;
        public string _CategoryName;
        public int _TurnAroundTime;
        public string _Remarks;
        public bool _IsActive;

        public int TestTypeID
        {
            get => _TestTypeID;
            set
            {
                _TestTypeID = value;
                OnPropertyChanged(nameof(TestTypeID));
            }
        }

        [Required(ErrorMessage = "Test type name field is required.")]
        [StringLength(100, MinimumLength = 2)]
        public string TestTypeName
        {
            get => _TestTypeName;
            set
            {
                _TestTypeName = value;
                OnPropertyChanged(nameof(TestTypeName));
            }
        }

        [Required(ErrorMessage = "Category field is required.")]
        public int CategoryID
        {
            get => _CategoryID;
            set
            {
                _CategoryID = value;
                OnPropertyChanged(nameof(CategoryID));
            }
        }

        public string CategoryName
        {
            get => _CategoryName;
            set
            {
                _CategoryName = value;
                OnPropertyChanged(nameof(CategoryName));
            }
        }

        [Required(ErrorMessage = "Turnaround time cannot be 0.")]
        public int TurnAroundTime
        {
            get => _TurnAroundTime;
            set
            {
                _TurnAroundTime = value;
                OnPropertyChanged(nameof(_TurnAroundTime));
            }
        }

        [Required(ErrorMessage = "Remarks field is required.")]
        public string Remarks
        {
            get => _Remarks;
            set
            {
                _Remarks = value;
                OnPropertyChanged(nameof(Remarks));
            }
        }

        public bool IsActive
        {
            get => _IsActive;
            set
            {
                _IsActive = value;
                OnPropertyChanged(nameof(IsActive));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
