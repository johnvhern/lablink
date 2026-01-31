namespace LabLink.Forms
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblDateTime = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            statusStripEx1 = new Syncfusion.Windows.Forms.Tools.StatusStripEx();
            mainPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            clock = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel1.BorderSides = Border3DSide.Bottom;
            gradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel1.Controls.Add(autoLabel1);
            gradientPanel1.Controls.Add(lblDateTime);
            gradientPanel1.Dock = DockStyle.Top;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Padding = new Padding(10, 0, 0, 0);
            gradientPanel1.Size = new Size(1350, 67);
            gradientPanel1.TabIndex = 1;
            // 
            // autoLabel1
            // 
            autoLabel1.AutoSize = false;
            autoLabel1.Dock = DockStyle.Fill;
            autoLabel1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.Location = new Point(10, 0);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Padding = new Padding(0, 5, 0, 0);
            autoLabel1.Size = new Size(1338, 33);
            autoLabel1.TabIndex = 2;
            autoLabel1.Text = "Welcome Back, John Vhern";
            autoLabel1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = false;
            lblDateTime.Dock = DockStyle.Bottom;
            lblDateTime.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.FromArgb(107, 121, 148);
            lblDateTime.Location = new Point(10, 33);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Padding = new Padding(3, 0, 0, 0);
            lblDateTime.Size = new Size(1338, 32);
            lblDateTime.TabIndex = 1;
            lblDateTime.Text = "Time";
            // 
            // statusStripEx1
            // 
            statusStripEx1.BackColor = Color.White;
            statusStripEx1.BeforeTouchSize = new Size(1350, 22);
            statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Bottom;
            statusStripEx1.Location = new Point(0, 707);
            statusStripEx1.MetroColor = Color.FromArgb(135, 206, 255);
            statusStripEx1.Name = "statusStripEx1";
            statusStripEx1.ShowSeparator = false;
            statusStripEx1.Size = new Size(1350, 22);
            statusStripEx1.SizingGrip = false;
            statusStripEx1.TabIndex = 2;
            statusStripEx1.Text = "statusStripEx1";
            statusStripEx1.ThemeName = "Metro";
            statusStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.StatusStripExStyle.Metro;
            // 
            // mainPanel
            // 
            mainPanel.BorderColor = Color.FromArgb(218, 223, 231);
            mainPanel.BorderSides = Border3DSide.Bottom;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 67);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1350, 640);
            mainPanel.TabIndex = 3;
            // 
            // clock
            // 
            clock.Interval = 1000;
            clock.Tick += clock_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarColor = Color.FromArgb(41, 59, 80);
            CaptionFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CaptionForeColor = Color.White;
            ClientSize = new Size(1350, 729);
            Controls.Add(mainPanel);
            Controls.Add(statusStripEx1);
            Controls.Add(gradientPanel1);
            InnerBorderVisibility = false;
            MetroColor = Color.FromArgb(41, 59, 80);
            Name = "frmMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LabLink";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.Sidebar sidebar1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblDateTime;
        private Syncfusion.Windows.Forms.Tools.StatusStripEx statusStripEx1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel mainPanel;
        private System.Windows.Forms.Timer clock;
    }
}