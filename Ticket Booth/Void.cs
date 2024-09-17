using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Booth
{
    
    public partial class AdminKey : Form
    {
        public AdminKey()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=POS system;Integrated Security=True");




        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username;
            username = txtUsername.Text;
            try
            {
                string querry = "SELECT *FROM admin WHERE username = '" + txtUsername.Text.Trim() +"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = txtUsername.Text;

                    Adminvoid admin = new Adminvoid();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error");
                txtUsername.Focus();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
