
namespace GROUP5_HOTEL_RESERVATION_SYSTEM
{
    partial class VIEWROOMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIEWROOMS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.vr = new MetroFramework.Controls.MetroTabControl();
            this.tab1 = new MetroFramework.Controls.MetroTabPage();
            this.tab2 = new MetroFramework.Controls.MetroTabPage();
            this.tab3 = new MetroFramework.Controls.MetroTabPage();
            this.tab4 = new MetroFramework.Controls.MetroTabPage();
            this.tab5 = new MetroFramework.Controls.MetroTabPage();
            this.panel1.SuspendLayout();
            this.vr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.vr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 941);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.lVIEWROOMS;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(95, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 96);
            this.button1.TabIndex = 64;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.lclosebent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(556, -2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 68);
            this.button7.TabIndex = 63;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // vr
            // 
            this.vr.Controls.Add(this.tab2);
            this.vr.Controls.Add(this.tab3);
            this.vr.Controls.Add(this.tab1);
            this.vr.Controls.Add(this.tab4);
            this.vr.Controls.Add(this.tab5);
            this.vr.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.vr.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.vr.Location = new System.Drawing.Point(15, 100);
            this.vr.Name = "vr";
            this.vr.SelectedIndex = 4;
            this.vr.Size = new System.Drawing.Size(589, 823);
            this.vr.Style = MetroFramework.MetroColorStyle.Purple;
            this.vr.TabIndex = 0;
            this.vr.UseCustomBackColor = true;
            this.vr.UseCustomForeColor = true;
            this.vr.UseSelectable = true;
            this.vr.CustomPaintBackground += new System.EventHandler<MetroFramework.Drawing.MetroPaintEventArgs>(this.metroTabControl1_CustomPaintBackground);
            // 
            // tab1
            // 
            this.tab1.BackColor = System.Drawing.Color.LavenderBlush;
            this.tab1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab1.BackgroundImage")));
            this.tab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tab1.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.HorizontalScrollbarBarColor = true;
            this.tab1.HorizontalScrollbarHighlightOnWheel = false;
            this.tab1.HorizontalScrollbarSize = 10;
            this.tab1.Location = new System.Drawing.Point(4, 35);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(581, 784);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "ROOM 1";
            this.tab1.VerticalScrollbarBarColor = true;
            this.tab1.VerticalScrollbarHighlightOnWheel = false;
            this.tab1.VerticalScrollbarSize = 10;
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.LavenderBlush;
            this.tab2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab2.BackgroundImage")));
            this.tab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tab2.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2.HorizontalScrollbarBarColor = true;
            this.tab2.HorizontalScrollbarHighlightOnWheel = false;
            this.tab2.HorizontalScrollbarSize = 10;
            this.tab2.Location = new System.Drawing.Point(4, 44);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(581, 775);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "ROOM 2";
            this.tab2.VerticalScrollbarBarColor = true;
            this.tab2.VerticalScrollbarHighlightOnWheel = false;
            this.tab2.VerticalScrollbarSize = 10;
            // 
            // tab3
            // 
            this.tab3.AutoScroll = true;
            this.tab3.BackColor = System.Drawing.Color.LavenderBlush;
            this.tab3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab3.BackgroundImage")));
            this.tab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tab3.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab3.HorizontalScrollbar = true;
            this.tab3.HorizontalScrollbarBarColor = true;
            this.tab3.HorizontalScrollbarHighlightOnWheel = false;
            this.tab3.HorizontalScrollbarSize = 10;
            this.tab3.Location = new System.Drawing.Point(4, 44);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(581, 775);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "ROOM 3";
            this.tab3.VerticalScrollbar = true;
            this.tab3.VerticalScrollbarBarColor = true;
            this.tab3.VerticalScrollbarHighlightOnWheel = false;
            this.tab3.VerticalScrollbarSize = 10;
            // 
            // tab4
            // 
            this.tab4.BackColor = System.Drawing.Color.LavenderBlush;
            this.tab4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab4.BackgroundImage")));
            this.tab4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tab4.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab4.HorizontalScrollbarBarColor = true;
            this.tab4.HorizontalScrollbarHighlightOnWheel = false;
            this.tab4.HorizontalScrollbarSize = 10;
            this.tab4.Location = new System.Drawing.Point(4, 35);
            this.tab4.Name = "tab4";
            this.tab4.Size = new System.Drawing.Size(581, 784);
            this.tab4.TabIndex = 3;
            this.tab4.Text = "ROOM 4";
            this.tab4.VerticalScrollbarBarColor = true;
            this.tab4.VerticalScrollbarHighlightOnWheel = false;
            this.tab4.VerticalScrollbarSize = 10;
            // 
            // tab5
            // 
            this.tab5.BackColor = System.Drawing.Color.LavenderBlush;
            this.tab5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab5.BackgroundImage")));
            this.tab5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tab5.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab5.HorizontalScrollbarBarColor = true;
            this.tab5.HorizontalScrollbarHighlightOnWheel = false;
            this.tab5.HorizontalScrollbarSize = 10;
            this.tab5.Location = new System.Drawing.Point(4, 44);
            this.tab5.Name = "tab5";
            this.tab5.Size = new System.Drawing.Size(581, 775);
            this.tab5.TabIndex = 4;
            this.tab5.Text = "ROOM 5";
            this.tab5.VerticalScrollbarBarColor = true;
            this.tab5.VerticalScrollbarHighlightOnWheel = false;
            this.tab5.VerticalScrollbarSize = 10;
            // 
            // VIEWROOMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 941);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VIEWROOMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIEWROOMS";
            this.Load += new System.EventHandler(this.VIEWROOMS_Load);
            this.panel1.ResumeLayout(false);
            this.vr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl vr;
        private MetroFramework.Controls.MetroTabPage tab2;
        private MetroFramework.Controls.MetroTabPage tab3;
        private MetroFramework.Controls.MetroTabPage tab5;
        private MetroFramework.Controls.MetroTabPage tab1;
        private MetroFramework.Controls.MetroTabPage tab4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
    }
}