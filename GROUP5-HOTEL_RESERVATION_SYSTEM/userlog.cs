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
    public partial class userlog : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqldr;
        public static string uid, name, phone;
        public userlog()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.LOGINBLUEBG;
            button1.BackColor = Color.FromArgb(120, 0, 179);
            
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.LOGINWHITEBG;
            button1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((!String.IsNullOrEmpty(ulogpass.Text)) && (!String.IsNullOrEmpty(upasspass.Text)))
            {
                sqlcon.Open();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "Select * from cust_table where u_id ='" + ulogpass.Text + "';";
                sqldr = sqlcmd.ExecuteReader();
                if (sqldr.HasRows)
                {
                    sqldr.Read();
                    if (sqldr[4].ToString() == upasspass.Text)
                    {

                        uid = sqldr[0].ToString();
                        name = sqldr[1].ToString() + " " + sqldr[2].ToString();
                        phone = sqldr[3].ToString();
                        usermodule openum = new usermodule();
                        this.Hide();
                        openum.Show();
                        sqlcon.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult closeconfirm = MessageBox.Show("Are you sure you want to exit?", "",MessageBoxButtons.YesNo);
            if(closeconfirm == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            userregister openreg = new userregister();
            
            openreg.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            adminlog openadlog = new adminlog();
            
            openadlog.Show();
            this.Hide();
        }
    }
}
