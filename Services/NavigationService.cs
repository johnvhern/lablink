using LabLink.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabLink.Services
{
    public class NavigationService : INavigationService
    {
        private readonly Panel _mainPanel;
        private readonly Panel _loadingPanel;
        private readonly Dictionary<Type, UserControl> _cache = new Dictionary<Type, UserControl>();

        public NavigationService(Panel mainPanel, Panel loadingPanel)
        {
            _mainPanel = mainPanel;
            _loadingPanel = loadingPanel;
        }
        public async Task NavigateTo<T>() where T : UserControl
        {
            Type type = typeof(T);

            _loadingPanel.BringToFront();
            _loadingPanel.Visible = true;
            Application.DoEvents(); // Force UI to draw the loader

            try
            {
                // 2. Get or Create Control
                if (!_cache.ContainsKey(type))
                {
                    _cache[type] = (T)Activator.CreateInstance(typeof(T));
                }

                UserControl control = _cache[type];

                // 3. Ensure it's in the panel
                if (!_mainPanel.Controls.Contains(control))
                {
                    control.Dock = DockStyle.Fill;
                    _mainPanel.Controls.Add(control);
                }

                // 4. The Key Step: Load Data while hidden
                if (control is IAsyncLoadable asyncControl)
                {
                    await asyncControl.LoadDataAsync();
                }

                // 5. Bring the populated control to front
                control.BringToFront();
            }
            finally
            {
                // 6. Hide Loader
                _loadingPanel.Visible = false;
                _loadingPanel.SendToBack();
            }
        }

        public Task NavigateTo<T>(object parameter) where T : UserControl
        {
            return Task.CompletedTask;
        }
    }
}
