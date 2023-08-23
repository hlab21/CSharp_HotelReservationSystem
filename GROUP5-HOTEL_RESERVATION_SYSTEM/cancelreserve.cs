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

namespace GROUP5_HOTEL_RESERVATION_SYSTEM
{
    public partial class cancelreserve : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqldr;
        public cancelreserve()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cancelclarify =MessageBox.Show("Are you sure you want to cancel your reservation?", "Cancel reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(cancelclarify == DialogResult.Yes)
            {
                sqlcon.Open();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "Delete from reservation_table where user_id='" + showuid.Text + "';";
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                sqlcon.Open();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "Update room_table set availability ='AVAILABLE' where room_num=" + showrn.Text + ";";
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Reservation successfully cancelled!", "Cancel Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usermodule openumod = new usermodule();
                this.Hide();
                openumod.Show();
            }
            else
            {

            }
        }

        private void cancelreserve_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from reservation_table where user_id ='" + userlog.uid + "';";
            sqldr = sqlcmd.ExecuteReader();
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            if (sqldr.HasRows)
            {
                sqldr.Read();
                showuid.Text = sqldr[0].ToString();
                showrn.Text = sqldr[1].ToString();
                showrt.Text = sqldr[2].ToString();
                showrate.Text = sqldr[3].ToString();
                showGuests.Text = sqldr[4].ToString();
                showpt.Text = sqldr[7].ToString();
                showpp.Text = sqldr[8].ToString();
                ci.Text = sqldr[5].ToString();
                co.Text = sqldr[6].ToString();
                sqlcon.Close();
            }
            sqlcon.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            usermodule openmod = new usermodule();
            this.Hide();
            openmod.Show();
        }
    }
}
