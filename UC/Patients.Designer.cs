namespace LabLink.UC
{
    partial class Patients
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
                searchTimer?.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo gridBordersInfo1 = new Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo();
            Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo gridBordersInfo2 = new Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnRefresh = new Syncfusion.WinForms.Controls.SfButton();
            btnAddPatient = new Syncfusion.WinForms.Controls.SfButton();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            lblPage = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            btnFirstPage = new Syncfusion.WinForms.Controls.SfButton();
            btnPrevPage = new Syncfusion.WinForms.Controls.SfButton();
            btnNextPage = new Syncfusion.WinForms.Controls.SfButton();
            btnLastPage = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel8 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel13 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            btnNewTest = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnEdit = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel11 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel12 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            cbConsentSMS = new CheckBox();
            txtPhoneNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtFullname = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            txtSearchBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            searchTimer = new System.Windows.Forms.Timer(components);
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            dgvPatients = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            gradientPanel9 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel8).BeginInit();
            gradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel13).BeginInit();
            gradientPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel7).BeginInit();
            gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel11).BeginInit();
            gradientPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel12).BeginInit();
            gradientPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFullname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSearchBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel9).BeginInit();
            gradientPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(btnRefresh);
            gradientPanel1.Controls.Add(btnAddPatient);
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
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddPatient
            // 
            btnAddPatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddPatient.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPatient.ImageSize = new Size(16, 16);
            btnAddPatient.Location = new Point(941, 5);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(158, 40);
            btnAddPatient.Style.Image = (Image)resources.GetObject("resource.Image1");
            btnAddPatient.TabIndex = 2;
            btnAddPatient.Text = "Add New Patient";
            btnAddPatient.TextAlign = ContentAlignment.MiddleRight;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(107, 121, 148);
            autoLabel2.Location = new Point(3, 28);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(276, 17);
            autoLabel2.TabIndex = 1;
            autoLabel2.Text = "Manage patient information and SMS consent";
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.Location = new Point(0, 3);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(91, 30);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Patients";
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(lblPage);
            gradientPanel2.Controls.Add(btnFirstPage);
            gradientPanel2.Controls.Add(btnPrevPage);
            gradientPanel2.Controls.Add(btnNextPage);
            gradientPanel2.Controls.Add(btnLastPage);
            gradientPanel2.Dock = DockStyle.Left;
            gradientPanel2.Location = new Point(15, 84);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Padding = new Padding(0, 0, 0, 15);
            gradientPanel2.Size = new Size(606, 513);
            gradientPanel2.TabIndex = 1;
            // 
            // lblPage
            // 
            lblPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPage.Location = new Point(0, 477);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(65, 15);
            lblPage.TabIndex = 4;
            lblPage.Text = "autoLabel8";
            // 
            // btnFirstPage
            // 
            btnFirstPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFirstPage.BackColor = Color.White;
            btnFirstPage.Font = new Font("Segoe UI Semibold", 9F);
            btnFirstPage.ImageSize = new Size(16, 16);
            btnFirstPage.Location = new Point(432, 470);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(39, 28);
            btnFirstPage.Style.BackColor = Color.White;
            btnFirstPage.Style.Image = (Image)resources.GetObject("resource.Image2");
            btnFirstPage.TabIndex = 3;
            btnFirstPage.UseVisualStyleBackColor = false;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrevPage.BackColor = Color.White;
            btnPrevPage.Font = new Font("Segoe UI Semibold", 9F);
            btnPrevPage.ImageSize = new Size(16, 16);
            btnPrevPage.Location = new Point(477, 470);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(39, 28);
            btnPrevPage.Style.BackColor = Color.White;
            btnPrevPage.Style.Image = (Image)resources.GetObject("resource.Image3");
            btnPrevPage.TabIndex = 3;
            btnPrevPage.UseVisualStyleBackColor = false;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNextPage.BackColor = Color.White;
            btnNextPage.Font = new Font("Segoe UI Semibold", 9F);
            btnNextPage.ImageSize = new Size(16, 16);
            btnNextPage.Location = new Point(522, 470);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(39, 28);
            btnNextPage.Style.BackColor = Color.White;
            btnNextPage.Style.Image = (Image)resources.GetObject("resource.Image4");
            btnNextPage.TabIndex = 3;
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnLastPage
            // 
            btnLastPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLastPage.BackColor = Color.White;
            btnLastPage.Font = new Font("Segoe UI Semibold", 9F);
            btnLastPage.ImageSize = new Size(16, 16);
            btnLastPage.Location = new Point(567, 470);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(39, 28);
            btnLastPage.Style.BackColor = Color.White;
            btnLastPage.Style.Image = (Image)resources.GetObject("resource.Image5");
            btnLastPage.TabIndex = 0;
            btnLastPage.UseVisualStyleBackColor = false;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderStyle = BorderStyle.None;
            gradientPanel3.Controls.Add(gradientPanel8);
            gradientPanel3.Controls.Add(gradientPanel7);
            gradientPanel3.Controls.Add(gradientPanel6);
            gradientPanel3.Controls.Add(gradientPanel5);
            gradientPanel3.Dock = DockStyle.Fill;
            gradientPanel3.Location = new Point(621, 84);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(15, 0, 0, 15);
            gradientPanel3.Size = new Size(616, 513);
            gradientPanel3.TabIndex = 2;
            // 
            // gradientPanel8
            // 
            gradientPanel8.BackColor = Color.White;
            gradientPanel8.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel8.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel8.Controls.Add(gradientPanel13);
            gradientPanel8.Dock = DockStyle.Fill;
            gradientPanel8.Location = new Point(15, 279);
            gradientPanel8.Name = "gradientPanel8";
            gradientPanel8.Size = new Size(601, 162);
            gradientPanel8.TabIndex = 3;
            // 
            // gradientPanel13
            // 
            gradientPanel13.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel13.BorderSides = Border3DSide.Bottom;
            gradientPanel13.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel13.Controls.Add(autoLabel7);
            gradientPanel13.Dock = DockStyle.Top;
            gradientPanel13.Location = new Point(0, 0);
            gradientPanel13.Name = "gradientPanel13";
            gradientPanel13.Padding = new Padding(10);
            gradientPanel13.Size = new Size(599, 61);
            gradientPanel13.TabIndex = 0;
            // 
            // autoLabel7
            // 
            autoLabel7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel7.Location = new Point(13, 19);
            autoLabel7.Name = "autoLabel7";
            autoLabel7.Size = new Size(106, 17);
            autoLabel7.TabIndex = 5;
            autoLabel7.Text = "Lab Test History";
            // 
            // gradientPanel7
            // 
            gradientPanel7.BorderStyle = BorderStyle.None;
            gradientPanel7.Controls.Add(btnCancel);
            gradientPanel7.Controls.Add(btnNewTest);
            gradientPanel7.Dock = DockStyle.Bottom;
            gradientPanel7.Location = new Point(15, 441);
            gradientPanel7.Name = "gradientPanel7";
            gradientPanel7.Size = new Size(601, 57);
            gradientPanel7.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F);
            btnCancel.Location = new Point(129, 17);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 40);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnNewTest
            // 
            btnNewTest.Font = new Font("Segoe UI Semibold", 9F);
            btnNewTest.ImageSize = new Size(16, 16);
            btnNewTest.Location = new Point(0, 17);
            btnNewTest.Name = "btnNewTest";
            btnNewTest.Size = new Size(123, 40);
            btnNewTest.Style.Image = (Image)resources.GetObject("resource.Image6");
            btnNewTest.TabIndex = 1;
            btnNewTest.Text = "New Lab Test";
            btnNewTest.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gradientPanel6
            // 
            gradientPanel6.BorderStyle = BorderStyle.None;
            gradientPanel6.Dock = DockStyle.Top;
            gradientPanel6.Location = new Point(15, 260);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Size = new Size(601, 19);
            gradientPanel6.TabIndex = 1;
            // 
            // gradientPanel5
            // 
            gradientPanel5.BackColor = Color.White;
            gradientPanel5.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel5.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel5.Controls.Add(btnEdit);
            gradientPanel5.Controls.Add(gradientPanel11);
            gradientPanel5.Controls.Add(autoLabel3);
            gradientPanel5.Dock = DockStyle.Top;
            gradientPanel5.Location = new Point(15, 0);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Padding = new Padding(10);
            gradientPanel5.Size = new Size(601, 260);
            gradientPanel5.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ImageSize = new Size(16, 16);
            btnEdit.Location = new Point(530, 15);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(56, 25);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // gradientPanel11
            // 
            gradientPanel11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradientPanel11.BorderStyle = BorderStyle.None;
            gradientPanel11.Controls.Add(gradientPanel12);
            gradientPanel11.Controls.Add(txtPhoneNumber);
            gradientPanel11.Controls.Add(autoLabel5);
            gradientPanel11.Controls.Add(txtFullname);
            gradientPanel11.Controls.Add(autoLabel4);
            gradientPanel11.Location = new Point(13, 60);
            gradientPanel11.Name = "gradientPanel11";
            gradientPanel11.Size = new Size(573, 185);
            gradientPanel11.TabIndex = 4;
            // 
            // gradientPanel12
            // 
            gradientPanel12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradientPanel12.BackColor = Color.FromArgb(248, 249, 250);
            gradientPanel12.BorderStyle = BorderStyle.None;
            gradientPanel12.Controls.Add(autoLabel6);
            gradientPanel12.Controls.Add(cbConsentSMS);
            gradientPanel12.Location = new Point(5, 122);
            gradientPanel12.Name = "gradientPanel12";
            gradientPanel12.Padding = new Padding(10);
            gradientPanel12.Size = new Size(568, 63);
            gradientPanel12.TabIndex = 4;
            // 
            // autoLabel6
            // 
            autoLabel6.ForeColor = Color.FromArgb(107, 121, 148);
            autoLabel6.Location = new Point(29, 35);
            autoLabel6.Name = "autoLabel6";
            autoLabel6.Size = new Size(316, 15);
            autoLabel6.TabIndex = 1;
            autoLabel6.Text = "Patient agrees to receive automated lab result notifications";
            // 
            // cbConsentSMS
            // 
            cbConsentSMS.AutoSize = true;
            cbConsentSMS.Enabled = false;
            cbConsentSMS.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbConsentSMS.Location = new Point(13, 13);
            cbConsentSMS.Name = "cbConsentSMS";
            cbConsentSMS.Size = new Size(224, 19);
            cbConsentSMS.TabIndex = 0;
            cbConsentSMS.Text = "Patient consents to SMS notifications";
            cbConsentSMS.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.BeforeTouchSize = new Size(576, 25);
            txtPhoneNumber.FocusBorderColor = Color.FromArgb(5, 142, 223);
            txtPhoneNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(3, 87);
            txtPhoneNumber.Margin = new Padding(3, 3, 3, 7);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(570, 25);
            txtPhoneNumber.TabIndex = 3;
            // 
            // autoLabel5
            // 
            autoLabel5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel5.ForeColor = Color.FromArgb(107, 121, 148);
            autoLabel5.Location = new Point(0, 60);
            autoLabel5.Margin = new Padding(3, 0, 3, 7);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(101, 17);
            autoLabel5.TabIndex = 2;
            autoLabel5.Text = "Phone Number";
            // 
            // txtFullname
            // 
            txtFullname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFullname.BeforeTouchSize = new Size(576, 25);
            txtFullname.FocusBorderColor = Color.FromArgb(5, 142, 223);
            txtFullname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullname.Location = new Point(3, 27);
            txtFullname.Margin = new Padding(3, 3, 3, 7);
            txtFullname.Name = "txtFullname";
            txtFullname.ReadOnly = true;
            txtFullname.Size = new Size(570, 25);
            txtFullname.TabIndex = 1;
            // 
            // autoLabel4
            // 
            autoLabel4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel4.ForeColor = Color.FromArgb(107, 121, 148);
            autoLabel4.Location = new Point(0, 0);
            autoLabel4.Margin = new Padding(3, 0, 3, 7);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(69, 17);
            autoLabel4.TabIndex = 0;
            autoLabel4.Text = "Full Name";
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel3.Location = new Point(13, 21);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(127, 17);
            autoLabel3.TabIndex = 3;
            autoLabel3.Text = "Patient Information";
            // 
            // txtSearchBox
            // 
            txtSearchBox.BackColor = Color.FromArgb(249, 250, 251);
            bannerTextInfo1.Text = "Search patients...";
            bannerTextInfo1.Visible = true;
            bannerTextProvider1.SetBannerText(txtSearchBox, bannerTextInfo1);
            txtSearchBox.BeforeTouchSize = new Size(576, 25);
            txtSearchBox.BorderColor = Color.FromArgb(209, 211, 212);
            txtSearchBox.BorderStyle = BorderStyle.FixedSingle;
            txtSearchBox.FocusBorderColor = Color.FromArgb(65, 0, 218);
            txtSearchBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBox.Location = new Point(13, 14);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(576, 25);
            txtSearchBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            txtSearchBox.TabIndex = 2;
            txtSearchBox.ThemeName = "Metro";
            txtSearchBox.UseBorderColorOnFocus = true;
            txtSearchBox.WordWrap = false;
            txtSearchBox.TextChanged += txtSearchBox_TextChanged;
            // 
            // searchTimer
            // 
            searchTimer.Interval = 300;
            searchTimer.Tick += searchTimer_Tick;
            // 
            // gradientPanel4
            // 
            gradientPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gradientPanel4.BackColor = Color.White;
            gradientPanel4.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel4.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel4.Controls.Add(dgvPatients);
            gradientPanel4.Controls.Add(gradientPanel9);
            gradientPanel4.Location = new Point(15, 84);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Size = new Size(606, 464);
            gradientPanel4.TabIndex = 1;
            // 
            // dgvPatients
            // 
            dgvPatients.AccessibleName = "Table";
            dgvPatients.AllowEditing = false;
            dgvPatients.AllowGrouping = false;
            dgvPatients.AllowTriStateSorting = true;
            dgvPatients.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            dgvPatients.Dock = DockStyle.Fill;
            dgvPatients.HeaderRowHeight = 0;
            dgvPatients.Location = new Point(0, 56);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            dgvPatients.RowHeight = 50;
            dgvPatients.Size = new Size(604, 406);
            dgvPatients.Style.BorderColor = Color.FromArgb(100, 100, 100);
            dgvPatients.Style.BorderStyle = BorderStyle.None;
            gridBordersInfo1.Bottom = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.Solid, Color.FromArgb(218, 223, 231));
            gridBordersInfo1.Left = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.None);
            gridBordersInfo1.Right = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.None);
            gridBordersInfo1.Top = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.None);
            dgvPatients.Style.CellStyle.Borders = gridBordersInfo1;
            dgvPatients.Style.CellStyle.Font.Size = 10F;
            dgvPatients.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;
            dgvPatients.Style.CellStyle.TextMargins = new Padding(15, 0, 10, 0);
            dgvPatients.Style.DragPreviewRowStyle.Font = new Font("Segoe UI", 9F);
            dgvPatients.Style.DragPreviewRowStyle.RowCountIndicatorTextColor = Color.FromArgb(255, 255, 255);
            gridBordersInfo2.Bottom = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.None);
            gridBordersInfo2.Left = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.None);
            gridBordersInfo2.Right = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.None);
            gridBordersInfo2.Top = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.None);
            dgvPatients.Style.HeaderStyle.Borders = gridBordersInfo2;
            dgvPatients.TabIndex = 1;
            dgvPatients.CellDoubleClick += dgvPatients_CellDoubleClick;
            dgvPatients.QueryImageCellStyle += dgvPatients_QueryImageCellStyle;
            // 
            // gradientPanel9
            // 
            gradientPanel9.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel9.BorderSides = Border3DSide.Bottom;
            gradientPanel9.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel9.Controls.Add(txtSearchBox);
            gradientPanel9.Dock = DockStyle.Top;
            gradientPanel9.Location = new Point(0, 0);
            gradientPanel9.Name = "gradientPanel9";
            gradientPanel9.Padding = new Padding(10);
            gradientPanel9.Size = new Size(604, 56);
            gradientPanel9.TabIndex = 0;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gradientPanel4);
            Controls.Add(gradientPanel3);
            Controls.Add(gradientPanel2);
            Controls.Add(gradientPanel1);
            Name = "Patients";
            Padding = new Padding(15);
            Size = new Size(1252, 612);
            Load += Patients_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel8).EndInit();
            gradientPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel13).EndInit();
            gradientPanel13.ResumeLayout(false);
            gradientPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel7).EndInit();
            gradientPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).EndInit();
            gradientPanel5.ResumeLayout(false);
            gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel11).EndInit();
            gradientPanel11.ResumeLayout(false);
            gradientPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel12).EndInit();
            gradientPanel12.ResumeLayout(false);
            gradientPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFullname).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSearchBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel9).EndInit();
            gradientPanel9.ResumeLayout(false);
            gradientPanel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel8;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel7;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnNewTest;
        private Syncfusion.WinForms.Controls.SfButton btnAddPatient;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel11;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPhoneNumber;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFullname;
        private CheckBox cbConsentSMS;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel13;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.WinForms.Controls.SfButton btnRefresh;
        private Syncfusion.WinForms.Controls.SfButton btnEdit;
        private System.Windows.Forms.Timer searchTimer;
        private Syncfusion.WinForms.Controls.SfButton btnLastPage;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvPatients;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel9;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearchBox;
        private Syncfusion.WinForms.Controls.SfButton btnFirstPage;
        private Syncfusion.WinForms.Controls.SfButton btnPrevPage;
        private Syncfusion.WinForms.Controls.SfButton btnNextPage;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblPage;
    }
}
