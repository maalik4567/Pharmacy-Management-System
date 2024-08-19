using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grand_project
{
    public partial class Sales : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\irfan\Documents\phmSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public Sales()
        {
            InitializeComponent();
        }

        private void empgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Sales_Load(object sender, EventArgs e)
        {
            salesRecord();
            fillSaleslbl();
            fillAvglbl();

        }
        private void salesRecord()
        {
            SqlCommand cmd = new SqlCommand("select * from sale", cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();
            salesgridview.DataSource = dt;
        }
        private void fillSaleslbl()
        {
            SqlCommand cmd = new SqlCommand("select SUM(Amount) from sale", cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();
            label4.Text = "Rs " + dt.Rows[0][0].ToString();
        }
        private void fillAvglbl()
        {
            SqlCommand cmd = new SqlCommand("select ROUND(AVG(Amount),2) from sale", cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();
            label2.Text = "Rs " + dt.Rows[0][0].ToString();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Sale WHERE date LIKE 'Date=@Date'", cn);
            cmd.Parameters.AddWithValue("@Date", datetxt.Text);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();
            salesgridview.DataSource = dt;

            //SELECT* FROM Sale WHERE date LIKE '%2022-06-07%';
        }
    }
}
