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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Member nm = new New_Member();
            nm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        Boolean b = true;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)

        {
            if (b == true)
            {
                menuStrip2.Dock = DockStyle.Left;
                b= false;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\anims\OneDrive\Desktop\my projects\img 1.png");
            }
            else
            {
                menuStrip2.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\anims\OneDrive\Desktop\my projects\img 2.png");
            }

           
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout lgot = new Logout();
            lgot.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Staff ns = new New_Staff();
            ns.Show();
        }

        private void equipmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipments eqp = new Equipments();
            eqp.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search src = new Search();
            src.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete dlt = new Delete();
            dlt.Show();
        }
    }
}
