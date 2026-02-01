namespace LabLink.Components
{
    partial class Topbar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Topbar));
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            pictureBox1 = new PictureBox();
            lblDateTime = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            clock = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderColor = Color.FromArgb(218, 223, 231);
            gradientPanel1.BorderSides = Border3DSide.Bottom;
            gradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel1.Controls.Add(autoLabel1);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(lblDateTime);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Padding = new Padding(10, 0, 0, 0);
            gradientPanel1.Size = new Size(1273, 60);
            gradientPanel1.TabIndex = 2;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.Location = new Point(49, 18);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(218, 20);
            autoLabel1.TabIndex = 3;
            autoLabel1.Text = "Lab Results Notification Center";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = false;
            lblDateTime.Dock = DockStyle.Right;
            lblDateTime.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.FromArgb(107, 121, 148);
            lblDateTime.Location = new Point(808, 0);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Padding = new Padding(3, 0, 7, 0);
            lblDateTime.Size = new Size(463, 58);
            lblDateTime.TabIndex = 1;
            lblDateTime.Text = "Time";
            lblDateTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // clock
            // 
            clock.Interval = 1000;
            clock.Tick += clock_Tick;
            // 
            // Topbar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gradientPanel1);
            Name = "Topbar";
            Size = new Size(1273, 60);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblDateTime;
        private System.Windows.Forms.Timer clock;
        private PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
    }
}
