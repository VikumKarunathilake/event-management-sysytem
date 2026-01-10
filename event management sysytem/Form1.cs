using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace event_management_sysytem
{
    public partial class frmPerformance : Form
    {
        public frmPerformance()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=EVENTMANAGEMENTSYSTEM;Uid=root;Pwd=;");
            MySqlCommand insert = new MySqlCommand("insert into records values ('" + txtPerformanceID.Text + "','" + txtPerformanceName.Text + "','" + txtPerformanceType.Text + "','" + txtSheduleID.Text + "')", con);
            con.Open();
            insert.CommandType = CommandType.Text;
            insert.ExecuteNonQuery();
            MessageBox.Show("inserted successfully");
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=EVENTMANAGEMENTSYSTEM;Uid=root;Pwd=;");
            MySqlCommand delete = new MySqlCommand("delete from records where ID ='" + txtPerformanceID.Text + "'", con);
            con.Open();
            delete.CommandType = CommandType.Text;
            delete.ExecuteNonQuery();
            MessageBox.Show("deleted succussfully");
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=EVENTMANAGEMENTSYSTEM;Uid=root;Pwd=;");
            MySqlCommand search = new MySqlCommand("select * from records where ID ='" + txtPerformanceID.Text + "'", con);
            con.Open();
            MySqlDataReader dr = search.ExecuteReader();
            if (dr.Read())
            {
                txtPerformanceName.Text = dr[1].ToString();
                txtPerformanceType.Text = dr[2].ToString();
                txtSheduleID.Text = dr[3].ToString();
                MessageBox.Show("Search Successful");
            }
            else
            {
                MessageBox.Show("Record not found");
            }
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtPerformanceID.Clear();
            txtPerformanceName.Clear();
            txtPerformanceType.Clear();
            txtSheduleID.Clear();

        }
    }
}
