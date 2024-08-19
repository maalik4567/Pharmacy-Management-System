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
    public partial class billing : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\irfan\Documents\phmSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public billing()
        {
            InitializeComponent();
        }
        private void billing_Load(object sender, EventArgs e)
        {

        }



        int grdtotal = 0;
        private void button9_Click(object sender, EventArgs e)
        {

            if (qty.Text == "" || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please Enter Quantity");
            }
            else
            {
                int n = 65;
                
                int v = billpgridview.Rows.Add();
                billpgridview.Rows[v].Cells[0].Value = "01";
                billpgridview.Rows[v].Cells[2].Value = qty.Text;
                billpgridview.Rows[v].Cells[1].Value = comboBox1.SelectedItem;
                billpgridview.Rows[v].Cells[3].Value = n;
                billpgridview.Rows[v].Cells[4].Value = n * Convert.ToInt32(qty.Text);
                int total = n * Convert.ToInt32(qty.Text);

                grdtotal = grdtotal + total;
                label4.Text = grdtotal + "Rs";
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = 0;
            if(comboBox1.Text == "Panadol")
            {
                n= 50;
            }
            else if (comboBox1.Text == "Tanzol")
            {
                n = 230;
            }
            else if (comboBox1.Text == "Brufen")
            {
                n = 95;
            }
            else if (comboBox1.Text == "Amoxil")
            {
                n = 90;
            }
            else if (comboBox1.Text == "Ponstan")
            {
                n = 110;
            }
            label2.Text = Convert.ToString(n);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to sales !");
            fillSalestbl();
            label2.Text = "";
            cust_name.Text = "";
            qty.Text = "";
            datetxt.Text = "";
            comboBox1.ResetText();
            
        }
        private void fillSalestbl()
        {
            SqlCommand cmd = new SqlCommand("insert into Sale(CustomerName,Amount,Date) values(@CustomerName,@Amount,@Date)", cn);
            cmd.Parameters.AddWithValue("@CustomerName", cust_name.Text);
            cmd.Parameters.AddWithValue("@Amount", grdtotal);
            cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(datetxt.Text));

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void billing_Load_1(object sender, EventArgs e)
        {

        }

        private void cust_name_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
    

