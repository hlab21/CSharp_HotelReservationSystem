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
    public partial class avail_rooms : Form
    {
        public avail_rooms()
        {
            InitializeComponent();
        }

        private void avail_rooms_Load(object sender, EventArgs e)
        {
            vr.SelectedTab = metroTabPage1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            usermodule openmod = new usermodule();
            this.Hide();
            openmod.Show();
        }
    }
}
