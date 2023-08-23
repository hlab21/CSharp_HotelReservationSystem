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
    public partial class viewuserhistory : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqldr;
        public viewuserhistory()
        {
            InitializeComponent();
        }

        private void viewuserhistory_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true; 
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from log_table where user_id = '" + userlog.uid + "';";
            sqldr = sqlcmd.ExecuteReader();
            listView1.Items.Clear();
            while (sqldr.Read())
            {
                ListViewItem lv = new ListViewItem(sqldr[0].ToString());
                lv.SubItems.Add(sqldr[1].ToString());
                lv.SubItems.Add(sqldr[2].ToString());
                lv.SubItems.Add(sqldr[3].ToString());
                lv.SubItems.Add(sqldr[4].ToString());
                lv.SubItems.Add(sqldr[5].ToString());
                lv.SubItems.Add(sqldr[6].ToString());
                lv.SubItems.Add(sqldr[7].ToString());
                lv.SubItems.Add(sqldr[8].ToString());
                lv.SubItems.Add(sqldr[9].ToString());
                lv.SubItems.Add(sqldr[10].ToString());
                lv.SubItems.Add(sqldr[11].ToString());
                listView1.Items.Add(lv);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            usermodule openmod = new usermodule();
            this.Hide();
            openmod.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
