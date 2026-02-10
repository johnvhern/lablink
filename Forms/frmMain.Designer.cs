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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            statusStripEx1 = new Syncfusion.Windows.Forms.Tools.StatusStripEx();
            statusStripLabel1 = new Syncfusion.Windows.Forms.Tools.StatusStripLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            mainPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            loadingPnl = new Panel();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            statusStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            loadingPnl.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel2.BorderSides = Border3DSide.Top;
            gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel2.Controls.Add(statusStripEx1);
            gradientPanel2.Dock = DockStyle.Bottom;
            gradientPanel2.Location = new Point(0, 702);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Padding = new Padding(10, 0, 10, 0);
            gradientPanel2.Size = new Size(1350, 27);
            gradientPanel2.TabIndex = 2;
            // 
            // statusStripEx1
            // 
            statusStripEx1.AutoSize = false;
            statusStripEx1.BackColor = Color.White;
            statusStripEx1.BeforeTouchSize = new Size(1328, 25);
            statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Fill;
            statusStripEx1.ImageScalingSize = new Size(14, 14);
            statusStripEx1.Items.AddRange(new ToolStripItem[] { statusStripLabel1, toolStripStatusLabel1 });
            statusStripEx1.Location = new Point(10, 0);
            statusStripEx1.MetroColor = Color.White;
            statusStripEx1.Name = "statusStripEx1";
            statusStripEx1.ShowSeparator = false;
            statusStripEx1.Size = new Size(1328, 25);
            statusStripEx1.SizingGrip = false;
            statusStripEx1.TabIndex = 0;
            statusStripEx1.Text = "statusStripEx1";
            statusStripEx1.ThemeName = "Metro";
            statusStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.StatusStripExStyle.Metro;
            // 
            // statusStripLabel1
            // 
            statusStripLabel1.Image = (Image)resources.GetObject("statusStripLabel1.Image");
            statusStripLabel1.Margin = new Padding(0, 3, 0, 2);
            statusStripLabel1.Name = "statusStripLabel1";
            statusStripLabel1.Size = new Size(110, 15);
            statusStripLabel1.Text = "statusStripLabel1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 15);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(249, 250, 251);
            mainPanel.BorderColor = Color.FromArgb(218, 223, 231);
            mainPanel.BorderSides = Border3DSide.Bottom;
            mainPanel.BorderStyle = BorderStyle.None;
            mainPanel.Controls.Add(loadingPnl);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1350, 702);
            mainPanel.TabIndex = 4;
            // 
            // loadingPnl
            // 
            loadingPnl.Controls.Add(progressBar1);
            loadingPnl.Controls.Add(label1);
            loadingPnl.Dock = DockStyle.Fill;
            loadingPnl.Location = new Point(0, 0);
            loadingPnl.Name = "loadingPnl";
            loadingPnl.Size = new Size(1350, 702);
            loadingPnl.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.None;
            progressBar1.Location = new Point(619, 339);
            progressBar1.MarqueeAnimationSpeed = 10;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(641, 313);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 0;
            label1.Text = "Loading...";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 729);
            Controls.Add(mainPanel);
            Controls.Add(gradientPanel2);
            Name = "frmMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LabLink";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            statusStripEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            loadingPnl.ResumeLayout(false);
            loadingPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Components.Sidebar sidebar1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.StatusStripEx statusStripEx1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel mainPanel;
        private Syncfusion.Windows.Forms.Tools.StatusStripLabel statusStripLabel1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel loadingPnl;
        private Label label1;
        private ProgressBar progressBar1;
    }
}