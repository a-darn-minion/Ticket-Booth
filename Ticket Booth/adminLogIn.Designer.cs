namespace Ticket_Booth
{
    partial class AdminLogIn
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogIn = new ReaLTaiizor.Controls.Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnReturn = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnReturn).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(74, 261);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 29);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "\r\n";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(74, 321);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(244, 29);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
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
            btnLogIn.Location = new Point(104, 374);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnLogIn.PressedColor = Color.FromArgb(165, 37, 37);
            btnLogIn.Size = new Size(186, 38);
            btnLogIn.TabIndex = 6;
            btnLogIn.Text = "LOG IN";
            btnLogIn.TextAlignment = StringAlignment.Center;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources._64572;
            pictureBox1.Location = new Point(114, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(btnReturn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 43);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // btnReturn
            // 
            btnReturn.Cursor = Cursors.Hand;
            btnReturn.Image = Properties.Resources._152532;
            btnReturn.Location = new Point(341, 3);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(39, 37);
            btnReturn.SizeMode = PictureBoxSizeMode.StretchImage;
            btnReturn.TabIndex = 0;
            btnReturn.TabStop = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 227);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 9;
            label1.Text = "Admin";
            // 
            // AdminLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 489);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminLogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private ReaLTaiizor.Controls.Button btnLogIn;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox btnReturn;
        private Label label1;
    }
}