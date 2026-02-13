namespace LabLink.Forms.Login
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnLogin = new Syncfusion.WinForms.Controls.SfButton();
            pictureBox1 = new PictureBox();
            txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            cbShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(30, 72, 207);
            btnLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(48, 357);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(286, 43);
            btnLogin.Style.BackColor = Color.FromArgb(30, 72, 207);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(151, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BeforeTouchSize = new Size(360, 25);
            txtUsername.BorderColor = Color.FromArgb(209, 211, 212);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.FocusBorderColor = Color.FromArgb(30, 72, 207);
            txtUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(48, 178);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(286, 27);
            txtUsername.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            txtUsername.TabIndex = 0;
            txtUsername.ThemeName = "Metro";
            txtUsername.UseBorderColorOnFocus = true;
            txtUsername.WordWrap = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BeforeTouchSize = new Size(360, 25);
            txtPassword.BorderColor = Color.FromArgb(209, 211, 212);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.FocusBorderColor = Color.FromArgb(30, 72, 207);
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(48, 240);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(286, 27);
            txtPassword.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            txtPassword.TabIndex = 1;
            txtPassword.ThemeName = "Metro";
            txtPassword.UseBorderColorOnFocus = true;
            txtPassword.WordWrap = false;
            // 
            // autoLabel1
            // 
            autoLabel1.Anchor = AnchorStyles.None;
            autoLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.Location = new Point(150, 103);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(65, 21);
            autoLabel1.TabIndex = 99;
            autoLabel1.Text = "LabLink";
            // 
            // autoLabel2
            // 
            autoLabel2.Anchor = AnchorStyles.None;
            autoLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel2.Location = new Point(46, 155);
            autoLabel2.Margin = new Padding(3, 0, 3, 3);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(67, 17);
            autoLabel2.TabIndex = 5;
            autoLabel2.Text = "Username";
            // 
            // autoLabel3
            // 
            autoLabel3.Anchor = AnchorStyles.None;
            autoLabel3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel3.Location = new Point(46, 217);
            autoLabel3.Margin = new Padding(3, 0, 3, 3);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(64, 17);
            autoLabel3.TabIndex = 6;
            autoLabel3.Text = "Password";
            // 
            // cbShowPassword
            // 
            cbShowPassword.Anchor = AnchorStyles.None;
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(48, 273);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(108, 19);
            cbShowPassword.TabIndex = 100;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarHeight = 35;
            ClientSize = new Size(377, 454);
            Controls.Add(cbShowPassword);
            Controls.Add(autoLabel3);
            Controls.Add(autoLabel2);
            Controls.Add(autoLabel1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            InnerBorderVisibility = false;
            MetroColor = Color.FromArgb(30, 72, 207);
            Name = "frmLogin";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton btnLogin;
        private PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private CheckBox cbShowPassword;
    }
}