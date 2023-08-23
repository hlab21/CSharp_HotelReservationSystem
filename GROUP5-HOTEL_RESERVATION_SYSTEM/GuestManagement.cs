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
    
    public partial class GuestManagement : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqldr;
        public GuestManagement()
        {
            InitializeComponent();
        }


        private void GuestManagement_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            setguests();
        }
        void setguests()
        {
            showguest.Items.Clear();
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from cust_table";
            sqlcmd.Connection = sqlcon;
            sqldr = sqlcmd.ExecuteReader();
            
            while (sqldr.Read())
            {
                ListViewItem lv = new ListViewItem(sqldr[0].ToString());
                lv.SubItems.Add(sqldr[1].ToString());
                lv.SubItems.Add(sqldr[2].ToString());
                lv.SubItems.Add(sqldr[3].ToString());
                showguest.Items.Add(lv);
            }
            sqlcon.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(guestreg.Text)) && (!String.IsNullOrEmpty(firstnamead.Text)) && (!String.IsNullOrEmpty(lastnamead.Text)) &&
                (!String.IsNullOrEmpty(phonenumad.Text)) && (!String.IsNullOrEmpty(passwordad.Text)))
            {
                if (phonenumad.Text.Length == 11)
                {
                        sqlcon.Open();
                        sqlcmd.Connection = sqlcon;
                        sqlcmd.CommandText = "Select * from cust_table where u_id ='" + guestreg.Text + "';";
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
                            sqlcmd.CommandText = "INSERT INTO cust_table values('" + guestreg.Text + "','" + firstnamead.Text + "','" + lastnamead.Text + "','" + phonenumad.Text + "','" + passwordad.Text + "');";
                            sqlcmd.CommandType = CommandType.Text;
                            sqlcmd.Connection = sqlcon;
                            sqlcmd.ExecuteNonQuery();
                            sqlcon.Close();
                            MessageBox.Show("Record is now saved in the Database!", "Record Save", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
            setguests();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminmodule openadmod = new adminmodule();
            this.Hide();
            openadmod.Show();
        }

        private void showguest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void passwordad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            adminmodule openmod = new adminmodule();
            this.Hide();
            openmod.Show();
        }
    }
}
