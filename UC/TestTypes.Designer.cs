namespace LabLink.UC
{
    partial class TestTypes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestTypes));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo gridBordersInfo1 = new Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo();
            Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo gridBordersInfo2 = new Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnRefresh = new Syncfusion.WinForms.Controls.SfButton();
            btnAddTestType = new Syncfusion.WinForms.Controls.SfButton();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            dgvTestTypes = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkBoxAdv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(btnRefresh);
            gradientPanel1.Controls.Add(btnAddTestType);
            gradientPanel1.Controls.Add(autoLabel2);
            gradientPanel1.Controls.Add(autoLabel1);
            gradientPanel1.Dock = DockStyle.Top;
            gradientPanel1.Location = new Point(15, 15);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1222, 69);
            gradientPanel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ImageSize = new Size(16, 16);
            btnRefresh.Location = new Point(1105, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(117, 40);
            btnRefresh.Style.Image = (Image)resources.GetObject("resource.Image");
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddTestType
            // 
            btnAddTestType.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddTestType.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTestType.ImageSize = new Size(16, 16);
            btnAddTestType.Location = new Point(925, 5);
            btnAddTestType.Name = "btnAddTestType";
            btnAddTestType.Size = new Size(174, 40);
            btnAddTestType.Style.Image = (Image)resources.GetObject("resource.Image1");
            btnAddTestType.TabIndex = 4;
            btnAddTestType.Text = "Add New Test Type";
            btnAddTestType.TextAlign = ContentAlignment.MiddleRight;
            btnAddTestType.Click += btnAddTestType_Click;
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(107, 121, 148);
            autoLabel2.Location = new Point(6, 29);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(303, 17);
            autoLabel2.TabIndex = 3;
            autoLabel2.Text = "Configure available lab tests and turnaround times";
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.Location = new Point(3, 0);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(239, 30);
            autoLabel1.TabIndex = 2;
            autoLabel1.Text = "Test Type Management";
            // 
            // gradientPanel2
            // 
            gradientPanel2.BackColor = Color.FromArgb(249, 250, 251);
            gradientPanel2.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel2.Controls.Add(textBoxExt1);
            gradientPanel2.Controls.Add(checkBoxAdv1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(15, 84);
            gradientPanel2.Margin = new Padding(3, 3, 3, 15);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Padding = new Padding(10);
            gradientPanel2.Size = new Size(1222, 53);
            gradientPanel2.TabIndex = 1;
            // 
            // textBoxExt1
            // 
            textBoxExt1.BackColor = Color.FromArgb(249, 250, 251);
            bannerTextInfo1.Text = "Search test types...";
            bannerTextInfo1.Visible = true;
            bannerTextProvider1.SetBannerText(textBoxExt1, bannerTextInfo1);
            textBoxExt1.BeforeTouchSize = new Size(295, 25);
            textBoxExt1.BorderColor = Color.FromArgb(209, 211, 212);
            textBoxExt1.BorderStyle = BorderStyle.FixedSingle;
            textBoxExt1.FocusBorderColor = Color.FromArgb(65, 0, 218);
            textBoxExt1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxExt1.Location = new Point(13, 13);
            textBoxExt1.Name = "textBoxExt1";
            textBoxExt1.Size = new Size(295, 25);
            textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            textBoxExt1.TabIndex = 1;
            textBoxExt1.ThemeName = "Metro";
            textBoxExt1.UseBorderColorOnFocus = true;
            textBoxExt1.WordWrap = false;
            // 
            // checkBoxAdv1
            // 
            checkBoxAdv1.AccessibilityEnabled = true;
            checkBoxAdv1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxAdv1.AutoSize = true;
            checkBoxAdv1.BeforeTouchSize = new Size(133, 21);
            checkBoxAdv1.DrawFocusRectangle = false;
            checkBoxAdv1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxAdv1.ForeColor = SystemColors.ControlText;
            checkBoxAdv1.ImageCheckBoxSize = new Size(20, 20);
            checkBoxAdv1.Location = new Point(1074, 15);
            checkBoxAdv1.MetroColor = Color.FromArgb(65, 0, 218);
            checkBoxAdv1.Name = "checkBoxAdv1";
            checkBoxAdv1.Size = new Size(133, 21);
            checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            checkBoxAdv1.TabIndex = 0;
            checkBoxAdv1.Text = "Show inactive tests";
            checkBoxAdv1.ThemeName = "Metro";
            // 
            // gradientPanel3
            // 
            gradientPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradientPanel3.BackColor = Color.White;
            gradientPanel3.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel3.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel3.Controls.Add(dgvTestTypes);
            gradientPanel3.Location = new Point(15, 155);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(1222, 439);
            gradientPanel3.TabIndex = 2;
            // 
            // dgvTestTypes
            // 
            dgvTestTypes.AccessibleName = "Table";
            dgvTestTypes.AllowEditing = false;
            dgvTestTypes.AllowGrouping = false;
            dgvTestTypes.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            dgvTestTypes.Dock = DockStyle.Fill;
            dgvTestTypes.Location = new Point(0, 0);
            dgvTestTypes.Name = "dgvTestTypes";
            dgvTestTypes.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            dgvTestTypes.RowHeight = 40;
            dgvTestTypes.Size = new Size(1220, 437);
            dgvTestTypes.Style.BorderColor = Color.FromArgb(100, 100, 100);
            dgvTestTypes.Style.BorderStyle = BorderStyle.None;
            gridBordersInfo1.Left = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.None);
            gridBordersInfo1.Right = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.None);
            dgvTestTypes.Style.CellStyle.Borders = gridBordersInfo1;
            dgvTestTypes.Style.CellStyle.Font.Size = 10F;
            dgvTestTypes.Style.CellStyle.TextMargins = new Padding(15, 0, 15, 0);
            dgvTestTypes.Style.DragPreviewRowStyle.Font = new Font("Segoe UI", 9F);
            dgvTestTypes.Style.DragPreviewRowStyle.RowCountIndicatorTextColor = Color.FromArgb(255, 255, 255);
            dgvTestTypes.Style.HeaderStyle.BackColor = Color.FromArgb(243, 244, 246);
            gridBordersInfo2.Left = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.None);
            gridBordersInfo2.Right = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.None);
            dgvTestTypes.Style.HeaderStyle.Borders = gridBordersInfo2;
            dgvTestTypes.Style.HeaderStyle.Font.Bold = true;
            dgvTestTypes.Style.HeaderStyle.Font.Size = 9F;
            dgvTestTypes.Style.HeaderStyle.HorizontalAlignment = HorizontalAlignment.Left;
            dgvTestTypes.Style.HeaderStyle.HoverBackColor = Color.FromArgb(243, 244, 246);
            dgvTestTypes.Style.HeaderStyle.HoverTextColor = Color.FromArgb(107, 112, 129);
            dgvTestTypes.Style.HeaderStyle.PressedTextColor = Color.FromArgb(107, 112, 129);
            dgvTestTypes.Style.HeaderStyle.TextColor = Color.FromArgb(107, 112, 129);
            dgvTestTypes.Style.HeaderStyle.TextMargins = new Padding(13, 0, 13, 0);
            dgvTestTypes.TabIndex = 0;
            dgvTestTypes.Text = "sfDataGrid1";
            // 
            // TestTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gradientPanel3);
            Controls.Add(gradientPanel2);
            Controls.Add(gradientPanel1);
            Name = "TestTypes";
            Padding = new Padding(15);
            Size = new Size(1252, 612);
            Load += TestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkBoxAdv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfButton btnRefresh;
        private Syncfusion.WinForms.Controls.SfButton btnAddTestType;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvTestTypes;
    }
}
