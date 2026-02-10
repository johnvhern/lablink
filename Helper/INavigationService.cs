using System;
using System.Collections.Generic;
using System.Text;

namespace LabLink.Helper
{
    public interface INavigationService
    {
        Task NavigateTo<T>() where T : UserControl;
        Task NavigateTo<T>(object parameter) where T : UserControl;
    }
}
