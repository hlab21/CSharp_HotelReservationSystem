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
    public partial class adminlog : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqldr;
        public static String adid, adphonenum,adname;
        public adminlog()
        {
            InitializeComponent();
        }

        private void adminlog_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(alogpass.Text)) && (!String.IsNullOrEmpty(apasspass.Text)))
            {
                sqlcon.Open();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "Select * from admin_table where admin_id ='" + alogpass.Text + "';";
                sqldr = sqlcmd.ExecuteReader();
                if (sqldr.HasRows)
                {
                    sqldr.Read();
                    if (sqldr[3].ToString() == apasspass.Text)
                    {
                        
                        adname = sqldr[1].ToString() + " " + sqldr[2].ToString();
                        adphonenum = sqldr[4].ToString();
                        adid = sqldr[0].ToString();
                        sqlcon.Close();
                        adminmodule openadmod = new adminmodule();
                        this.Hide();
                        openadmod.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlcon.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Account does not exist in the database", "Account Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqlcon.Close();
                }

            }
            else
            {
                MessageBox.Show("Please fill all of the required fields!", "Account Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.CANCELBLUEBG;
            button1.BackColor = Color.FromArgb(120, 0, 179);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.CANCELWHITEBG;
            button2.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userlog ulog = new userlog();
            ulog.Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.LOGINBLUEBG;
            button1.BackColor = Color.FromArgb(120, 0, 179);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult closeconfirm = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo);
            if (closeconfirm == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.LOGINWHITEBG;
            button2.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
