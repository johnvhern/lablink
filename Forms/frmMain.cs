using LabLink.Components;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabLink.Forms
{
    public partial class frmMain : MetroForm
    {
        private DateTime currentTime;
        private bool useOnlineTime = false;
        public frmMain()
        {
            InitializeComponent();
            InitializeTimeAsync();
            this.WindowState = FormWindowState.Maximized;

            Sidebar sidebar = new Sidebar(this);
            sidebar.Dock = DockStyle.Left;
            this.Controls.Add(sidebar);
        }

        private async void InitializeTimeAsync()
        {
            if (await IsInternetAvailable())
            {
                var onlineTime = await GetOnlineTime();
                if (onlineTime.HasValue)
                {
                    currentTime = onlineTime.Value;
                    useOnlineTime = true;
                }
                else
                {
                    currentTime = DateTime.Now; // Fallback
                    useOnlineTime = false;
                }
            }
            else
            {
                currentTime = DateTime.Now; // No internet, use system time
                useOnlineTime = false;
            }

            clock.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenScreen(new UC.Dashboard());
        }

        public void OpenScreen(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
            control.Show();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            if (useOnlineTime)
            {
                currentTime = currentTime.AddSeconds(1);
            }
            else
            {
                currentTime = DateTime.Now;
            }

            lblDateTime.Text = currentTime.ToString("dddd, MMMM dd, yyyy - hh:mm:ss tt");
        }

        private async Task<bool> IsInternetAvailable()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(3);
                    var response = await client.GetAsync("https://www.google.com");
                    return response.IsSuccessStatusCode;
                }
            }
            catch
            {
                return false;
            }
        }

        private async Task<DateTime?> GetOnlineTime()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(5);
                    var response = await client.GetStringAsync("https://time.now/developer/api/ip");
                    var json = Newtonsoft.Json.Linq.JObject.Parse(response);
                    var datetime = json["datetime"].ToString();
                    return DateTime.Parse(datetime);
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
