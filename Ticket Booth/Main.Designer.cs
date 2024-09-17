namespace Ticket_Booth
{
    partial class Main
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnExit = new PictureBox();
            Menu = new Panel();
            nightButton2 = new ReaLTaiizor.Controls.NightButton();
            nightButton1 = new ReaLTaiizor.Controls.NightButton();
            btnSales = new ReaLTaiizor.Controls.NightButton();
            btnRemove = new ReaLTaiizor.Controls.Button();
            panel3 = new Panel();
            grid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            lbTotal = new Label();
            label1 = new Label();
            btnClear = new ReaLTaiizor.Controls.Button();
            btnCheck = new ReaLTaiizor.Controls.Button();
            ControlPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            Menu.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1301, 50);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = Properties.Resources.button;
            btnExit.Location = new Point(1248, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(41, 37);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 0;
            btnExit.TabStop = false;
            btnExit.Click += pictureBox1_Click;
            // 
            // Menu
            // 
            Menu.AccessibleRole = AccessibleRole.MenuBar;
            Menu.BackColor = Color.DarkGray;
            Menu.Controls.Add(nightButton2);
            Menu.Controls.Add(nightButton1);
            Menu.Controls.Add(btnSales);
            Menu.Dock = DockStyle.Left;
            Menu.Location = new Point(0, 50);
            Menu.Name = "Menu";
            Menu.Size = new Size(144, 605);
            Menu.TabIndex = 1;
            Menu.Paint += Menu_Paint;
            // 
            // nightButton2
            // 
            nightButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nightButton2.BackColor = Color.Transparent;
            nightButton2.DialogResult = DialogResult.None;
            nightButton2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nightButton2.ForeColor = Color.Black;
            nightButton2.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            nightButton2.HoverForeColor = Color.White;
            nightButton2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton2.Location = new Point(0, 546);
            nightButton2.MinimumSize = new Size(144, 47);
            nightButton2.Name = "nightButton2";
            nightButton2.NormalBackColor = Color.Black;
            nightButton2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton2.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton2.PressedForeColor = Color.White;
            nightButton2.Radius = 20;
            nightButton2.Size = new Size(144, 47);
            nightButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton2.TabIndex = 11;
            nightButton2.Text = "Void";
            nightButton2.Click += nightButton2_Click;
            // 
            // nightButton1
            // 
            nightButton1.BackColor = Color.Transparent;
            nightButton1.DialogResult = DialogResult.None;
            nightButton1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nightButton1.ForeColor = Color.Black;
            nightButton1.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            nightButton1.HoverForeColor = Color.White;
            nightButton1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton1.Location = new Point(0, 59);
            nightButton1.MinimumSize = new Size(144, 47);
            nightButton1.Name = "nightButton1";
            nightButton1.NormalBackColor = Color.Black;
            nightButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton1.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton1.PressedForeColor = Color.White;
            nightButton1.Radius = 20;
            nightButton1.Size = new Size(144, 47);
            nightButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton1.TabIndex = 10;
            nightButton1.Text = "User Manual";
            nightButton1.Click += nightButton1_Click_1;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.Transparent;
            btnSales.DialogResult = DialogResult.None;
            btnSales.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSales.ForeColor = Color.Black;
            btnSales.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnSales.HoverForeColor = Color.White;
            btnSales.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnSales.Location = new Point(0, 6);
            btnSales.MinimumSize = new Size(144, 47);
            btnSales.Name = "btnSales";
            btnSales.NormalBackColor = Color.Black;
            btnSales.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnSales.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnSales.PressedForeColor = Color.White;
            btnSales.Radius = 20;
            btnSales.Size = new Size(144, 47);
            btnSales.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnSales.TabIndex = 9;
            btnSales.Text = "Sales";
            btnSales.Click += btnSales_Click;
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
            btnRemove.Location = new Point(51, 490);
            btnRemove.Name = "btnRemove";
            btnRemove.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnRemove.PressedColor = Color.FromArgb(165, 37, 37);
            btnRemove.Size = new Size(115, 40);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.TextAlignment = StringAlignment.Center;
            btnRemove.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(grid);
            panel3.Controls.Add(lbTotal);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnRemove);
            panel3.Controls.Add(btnCheck);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1006, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 605);
            panel3.TabIndex = 3;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = SystemColors.ControlDark;
            grid.Location = new Point(0, 3);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowTemplate.Height = 25;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(292, 460);
            grid.TabIndex = 8;
            grid.CellFormatting += grid_CellFormatting;
            // 
            // Column1
            // 
            Column1.HeaderText = "ITEM";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "QTY";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "COST";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // lbTotal
            // 
            lbTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.Location = new Point(219, 466);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(19, 21);
            lbTotal.TabIndex = 7;
            lbTotal.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 467);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 6;
            label1.Text = "Total:";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.BackColor = Color.Transparent;
            btnClear.BorderColor = Color.FromArgb(64, 64, 64);
            btnClear.EnteredBorderColor = Color.FromArgb(192, 0, 0);
            btnClear.EnteredColor = Color.FromArgb(192, 0, 0);
            btnClear.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Image = null;
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.InactiveColor = Color.Red;
            btnClear.Location = new Point(172, 490);
            btnClear.Name = "btnClear";
            btnClear.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnClear.PressedColor = Color.FromArgb(165, 37, 37);
            btnClear.Size = new Size(115, 40);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear All";
            btnClear.TextAlignment = StringAlignment.Center;
            btnClear.Click += button2_Click;
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
            btnCheck.Location = new Point(97, 536);
            btnCheck.Name = "btnCheck";
            btnCheck.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnCheck.PressedColor = Color.FromArgb(165, 37, 37);
            btnCheck.Size = new Size(159, 57);
            btnCheck.TabIndex = 3;
            btnCheck.Text = "Check";
            btnCheck.TextAlignment = StringAlignment.Center;
            btnCheck.Click += btnCheck_Click;
            // 
            // ControlPanel
            // 
            ControlPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ControlPanel.AutoScroll = true;
            ControlPanel.Location = new Point(150, 56);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(850, 599);
            ControlPanel.TabIndex = 9;
            ControlPanel.Paint += ControlPanel_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 655);
            Controls.Add(ControlPanel);
            Controls.Add(panel3);
            Controls.Add(Menu);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            Shown += Main_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            Menu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Menu;
        private Panel panel3;
        private PictureBox btnExit;
        private ReaLTaiizor.Controls.Button btnCheck;
        private ReaLTaiizor.Controls.Button btnRemove;
        private ReaLTaiizor.Controls.Button btnClear;
        private Label lbTotal;
        private Label label1;
        private DataGridView grid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private FlowLayoutPanel ControlPanel;
        private ReaLTaiizor.Controls.NightButton btnSales;
        private ReaLTaiizor.Controls.NightButton nightButton1;
        private ReaLTaiizor.Controls.NightButton nightButton2;
    }
}