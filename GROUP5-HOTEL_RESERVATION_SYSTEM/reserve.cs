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
    public partial class reserve : Form
    {
        public static string uid1, guests;
        public static int guestcount;
        public static DateTime datein1, dateout1;
        public static reserve savereserve;
        public reserve()
        {
            InitializeComponent();
        }

        private void reserve_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            uid.Text = userlog.uid;
            datein.MinDate = DateTime.Now;
            dateout.MinDate = DateTime.Now;
            rtdisp.Text = viewroomtype.rtype;
            packdisp.Text = viewroomtype.package;
            uid.Focus();
            if(viewroomtype.guestcount == 4)
            {
                gc.Items.Add(1);
                gc.Items.Add(2);
                gc.Items.Add(3);
                gc.Items.Add(4);
            }
            else if(viewroomtype.guestcount == 3)
            {
                gc.Items.Add(1);
                gc.Items.Add(2);
                gc.Items.Add(3);  
            }
            else if (viewroomtype.guestcount == 2)
            {
                gc.Items.Add(1);
                gc.Items.Add(2);

            }
            else if (viewroomtype.guestcount == 1)
            {
                gc.Items.Add(1);
            }
        }

        private void datein_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void datein_ValueChanged(object sender, EventArgs e)
        {
            dateout.MinDate = datein.Value.Date.AddDays(1);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateout_ValueChanged(object sender, EventArgs e)
        {

        }

        private void uid_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            savereserve = this;
            datein1 = datein.Value.Date;
            guestcount = Convert.ToInt32(gc.Text);
            dateout1 = dateout.Value.Date;
        }
    }
}
