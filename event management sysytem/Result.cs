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
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("Server=localhost;Database=EVENTMANAGEMENTSYSTEM;Uid=root;Pwd=;");
            MySqlCommand insert = new MySqlCommand("insert into result values ('" + txtComptitionID.Text + "','" + txtParticipantID.Text + "','" + txtPlace.Text + "')", con);
            con.Open();
            insert.CommandType = CommandType.Text;
            insert.ExecuteNonQuery();
            MessageBox.Show("inserted successfully");
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=EVENTMANAGEMENTSYSTEM;Uid=root;Pwd=;");
            MySqlCommand delete = new MySqlCommand("delete from result where ID ='" + txtComptitionID.Text + "'", con);
            con.Open();
            delete.CommandType = CommandType.Text;
            delete.ExecuteNonQuery();
            MessageBox.Show("deleted succussfully");
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=EVENTMANAGEMENTSYSTEM;Uid=root;Pwd=;");
            MySqlCommand search = new MySqlCommand("select * from result where ID ='" + txtComptitionID.Text + "'", con);
            con.Open();
            MySqlDataReader dr = search.ExecuteReader();
            if (dr.Read())
            {
                txtParticipantID.Text = dr[1].ToString();
                txtPlace.Text = dr[2].ToString();
                MessageBox.Show("Search Successful");
            }
            else
            {
                MessageBox.Show("Result not found");
            }
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtComptitionID.Clear();
            txtParticipantID.Clear();
            txtPlace.Clear();
            
        }
    }
}
