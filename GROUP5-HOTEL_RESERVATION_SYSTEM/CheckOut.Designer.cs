
namespace GROUP5_HOTEL_RESERVATION_SYSTEM
{
    partial class CheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkinreserve = new System.Windows.Forms.Button();
            this.citable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 707);
            this.panel1.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.lclosebent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1077, -1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 105);
            this.button7.TabIndex = 90;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.checkinreserve);
            this.panel2.Controls.Add(this.citable);
            this.panel2.Location = new System.Drawing.Point(42, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 569);
            this.panel2.TabIndex = 0;
            // 
            // checkinreserve
            // 
            this.checkinreserve.BackColor = System.Drawing.Color.Transparent;
            this.checkinreserve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkinreserve.BackgroundImage")));
            this.checkinreserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkinreserve.FlatAppearance.BorderSize = 0;
            this.checkinreserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinreserve.Location = new System.Drawing.Point(413, 481);
            this.checkinreserve.Name = "checkinreserve";
            this.checkinreserve.Size = new System.Drawing.Size(250, 74);
            this.checkinreserve.TabIndex = 89;
            this.checkinreserve.UseVisualStyleBackColor = false;
            this.checkinreserve.Click += new System.EventHandler(this.checkinreserve_Click);
            // 
            // citable
            // 
            this.citable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.citable.Dock = System.Windows.Forms.DockStyle.Top;
            this.citable.FullRowSelect = true;
            this.citable.GridLines = true;
            this.citable.HideSelection = false;
            this.citable.Location = new System.Drawing.Point(0, 0);
            this.citable.MultiSelect = false;
            this.citable.Name = "citable";
            this.citable.Size = new System.Drawing.Size(1089, 460);
            this.citable.TabIndex = 3;
            this.citable.UseCompatibleStateImageBehavior = false;
            this.citable.View = System.Windows.Forms.View.Details;
            this.citable.SelectedIndexChanged += new System.EventHandler(this.citable_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "USER ID";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ROOM NUMBER";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ROOM TYPE";
            this.columnHeader3.Width = 308;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ROOM RATE";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "GUESTS";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CHECK-IN DATE";
            this.columnHeader6.Width = 121;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CHECK-OUT DATE";
            this.columnHeader7.Width = 126;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "PACKAGE TYPE";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "PACKAGE RATE";
            this.columnHeader9.Width = 191;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 707);
            this.Controls.Add(this.panel1);
            this.Name = "CheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView citable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button checkinreserve;
        private System.Windows.Forms.Button button7;
    }
}