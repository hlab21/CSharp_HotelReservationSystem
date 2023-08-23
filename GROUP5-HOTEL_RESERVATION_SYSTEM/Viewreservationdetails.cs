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
    public partial class Viewreservationdetails : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqldr;
        public Viewreservationdetails()
        {
            InitializeComponent();
        }

        private void Viewreservationdetails_Load(object sender, EventArgs e)
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
                ci.Text = sqldr[5].ToString();
                co.Text = sqldr[6].ToString();
                showpt.Text = sqldr[7].ToString();
                showpp.Text = sqldr[8].ToString();
                sqlcon.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            usermodule openmod = new usermodule();
            this.Hide();
            openmod.Show();
        }
    }
}
