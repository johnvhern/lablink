using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LabLink.Models
{
    public class TestTypeCategoryModel : INotifyPropertyChanged
    {
        public int _CategoryID;
        public string _CategoryName;

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

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
