using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Booth
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            ControlPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlPanel.Controls.Add(f);
            f.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControls(new frmStaff());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            AddControls(new Sales());
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            AddControls(new Stocks());
        }

        private void nightButton1_Click(object sender, EventArgs e)
        {
            AddControls(new About()); 
        }
    }
}
