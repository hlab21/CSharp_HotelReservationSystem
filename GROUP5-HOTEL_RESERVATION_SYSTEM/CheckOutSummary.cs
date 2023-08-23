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
    public partial class CheckOutSummary : Form
    {
        public CheckOutSummary()
        {
            InitializeComponent();
        }

        private void CheckOutSummary_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true; pid.Text = checkoutconfirm.uid;
            prn.Text = checkoutconfirm.rn; 
            prt.Text = checkoutconfirm.rt;
            pg.Text = checkoutconfirm.g;
            pci.Text = checkoutconfirm.dateinconv;
            pco.Text = checkoutconfirm.dateoutconv;
            prf.Text = checkoutconfirm.rr;
            ppf.Text = checkoutconfirm.pp;
            pdf.Text = checkoutconfirm.dmgfee;
            pof.Text = checkoutconfirm.offee;
            ptot.Text = checkoutconfirm.total;
            pcp.Text = checkoutconfirm.tp;
            pcc.Text = checkoutconfirm.tc;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckOut openmod = new CheckOut();
            this.Hide();
            openmod.Show();
        }
    }
}
