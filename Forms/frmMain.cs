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
        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            Sidebar sidebar = new Sidebar(this);
            sidebar.Dock = DockStyle.Left;
            this.Controls.Add(sidebar);
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
    }
}
