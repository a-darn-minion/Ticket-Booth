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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int index;
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=POS system;Integrated Security=True");


        public void AddItem(string name, double cost, categories category, string icon)
        {
            var w = new Widget()
            {
                Title = name,
                Cost = cost,
                Category = category,
                Icon = Image.FromFile("icons/" + icon),

            };

            ControlPanel.Controls.Add(w);

            w.OnSelect += (ss, ee) =>
            {
                var wdg = (Widget)ss;
                foreach (DataGridViewRow item in grid.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wdg.lblTitle.Text)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
                        item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * double.Parse(wdg.lblCost.Text.Replace("₱", ""))).ToString("C2");
                        CalculateTotal();
                        return;
                    }
                }
                grid.Rows.Add(new object[] { wdg.lblTitle.Text, 1, wdg.lblCost.Text });
                CalculateTotal();
            };

        }

        void CalculateTotal()
        {
            double tot = 0;
            foreach (DataGridViewRow item in grid.Rows)
            {
                tot += double.Parse(item.Cells[2].Value.ToString().Replace("₱", ""));
            }

            lbTotal.Text = tot.ToString("C2");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            index = grid.CurrentCell.RowIndex;
            grid.Rows.RemoveAt(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grid.Rows.Clear();
            lbTotal.Text = "0";
        }

        private void nightButton1_Click(object sender, EventArgs e)
        {

        }






        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void Main_Shown(object sender, EventArgs e)
        {
            //borgirssss
            AddItem("Ebi Burger", 275, categories.Burgers, "burger.png");
            AddItem("Teriyaki Burger", 175, categories.Burgers, "burger.png");
            AddItem("Tonkatsu Burger", 385, categories.Burgers, "burger.png");
            AddItem("Korokke Burger", 175, categories.Burgers, "burger.png");

            //Ramens
            AddItem("Kitakata Ramen", 300, categories.Ramen, "ramen.png");
            AddItem("Tonkotsu Ramen", 350, categories.Ramen, "ramen.png");
            AddItem("Miso Ramen", 250, categories.Ramen, "ramen.png");
            AddItem("Tsukemen Ramen", 275, categories.Ramen, "ramen.png");

            // bentos
            AddItem("Prawn&Veggie Tempura", 290, categories.Bento, "bento.png");
            AddItem("Pork katsu", 350, categories.Bento, "bento.png");
            AddItem("Pork Tonkatsu", 400, categories.Bento, "bento.png");
            AddItem("Chicken Kaarage", 375, categories.Bento, "bento.png");

            //sushi
            AddItem("Maki", 300, categories.Sushi, "sushi.png");
            AddItem("Californian Roll", 350, categories.Sushi, "sushi.png");
            AddItem("Nigiri", 300, categories.Sushi, "sushi.png");
            AddItem("Sashimi", 350, categories.Sushi, "sushi.png");
            AddItem("Salmon sushi", 350, categories.Sushi, "sushi.png");

            //drinks
            AddItem("Coca-cola", 50, categories.Drinks, "drink.png");
            AddItem("Sprite", 50, categories.Drinks, "drink.png");
            AddItem("Matcha Tea", 70, categories.Drinks, "drink.png");
            AddItem("Iced Tea", 50, categories.Drinks, "drink.png");
            AddItem("Coffee", 50, categories.Drinks, "drink.png");
        }



        private void btnCheck_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=POS system;Integrated Security=True");

            var result = MessageBox.Show("Check out Items?", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                for (int i = 0; i < grid.Rows.Count - 1; i++)
                {

                    SqlCommand cmd1 = new SqlCommand(@"INSERT INTO Sales3(ITEM,QTY,COST) VALUES('" + grid.Rows[i].Cells[0].Value + "','" + grid.Rows[i].Cells[1].Value + "','" + grid.Rows[i].Cells[2].Value + "')", conn);
                    lbTotal.Text = "0";
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                }
                grid.Rows.Clear();
            }



        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales1 sales = new Sales1();
            sales.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nightButton1_Click_1(object sender, EventArgs e)
        {
            Manual manual = new Manual();
            manual.Show();
        }

        private void nightButton2_Click(object sender, EventArgs e)
        {
            AdminKey adminKey = new AdminKey();
            adminKey.Show();
        }

        private void ControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
