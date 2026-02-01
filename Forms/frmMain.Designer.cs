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
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            statusStripEx1 = new Syncfusion.Windows.Forms.Tools.StatusStripEx();
            statusStripLabel1 = new Syncfusion.Windows.Forms.Tools.StatusStripLabel();
            mainPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            statusStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
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
            gradientPanel2.Padding = new Padding(10, 0, 0, 0);
            gradientPanel2.Size = new Size(1350, 27);
            gradientPanel2.TabIndex = 2;
            // 
            // statusStripEx1
            // 
            statusStripEx1.BackColor = Color.Transparent;
            statusStripEx1.BeforeTouchSize = new Size(1338, 25);
            statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Fill;
            statusStripEx1.Items.AddRange(new ToolStripItem[] { statusStripLabel1 });
            statusStripEx1.Location = new Point(10, 0);
            statusStripEx1.MetroColor = Color.FromArgb(135, 206, 255);
            statusStripEx1.Name = "statusStripEx1";
            statusStripEx1.ShowSeparator = false;
            statusStripEx1.Size = new Size(1338, 25);
            statusStripEx1.SizingGrip = false;
            statusStripEx1.TabIndex = 0;
            statusStripEx1.Text = "statusStripEx1";
            statusStripEx1.ThemeName = "Metro";
            statusStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.StatusStripExStyle.Metro;
            // 
            // statusStripLabel1
            // 
            statusStripLabel1.Margin = new Padding(0, 3, 0, 2);
            statusStripLabel1.Name = "statusStripLabel1";
            statusStripLabel1.Size = new Size(96, 15);
            statusStripLabel1.Text = "statusStripLabel1";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(249, 250, 251);
            mainPanel.BorderColor = Color.FromArgb(218, 223, 231);
            mainPanel.BorderSides = Border3DSide.Bottom;
            mainPanel.BorderStyle = BorderStyle.None;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1350, 702);
            mainPanel.TabIndex = 4;
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
            gradientPanel2.PerformLayout();
            statusStripEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Components.Sidebar sidebar1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.StatusStripEx statusStripEx1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel mainPanel;
        private Syncfusion.Windows.Forms.Tools.StatusStripLabel statusStripLabel1;
    }
}