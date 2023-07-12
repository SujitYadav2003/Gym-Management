using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management
{
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }

        private void SearchMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=LAPTOP-FF6S3I6J\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewMember";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection();

                con.ConnectionString = "Data Source=LAPTOP-FF6S3I6J\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True";


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewMember where MID = " + textBox1.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Please enter some id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
