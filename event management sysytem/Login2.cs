using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace event_management_sysytem
{
    public partial class frmLogin2 : Form
    {
        public frmLogin2()
        {
            InitializeComponent();
        }

        private void btnmembers_Click(object sender, EventArgs e)
        {
            frmMembers members = new frmMembers();
            members.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
        }
    }
}
