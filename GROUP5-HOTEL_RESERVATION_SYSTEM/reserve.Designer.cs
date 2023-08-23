
namespace GROUP5_HOTEL_RESERVATION_SYSTEM
{
    partial class reserve
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateout = new System.Windows.Forms.DateTimePicker();
            this.datein = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtdisp = new System.Windows.Forms.Label();
            this.packdisp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.formbg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.packdisp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.rtdisp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.gc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateout);
            this.panel1.Controls.Add(this.datein);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.uid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 529);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.cfar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(45, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 65);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 58);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // gc
            // 
            this.gc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gc.Font = new System.Drawing.Font("BigNoodleTitling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc.FormattingEnabled = true;
            this.gc.Location = new System.Drawing.Point(192, 393);
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(87, 38);
            this.gc.TabIndex = 24;
            this.gc.SelectedIndexChanged += new System.EventHandler(this.gc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("LEMON MILK Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 38);
            this.label5.TabIndex = 22;
            this.label5.Text = "Guests:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateout
            // 
            this.dateout.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateout.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateout.Font = new System.Drawing.Font("BigNoodleTitling", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateout.Location = new System.Drawing.Point(192, 337);
            this.dateout.Name = "dateout";
            this.dateout.Size = new System.Drawing.Size(274, 28);
            this.dateout.TabIndex = 19;
            this.dateout.ValueChanged += new System.EventHandler(this.dateout_ValueChanged);
            this.dateout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datein_KeyDown);
            // 
            // datein
            // 
            this.datein.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.datein.CalendarTitleForeColor = System.Drawing.Color.White;
            this.datein.Font = new System.Drawing.Font("BigNoodleTitling", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datein.Location = new System.Drawing.Point(192, 272);
            this.datein.Name = "datein";
            this.datein.Size = new System.Drawing.Size(274, 28);
            this.datein.TabIndex = 18;
            this.datein.ValueChanged += new System.EventHandler(this.datein_ValueChanged);
            this.datein.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datein_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("LEMON MILK Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 38);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date Out:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("LEMON MILK Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 38);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date In:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // uid
            // 
            this.uid.AutoSize = true;
            this.uid.BackColor = System.Drawing.Color.Transparent;
            this.uid.Font = new System.Drawing.Font("LEMON MILK Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uid.ForeColor = System.Drawing.Color.White;
            this.uid.Location = new System.Drawing.Point(166, 89);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(148, 38);
            this.uid.TabIndex = 15;
            this.uid.Text = "User_ID:";
            this.uid.Click += new System.EventHandler(this.uid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("LEMON MILK Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "User ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("LEMON MILK Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 27);
            this.label6.TabIndex = 27;
            this.label6.Text = "Room type:";
            // 
            // rtdisp
            // 
            this.rtdisp.AutoSize = true;
            this.rtdisp.BackColor = System.Drawing.Color.Transparent;
            this.rtdisp.Font = new System.Drawing.Font("LEMON MILK Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtdisp.ForeColor = System.Drawing.Color.White;
            this.rtdisp.Location = new System.Drawing.Point(157, 174);
            this.rtdisp.Name = "rtdisp";
            this.rtdisp.Size = new System.Drawing.Size(113, 21);
            this.rtdisp.TabIndex = 31;
            this.rtdisp.Text = "Room type:";
            // 
            // packdisp
            // 
            this.packdisp.AutoSize = true;
            this.packdisp.BackColor = System.Drawing.Color.Transparent;
            this.packdisp.Font = new System.Drawing.Font("LEMON MILK Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packdisp.ForeColor = System.Drawing.Color.White;
            this.packdisp.Location = new System.Drawing.Point(156, 213);
            this.packdisp.Name = "packdisp";
            this.packdisp.Size = new System.Drawing.Size(121, 23);
            this.packdisp.TabIndex = 33;
            this.packdisp.Text = "Room type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("LEMON MILK Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(40, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 27);
            this.label8.TabIndex = 32;
            this.label8.Text = "Package:";
            // 
            // reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 529);
            this.Controls.Add(this.panel1);
            this.Name = "reserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkin";
            this.Load += new System.EventHandler(this.reserve_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateout;
        private System.Windows.Forms.DateTimePicker datein;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox gc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rtdisp;
        private System.Windows.Forms.Label packdisp;
        private System.Windows.Forms.Label label8;
    }
}