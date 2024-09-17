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
    public enum categories { Sushi, Bento, Burgers, Ramen, Drinks }

    public partial class Widget : UserControl
    {
            private categories _category;
            private double _cost;



        public event EventHandler OnSelect = null;
        public Widget()
        {
            InitializeComponent();
        }

        private void Widget_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void Widget_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        public categories Category { get => _category; set => _category = value; }


        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public double Cost { get => _cost; set { _cost = value; lblCost.Text = _cost.ToString("C2"); } }
        public Image Icon { get => imgImage.Image; set => imgImage.Image = value; }





    }
}
