using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;

namespace Ticket_Booth
{
    public partial class AdminLogIn : Form
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=POS system;Integrated Security=True");

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUsername.Text;
            password = txtPassword.Text;
            try
            {
                string querry = "SELECT *FROM admin WHERE username = '" + txtUsername.Text.Trim() + "' AND password = '" + txtPassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;

                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
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
