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
    public partial class usermodule : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqldr;
        public usermodule()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            editpass openview = new editpass();
            this.Hide();
            openview.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.EDITPASSPURP1;
            button2.BackColor = Color.FromArgb(120, 0, 179);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.EDITPASSWHITE;
            button2.BackColor = Color.FromArgb(120, 0, 179);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.logoutpurp;
            button1.BackColor = Color.FromArgb(120, 0, 179);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.LOGOUTWHITE;
            button1.BackColor = Color.FromArgb(120, 0, 179);
        }

        private void usermodule_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true; 
            dispid.Text = userlog.uid.ToString();
            dispname.Text = userlog.name.ToString();
            disppn.Text = userlog.phone.ToString();
            dispid.BackColor = dispid.BackColor;
            dispname.BackColor = dispname.BackColor;
            disppn.BackColor = disppn.BackColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userlog newlog = new userlog();
            this.Hide();
            newlog.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from reservation_table where user_id ='" + userlog.uid + "';";
            sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)
            {
                MessageBox.Show("The user is already reserved!", "Reservation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
            else
            {
                sqlcon.Close();
                sqlcon.Open();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "Select * from checkin_table where user_id ='" + userlog.uid + "';";
                sqldr = sqlcmd.ExecuteReader();
                if (sqldr.HasRows)
                {
                    sqlcon.Close();
                    MessageBox.Show("The user is already Checked in the hotel!", "Reservation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    sqlcon.Close();
                    viewroomtype openrooms = new viewroomtype();
                    this.Hide();
                    openrooms.Show();
                }
                    
            }
            
        }

        private void vr_Click(object sender, EventArgs e)
        {
            VIEWROOMS openviewroom = new VIEWROOMS();
            this.Hide();
            openviewroom.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from reservation_table where user_id ='" + userlog.uid + "';";
            sqldr = sqlcmd.ExecuteReader();

            if (sqldr.HasRows)
            {
                Viewreservationdetails opencancel = new Viewreservationdetails();
                this.Hide();
                opencancel.Show();
                sqlcon.Close();
            }
            else
            {
                MessageBox.Show("You are not reserved!", "Unreserved user error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from reservation_table where user_id ='" + userlog.uid + "';";
            sqldr = sqlcmd.ExecuteReader();
            
            if (sqldr.HasRows)
            {
                cancelreserve opencancel = new cancelreserve();
                this.Hide();
                opencancel.Show();
                sqlcon.Close();
            }
            else
            {
                MessageBox.Show("You are not reserved!", "Unreserved user error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewuserhistory openviewuhis = new viewuserhistory();
            this.Hide();
            openviewuhis.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult closeconfirm = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo);
            if (closeconfirm == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
