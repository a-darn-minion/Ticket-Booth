namespace Ticket_Booth
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            btnAdmin = new Button();
            panel1 = new Panel();
            btnLogIn = new ReaLTaiizor.Controls.Button();
            slidePic = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slidePic).BeginInit();
            SuspendLayout();
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(565, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            nightControlBox1.Click += nightControlBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(nightControlBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(704, 28);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources._64572;
            pictureBox1.Location = new Point(85, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(42, 277);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 29);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "\r\n";
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(42, 329);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(244, 29);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 222);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 3;
            label1.Text = "Log In";
            label1.Click += label1_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(64, 64, 64);
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Location = new Point(117, 456);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(103, 24);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "Administrator";
            btnAdmin.TextAlign = ContentAlignment.TopCenter;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 515);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Transparent;
            btnLogIn.BorderColor = Color.FromArgb(32, 34, 37);
            btnLogIn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnLogIn.EnteredColor = Color.FromArgb(32, 34, 37);
            btnLogIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.Image = null;
            btnLogIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogIn.InactiveColor = Color.FromArgb(32, 34, 37);
            btnLogIn.Location = new Point(70, 400);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnLogIn.PressedColor = Color.FromArgb(165, 37, 37);
            btnLogIn.Size = new Size(186, 38);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "LOG IN";
            btnLogIn.TextAlignment = StringAlignment.Center;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // slidePic
            // 
            slidePic.Dock = DockStyle.Fill;
            slidePic.Image = Properties.Resources.coast_prince_george_hotel_by_apa_shogun1;
            slidePic.Location = new Point(339, 28);
            slidePic.Name = "slidePic";
            slidePic.Size = new Size(365, 515);
            slidePic.SizeMode = PictureBoxSizeMode.StretchImage;
            slidePic.TabIndex = 3;
            slidePic.TabStop = false;
            slidePic.Click += pictureBox2_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 543);
            Controls.Add(slidePic);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slidePic).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Button btnAdmin;
        private Panel panel1;
        private PictureBox slidePic;
        private ReaLTaiizor.Controls.Button btnLogIn;
    }
}