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
    public partial class checkin : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqldr;
        String roomtype1;
        public checkin()
        {
            InitializeComponent();
        }
        private void checkin_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true; datein.MinDate = DateTime.Now;
            dateout.MinDate = DateTime.Now.AddDays(1);
            setcheckin();
            setreserve();
        }
        
        void setcheckin()
        {
            citable.Items.Clear();
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from checkin_table";
            sqlcmd.Connection = sqlcon;
            sqldr = sqlcmd.ExecuteReader();

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
                citable.Items.Add(lv);
            }
            sqlcon.Close();
        }
        
        void setreserve()
        {
            restable.Items.Clear();
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from reservation_table";
            sqlcmd.Connection = sqlcon;
            sqldr = sqlcmd.ExecuteReader();

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
                restable.Items.Add(lv);
            }
            sqlcon.Close();
        }
        void inserttocheckindb()
        {
            sqlcon.Close();
            sqlcon.Open();
            sqlcmd.CommandText = "INSERT INTO checkin_table values('" + showuid.Text + "'," + Convert.ToInt32(rn1.SelectedItem) + ",'" +
                rt.SelectedItem + "'," + Convert.ToInt32(rr.Text) + "," + Convert.ToInt32(gcount.SelectedItem) + ",'"+datein.Value.ToString("MM/dd/yyyy HH:mm:ss") +"','"+
                dateout.Value.ToString("MM/dd/yyyy")+"','"+pt.SelectedItem.ToString()+"',"+ Convert.ToInt32(pp.Text)+");";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlcon;
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Update room_table set availability= 'UNAVAILABLE' where room_num=" + Convert.ToInt32(rn1.SelectedItem) + ";";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            setrooms();
            
            
            MessageBox.Show("The user is now Checked-in the hotel room!", "Record Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void inserttocheckindb2() 
        {
            sqlcon.Open();
            ListViewItem items = restable.SelectedItems[0];

            DateTime dateinconv, dateoutconv;

            dateinconv = DateTime.Parse(items.SubItems[5].Text);
            dateoutconv = DateTime.Parse(items.SubItems[6].Text);
            String uid, rn, rt, rr, g, ci, co, pt, pp;
            uid = items.SubItems[0].Text;
            rn = items.SubItems[1].Text;
            rt = items.SubItems[2].Text;
            rr = items.SubItems[3].Text;
            g = items.SubItems[4].Text;
            ci = dateinconv.ToString("MM/dd/yyyy");
            co = dateoutconv.ToString("MM/dd/yyyy");
            pt = items.SubItems[7].Text;
            pp = items.SubItems[8].Text;

            sqlcmd.CommandText = "INSERT INTO checkin_table values('" + uid + "'," + Convert.ToInt32(rn) + ",'" +
                rt + "'," + Convert.ToInt32(rr) + "," + Convert.ToInt32(g) + ",'" +
                ci + " " + DateTime.Now.ToString("HH:MM:ss")+"','" + co + "','" + pt + "'," + Convert.ToInt32(pp) + ");";
           
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlcon;
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Delete from reservation_table where user_id='" + uid + "';";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Update room_table set availability='UNAVAILABLE' where room_num=" + Convert.ToInt32(rn) + ";";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();

            setcheckin();
            setreserve();
            MessageBox.Show("Record is now saved in the Database!", "Record Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        void removeroom()
        {
            ListViewItem items = restable.SelectedItems[0];

            DateTime dateinconv, dateoutconv;

            dateinconv = DateTime.Parse(items.SubItems[5].Text);
            dateoutconv = DateTime.Parse(items.SubItems[6].Text);
            String uid, rn, rt, rr, g, ci, co, pt, pp;
            uid = items.SubItems[0].Text;
            rn = items.SubItems[1].Text;
            rt = items.SubItems[2].Text;
            rr = items.SubItems[3].Text;
            g = items.SubItems[4].Text;
            ci = dateinconv.ToString("MM/dd/yyyy");
            co = dateoutconv.ToString("MM/dd/yyyy");
            pt = items.SubItems[7].Text;
            pp = items.SubItems[8].Text;
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Delete from reservation_table where user_id='" + uid + "';";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            setcheckin();
            setreserve();
        }
        
        void setrooms()
        {
            rn1.Items.Clear();
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from room_table where room_type = '" + rt.SelectedItem + "' and availability = 'AVAILABLE';";
            sqldr = sqlcmd.ExecuteReader();

            while (sqldr.Read())
            {
                rn1.Items.Add(sqldr[0].ToString());
            }
            sqlcon.Close();
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select checkinDate,checkoutDate, room_num from checkin_table where room_type ='" + rt.SelectedItem + "';";
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
            sqlcmd.CommandText = "Select checkin,checkout, room_num from reservation_table where room_type ='" + rt.SelectedItem + "';";
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
        private void rt_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomtype1 = rt.SelectedItem.ToString();
            setrooms();
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select rate,occupancy from room_table where room_type = '" + rt.SelectedItem + "';";
            sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
            {
                rr.Text = sqldr[0].ToString();
                if (sqldr[1].ToString() == "1")
                {
                    gcount.Items.Clear();
                    gcount.Items.Add(1);
                }
                if (sqldr[1].ToString() == "2")
                {
                    gcount.Items.Clear();
                    gcount.Items.Add(1);
                    gcount.Items.Add(2);
                }
                if (sqldr[1].ToString() == "3")
                {
                    gcount.Items.Clear();
                    gcount.Items.Add(1);
                    gcount.Items.Add(2);
                    gcount.Items.Add(3);
                }
                if (sqldr[1].ToString() == "4")
                {
                    gcount.Items.Clear();
                    gcount.Items.Add(1);
                    gcount.Items.Add(2);
                    gcount.Items.Add(3);
                    gcount.Items.Add(4);
                }
            }
            sqlcon.Close();
            
        }

        private void datein_ValueChanged(object sender, EventArgs e)
        {
            dateout.MinDate = datein.Value.Date.AddDays(1);
            rn1.Items.Clear();
            setrooms();
        }

        private void pt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pt.SelectedIndex == 0)
            {
                pp.Text = "200";
            }
            if (pt.SelectedIndex == 1)
            {
                pp.Text = "1500";
            }
        }

        private void dateout_ValueChanged(object sender, EventArgs e)
        {
            rn1.Items.Clear();
            setrooms();
        }

        private void checkinnewguest_Click(object sender, EventArgs e)
        {
            if((!String.IsNullOrEmpty(showuid.Text))&& (!String.IsNullOrEmpty(pp.Text))&&(!String.IsNullOrEmpty(rr.Text))&&
                (gcount.SelectedIndex!=-1)&&(rt.SelectedIndex!=-1)&& (pt.SelectedIndex != -1)&&(rn1.SelectedIndex !=-1))
            {
                sqlcon.Open();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "Select * from cust_table where u_id = '" + showuid.Text + "';";
                sqldr = sqlcmd.ExecuteReader();
                if (sqldr.HasRows)
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "Select * from checkin_table where user_id = '" + showuid.Text + "';";
                    sqldr = sqlcmd.ExecuteReader();
                    if (sqldr.HasRows)
                    {
                        sqlcon.Close();
                        MessageBox.Show("The user is already checked-in a hotel room", "Check-in Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sqlcon.Close();
                        sqlcon.Open();
                        sqlcmd.Connection = sqlcon;
                        sqlcmd.CommandText = "Select * from reservation_table where user_id = '" + showuid.Text + "';";
                        sqldr = sqlcmd.ExecuteReader();
                        if (sqldr.HasRows)
                        {
                            sqlcon.Close();
                            MessageBox.Show("The user is already reserved! Cannot check-in user that is already reserved", "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            inserttocheckindb();
                            setcheckin();
                            
                        }
                    }
                }
            }
            else
            {
                sqlcon.Close();
                MessageBox.Show("Please fill all the required fields!", "Check-in Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }

        private void checkinreserve_Click(object sender, EventArgs e)
        {
            if (restable.SelectedItems.Count != 0)
            {
                ListViewItem checksuid = restable.SelectedItems[0];
                String checkuid;
                checkuid = checksuid.SubItems[0].Text;
                sqlcon.Open();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "Select * from reservation_table where user_id = '" + checkuid + "';";
                sqldr = sqlcmd.ExecuteReader();
                sqldr.Read();
                if ((DateTime.Now.Date == DateTime.Parse(sqldr[5].ToString()).Date) && (DateTime.Now.Date <= DateTime.Parse(sqldr[6].ToString()).Date))
                {
                    sqlcon.Close();
                    inserttocheckindb2();
                }
                else if (DateTime.Now.Date > DateTime.Parse(sqldr[5].ToString()).Date)
                {
                    MessageBox.Show("Too late for an official check-in. Guest reservation was officially cancelled!", "Guest Check-in Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqlcon.Close();
                    removeroom();
                }
                else if(DateTime.Now.Date <= DateTime.Parse(sqldr[5].ToString()).Date)
                {
                    sqlcon.Close();
                    MessageBox.Show("Check-in is too early for intended check-in date!", "Guest Check-in Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }else if(DateTime.Now.Date <= DateTime.Parse(sqldr[6].ToString()).Date)
                {
                    sqlcon.Close();
                    removeroom();
                    MessageBox.Show("Too late for an official check-in. Guest reservation was officially cancelled!", "Guest Check-in Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Please select a record in the table to officially check in", "Guest Check-in Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void restable_SelectedIndexChanged(object sender, EventArgs e)
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
