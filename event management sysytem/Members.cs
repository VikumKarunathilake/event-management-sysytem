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
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
             MySqlConnection con = new MySqlConnection("Server=localhost;Database=EVENTMANAGEMENTSYSTEM;Uid=root;Pwd=;");
            MySqlCommand insert = new MySqlCommand("insert into members values ('" + txtMembersName.Text + "','" + txtMembersID.Text + "','" + txtGrade.Text + "','" + txtContact.Text + "','" + txtPosition.Text +"')", con);
            con.Open();
            insert.CommandType = CommandType.Text;
            insert.ExecuteNonQuery();
            MessageBox.Show("inserted successfully");
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=EVENTMANAGEMENTSYSTEM;Uid=root;Pwd=;");
            MySqlCommand delete = new MySqlCommand("delete from members where ID ='" + txtMembersID.Text + "'", con);
            con.Open();
            delete.CommandType = CommandType.Text;
            delete.ExecuteNonQuery();
            MessageBox.Show("deleted succussfully");
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=EVENTMANAGEMENTSYSTEM;Uid=root;Pwd=;");
            MySqlCommand search = new MySqlCommand("select * from members where ID ='" + txtMembersID.Text + "'", con);
            con.Open();
            MySqlDataReader dr = search.ExecuteReader();
            if (dr.Read())
            {
                txtMembersName.Text = dr[0].ToString();
                txtGrade.Text = dr[2].ToString();
                txtContact.Text = dr[3].ToString();
                txtPosition.Text = dr[4].ToString();
                MessageBox.Show("Search Successful");
            }
            else
            {
                MessageBox.Show("Member not found");
            }
            con.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtPosition.Clear();
            txtMembersName.Clear();
            txtMembersID.Clear();
            txtGrade.Clear();
            txtContact.Clear();
        }
    }
}
