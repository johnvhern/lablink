namespace LabLink.Forms.TestTypes
{
    partial class frmNewTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTest));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo2 = new Syncfusion.Windows.Forms.BannerTextInfo();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            btnAddTestType = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            cbIsActive = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtTurnaroundTime = new Syncfusion.WinForms.Input.SfNumericTextBox();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            cmbCategory = new Syncfusion.WinForms.ListView.SfComboBox();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtTestTypeName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbIsActive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTestTypeName).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackColor = Color.FromArgb(249, 250, 251);
            gradientPanel1.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel1.BorderSides = Border3DSide.Top;
            gradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel1.Controls.Add(btnCancel);
            gradientPanel1.Controls.Add(btnAddTestType);
            gradientPanel1.Dock = DockStyle.Bottom;
            gradientPanel1.Location = new Point(0, 320);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(408, 58);
            gradientPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ImageSize = new Size(16, 16);
            btnCancel.Location = new Point(166, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(76, 35);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            // 
            // btnAddTestType
            // 
            btnAddTestType.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddTestType.Enabled = false;
            btnAddTestType.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTestType.ImageSize = new Size(16, 16);
            btnAddTestType.Location = new Point(248, 10);
            btnAddTestType.Name = "btnAddTestType";
            btnAddTestType.Size = new Size(135, 35);
            btnAddTestType.Style.Image = (Image)resources.GetObject("resource.Image");
            btnAddTestType.TabIndex = 3;
            btnAddTestType.Text = "Add Test Type";
            btnAddTestType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel2.BorderSides = Border3DSide.Top;
            gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel2.Controls.Add(gradientPanel3);
            gradientPanel2.Controls.Add(autoLabel7);
            gradientPanel2.Controls.Add(txtTurnaroundTime);
            gradientPanel2.Controls.Add(autoLabel5);
            gradientPanel2.Controls.Add(autoLabel6);
            gradientPanel2.Controls.Add(cmbCategory);
            gradientPanel2.Controls.Add(autoLabel4);
            gradientPanel2.Controls.Add(autoLabel3);
            gradientPanel2.Controls.Add(autoLabel2);
            gradientPanel2.Controls.Add(txtTestTypeName);
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Dock = DockStyle.Fill;
            gradientPanel2.Location = new Point(0, 0);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Padding = new Padding(20, 15, 20, 15);
            gradientPanel2.Size = new Size(408, 320);
            gradientPanel2.TabIndex = 1;
            // 
            // gradientPanel3
            // 
            gradientPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradientPanel3.BackColor = Color.FromArgb(249, 250, 251);
            gradientPanel3.BorderColor = Color.FromArgb(209, 211, 212);
            gradientPanel3.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel3.Controls.Add(autoLabel8);
            gradientPanel3.Controls.Add(cbIsActive);
            gradientPanel3.Location = new Point(23, 233);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(10);
            gradientPanel3.Size = new Size(360, 67);
            gradientPanel3.TabIndex = 11;
            // 
            // autoLabel8
            // 
            autoLabel8.ForeColor = Color.FromArgb(107, 112, 129);
            autoLabel8.Location = new Point(29, 33);
            autoLabel8.Name = "autoLabel8";
            autoLabel8.Size = new Size(223, 15);
            autoLabel8.TabIndex = 12;
            autoLabel8.Text = "Test type is available for new lab requests";
            // 
            // cbIsActive
            // 
            cbIsActive.AccessibilityEnabled = true;
            cbIsActive.Checked = true;
            cbIsActive.CheckState = CheckState.Checked;
            cbIsActive.DrawFocusRectangle = false;
            cbIsActive.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbIsActive.Location = new Point(13, 13);
            cbIsActive.MetroColor = Color.FromArgb(30, 72, 207);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(150, 21);
            cbIsActive.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            cbIsActive.TabIndex = 0;
            cbIsActive.Text = "Active";
            cbIsActive.ThemeName = "Metro";
            cbIsActive.WrapText = false;
            // 
            // autoLabel7
            // 
            autoLabel7.ForeColor = Color.FromArgb(107, 112, 129);
            autoLabel7.Location = new Point(20, 202);
            autoLabel7.Name = "autoLabel7";
            autoLabel7.Size = new Size(265, 15);
            autoLabel7.TabIndex = 10;
            autoLabel7.Text = "Expected time to complete this test (1-168 hours)";
            // 
            // txtTurnaroundTime
            // 
            txtTurnaroundTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTurnaroundTime.BorderStyle = BorderStyle.FixedSingle;
            txtTurnaroundTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTurnaroundTime.ForeColor = SystemColors.WindowText;
            txtTurnaroundTime.HideTrailingZeros = true;
            txtTurnaroundTime.Location = new Point(23, 170);
            txtTurnaroundTime.Margin = new Padding(3, 3, 3, 7);
            txtTurnaroundTime.Name = "txtTurnaroundTime";
            txtTurnaroundTime.Size = new Size(360, 25);
            txtTurnaroundTime.Style.BorderColor = Color.FromArgb(209, 211, 212);
            txtTurnaroundTime.Style.FocusBorderColor = Color.FromArgb(30, 72, 207);
            txtTurnaroundTime.Style.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtTurnaroundTime.Style.HoverBorderColor = Color.FromArgb(209, 211, 212);
            txtTurnaroundTime.TabIndex = 9;
            txtTurnaroundTime.Text = "0";
            txtTurnaroundTime.WordWrap = false;
            // 
            // autoLabel5
            // 
            autoLabel5.BackColor = Color.Transparent;
            autoLabel5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel5.ForeColor = Color.Red;
            autoLabel5.Location = new Point(177, 147);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(12, 15);
            autoLabel5.TabIndex = 8;
            autoLabel5.Text = "*";
            // 
            // autoLabel6
            // 
            autoLabel6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel6.Location = new Point(20, 145);
            autoLabel6.Margin = new Padding(3, 0, 3, 5);
            autoLabel6.Name = "autoLabel6";
            autoLabel6.Size = new Size(161, 17);
            autoLabel6.TabIndex = 7;
            autoLabel6.Text = "Turnaround Time (Hours)";
            // 
            // cmbCategory
            // 
            cmbCategory.AllowDropDownResize = false;
            cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCategory.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            cmbCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.Location = new Point(23, 105);
            cmbCategory.Margin = new Padding(3, 3, 3, 15);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(360, 25);
            cmbCategory.Style.DropDownStyle.BorderColor = Color.FromArgb(209, 211, 212);
            cmbCategory.Style.EditorStyle.BorderColor = Color.FromArgb(209, 211, 212);
            cmbCategory.Style.EditorStyle.FocusedBorderColor = Color.FromArgb(30, 72, 207);
            cmbCategory.Style.EditorStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.Style.EditorStyle.HoverBorderColor = Color.FromArgb(209, 211, 212);
            cmbCategory.Style.ReadOnlyEditorStyle.FocusedBorderColor = Color.FromArgb(30, 72, 207);
            cmbCategory.Style.ReadOnlyEditorStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            cmbCategory.Style.TokenStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.TabIndex = 6;
            cmbCategory.TabStop = false;
            // 
            // autoLabel4
            // 
            autoLabel4.BackColor = Color.Transparent;
            autoLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel4.ForeColor = Color.Red;
            autoLabel4.Location = new Point(81, 82);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(12, 15);
            autoLabel4.TabIndex = 5;
            autoLabel4.Text = "*";
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel3.Location = new Point(20, 80);
            autoLabel3.Margin = new Padding(3, 0, 3, 5);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(64, 17);
            autoLabel3.TabIndex = 3;
            autoLabel3.Text = "Category";
            // 
            // autoLabel2
            // 
            autoLabel2.BackColor = Color.Transparent;
            autoLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.Red;
            autoLabel2.Location = new Point(121, 15);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(12, 15);
            autoLabel2.TabIndex = 2;
            autoLabel2.Text = "*";
            // 
            // txtTestTypeName
            // 
            txtTestTypeName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bannerTextInfo2.Text = "e.g., Complete Blood Count (CBC)";
            bannerTextInfo2.Visible = true;
            bannerTextProvider1.SetBannerText(txtTestTypeName, bannerTextInfo2);
            txtTestTypeName.BeforeTouchSize = new Size(399, 25);
            txtTestTypeName.BorderColor = Color.FromArgb(209, 211, 212);
            txtTestTypeName.BorderStyle = BorderStyle.FixedSingle;
            txtTestTypeName.FocusBorderColor = Color.FromArgb(30, 72, 207);
            txtTestTypeName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTestTypeName.Location = new Point(23, 40);
            txtTestTypeName.Margin = new Padding(3, 3, 3, 15);
            txtTestTypeName.Name = "txtTestTypeName";
            txtTestTypeName.Size = new Size(360, 25);
            txtTestTypeName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            txtTestTypeName.TabIndex = 1;
            txtTestTypeName.ThemeName = "Metro";
            txtTestTypeName.UseBorderColorOnFocus = true;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.Location = new Point(20, 15);
            autoLabel1.Margin = new Padding(3, 0, 3, 5);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(104, 17);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Test Type Name";
            // 
            // frmNewTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarColor = Color.FromArgb(249, 250, 251);
            CaptionBarHeight = 40;
            CaptionFont = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientSize = new Size(408, 378);
            Controls.Add(gradientPanel2);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            InnerBorderVisibility = false;
            MetroColor = Color.FromArgb(30, 72, 207);
            Name = "frmNewTest";
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Test Type";
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbIsActive).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTestTypeName).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTestTypeName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.WinForms.ListView.SfComboBox cmbCategory;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtTurnaroundTime;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbIsActive;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel8;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnAddTestType;
    }
}