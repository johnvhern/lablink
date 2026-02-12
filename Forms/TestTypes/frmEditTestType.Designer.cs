namespace LabLink.Forms.TestTypes
{
    partial class frmEditTestType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditTestType));
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            btnSaveChanges = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtRemarks = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel9 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtTurnaroundTime = new Syncfusion.WinForms.Input.SfNumericTextBox();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            cmbCategory = new Syncfusion.WinForms.ListView.SfComboBox();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            cbIsActive = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            txtTestTypeName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtRemarks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbIsActive).BeginInit();
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
            gradientPanel1.Controls.Add(btnSaveChanges);
            gradientPanel1.Dock = DockStyle.Bottom;
            gradientPanel1.Location = new Point(0, 423);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(408, 58);
            gradientPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ImageSize = new Size(16, 16);
            btnCancel.Location = new Point(169, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(76, 35);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveChanges.Enabled = false;
            btnSaveChanges.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.ImageSize = new Size(16, 16);
            btnSaveChanges.Location = new Point(251, 10);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(135, 35);
            btnSaveChanges.Style.Image = (Image)resources.GetObject("resource.Image");
            btnSaveChanges.TabIndex = 5;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel2.BorderSides = Border3DSide.Top;
            gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel2.Controls.Add(txtRemarks);
            gradientPanel2.Controls.Add(autoLabel9);
            gradientPanel2.Controls.Add(autoLabel10);
            gradientPanel2.Controls.Add(autoLabel7);
            gradientPanel2.Controls.Add(txtTurnaroundTime);
            gradientPanel2.Controls.Add(autoLabel5);
            gradientPanel2.Controls.Add(autoLabel6);
            gradientPanel2.Controls.Add(cmbCategory);
            gradientPanel2.Controls.Add(autoLabel4);
            gradientPanel2.Controls.Add(autoLabel3);
            gradientPanel2.Controls.Add(autoLabel2);
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Controls.Add(gradientPanel3);
            gradientPanel2.Controls.Add(txtTestTypeName);
            gradientPanel2.Dock = DockStyle.Fill;
            gradientPanel2.Location = new Point(0, 0);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Padding = new Padding(20, 15, 20, 15);
            gradientPanel2.Size = new Size(408, 423);
            gradientPanel2.TabIndex = 2;
            // 
            // txtRemarks
            // 
            txtRemarks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRemarks.BeforeTouchSize = new Size(360, 25);
            txtRemarks.BorderColor = Color.FromArgb(209, 211, 212);
            txtRemarks.BorderStyle = BorderStyle.FixedSingle;
            txtRemarks.FocusBorderColor = Color.FromArgb(30, 72, 207);
            txtRemarks.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemarks.Location = new Point(26, 257);
            txtRemarks.Margin = new Padding(3, 3, 3, 15);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(360, 61);
            txtRemarks.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            txtRemarks.TabIndex = 25;
            txtRemarks.ThemeName = "Metro";
            txtRemarks.UseBorderColorOnFocus = true;
            txtRemarks.WordWrap = false;
            // 
            // autoLabel9
            // 
            autoLabel9.BackColor = Color.Transparent;
            autoLabel9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel9.ForeColor = Color.Red;
            autoLabel9.Location = new Point(84, 232);
            autoLabel9.Name = "autoLabel9";
            autoLabel9.Size = new Size(12, 15);
            autoLabel9.TabIndex = 24;
            autoLabel9.Text = "*";
            // 
            // autoLabel10
            // 
            autoLabel10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel10.Location = new Point(23, 232);
            autoLabel10.Margin = new Padding(3, 0, 3, 5);
            autoLabel10.Name = "autoLabel10";
            autoLabel10.Size = new Size(60, 17);
            autoLabel10.TabIndex = 23;
            autoLabel10.Text = "Remarks";
            // 
            // autoLabel7
            // 
            autoLabel7.ForeColor = Color.FromArgb(107, 112, 129);
            autoLabel7.Location = new Point(23, 202);
            autoLabel7.Margin = new Padding(3, 3, 3, 15);
            autoLabel7.Name = "autoLabel7";
            autoLabel7.Size = new Size(265, 15);
            autoLabel7.TabIndex = 21;
            autoLabel7.Text = "Expected time to complete this test (1-168 hours)";
            // 
            // txtTurnaroundTime
            // 
            txtTurnaroundTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTurnaroundTime.BorderStyle = BorderStyle.FixedSingle;
            txtTurnaroundTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTurnaroundTime.ForeColor = SystemColors.WindowText;
            txtTurnaroundTime.HideTrailingZeros = true;
            txtTurnaroundTime.Location = new Point(26, 170);
            txtTurnaroundTime.Margin = new Padding(3, 3, 3, 7);
            txtTurnaroundTime.Name = "txtTurnaroundTime";
            txtTurnaroundTime.Size = new Size(360, 25);
            txtTurnaroundTime.Style.BorderColor = Color.FromArgb(209, 211, 212);
            txtTurnaroundTime.Style.FocusBorderColor = Color.FromArgb(30, 72, 207);
            txtTurnaroundTime.Style.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtTurnaroundTime.Style.HoverBorderColor = Color.FromArgb(209, 211, 212);
            txtTurnaroundTime.TabIndex = 20;
            txtTurnaroundTime.Text = "0";
            txtTurnaroundTime.WordWrap = false;
            // 
            // autoLabel5
            // 
            autoLabel5.BackColor = Color.Transparent;
            autoLabel5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel5.ForeColor = Color.Red;
            autoLabel5.Location = new Point(180, 147);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(12, 15);
            autoLabel5.TabIndex = 19;
            autoLabel5.Text = "*";
            // 
            // autoLabel6
            // 
            autoLabel6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel6.Location = new Point(23, 145);
            autoLabel6.Margin = new Padding(3, 0, 3, 5);
            autoLabel6.Name = "autoLabel6";
            autoLabel6.Size = new Size(161, 17);
            autoLabel6.TabIndex = 18;
            autoLabel6.Text = "Turnaround Time (Hours)";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCategory.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            cmbCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.Location = new Point(26, 105);
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
            cmbCategory.TabIndex = 17;
            cmbCategory.TabStop = false;
            // 
            // autoLabel4
            // 
            autoLabel4.BackColor = Color.Transparent;
            autoLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel4.ForeColor = Color.Red;
            autoLabel4.Location = new Point(84, 82);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(12, 15);
            autoLabel4.TabIndex = 16;
            autoLabel4.Text = "*";
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel3.Location = new Point(23, 80);
            autoLabel3.Margin = new Padding(3, 0, 3, 5);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(64, 17);
            autoLabel3.TabIndex = 15;
            autoLabel3.Text = "Category";
            // 
            // autoLabel2
            // 
            autoLabel2.BackColor = Color.Transparent;
            autoLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.Red;
            autoLabel2.Location = new Point(124, 15);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(12, 15);
            autoLabel2.TabIndex = 14;
            autoLabel2.Text = "*";
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.Location = new Point(23, 15);
            autoLabel1.Margin = new Padding(3, 0, 3, 5);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(104, 17);
            autoLabel1.TabIndex = 12;
            autoLabel1.Text = "Test Type Name";
            // 
            // gradientPanel3
            // 
            gradientPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradientPanel3.BackColor = Color.FromArgb(249, 250, 251);
            gradientPanel3.BorderColor = Color.FromArgb(209, 211, 212);
            gradientPanel3.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel3.Controls.Add(autoLabel8);
            gradientPanel3.Controls.Add(cbIsActive);
            gradientPanel3.Location = new Point(26, 336);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(10);
            gradientPanel3.Size = new Size(360, 67);
            gradientPanel3.TabIndex = 22;
            // 
            // autoLabel8
            // 
            autoLabel8.ForeColor = Color.FromArgb(107, 112, 129);
            autoLabel8.Location = new Point(29, 34);
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
            // txtTestTypeName
            // 
            txtTestTypeName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTestTypeName.BeforeTouchSize = new Size(360, 25);
            txtTestTypeName.BorderColor = Color.FromArgb(209, 211, 212);
            txtTestTypeName.BorderStyle = BorderStyle.FixedSingle;
            txtTestTypeName.FocusBorderColor = Color.FromArgb(30, 72, 207);
            txtTestTypeName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTestTypeName.Location = new Point(26, 40);
            txtTestTypeName.Margin = new Padding(3, 3, 3, 15);
            txtTestTypeName.Name = "txtTestTypeName";
            txtTestTypeName.Size = new Size(360, 25);
            txtTestTypeName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            txtTestTypeName.TabIndex = 13;
            txtTestTypeName.ThemeName = "Metro";
            txtTestTypeName.UseBorderColorOnFocus = true;
            txtTestTypeName.WordWrap = false;
            // 
            // frmEditTestType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarColor = Color.FromArgb(249, 250, 251);
            CaptionBarHeight = 40;
            CaptionFont = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientSize = new Size(408, 481);
            Controls.Add(gradientPanel2);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            InnerBorderVisibility = false;
            MetroColor = Color.FromArgb(30, 72, 207);
            Name = "frmEditTestType";
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Test Type";
            Load += frmEditTestType_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtRemarks).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbIsActive).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTestTypeName).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnSaveChanges;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtTurnaroundTime;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.WinForms.ListView.SfComboBox cmbCategory;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel8;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbIsActive;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTestTypeName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel9;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel10;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtRemarks;
    }
}