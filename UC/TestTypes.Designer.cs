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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestTypes));
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnRefresh = new Syncfusion.WinForms.Controls.SfButton();
            btnAddTestType = new Syncfusion.WinForms.Controls.SfButton();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
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
            // TestTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gradientPanel1);
            Name = "TestTypes";
            Padding = new Padding(15);
            Size = new Size(1252, 612);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfButton btnRefresh;
        private Syncfusion.WinForms.Controls.SfButton btnAddTestType;
    }
}
