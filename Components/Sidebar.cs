using LabLink.Forms;
using LabLink.Helper;
using LabLink.UC;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabLink.Components
{
    public partial class Sidebar : UserControl
    {
        private frmMain _main;
        private SfButton activeButton;

        private Dashboard dashboard;
        public Sidebar(frmMain main)
        {
            InitializeComponent();

            _main = main;
            ColorActiveButton(btnDashboard);

            ButtonStyles.Default(btnDashboard);
            ButtonStyles.Default(btnPendingTests);
            ButtonStyles.Default(btnCompletedTest);
            ButtonStyles.Default(btnSmsHistory);
            ButtonStyles.Default(btnPatients);
            ButtonStyles.Default(btnTestTypes);
            ButtonStyles.Default(btnSettings);
            ButtonStyles.Default(btnLogout);

            dashboard = new Dashboard();
        }

        private void ColorActiveButton(SfButton button)
        {
            if (activeButton != null)
            {
                activeButton.Style.BackColor = Color.FromArgb(41, 59, 80);
                activeButton.Style.ForeColor = Color.FromArgb(199, 206, 212);
                activeButton.Style.ImageForeColor = Color.FromArgb(199, 206, 212);
            }

            activeButton = button;
            activeButton.Style.BackColor = Color.FromArgb(5, 142, 223);
            activeButton.Style.ForeColor = Color.FromArgb(239, 242, 245);
            activeButton.Style.ImageForeColor = Color.FromArgb(239, 242, 245);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _main.OpenScreen(dashboard);
            ColorActiveButton(btnDashboard);
        }
    }
}
