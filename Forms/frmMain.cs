using LabLink.Components;
using LabLink.Data;
using Microsoft.Data.SqlClient;
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
    public partial class frmMain : Form
    {
        private readonly Services.NavigationService _navigationService;
        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Reduce Flickering
            typeof(Panel).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.SetProperty |
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.NonPublic,
            null, mainPanel, new object[] { true });

            _navigationService = new Services.NavigationService(this.mainPanel);
            Sidebar sidebar = new Sidebar(_navigationService);
            sidebar.Dock = DockStyle.Left;
            this.Controls.Add(sidebar);

            Topbar topbar = new Topbar();
            topbar.Dock = DockStyle.Top;
            this.Controls.Add(topbar);
        }

        public static bool IsConnectionSuccessful()
        {
            // Use a using statement to ensure the connection is always disposed, 
            // even if an exception occurs.
            using (var connection = DBConnection.GetConnection())
            {
                try
                {
                    // Attempt to open the connection.
                    connection.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Catch any SQL-specific exceptions.
                    Console.WriteLine($"Connection failed: {ex.Message}");
                    return false;
                }
                // The connection is automatically closed and disposed when exiting the using block.
            }
        }

        private void appVersion()
        {
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            toolStripStatusLabel1.ForeColor = Color.FromArgb(156, 161, 176);
            toolStripStatusLabel1.Text = "v1.0.0";
        }

        private void status()
        {
            bool isConnected = IsConnectionSuccessful();

            if (isConnected)
            {
                statusStripLabel1.ForeColor = Color.Green;
                statusStripLabel1.Text = "Connected";
            }
            else
            {
                statusStripLabel1.ForeColor = Color.Red;
                statusStripLabel1.Text = "Disconnected";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _navigationService.NavigateTo<UC.Dashboard>();

            appVersion();
            status();
        }
    }
}
