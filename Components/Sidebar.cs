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
        private PendingTests pendingTests;
        private CompletedTests completedTests;
        private Patients patients;
        private TestTypes testTypes;
        public Sidebar(frmMain main)
        {
            InitializeComponent();
            ButtonStyles.ApplyNavButtonStyle(this);
            ColorActiveButton(btnDashboard);
            _main = main;

            dashboard = new Dashboard();
            pendingTests = new PendingTests();
            completedTests = new CompletedTests();
            patients = new Patients();
            testTypes = new TestTypes();
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _main.OpenScreen(dashboard);
            ColorActiveButton(btnDashboard);
        }

        private void btnPendingTests_Click(object sender, EventArgs e)
        {
            _main.OpenScreen(pendingTests);
            ColorActiveButton(btnPendingTests);
        }

        private void btnCompletedTest_Click(object sender, EventArgs e)
        {
            _main.OpenScreen(completedTests);
            ColorActiveButton(btnCompletedTest);
        }

        private void btnSmsHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            _main.OpenScreen(patients);
            ColorActiveButton(btnPatients);
        }

        private void btnTestTypes_Click(object sender, EventArgs e)
        {
            _main.OpenScreen(testTypes);
            ColorActiveButton(btnTestTypes);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
