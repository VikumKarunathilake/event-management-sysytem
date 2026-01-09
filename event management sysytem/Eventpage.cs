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
    public partial class frmEventpage : Form
    {
        public frmEventpage()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=EVENTMANAGEMENTSYSTEM;Uid=root;Pwd=;");
            MySqlCommand insert = new MySqlCommand("insert into event values ('" + txtEventDate.Text + "','" + txtEventID.Text + "','" + txtEventName.Text + "','" + txtVenue.Text + "')", con);
            con.Open();
            insert.CommandType = CommandType.Text;
            insert.ExecuteNonQuery();
            MessageBox.Show("inserted successfully");
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=EVENTMANAGEMENTSYSTEM;Uid=root;Pwd=;");
            MySqlCommand delete = new MySqlCommand("delete from event where ID ='" + txtEventID.Text + "'", con);
            con.Open();
            delete.CommandType = CommandType.Text;
            delete.ExecuteNonQuery();
            MessageBox.Show("deleted succussfully");
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=EVENTMANAGEMENTSYSTEM;Uid=root;Pwd=;");
            MySqlCommand search = new MySqlCommand("select * from event where ID ='" + txtEventID.Text + "'", con);
            con.Open();
            MySqlDataReader dr = search.ExecuteReader();
            if (dr.Read())
            {
                txtEventDate.Text = dr[0].ToString();
                txtEventName.Text = dr[2].ToString();
                txtVenue.Text = dr[3].ToString();
                MessageBox.Show("Search Successful");
            }
            else
            {
                MessageBox.Show("Event not found");
            }
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEventDate.Clear();
            txtEventID.Clear();
            txtEventName.Clear();
            txtVenue.Clear();
        }
    }
}
