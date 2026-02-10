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

        private readonly INavigationService _navigationService;
        public Sidebar(INavigationService navigationService)
        {
            InitializeComponent();
            ButtonStyles.ApplyNavButtonStyle(this);
            ColorActiveButton(btnDashboard);

            _navigationService = navigationService;
        }

        private void ColorActiveButton(SfButton button)
        {
            if (activeButton != null)
            {
                activeButton.Style.BackColor = Color.White;
                activeButton.Style.ForeColor = Color.FromArgb(74, 83, 100);
                activeButton.Style.ImageForeColor = Color.FromArgb(107, 112, 129);

                activeButton.Style.HoverBackColor = Color.FromArgb(249, 250, 251);
                activeButton.Style.HoverForeColor = Color.FromArgb(74, 83, 100);
                activeButton.Style.HoverImageForeColor = Color.FromArgb(54, 63, 82);
            }

            activeButton = button;
            activeButton.Style.BackColor = Color.FromArgb(235, 242, 255);
            activeButton.Style.ForeColor = Color.FromArgb(30, 72, 207);
            activeButton.Style.ImageForeColor = Color.FromArgb(30, 72, 207);

            activeButton.Style.HoverBackColor = Color.FromArgb(235, 242, 255);
            activeButton.Style.HoverForeColor = Color.FromArgb(30, 72, 207);
            activeButton.Style.HoverImageForeColor = Color.FromArgb(30, 72, 207);
        }

        private async void btnDashboard_Click(object sender, EventArgs e)
        {
            await _navigationService.NavigateTo<Dashboard>();
            ColorActiveButton(btnDashboard);
        }

        private async void btnPendingTests_Click(object sender, EventArgs e)
        {
            await _navigationService.NavigateTo<PendingTests>();
            ColorActiveButton(btnPendingTests);
        }

        private async void btnCompletedTest_Click(object sender, EventArgs e)
        {
            await _navigationService.NavigateTo<CompletedTests>();
            ColorActiveButton(btnCompletedTest);
        }

        private async void btnSmsHistory_Click(object sender, EventArgs e)
        {

        }

        private async void btnPatients_Click(object sender, EventArgs e)
        {
            await _navigationService.NavigateTo<Patients>();
            ColorActiveButton(btnPatients);
        }

        private async void btnTestTypes_Click(object sender, EventArgs e)
        {
            await _navigationService.NavigateTo<TestTypes>();
            ColorActiveButton(btnTestTypes);
        }

        private async void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private async void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
