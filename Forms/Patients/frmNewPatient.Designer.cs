namespace LabLink.Forms.Patients
{
    partial class frmNewPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewPatient));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo3 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo4 = new Syncfusion.Windows.Forms.BannerTextInfo();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            btnAddPatient = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)checkBoxAdv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBoxExt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackColor = Color.FromArgb(249, 250, 251);
            gradientPanel1.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel1.BorderSides = Border3DSide.Top;
            gradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel1.Controls.Add(btnCancel);
            gradientPanel1.Controls.Add(btnAddPatient);
            gradientPanel1.Dock = DockStyle.Bottom;
            gradientPanel1.Location = new Point(0, 276);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(447, 58);
            gradientPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ImageSize = new Size(16, 16);
            btnCancel.Location = new Point(205, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(76, 35);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            // 
            // btnAddPatient
            // 
            btnAddPatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddPatient.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPatient.ImageSize = new Size(16, 16);
            btnAddPatient.Location = new Point(287, 11);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(135, 35);
            btnAddPatient.Style.Image = (Image)resources.GetObject("resource.Image");
            btnAddPatient.TabIndex = 1;
            btnAddPatient.Text = "Add Patient";
            btnAddPatient.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel2.BorderSides = Border3DSide.Top;
            gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel2.Controls.Add(autoLabel6);
            gradientPanel2.Controls.Add(autoLabel5);
            gradientPanel2.Controls.Add(gradientPanel3);
            gradientPanel2.Controls.Add(autoLabel3);
            gradientPanel2.Controls.Add(textBoxExt2);
            gradientPanel2.Controls.Add(autoLabel2);
            gradientPanel2.Controls.Add(textBoxExt1);
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Dock = DockStyle.Fill;
            gradientPanel2.Location = new Point(0, 0);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Padding = new Padding(20, 15, 20, 15);
            gradientPanel2.Size = new Size(447, 276);
            gradientPanel2.TabIndex = 1;
            // 
            // autoLabel6
            // 
            autoLabel6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel6.ForeColor = Color.Red;
            autoLabel6.Location = new Point(119, 80);
            autoLabel6.Margin = new Padding(3, 0, 3, 5);
            autoLabel6.Name = "autoLabel6";
            autoLabel6.Size = new Size(14, 17);
            autoLabel6.TabIndex = 6;
            autoLabel6.Text = "*";
            // 
            // autoLabel5
            // 
            autoLabel5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel5.ForeColor = Color.Red;
            autoLabel5.Location = new Point(87, 15);
            autoLabel5.Margin = new Padding(3, 0, 3, 5);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(14, 17);
            autoLabel5.TabIndex = 5;
            autoLabel5.Text = "*";
            // 
            // gradientPanel3
            // 
            gradientPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradientPanel3.BackColor = Color.FromArgb(236, 255, 244);
            gradientPanel3.BorderColor = Color.FromArgb(161, 255, 210);
            gradientPanel3.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel3.Controls.Add(autoLabel4);
            gradientPanel3.Controls.Add(checkBoxAdv1);
            gradientPanel3.Location = new Point(23, 173);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(5);
            gradientPanel3.Size = new Size(399, 83);
            gradientPanel3.TabIndex = 4;
            // 
            // autoLabel4
            // 
            autoLabel4.AutoSize = false;
            autoLabel4.ForeColor = Color.FromArgb(107, 121, 148);
            autoLabel4.Location = new Point(24, 36);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(349, 40);
            autoLabel4.TabIndex = 1;
            autoLabel4.Text = "Patient agrees to receive automated SMS notifications when lab results are ready for pickup.";
            // 
            // checkBoxAdv1
            // 
            checkBoxAdv1.AccessibilityEnabled = true;
            checkBoxAdv1.BeforeTouchSize = new Size(188, 32);
            checkBoxAdv1.DrawFocusRectangle = false;
            checkBoxAdv1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxAdv1.Location = new Point(8, 8);
            checkBoxAdv1.MetroColor = Color.FromArgb(46, 204, 113);
            checkBoxAdv1.Name = "checkBoxAdv1";
            checkBoxAdv1.Size = new Size(188, 32);
            checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            checkBoxAdv1.TabIndex = 0;
            checkBoxAdv1.Text = "SMS Notification Consent";
            checkBoxAdv1.ThemeName = "Metro";
            // 
            // autoLabel3
            // 
            autoLabel3.ForeColor = Color.FromArgb(107, 121, 148);
            autoLabel3.Location = new Point(20, 137);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(156, 15);
            autoLabel3.TabIndex = 2;
            autoLabel3.Text = "Format: +63-XXX-XXX-XXXX";
            // 
            // textBoxExt2
            // 
            textBoxExt2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bannerTextInfo3.Text = "+63-XXX-XXX-XXXX";
            bannerTextInfo3.Visible = true;
            bannerTextProvider1.SetBannerText(textBoxExt2, bannerTextInfo3);
            textBoxExt2.BeforeTouchSize = new Size(399, 25);
            textBoxExt2.BorderColor = Color.FromArgb(209, 211, 212);
            textBoxExt2.BorderStyle = BorderStyle.FixedSingle;
            textBoxExt2.FocusBorderColor = Color.FromArgb(30, 72, 207);
            textBoxExt2.Font = new Font("Segoe UI", 9.75F);
            textBoxExt2.Location = new Point(23, 105);
            textBoxExt2.Margin = new Padding(3, 3, 3, 10);
            textBoxExt2.Name = "textBoxExt2";
            textBoxExt2.Size = new Size(399, 25);
            textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            textBoxExt2.TabIndex = 3;
            textBoxExt2.ThemeName = "Metro";
            textBoxExt2.UseBorderColorOnFocus = true;
            textBoxExt2.WordWrap = false;
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel2.Location = new Point(20, 80);
            autoLabel2.Margin = new Padding(3, 0, 3, 5);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(101, 17);
            autoLabel2.TabIndex = 2;
            autoLabel2.Text = "Phone Number";
            // 
            // textBoxExt1
            // 
            textBoxExt1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bannerTextInfo4.Text = "Enter patient's full name";
            bannerTextInfo4.Visible = true;
            bannerTextProvider1.SetBannerText(textBoxExt1, bannerTextInfo4);
            textBoxExt1.BeforeTouchSize = new Size(399, 25);
            textBoxExt1.BorderColor = Color.FromArgb(209, 211, 212);
            textBoxExt1.BorderStyle = BorderStyle.FixedSingle;
            textBoxExt1.FocusBorderColor = Color.FromArgb(30, 72, 207);
            textBoxExt1.Font = new Font("Segoe UI", 9.75F);
            textBoxExt1.Location = new Point(23, 40);
            textBoxExt1.Margin = new Padding(3, 3, 3, 15);
            textBoxExt1.Name = "textBoxExt1";
            textBoxExt1.Size = new Size(399, 25);
            textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            textBoxExt1.TabIndex = 1;
            textBoxExt1.ThemeName = "Metro";
            textBoxExt1.UseBorderColorOnFocus = true;
            textBoxExt1.WordWrap = false;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.Location = new Point(20, 15);
            autoLabel1.Margin = new Padding(3, 0, 3, 5);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(69, 17);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Full Name";
            // 
            // frmNewPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarColor = Color.FromArgb(249, 250, 251);
            CaptionBarHeight = 40;
            CaptionFont = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientSize = new Size(447, 334);
            Controls.Add(gradientPanel2);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            InnerBorderVisibility = false;
            MaximizeBox = false;
            MetroColor = Color.FromArgb(30, 72, 207);
            Name = "frmNewPatient";
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Patient";
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)checkBoxAdv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBoxExt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.WinForms.Controls.SfButton btnAddPatient;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
    }
}