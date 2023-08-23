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
    public partial class editpass : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqldr;
        public editpass()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if((!String.IsNullOrEmpty(oldpass.Text))&& (!String.IsNullOrEmpty(newpass.Text)) && (!String.IsNullOrEmpty(cnewpass.Text)))
            {
                sqlcon.Open();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "Select * from cust_table where u_id ='" + userlog.uid + "';";
                sqldr = sqlcmd.ExecuteReader();
                if (sqldr.HasRows)
                {
                    sqldr.Read();
                    if (sqldr[4].ToString() == oldpass.Text)
                    {
                        if (newpass.Text == cnewpass.Text)
                        {
                            sqlcon.Close();
                            sqlcon.Open();
                            sqlcmd.Connection = sqlcon;
                            sqlcmd.CommandText = "UPDATE cust_table set pass ='" + newpass.Text + "' where u_id ='" + userlog.uid + "';";
                            sqlcmd.CommandType = CommandType.Text;
                            sqlcmd.ExecuteNonQuery();
                            sqlcon.Close();
                            DialogResult closeeditpass = MessageBox.Show("Successfully updated the password", "Password updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sqlcon.Close();
                            if (closeeditpass == DialogResult.OK)
                            {
                                usermodule setumain = new usermodule();
                                this.Hide();
                                setumain.Show();
                            }

                        }
                        else
                        {
                            MessageBox.Show("New password and confirm password does not match!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            sqlcon.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Old password is incorrect!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlcon.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all required fields!", "Edit tPassword Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void editpass_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usermodule setumain = new usermodule();
            this.Hide();
            setumain.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            usermodule openmod = new usermodule();
            this.Hide();
            openmod.Show();
        }
    }
}
