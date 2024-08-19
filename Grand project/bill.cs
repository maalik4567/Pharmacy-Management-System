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
    public partial class Manufacturers : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\irfan\Documents\phmSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public Manufacturers()
        {
            InitializeComponent();
        }
        //int indexrow;

        private void button9_Click(object sender, EventArgs e)
        {
            if (compid.Text == "" || compname.Text == "" || compcont.Text == "" || compcont.Text == "")
            {
                MessageBox.Show("Information Incomplete", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into MedManufacturer values(@CompanyId,@CompanyName,@PhNumber,@Address)", cn);
                cmd.Parameters.AddWithValue("@CompanyId", compid.Text);
                cmd.Parameters.AddWithValue("@CompanyName", compname.Text);
                cmd.Parameters.AddWithValue("@PhNumber", compcont.Text);
                cmd.Parameters.AddWithValue("@Address", compadd.Text);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                getMedRecord();
                MessageBox.Show("Manufacturer added succesfully", "ADDED");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE MedManufacturer SET CompanyId = @CompanyId ,CompanyName = @CompanyName,PhNumber=@PhNumber,Address=@Address WHERE CompanyId = @CompanyId", cn);
            cmd.Parameters.AddWithValue("@CompanyId", compid.Text);
            cmd.Parameters.AddWithValue("@CompanyName", compname.Text);
            cmd.Parameters.AddWithValue("@PhNumber", compcont.Text);
            cmd.Parameters.AddWithValue("@Address", compadd.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            getMedRecord();

            MessageBox.Show("Manufacturer updated succesfully", "UPDATED");

        }
        private void button12_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM MedManufacturer WHERE CompanyId = @CompanyId", cn);
            cmd.Parameters.AddWithValue("@CompanyId", compid.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            getMedRecord();

            MessageBox.Show("Company deleted succesfully", "DELETED");
        }

        private void bill_Load(object sender, EventArgs e)
        {
            getMedRecord();
        }
        private void getMedRecord()
        {
            SqlCommand cmd = new SqlCommand("select* from MedManufacturer",cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();
            dataGridView1.DataSource = dt;
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            compid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            compname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            compcont.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            compadd.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
