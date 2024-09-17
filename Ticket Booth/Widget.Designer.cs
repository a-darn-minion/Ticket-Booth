namespace Ticket_Booth
{
    partial class Widget
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
            panel1 = new Panel();
            imgImage = new PictureBox();
            lblCost = new Label();
            lblTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(imgImage);
            panel1.Controls.Add(lblCost);
            panel1.Controls.Add(lblTitle);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(9, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 114);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            panel1.Paint += panel1_Paint;
            // 
            // imgImage
            // 
            imgImage.Anchor = AnchorStyles.Right;
            imgImage.Image = Properties.Resources.burger;
            imgImage.Location = new Point(128, 3);
            imgImage.Name = "imgImage";
            imgImage.Size = new Size(109, 111);
            imgImage.SizeMode = PictureBoxSizeMode.StretchImage;
            imgImage.TabIndex = 2;
            imgImage.TabStop = false;
            imgImage.Click += pictureBox1_Click;
            // 
            // lblCost
            // 
            lblCost.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCost.ForeColor = Color.FromArgb(64, 64, 64);
            lblCost.Location = new Point(10, 75);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(72, 32);
            lblCost.TabIndex = 1;
            lblCost.Text = "2.75$";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(3, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ebi Burger";
            lblTitle.Click += lblTitle_Click;
            // 
            // Widget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Name = "Widget";
            Size = new Size(267, 129);
            Load += Widget_Load;
            Click += Widget_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox imgImage;
        public Label lblCost;
        public Label lblTitle;
    }
}
