using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grand_project
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            stock med = new stock();
            med.Show();
            this.Hide();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            login logon = new login();
            logon.Show();
            this.Hide();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Manufacturers med = new Manufacturers();
            med.Show();
            this.Hide();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            billing med = new billing();
            med.Show();
            this.Hide();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            employee med = new employee();
            med.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            Sales sl = new Sales();
            sl.Show();
            this.Hide();
        }
    }
}
