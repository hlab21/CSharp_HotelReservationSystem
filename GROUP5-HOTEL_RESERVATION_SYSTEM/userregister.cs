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
    public partial class userregister : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqldr;
        public userregister()
        {
            InitializeComponent();
        }

        private void userregister_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.CANCELBLUEBG;
            button2.BackColor = Color.FromArgb(120, 0, 179);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.registerbluebg;
            button1.BackColor = Color.FromArgb(120, 0, 179);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.REGISTERWHITEBG;
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.CANCELWHITEBG;
            button2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((!String.IsNullOrEmpty(uregpass.Text))&& (!String.IsNullOrEmpty(fnreg.Text))&& (!String.IsNullOrEmpty(lnreg.Text))&&
                (!String.IsNullOrEmpty(pnreg.Text))&& (!String.IsNullOrEmpty(psreg.Text))&& (!String.IsNullOrEmpty(uregpass.Text))&&
                (!String.IsNullOrEmpty(checkps.Text)))
            {
                if (pnreg.Text.Length == 11)
                {
                    if (checkps.Text == psreg.Text)
                    {
                        
                        sqlcon.Open();
                        sqlcmd.Connection = sqlcon;
                        sqlcmd.CommandText = "Select * from cust_table where u_id ='" + uregpass.Text + "';";
                        sqldr = sqlcmd.ExecuteReader();
                        if (sqldr.HasRows)
                        {
                            sqlcon.Close();
                            MessageBox.Show("The user ID is already taken", "UserID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            sqlcon.Close();
                            sqlcon.Open();
                            sqlcmd.CommandText = "INSERT INTO cust_table values('" + uregpass.Text + "','" + fnreg.Text + "','" + lnreg.Text + "','" + pnreg.Text + "','" + psreg.Text + "');";
                            sqlcmd.CommandType = CommandType.Text;
                            sqlcmd.Connection = sqlcon;
                            sqlcmd.ExecuteNonQuery();
                            sqlcon.Close();
                            MessageBox.Show("Record is now saved in the Database!", "Record Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            userlog openlog = new userlog();
                            this.Hide();
                            openlog.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Your password and confirm password do not match!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a valid phone number", "Phone Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all required fields!", "Account creation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userlog openulog = new userlog();
            
            openulog.Show();
            this.Hide();
        }

        

        

        private void pnreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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
