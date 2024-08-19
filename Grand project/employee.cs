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
    public partial class employee : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\irfan\Documents\phmSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public employee()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (empid.Text == "" || empname.Text == "" || empsal.Text == "" || empage.Text == "" || combobox2.SelectedItem == null || empcont.Text == "")
            {
                MessageBox.Show("Information Incomplete", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into employees values(@empId,@empName,@salary,@empAge,@gender,@phNumber)", cn);
                cmd.Parameters.AddWithValue("@empId", empid.Text);
                cmd.Parameters.AddWithValue("@empName", empname.Text);
                cmd.Parameters.AddWithValue("@empAge", empage.Text);
                cmd.Parameters.AddWithValue("@salary", empsal.Text);
                cmd.Parameters.AddWithValue("@gender", combobox2.Text);
                cmd.Parameters.AddWithValue("@phNumber", empcont.Text);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                
                MessageBox.Show("Employee added succesfully", "ADDED");
                getEmpRecord();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE employees SET empId = @empId,empName=@empName,empAge = @empAge,salary = @salary,gender = @gender,phNumber = @phNumber WHERE empID = @empid", cn);
            cmd.Parameters.AddWithValue("@empId", empid.Text);
            cmd.Parameters.AddWithValue("@empName", empname.Text);
            cmd.Parameters.AddWithValue("@empAge", empage.Text);
            cmd.Parameters.AddWithValue("@salary", empsal.Text);
            cmd.Parameters.AddWithValue("@gender", combobox2.Text);
            cmd.Parameters.AddWithValue("@phNumber", empcont.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            getEmpRecord();
            MessageBox.Show("Employee updated succesfully", "UPDATED");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM employees WHERE empID = @empid", cn);
            cmd.Parameters.AddWithValue("@empId", empid.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            getEmpRecord();
            MessageBox.Show("Employee deleted succesfully", "DELETED");
        }

        private void employee_Load(object sender, EventArgs e)
        {
            getEmpRecord();
        }
        private void getEmpRecord(){
            SqlCommand cmd = new SqlCommand("select* from employees", cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();
            empgridview.DataSource = dt;
        }
        private void empgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            empid.Text =empgridview.SelectedRows[0].Cells[0].Value.ToString();
            empname.Text =empgridview.SelectedRows[0].Cells[1].Value.ToString();
            empage.Text =empgridview.SelectedRows[0].Cells[3].Value.ToString();
            empsal.Text =empgridview.SelectedRows[0].Cells[2].Value.ToString();
            combobox2.Text =empgridview.SelectedRows[0].Cells[4].Value.ToString();
            empcont.Text =empgridview.SelectedRows[0].Cells[5].Value.ToString();//contact
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
