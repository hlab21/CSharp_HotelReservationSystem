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
    public partial class CheckOut : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqldr;
        public static int transac, total, overstayingfee;
        public static String uid, rn, rt, rr, g, ci, co, pt, pp;

        private void button7_Click(object sender, EventArgs e)
        {
            adminmodule openmod = new adminmodule();
            this.Hide();
            openmod.Show();
        }

        public static DateTime dateinconv, dateoutconv;
        public static double days, overstayingdays;
        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            setcheckin();
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
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
        void checkout()
        {
            sqlcon.Open();
            ListViewItem items = citable.SelectedItems[0];
            dateinconv = DateTime.Parse(items.SubItems[5].Text);
            dateoutconv = DateTime.Parse(items.SubItems[6].Text);
            uid = items.SubItems[0].Text;
            rn = items.SubItems[1].Text;
            rt = items.SubItems[2].Text;
            rr = items.SubItems[3].Text;
            g = items.SubItems[4].Text;
            ci = dateinconv.ToString("MM/dd/yyyy HH:MM:ss");
            co = dateoutconv.ToString("MM/dd/yyyy");
            pt = items.SubItems[7].Text;
            pp = items.SubItems[8].Text;
            days = (dateoutconv.Date - dateinconv.Date).TotalDays;
            total = (Convert.ToInt32(rr.ToString()) + Convert.ToInt32(pp.ToString())) * Convert.ToInt32(days);
            sqlcon.Close();
            
            if (DateTime.Now.Date > dateoutconv.Date)
            {
                uid = items.SubItems[0].Text;
                rn = items.SubItems[1].Text;
                rt = items.SubItems[2].Text;
                rr = items.SubItems[3].Text;
                g = items.SubItems[4].Text;
                ci = dateinconv.ToString("MM/dd/yyyy HH:MM:ss");
                co = dateoutconv.ToString("MM/dd/yyyy");
                pt = items.SubItems[7].Text;
                pp = items.SubItems[8].Text;
                overstayingdays = (DateTime.Now.Date - dateoutconv.Date).TotalDays;
                overstayingfee = (Convert.ToInt32(rr.ToString()) + Convert.ToInt32(pp.ToString())) * (Convert.ToInt32(overstayingdays));
                total = (Convert.ToInt32(rr.ToString()) + Convert.ToInt32(pp.ToString())) * Convert.ToInt32(days);
                total += Convert.ToInt32(overstayingfee);
                days += Convert.ToInt32(overstayingdays);
                checkoutconfirm opencoc = new checkoutconfirm();
                this.Hide();
                opencoc.Show();
            }
            else
            {

                uid = items.SubItems[0].Text;
                rn = items.SubItems[1].Text;
                rt = items.SubItems[2].Text;
                rr = items.SubItems[3].Text;
                g = items.SubItems[4].Text;
                ci = dateinconv.ToString("MM/dd/yyyy HH:MM:ss");
                co = dateoutconv.ToString("MM/dd/yyyy");
                pt = items.SubItems[7].Text;
                pp = items.SubItems[8].Text;
                overstayingfee = 0;
                overstayingdays = 0;
                total = (Convert.ToInt32(rr.ToString()) + Convert.ToInt32(pp.ToString())) * Convert.ToInt32(days);
                total += Convert.ToInt32(overstayingfee);
                days += Convert.ToInt32(overstayingdays);
                checkoutconfirm opencoc = new checkoutconfirm();
                this.Hide();
                opencoc.Show();
            }


        }

        private void checkinreserve_Click(object sender, EventArgs e)
        {
            checkout();
        }

        private void citable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
