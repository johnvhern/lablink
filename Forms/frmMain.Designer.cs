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
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            mainPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel1.BorderSides = Border3DSide.Bottom;
            gradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel1.Dock = DockStyle.Top;
            gradientPanel1.Location = new Point(255, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1095, 67);
            gradientPanel1.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.BorderStyle = BorderStyle.None;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(255, 67);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1095, 662);
            mainPanel.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderThickness = 0;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarColor = Color.FromArgb(41, 59, 80);
            CaptionForeColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1350, 729);
            Controls.Add(mainPanel);
            Controls.Add(gradientPanel1);
            Controls.Add(sidebar1);
            InnerBorderVisibility = false;
            MetroColor = Color.FromArgb(41, 59, 80);
            Name = "frmMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LabLink";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Components.Sidebar sidebar1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel mainPanel;
    }
}