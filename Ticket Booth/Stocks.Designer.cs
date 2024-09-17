namespace Ticket_Booth
{
    partial class Stocks
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
            label1 = new Label();
            panel1 = new Panel();
            btnRemove = new ReaLTaiizor.Controls.Button();
            btnCheck = new ReaLTaiizor.Controls.Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(497, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(602, 586);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 1;
            label1.Text = "VIEW STOCKS";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnCheck);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 533);
            panel1.TabIndex = 2;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemove.BackColor = Color.Transparent;
            btnRemove.BorderColor = Color.FromArgb(64, 64, 64);
            btnRemove.EnteredBorderColor = Color.FromArgb(192, 64, 0);
            btnRemove.EnteredColor = Color.FromArgb(192, 64, 0);
            btnRemove.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.Image = null;
            btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemove.InactiveColor = Color.Orange;
            btnRemove.Location = new Point(237, 396);
            btnRemove.Name = "btnRemove";
            btnRemove.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnRemove.PressedColor = Color.FromArgb(165, 37, 37);
            btnRemove.Size = new Size(159, 57);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove";
            btnRemove.TextAlignment = StringAlignment.Center;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCheck
            // 
            btnCheck.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCheck.BackColor = Color.Transparent;
            btnCheck.BorderColor = Color.FromArgb(64, 64, 64);
            btnCheck.EnteredBorderColor = Color.Green;
            btnCheck.EnteredColor = Color.Green;
            btnCheck.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheck.Image = null;
            btnCheck.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheck.InactiveColor = Color.Lime;
            btnCheck.Location = new Point(50, 396);
            btnCheck.Name = "btnCheck";
            btnCheck.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnCheck.PressedColor = Color.FromArgb(165, 37, 37);
            btnCheck.Size = new Size(159, 57);
            btnCheck.TabIndex = 9;
            btnCheck.Text = "Add Stock";
            btnCheck.TextAlignment = StringAlignment.Center;
            btnCheck.Click += btnCheck_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(70, 305);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(302, 35);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(70, 229);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(302, 35);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(70, 152);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 35);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 76);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 35);
            textBox1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 306);
            label6.Name = "label6";
            label6.Size = new Size(37, 17);
            label6.TabIndex = 4;
            label6.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 229);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 3;
            label5.Text = "Supplier";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 152);
            label4.Name = "label4";
            label4.Size = new Size(35, 17);
            label4.TabIndex = 2;
            label4.Text = "Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 77);
            label3.Name = "label3";
            label3.Size = new Size(36, 17);
            label3.TabIndex = 1;
            label3.Text = "Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(170, 10);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 0;
            label2.Text = "ADD STOCK";
            // 
            // Stocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 610);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stocks";
            Text = "Stocks";
            Load += Stocks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ReaLTaiizor.Controls.Button btnCheck;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ReaLTaiizor.Controls.Button btnRemove;
    }
}