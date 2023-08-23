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
    public partial class viewroomtype : Form
    {
        public static String rtype,package;
        public static int room_price, packageprice, guestcount, transacnum=1;
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqldr;
        public viewroomtype()
        {
            InitializeComponent();
        }

        void setguest()
        {
            if (guestcount == 4)
            {
                gc.Items.Add(1);
                gc.Items.Add(2);
                gc.Items.Add(3);
                gc.Items.Add(4);
            }
            else if (guestcount == 3)
            {
                gc.Items.Add(1);
                gc.Items.Add(2);
                gc.Items.Add(3);
            }
            else if (guestcount == 2)
            {
                gc.Items.Add(1);
                gc.Items.Add(2);

            }
            else if (guestcount == 1)
            {
                gc.Items.Add(1);
            }
        }
        private void srp2_Click(object sender, EventArgs e)
        {
            rtype = "STANDARD SINGLE ROOM AND SMALL SINGLE";
            package = "Package 2";
            room_price = 1800;
            packageprice = 1500;
            uid.Text = userlog.uid;
            rtdisp.Text = rtype;
            packdisp.Text = package;
            guestcount = 1;
            setguest();
            
            vr.SelectedTab = tab3;
            

        }

        private void drp1_Click(object sender, EventArgs e)
        {
            
            
            rtype = "STANDARD DOUBLE ROOM AND SMALL DOUBLE";
            package = "Package 1";
            room_price = 2200;
            packageprice = 200;
            guestcount = 2;
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from room_table where room_type = '" + rtype + "' and availability = 'AVAIlABLE';";
            sqldr = sqlcmd.ExecuteReader();

            while (sqldr.Read())
            {
                rn1.Items.Add(sqldr[0]);
            }
            sqlcon.Close();

            uid.Text = userlog.uid;
            rtdisp.Text = rtype;
            packdisp.Text = package;
            setguest();
            vr.SelectedTab = tab3;
        }

        private void drp2_Click(object sender, EventArgs e)
        {
            rtype = "STANDARD DOUBLE ROOM AND SMALL DOUBLE";
            package = "Package 2";
            room_price = 2200;
            packageprice = 1500;
            guestcount = 2;
            uid.Text = userlog.uid;
            rtdisp.Text = rtype;
            packdisp.Text = package;
            setguest();
            
            sqlcon.Close();
            vr.SelectedTab = tab3;
        }

        private void trp1_Click(object sender, EventArgs e)
        {
            rtype = "STANDARD TWIN ROOM";
            package = "Package 1";
            room_price = 2200;
            packageprice = 200;
            guestcount = 2;
            uid.Text = userlog.uid;
            rtdisp.Text = rtype;
            packdisp.Text = package;
            setguest();
            
            
            vr.SelectedTab = tab3;
        }

        private void trp2_Click(object sender, EventArgs e)
        {
            rtype = "STANDARD TWIN ROOM";
            package = "Package 2";
            room_price = 2200;
            packageprice = 1500;
            guestcount = 2;
            uid.Text = userlog.uid;
            rtdisp.Text = rtype;
            packdisp.Text = package;
            setguest();
           
            
            vr.SelectedTab = tab3;
        }

        private void triprp1_Click(object sender, EventArgs e)
        {
            rtype = "TRIPLE ROOM;";
            package = "Package 1";
            room_price = 3000;
            packageprice = 200;
            guestcount = 3;
            uid.Text = userlog.uid;
            rtdisp.Text = rtype;
            packdisp.Text = package;
            setguest();
        
            
            vr.SelectedTab = tab3;

        }

        private void triprp2_Click(object sender, EventArgs e)
        {
            rtype = "TRIPLE ROOM";
            package = "Package 2";
            room_price = 3000;
            packageprice = 200;
            guestcount = 3;
            uid.Text = userlog.uid;
            rtdisp.Text = rtype;
            packdisp.Text = package;
            setguest();
           
            vr.SelectedTab = tab3;

        }

        private void frp1_Click(object sender, EventArgs e)
        {
            rtype = "LOWER GROUND FAMILY ROOM";
            package = "Package 1";
            room_price = 3700;
            packageprice = 200;
            guestcount = 4;
            uid.Text = userlog.uid;
            rtdisp.Text = rtype;
            packdisp.Text = package;
            setguest();
            vr.SelectedTab = tab3;

        }

        

        private void datein_ValueChanged(object sender, EventArgs e)
        {
            dateout.MinDate = datein.Value.Date.AddDays(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if((gc.SelectedIndex > -1) && (dateout.Value > datein.Value) && (rn1.SelectedIndex != -1))
            {
                sqlcon.Open();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "insert into reservation_table values('" + userlog.uid + "'," + Convert.ToInt32(rn1.SelectedItem) + ",'" +
                    viewroomtype.rtype + "'," + viewroomtype.room_price + "," + Convert.ToInt32(gc.SelectedItem) + ", '" + datein.Value.ToString("MM/dd/yyyy") +
                    "','" + dateout.Value.ToString("MM/dd/yyyy") +
                    "','" + viewroomtype.package + "'," + viewroomtype.packageprice + ");";
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Connection = sqlcon;
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                /*sqlcon.Open();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "Update room_table set availability='RESERVED' where room_num =" + Convert.ToInt32(rn1.SelectedItem) + ";";
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Connection = sqlcon;
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();*/
                MessageBox.Show("You are now reserved!", "Reservation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usermodule openumod = new usermodule();
                this.Hide();
                openumod.Show();
            }
            else
            {
                MessageBox.Show("Please fill all the required fields!", "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult openres = MessageBox.Show("Do you wish to cancel reservation transaction?", "Reservation Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(openres == DialogResult.Yes)
            {
                usermodule openumod = new usermodule();
                this.Hide();
                openumod.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rn1.Items.Clear();
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from room_table where room_type = '" + rtype + "' and availability = 'AVAILABLE';";
            sqldr = sqlcmd.ExecuteReader();

            while (sqldr.Read())
            {
                rn1.Items.Add(sqldr[0].ToString());
            }
            sqlcon.Close();
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select checkinDate,checkoutDate, room_num from checkin_table where room_type ='" + rtype + "';";
            sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)
            {
                while (sqldr.Read())
                {

                    if (((datein.Value >= DateTime.Parse(sqldr[0].ToString())) && (datein.Value <= DateTime.Parse(sqldr[1].ToString()))) ||
                        ((dateout.Value >= DateTime.Parse(sqldr[0].ToString())) && (dateout.Value <= DateTime.Parse(sqldr[1].ToString()))))
                    {
                        rn1.Items.Remove(sqldr[2].ToString());
                    }
                }
            }
            sqlcon.Close();
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select checkin,checkout, room_num from reservation_table where room_type ='" + rtype + "';";
            sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)
            {
                while (sqldr.Read())
                {
                    if (((datein.Value >= DateTime.Parse(sqldr[0].ToString())) && (datein.Value <= DateTime.Parse(sqldr[1].ToString()))) ||
                        ((dateout.Value >= DateTime.Parse(sqldr[0].ToString())) && (dateout.Value <= DateTime.Parse(sqldr[1].ToString()))))
                    {
                        rn1.Items.Remove(sqldr[2].ToString());
                    }
                }
            }
            sqlcon.Close();
            

        }

        private void dateout_ValueChanged(object sender, EventArgs e)
        {
            rn1.Items.Clear();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            usermodule openmod = new usermodule();
            this.Hide();
            openmod.Show();
        }

        private void datein_ValueChanged_1(object sender, EventArgs e)
        {
            dateout.MinDate = datein.Value.Date.AddDays(1);
            rn1.Items.Clear();
        }

        private void frp2_Click(object sender, EventArgs e)
        {
            rtype = "LOWER GROUND FAMILY ROOM";
            package = "Package 2";
            room_price = 3700;
            packageprice = 1500;
            guestcount = 4;
            uid.Text = userlog.uid;
            rtdisp.Text = rtype;
            packdisp.Text = package;
            setguest();
            
            vr.SelectedTab = tab3;
        }

        private void viewroomtype_Load(object sender, EventArgs e)
        {
            
            uid.Text = userlog.uid;
            datein.MinDate = DateTime.Now;
            dateout.MinDate = DateTime.Now.AddDays(1);
            rtdisp.Text = viewroomtype.rtype;
            packdisp.Text = viewroomtype.package; 
            vr.SelectedTab = tab1;
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rtype = "STANDARD SINGLE ROOM AND SMALL SINGLE";
            package = "Package 1";
            room_price = 1800;
            packageprice = 200;
            guestcount = 1;
            uid.Text = userlog.uid;
            rtdisp.Text = rtype;
            packdisp.Text = package;
            setguest();
            vr.SelectedTab = tab3;
        }
    }
}
