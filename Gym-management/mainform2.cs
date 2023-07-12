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
    public partial class mainform2 : Form
    {
        public mainform2()
        {
            InitializeComponent();
        }
        Boolean b = true;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"D:\1-college\icons\img1.png");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"D:\1-college\icons\img2.png");
            }
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.Show();
        }

        private void mainform2_Load(object sender, EventArgs e)
        {
            toolStripMenuItem1.Image = Image.FromFile(@"D:\1-college\icons\img2.png");
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember na = new NewMember();
            na.Show();

        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStaff ns = new NewStaff();
            ns.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Log Out!! Confirm?", "Log OUT", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                logins lg = new logins();
                lg.Show();
            }
        }
    }
}
