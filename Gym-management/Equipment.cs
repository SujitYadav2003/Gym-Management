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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String EquipName = textBox1.Text;
            String Description = richTextBox1.Text;
            String MUsed = textBox2.Text;
            String DDate = dateTimePicker2.Text;
            Int64 cost = Int64.Parse(textBox3.Text);

            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=LAPTOP-FF6S3I6J\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Equipment (EquipName,EDescription,MUsed,DDate,Cost) values ('" + EquipName + "','" + Description + "','" + MUsed + "', '" + DDate + " '," + cost + ")"; 


            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved","Inserted",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }
    }
}
