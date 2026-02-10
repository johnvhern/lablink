using System;
using System.Collections.Generic;
using System.Text;

namespace LabLink.Helper
{
    public interface IAsyncLoadable
    {
        Task LoadDataAsync();
    }
}
