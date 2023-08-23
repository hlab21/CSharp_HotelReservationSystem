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
    public partial class VIEWROOMS : Form
    {
        public VIEWROOMS()
        {
            InitializeComponent();
        }

        

        

        private void VIEWROOMS_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            vr.SelectedTab = tab1;
        }


        private void metroTabControl1_CustomPaintBackground(object sender, MetroFramework.Drawing.MetroPaintEventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            usermodule openmod = new usermodule();
            this.Hide();
            openmod.Show();
        }
    }
}
