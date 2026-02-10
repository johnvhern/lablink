using LabLink.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabLink.Services
{
    public class NavigationService : INavigationService
    {
        private readonly Panel _mainPanel;
        private readonly Dictionary<Type, UserControl> _cache = new Dictionary<Type, UserControl>();

        public NavigationService(Panel mainPanel)
        {
            _mainPanel = mainPanel;
        }
        public void NavigateTo<T>() where T : UserControl
        {
            Type type = typeof(T);

            if (!_cache.ContainsKey(type))
            {
                _cache[type] = (T)Activator.CreateInstance(typeof(T));
            }

            UserControl control = _cache[type];

            if (!_mainPanel.Controls.Contains(control))
            {
                _mainPanel.Controls.Clear();
                control.Dock = DockStyle.Fill;
                _mainPanel.Controls.Add(control);
            }

            control.BringToFront();
        }

        public void NavigateTo<T>(object parameter) where T : UserControl
        {
            // Implementation for passing data (e.g., Patient ID) to the next screen
        }
    }
}
