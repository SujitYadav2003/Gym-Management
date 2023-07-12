using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management
{
    public partial class logins : Form
    {
        public logins()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="admin" &&textBox2.Text =="admin")
            {
                mainform2 mn = new mainform2();
                mn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
