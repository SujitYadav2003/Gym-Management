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
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            String lname = textBox2.Text;

            String gender = "";

            bool isChecked = radioButton1.Checked;

            if (isChecked)
            {
                gender = radioButton1.Text;

            }
            else
            {
                gender = radioButton2.Text;
            }
            String dob = dateTimePicker1.Text;
            Int64 mobile = Int64.Parse(textBox3.Text);
            //Int64 mobile = Int64.Parse(textBox3.Text);
            String email = textBox4.Text;
            String joindate = dateTimePicker2.Text;
            String gymTime = comboBox1.Text;
            String address = richTextBox1.Text;
            String membership = comboBox2.Text;


            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = LAPTOP-FF6S3I6J\\SQLEXPRESS"; Database = Gym; integrated security = "True";
            con.ConnectionString = "Data Source=LAPTOP-FF6S3I6J\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True";

            //  database = Gym;integrated security = true;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into NewMember (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Gymtime,Maddress,MembershipTime) values ('" + fname + "','" + lname + "','" + gender + "', '" + dob + " ','" + mobile + "', ' " + email + " ','" + joindate + " ','" + gymTime + " ','" + address + "','" + membership + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            comboBox1.ResetText();
            comboBox2.ResetText();

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
    }
}
