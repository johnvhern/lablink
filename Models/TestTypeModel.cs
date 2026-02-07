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
        public int _TurnAroundTime;
        public bool _isActive;

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

        public bool isActive
        {
            get => _isActive;
            set
            {
                _isActive = value;
                OnPropertyChanged(nameof(isActive));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
