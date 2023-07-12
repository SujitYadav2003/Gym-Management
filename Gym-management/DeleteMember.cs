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

namespace Gym_management
{
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("this will delete your data.confirm?", "Delete data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();

                con.ConnectionString = "Data Source=LAPTOP-FF6S3I6J\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True";


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewMember where MID = " + textBox1.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


            }
            else
            {
                this.Activate();
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
        }

        private void DeleteMember_Load(object sender, EventArgs e)
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
    }
}
