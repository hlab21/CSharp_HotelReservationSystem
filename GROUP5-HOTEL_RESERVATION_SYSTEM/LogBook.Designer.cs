
namespace GROUP5_HOTEL_RESERVATION_SYSTEM
{
    partial class LogBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.transac_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.room_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.room_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.room_rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkindate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkoutdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.packagety = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.packagerate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totaldays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button7 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(32, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 549);
            this.panel2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.transac_id,
            this.user_id,
            this.room_num,
            this.room_type,
            this.room_rate,
            this.guest,
            this.checkindate,
            this.checkoutdate,
            this.packagety,
            this.packagerate,
            this.totaldays,
            this.total});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1708, 549);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // transac_id
            // 
            this.transac_id.DisplayIndex = 11;
            this.transac_id.Text = "Transaction ID:";
            this.transac_id.Width = 117;
            // 
            // user_id
            // 
            this.user_id.DisplayIndex = 0;
            this.user_id.Text = "USER ID:";
            this.user_id.Width = 128;
            // 
            // room_num
            // 
            this.room_num.DisplayIndex = 1;
            this.room_num.Text = "ROOM NUMBER";
            this.room_num.Width = 156;
            // 
            // room_type
            // 
            this.room_type.DisplayIndex = 2;
            this.room_type.Text = "ROOM TYPE";
            this.room_type.Width = 262;
            // 
            // room_rate
            // 
            this.room_rate.DisplayIndex = 3;
            this.room_rate.Text = "ROOM RATE";
            this.room_rate.Width = 121;
            // 
            // guest
            // 
            this.guest.DisplayIndex = 4;
            this.guest.Text = "GUESTS";
            this.guest.Width = 88;
            // 
            // checkindate
            // 
            this.checkindate.DisplayIndex = 5;
            this.checkindate.Text = "CHECK-IN DATE";
            this.checkindate.Width = 189;
            // 
            // checkoutdate
            // 
            this.checkoutdate.DisplayIndex = 6;
            this.checkoutdate.Text = "CHECK-OUT DATE";
            this.checkoutdate.Width = 158;
            // 
            // packagety
            // 
            this.packagety.DisplayIndex = 7;
            this.packagety.Text = "PACKAGE TYPE";
            this.packagety.Width = 140;
            // 
            // packagerate
            // 
            this.packagerate.DisplayIndex = 8;
            this.packagerate.Text = "PACKAGE RATE";
            this.packagerate.Width = 123;
            // 
            // totaldays
            // 
            this.totaldays.Text = "NO. OF DAYS";
            this.totaldays.Width = 129;
            // 
            // total
            // 
            this.total.DisplayIndex = 9;
            this.total.Text = "TOTAL ";
            this.total.Width = 92;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.lclosebent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(761, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 90);
            this.button7.TabIndex = 77;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // LogBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.llogbook;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 680);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "LogBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogBook";
            this.Load += new System.EventHandler(this.LogBook_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader transac_id;
        private System.Windows.Forms.ColumnHeader user_id;
        private System.Windows.Forms.ColumnHeader room_num;
        private System.Windows.Forms.ColumnHeader room_type;
        private System.Windows.Forms.ColumnHeader room_rate;
        private System.Windows.Forms.ColumnHeader guest;
        private System.Windows.Forms.ColumnHeader checkindate;
        private System.Windows.Forms.ColumnHeader checkoutdate;
        private System.Windows.Forms.ColumnHeader packagety;
        private System.Windows.Forms.ColumnHeader packagerate;
        private System.Windows.Forms.ColumnHeader totaldays;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.Button button7;
    }
}