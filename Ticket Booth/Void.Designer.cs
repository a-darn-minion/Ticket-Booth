namespace Ticket_Booth
{
    partial class AdminKey
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
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            btnLogIn = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources._64572;
            pictureBox1.Location = new Point(115, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(72, 222);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 29);
            txtUsername.TabIndex = 9;
            txtUsername.Text = "\r\n";
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
            btnLogIn.Location = new Point(100, 267);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnLogIn.PressedColor = Color.FromArgb(165, 37, 37);
            btnLogIn.Size = new Size(186, 38);
            btnLogIn.TabIndex = 10;
            btnLogIn.Text = "ENTER KEY";
            btnLogIn.TextAlignment = StringAlignment.Center;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // AdminKey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 412);
            Controls.Add(btnLogIn);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminKey";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminKey";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private ReaLTaiizor.Controls.Button btnLogIn;
    }
}