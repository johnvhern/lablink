using System;
using System.Collections.Generic;
using System.Text;

namespace LabLink.Helper
{
    public interface INavigationService
    {
        void NavigateTo<T>() where T : UserControl;
        void NavigateTo<T>(object parameter) where T : UserControl;
    }
}
