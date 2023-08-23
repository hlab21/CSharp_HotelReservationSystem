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
    public partial class checkoutconfirm : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost; uid=root; pwd=''; database=hotel_reservation_db");
        MySqlCommand sqlcmd = new MySqlCommand();
        public static int change;
        public static String uid, rn, rt, rr, g, ci, co, pt, pp, dmgfee, dateinconv, dateoutconv,days, offee,total, tp, tc;

        private void cop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckOut openmod = new CheckOut();
            this.Hide();
            openmod.Show();
        }

        public checkoutconfirm()
        {
            InitializeComponent();
        }

        void roomsetavail()
        {
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Update room_table set availability= 'AVAILABLE' where room_num=" + Convert.ToInt32(corn.Text) + ";";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
        }
        void insertolog()
        {
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "INSERT INTO log_table values(default,'" + CheckOut.uid + "'," + Convert.ToInt32(CheckOut.rn) + ",'" +
                CheckOut.rt + "'," + Convert.ToInt32(CheckOut.rr) + "," + Convert.ToInt32(CheckOut.g) + ",'" +
                CheckOut.ci + "','" + CheckOut.co + " " + DateTime.Now.ToString("HH:MM:ss") + "','" + CheckOut.pt + "'," + Convert.ToInt32(CheckOut.pp) + ","
                + CheckOut.days + "," + CheckOut.total + ");";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlcon;
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Delete from checkin_table where user_id='" + CheckOut.uid + "';";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            roomsetavail();

            MessageBox.Show("Record is now saved in the Database!", "Record Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void checkoutconfirm_Load(object sender, EventArgs e)
        {
            coid.Text = CheckOut.uid;
            corn.Text = CheckOut.rn;
            cort.Text = CheckOut.rt;
            corr.Text = CheckOut.rr;
            corg.Text = CheckOut.g;
            coci.Text = CheckOut.dateinconv.ToString("MM/dd/yyyy");
            coco.Text = CheckOut.dateoutconv.ToString("MM/dd/yyyy");
            copt.Text = CheckOut.pt;
            copp.Text = CheckOut.pp;
            coof.Text = CheckOut.overstayingfee.ToString();
            cot.Text = CheckOut.total.ToString();
            codays.Text = CheckOut.days.ToString();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                cod.Text = "500";
                dmgfee = "500";
            }
            else
            {
                cod.Text = "0";
                dmgfee = "0";
            }
        }

        private void checkinreserve_Click(object sender, EventArgs e)
        {
            if (cop.Text.Equals(""))
            {
                MessageBox.Show("Please input a valid cash!", "Insufficient Cash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(cop.Text.ToString()) >= Convert.ToInt32(cot.Text.ToString()))
            {
                int change = Convert.ToInt32(cop.Text) - Convert.ToInt32(cot.Text);
                uid = coid.Text;
                rn = corn.Text;
                rt = cort.Text;
                rr = corr.Text;
                g = corg.Text;
                dateinconv = coci.Text;
                dateoutconv = coco.Text;
                days = codays.Text;
                pt = copt.Text;
                pp = copp.Text;
                offee = coof.Text;
                dmgfee = cod.Text;
                total = cot.Text;
                tp = cop.Text;
                tc = change.ToString(); ;
                insertolog();
                CheckOutSummary openreceipt1 = new CheckOutSummary();
                this.Hide();
                openreceipt1.Show();

            }
            
            
        }

        private void coid_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void cod_TextChanged(object sender, EventArgs e)
        {
            if(cod.Text == "500")
            {
                CheckOut.total += 500;
                cot.Text = CheckOut.total.ToString();
            }
            if (cod.Text == "0")
            {
                CheckOut.total -= 500;
                cot.Text = CheckOut.total.ToString();
            }
        }
    }
}
