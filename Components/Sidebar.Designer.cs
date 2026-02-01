namespace LabLink.Components
{
    partial class Sidebar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sidebar));
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDashboard = new Syncfusion.WinForms.Controls.SfButton();
            btnPendingTests = new Syncfusion.WinForms.Controls.SfButton();
            btnCompletedTest = new Syncfusion.WinForms.Controls.SfButton();
            btnSmsHistory = new Syncfusion.WinForms.Controls.SfButton();
            btnPatients = new Syncfusion.WinForms.Controls.SfButton();
            btnTestTypes = new Syncfusion.WinForms.Controls.SfButton();
            btnSettings = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnLogout = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackColor = SystemColors.Control;
            gradientPanel1.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel1.BorderSides = Border3DSide.Right;
            gradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel1.Controls.Add(panel1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(255, 756);
            gradientPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 59, 80);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(gradientPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 754);
            panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(btnPendingTests);
            flowLayoutPanel1.Controls.Add(btnCompletedTest);
            flowLayoutPanel1.Controls.Add(btnSmsHistory);
            flowLayoutPanel1.Controls.Add(btnPatients);
            flowLayoutPanel1.Controls.Add(btnTestTypes);
            flowLayoutPanel1.Controls.Add(btnSettings);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 10, 0, 10);
            flowLayoutPanel1.Size = new Size(253, 687);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.ImageSize = new Size(24, 24);
            btnDashboard.Location = new Point(0, 13);
            btnDashboard.Margin = new Padding(0, 3, 0, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(252, 48);
            btnDashboard.Style.Image = (Image)resources.GetObject("resource.Image");
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnPendingTests
            // 
            btnPendingTests.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnPendingTests.ImageAlign = ContentAlignment.MiddleLeft;
            btnPendingTests.ImageSize = new Size(24, 24);
            btnPendingTests.Location = new Point(0, 67);
            btnPendingTests.Margin = new Padding(0, 3, 0, 3);
            btnPendingTests.Name = "btnPendingTests";
            btnPendingTests.Padding = new Padding(10, 0, 0, 0);
            btnPendingTests.Size = new Size(252, 48);
            btnPendingTests.Style.Image = (Image)resources.GetObject("resource.Image1");
            btnPendingTests.TabIndex = 1;
            btnPendingTests.Text = "Pending Lab Tests";
            btnPendingTests.TextAlign = ContentAlignment.MiddleLeft;
            btnPendingTests.Click += btnPendingTests_Click;
            // 
            // btnCompletedTest
            // 
            btnCompletedTest.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCompletedTest.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompletedTest.ImageSize = new Size(24, 24);
            btnCompletedTest.Location = new Point(0, 121);
            btnCompletedTest.Margin = new Padding(0, 3, 0, 3);
            btnCompletedTest.Name = "btnCompletedTest";
            btnCompletedTest.Padding = new Padding(10, 0, 0, 0);
            btnCompletedTest.Size = new Size(252, 48);
            btnCompletedTest.Style.Image = (Image)resources.GetObject("resource.Image2");
            btnCompletedTest.TabIndex = 2;
            btnCompletedTest.Text = "Completed Tests";
            btnCompletedTest.TextAlign = ContentAlignment.MiddleLeft;
            btnCompletedTest.Click += btnCompletedTest_Click;
            // 
            // btnSmsHistory
            // 
            btnSmsHistory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSmsHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnSmsHistory.ImageSize = new Size(24, 24);
            btnSmsHistory.Location = new Point(0, 175);
            btnSmsHistory.Margin = new Padding(0, 3, 0, 3);
            btnSmsHistory.Name = "btnSmsHistory";
            btnSmsHistory.Padding = new Padding(10, 0, 0, 0);
            btnSmsHistory.Size = new Size(252, 48);
            btnSmsHistory.Style.Image = (Image)resources.GetObject("resource.Image3");
            btnSmsHistory.TabIndex = 3;
            btnSmsHistory.Text = "SMS History";
            btnSmsHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnSmsHistory.Click += btnSmsHistory_Click;
            // 
            // btnPatients
            // 
            btnPatients.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnPatients.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatients.ImageSize = new Size(24, 24);
            btnPatients.Location = new Point(0, 229);
            btnPatients.Margin = new Padding(0, 3, 0, 3);
            btnPatients.Name = "btnPatients";
            btnPatients.Padding = new Padding(10, 0, 0, 0);
            btnPatients.Size = new Size(252, 48);
            btnPatients.Style.Image = (Image)resources.GetObject("resource.Image4");
            btnPatients.TabIndex = 4;
            btnPatients.Text = "Patients";
            btnPatients.TextAlign = ContentAlignment.MiddleLeft;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnTestTypes
            // 
            btnTestTypes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnTestTypes.ImageAlign = ContentAlignment.MiddleLeft;
            btnTestTypes.ImageSize = new Size(24, 24);
            btnTestTypes.Location = new Point(0, 283);
            btnTestTypes.Margin = new Padding(0, 3, 0, 3);
            btnTestTypes.Name = "btnTestTypes";
            btnTestTypes.Padding = new Padding(10, 0, 0, 0);
            btnTestTypes.Size = new Size(252, 48);
            btnTestTypes.Style.Image = (Image)resources.GetObject("resource.Image5");
            btnTestTypes.TabIndex = 5;
            btnTestTypes.Text = "Test Types";
            btnTestTypes.TextAlign = ContentAlignment.MiddleLeft;
            btnTestTypes.Click += btnTestTypes_Click;
            // 
            // btnSettings
            // 
            btnSettings.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.ImageSize = new Size(24, 24);
            btnSettings.Location = new Point(0, 337);
            btnSettings.Margin = new Padding(0, 3, 0, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 0, 0);
            btnSettings.Size = new Size(254, 48);
            btnSettings.Style.Image = (Image)resources.GetObject("resource.Image6");
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.Click += btnSettings_Click;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BackColor = Color.White;
            gradientPanel3.Border3DStyle = Border3DStyle.Flat;
            gradientPanel3.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel3.BorderSides = Border3DSide.Top;
            gradientPanel3.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel3.Controls.Add(btnLogout);
            gradientPanel3.Dock = DockStyle.Bottom;
            gradientPanel3.Location = new Point(0, 687);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(253, 67);
            gradientPanel3.TabIndex = 100;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.ImageSize = new Size(24, 24);
            btnLogout.Location = new Point(-1, 9);
            btnLogout.Margin = new Padding(0, 3, 0, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10);
            btnLogout.Size = new Size(254, 48);
            btnLogout.Style.Image = (Image)resources.GetObject("resource.Image7");
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Click += btnLogout_Click;
            // 
            // Sidebar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gradientPanel1);
            Name = "Sidebar";
            Size = new Size(255, 756);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.WinForms.Controls.SfButton btnDashboard;
        private Syncfusion.WinForms.Controls.SfButton btnPendingTests;
        private Syncfusion.WinForms.Controls.SfButton btnCompletedTest;
        private Syncfusion.WinForms.Controls.SfButton btnSmsHistory;
        private Syncfusion.WinForms.Controls.SfButton btnPatients;
        private Syncfusion.WinForms.Controls.SfButton btnTestTypes;
        private Syncfusion.WinForms.Controls.SfButton btnSettings;
        private Syncfusion.WinForms.Controls.SfButton btnLogout;
    }
}
