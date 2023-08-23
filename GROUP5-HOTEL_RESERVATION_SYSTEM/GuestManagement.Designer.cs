
namespace GROUP5_HOTEL_RESERVATION_SYSTEM
{
    partial class GuestManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showguest = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guestreg = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstnamead = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.passwordad = new System.Windows.Forms.TextBox();
            this.lastnamead = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.phonenumad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.showguest);
            this.panel1.Controls.Add(this.guestreg);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.firstnamead);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.passwordad);
            this.panel1.Controls.Add(this.lastnamead);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.phonenumad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 776);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::GROUP5_HOTEL_RESERVATION_SYSTEM.Properties.Resources.lclosebent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1142, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 90);
            this.button7.TabIndex = 76;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.label7.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(681, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 70);
            this.label7.TabIndex = 75;
            this.label7.Text = "GUEST LIST:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Font = new System.Drawing.Font("BigNoodleTitling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(189, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 5);
            this.panel2.TabIndex = 72;
            // 
            // showguest
            // 
            this.showguest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.showguest.HideSelection = false;
            this.showguest.Location = new System.Drawing.Point(485, 223);
            this.showguest.MultiSelect = false;
            this.showguest.Name = "showguest";
            this.showguest.Size = new System.Drawing.Size(676, 541);
            this.showguest.TabIndex = 4;
            this.showguest.UseCompatibleStateImageBehavior = false;
            this.showguest.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "GUEST ID";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FIRST NAME";
            this.columnHeader2.Width = 168;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LAST NAME";
            this.columnHeader3.Width = 163;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PHONE NUMBER";
            this.columnHeader4.Width = 187;
            // 
            // guestreg
            // 
            this.guestreg.BackColor = System.Drawing.Color.LavenderBlush;
            this.guestreg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestreg.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestreg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guestreg.Location = new System.Drawing.Point(189, 192);
            this.guestreg.Name = "guestreg";
            this.guestreg.Size = new System.Drawing.Size(233, 32);
            this.guestreg.TabIndex = 54;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(176, 659);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 73);
            this.button2.TabIndex = 69;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.label2.Font = new System.Drawing.Font("BigNoodleTitling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 53;
            this.label2.Text = "GUEST id:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(100, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 84);
            this.button1.TabIndex = 68;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Font = new System.Drawing.Font("BigNoodleTitling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(189, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 5);
            this.panel3.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.label5.Font = new System.Drawing.Font("BigNoodleTitling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(75, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 30);
            this.label5.TabIndex = 67;
            this.label5.Text = "PASSWORD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.label1.Font = new System.Drawing.Font("BigNoodleTitling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 56;
            this.label1.Text = "first name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.label3.Font = new System.Drawing.Font("BigNoodleTitling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 66;
            this.label3.Text = "LAST NAME:";
            // 
            // firstnamead
            // 
            this.firstnamead.BackColor = System.Drawing.Color.LavenderBlush;
            this.firstnamead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnamead.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamead.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstnamead.Location = new System.Drawing.Point(189, 248);
            this.firstnamead.Name = "firstnamead";
            this.firstnamead.Size = new System.Drawing.Size(233, 32);
            this.firstnamead.TabIndex = 57;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Font = new System.Drawing.Font("BigNoodleTitling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(189, 468);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(233, 5);
            this.panel6.TabIndex = 65;
            // 
            // passwordad
            // 
            this.passwordad.BackColor = System.Drawing.Color.LavenderBlush;
            this.passwordad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordad.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordad.Location = new System.Drawing.Point(189, 436);
            this.passwordad.Name = "passwordad";
            this.passwordad.PasswordChar = '*';
            this.passwordad.Size = new System.Drawing.Size(233, 32);
            this.passwordad.TabIndex = 64;
            this.passwordad.TextChanged += new System.EventHandler(this.passwordad_TextChanged);
            // 
            // lastnamead
            // 
            this.lastnamead.BackColor = System.Drawing.Color.LavenderBlush;
            this.lastnamead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnamead.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnamead.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastnamead.Location = new System.Drawing.Point(189, 314);
            this.lastnamead.Name = "lastnamead";
            this.lastnamead.Size = new System.Drawing.Size(233, 32);
            this.lastnamead.TabIndex = 59;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Font = new System.Drawing.Font("BigNoodleTitling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(189, 406);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 5);
            this.panel5.TabIndex = 63;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Font = new System.Drawing.Font("BigNoodleTitling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(189, 345);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 5);
            this.panel4.TabIndex = 60;
            // 
            // phonenumad
            // 
            this.phonenumad.BackColor = System.Drawing.Color.LavenderBlush;
            this.phonenumad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phonenumad.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phonenumad.Location = new System.Drawing.Point(189, 375);
            this.phonenumad.MaxLength = 11;
            this.phonenumad.Name = "phonenumad";
            this.phonenumad.Size = new System.Drawing.Size(233, 32);
            this.phonenumad.TabIndex = 62;
            this.phonenumad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.label4.Font = new System.Drawing.Font("BigNoodleTitling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 30);
            this.label4.TabIndex = 61;
            this.label4.Text = "PHONE NUMBER:";
            // 
            // GuestManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 776);
            this.Controls.Add(this.panel1);
            this.Name = "GuestManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestManagement";
            this.Load += new System.EventHandler(this.GuestManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phonenumad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox lastnamead;
        private System.Windows.Forms.TextBox passwordad;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox firstnamead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox guestreg;
        private System.Windows.Forms.ListView showguest;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
    }
}