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
using System.IO;

namespace Grand_project
{
    public partial class stock : Form
    {
        SqlConnection cont = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\irfan\Documents\phmSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public stock()
        {
            InitializeComponent();
        }
        public string name;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int fk = 0;
            if (comboBox1.Text == "Oxineland")
            {
                fk = 1;
            }
            else if(comboBox1.Text == "Memon co")
            {
                fk = 2;
            }
            else if(comboBox1.Text == "PakMed")
            {
                fk = 3;
            }
            else if (comboBox1.Text == "MyMed LTD.")
            {
                fk = 4;
            }
            else if (comboBox1.Text == "Mengrani's")
            {
                fk = 5;
            }
            if (MdName.Text == "" || MdName.Text == "" || BPrice.Text == "" || MdQty.Text == "" || comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Information Incomplete", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                   cont.Open();
                   SqlCommand cmd = new SqlCommand("insert into StockMed values(@MedName,@Bprice,@Sprice,@MedQty,@ExpiryDate,@Company)",cont);
                cmd.Parameters.AddWithValue("@MedName", MdName.Text);
                cmd.Parameters.AddWithValue("@Bprice", BPrice.Text);
                cmd.Parameters.AddWithValue("@Sprice", SPrice.Text);
                cmd.Parameters.AddWithValue("@MedQty", MdQty.Text);
                cmd.Parameters.AddWithValue("ExpiryDate", Convert.ToDateTime(expiry.Text));
                cmd.Parameters.AddWithValue("@Company", fk);

                cmd.ExecuteNonQuery();
                cont.Close();
                getStockRecord();

                MessageBox.Show("Medicine added succesfully", "ADDED");
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            cont.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM StockMed WHERE MedName = @MedName", cont);
            cmd.Parameters.AddWithValue("@MedName", MdName.Text);


            cmd.ExecuteNonQuery();
            cont.Close();
            getStockRecord();
            MessageBox.Show("Medicine deleted succesfully", "DELETED");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cont.Open();
            SqlCommand cmd = new SqlCommand("UPDATE StockMed SET MedName=@MedName,Bprice=@Bprice,Sprice=@Sprice,MedQty=@MedQty,ExpiryDate=@ExpiryDate,Company=@Company WHERE MedName = @MedName", cont);
            cmd.Parameters.AddWithValue("@MedName", MdName.Text);
            cmd.Parameters.AddWithValue("@Bprice", BPrice.Text);
            cmd.Parameters.AddWithValue("@Sprice", SPrice.Text);
            cmd.Parameters.AddWithValue("@MedQty", MdQty.Text);
            cmd.Parameters.AddWithValue("ExpiryDate", Convert.ToDateTime(expiry.Text));
            cmd.Parameters.AddWithValue("@Company", 3);

            cmd.ExecuteNonQuery();
            cont.Close();
            getStockRecord();
            MessageBox.Show("Medicine updated succesfully", "UPDATED");

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void stock_Load(object sender, EventArgs e)
        {
            getStockRecord();
        }
        private void getStockRecord()
        {
            SqlCommand cmd = new SqlCommand("SELECT medname,bprice,sprice,medqty,Expirydate,MedManufacturer.companyName FROM StockMed INNER JOIN MedManufacturer ON MedManufacturer.CompanyID = StockMed.Company; ", cont);
            DataTable dt = new DataTable();
            cont.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cont.Close();
            dataGridView1.DataSource = dt;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            //indexrow = e.RowIndex;
            //DataGridViewRow row = dataGridView1.Rows[indexrow];

            //empid.Text = empgridview.SelectedRows[0].Cells[0].Value.ToString();

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MdName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SPrice.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            BPrice.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            MdQty.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            expiry.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void expiry_onValueChanged(object sender, EventArgs e)
        {

        }
    }
}
