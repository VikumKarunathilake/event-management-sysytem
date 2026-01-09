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
    public partial class frmhome_page : Form
    {
        public frmhome_page()
        {
            InitializeComponent();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            frmEventpage frmEvent = new frmEventpage();
            frmEvent.Show();
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            frmPerformance frmPerformance = new frmPerformance();
            frmPerformance.Show();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmMembers frmMembers = new frmMembers();
            frmMembers.Show();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            frmResult frmResult = new frmResult();
            frmResult.Show();
        }
    }
}
