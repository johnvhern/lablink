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
        public Sidebar(frmMain main)
        {
            InitializeComponent();
            ButtonStyles.ApplyNavButtonStyle(this);
            ColorActiveButton(btnDashboard);
            _main = main;

            dashboard = new Dashboard();
            pendingTests = new PendingTests();
            completedTests = new CompletedTests();
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
    }
}
