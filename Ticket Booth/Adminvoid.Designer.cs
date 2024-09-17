namespace Ticket_Booth
{
    partial class Adminvoid
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
            dataGridView1 = new DataGridView();
            button1 = new ReaLTaiizor.Controls.Button();
            btnReturn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReturn).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 388);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(32, 34, 37);
            button1.Location = new Point(341, 398);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(120, 40);
            button1.TabIndex = 1;
            button1.Text = "Remove";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // btnReturn
            // 
            btnReturn.Cursor = Cursors.Hand;
            btnReturn.Image = Properties.Resources._152532;
            btnReturn.Location = new Point(749, 401);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(39, 37);
            btnReturn.SizeMode = PictureBoxSizeMode.StretchImage;
            btnReturn.TabIndex = 2;
            btnReturn.TabStop = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // Adminvoid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Adminvoid";
            Text = "Adminvoid";
            Load += Adminvoid_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReturn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.Button button1;
        private PictureBox btnReturn;
    }
}