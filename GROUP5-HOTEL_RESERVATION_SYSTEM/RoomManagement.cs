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
    public partial class RoomManagement : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqldr;
        int rncounter,rate,maxguests;
        public RoomManagement()
        {
            InitializeComponent();
        }

        private void RoomManagement_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            setrooms();
        }
        void setrooms()
        {
            rmview.Items.Clear();
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from room_table";
            sqlcmd.Connection = sqlcon;
            sqldr = sqlcmd.ExecuteReader();

            while (sqldr.Read())
            {
                ListViewItem lv = new ListViewItem(sqldr[0].ToString());
                lv.SubItems.Add(sqldr[1].ToString());
                lv.SubItems.Add(sqldr[3].ToString());
                lv.SubItems.Add(sqldr[2].ToString());
                lv.SubItems.Add(sqldr[4].ToString());
                rmview.Items.Add(lv);
            }
            sqlcon.Close();
        }
        void checkrooms()
        {
            
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from room_table where room_num='"+ inroom.Text+"';";
            sqlcmd.Connection = sqlcon;
            sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)
            {
                rncounter = 1;
                sqlcon.Close();
            }
            else
            {
                rncounter = 0;
                sqlcon.Close();
            }
        }

        private void guestreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adminmodule openmod = new adminmodule();
            this.Hide();
            openmod.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((rtype.SelectedIndex != -1) && (!String.IsNullOrEmpty(inroom.Text))&&(avail.SelectedIndex!=-1))
            {
                checkrooms();
                if(rncounter == 1)
                {
                    MessageBox.Show("Room number already exists!", "Room number error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    sqlcmd.CommandText = "INSERT INTO room_table values("+inroom.Text+",'" +rtype.SelectedItem+"','"+avail.SelectedItem+"',"+rate+","+maxguests+");";
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("Successfully added a room!", "Room creation success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setrooms();
                }
            }
            else 
            {
                MessageBox.Show("Please fill all the required fields!", "Room creation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rtype.SelectedIndex == 0)
            {
                rate = 1800;
                maxguests = 1;
            }
            if (rtype.SelectedIndex == 1)
            {
                rate = 2200;
                maxguests = 2;
            }
            if (rtype.SelectedIndex == 2)
            {
                rate = 2200;
                maxguests = 2;
            }
            if (rtype.SelectedIndex == 3)
            {
                rate = 3000;
                maxguests = 3;
            }
            if (rtype.SelectedIndex == 4)
            {
                rate = 3700;
                maxguests = 4;
            }
            
        }
    }
}
