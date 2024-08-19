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
    public partial class login : Form
    {
        SqlConnection cont = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\irfan\Documents\phmdb.mdf;Integrated Security=True;Connect Timeout=30");
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            SqlCommand cmd = new SqlCommand("insert into login values(@UserName, @Password",cont);
            cmd.Parameters.AddWithValue("@UserName", bunifuMaterialTextbox1.Text);
            cmd.Parameters.AddWithValue("@Password", bunifuMaterialTextbox2.Text);

            cont.Open();
            cmd.ExecuteNonQuery();
            cont.Close();
            */

            if (bunifuMaterialTextbox1.Text == "admin" && bunifuMaterialTextbox2.Text == "admin")
            {
                home home1 = new home();
                home1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }
    }
}
