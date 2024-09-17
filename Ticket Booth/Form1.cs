using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;

namespace Ticket_Booth
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            panel1.Controls.Add(pictureBox1);
            pictureBox1.Location = new Point(86, 71);
            pictureBox1.BackColor = Color.Transparent;
        }




        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=POS system;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogIn adminLogIn = new AdminLogIn();
            adminLogIn.Show();
            this.Hide();



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUsername.Text;
            password = txtPassword.Text;
            try
            {
                string querry = "SELECT *FROM Login WHERE Username = '" + txtUsername.Text.Trim() + "' AND Password = '" + txtPassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;

                    Main main = new Main();
                    main.Show();
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

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}