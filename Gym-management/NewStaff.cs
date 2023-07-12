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
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = txtfname.Text;
            String lname = txtlname.Text;

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
            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtmobile.Text);
            String email = txtemail.Text;
            String joindate = dateTimePicker2.Text;
            String city = txtcity.Text;
            String state = txtstate.Text;

            SqlConnection con = new SqlConnection();
           
            con.ConnectionString = "Data Source=LAPTOP-FF6S3I6J\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True";

          
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into NewStaff (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Statee,City) values ('" + fname + "','" + lname + "','" + gender + "', '" + dob + " ','" + mobile + "', ' " + email + " ','" + joindate + " ','" + state + " ','" + city +  "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtlname.Clear();
            txtemail.Clear();
            txtmobile.Clear();
            txtstate.Clear();
            txtcity.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
    }
    }

