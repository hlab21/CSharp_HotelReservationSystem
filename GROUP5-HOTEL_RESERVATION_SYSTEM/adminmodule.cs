using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP5_HOTEL_RESERVATION_SYSTEM
{
    public partial class adminmodule : Form
    {
        public adminmodule()
        {
            InitializeComponent();
        }

        private void adminmodule_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            dispadid.Text = adminlog.adid;
            dispadname.Text = adminlog.adname;
            disppn.Text = adminlog.adphonenum;
        }

        private void vr_Click(object sender, EventArgs e)
        {
            GuestManagement opengm = new GuestManagement();
            this.Hide();
            opengm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RoomManagement openrm = new RoomManagement();
            this.Hide();
            openrm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkin opencheckinform = new checkin();
            this.Hide();
            opencheckinform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckOut opencheckout = new CheckOut();
            this.Hide();
            opencheckout.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogBook openlog = new LogBook();
            this.Hide();
            openlog.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult closeconfirm = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo);
            if (closeconfirm == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminlog openadlog = new adminlog();
            this.Hide();
            openadlog.Show();
        }
    }
}
