namespace IIC_ARM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.portlist = new System.Windows.Forms.ComboBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gs1 = new System.Windows.Forms.TrackBar();
            this.gs2 = new System.Windows.Forms.TrackBar();
            this.gs3 = new System.Windows.Forms.TrackBar();
            this.gs4 = new System.Windows.Forms.TrackBar();
            this.sl4 = new System.Windows.Forms.Button();
            this.sr2 = new System.Windows.Forms.Button();
            this.sr3 = new System.Windows.Forms.Button();
            this.sr4 = new System.Windows.Forms.Button();
            this.sl1 = new System.Windows.Forms.Button();
            this.sl2 = new System.Windows.Forms.Button();
            this.sl3 = new System.Windows.Forms.Button();
            this.sr1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.sr1);
            this.panel2.Controls.Add(this.sl3);
            this.panel2.Controls.Add(this.sl2);
            this.panel2.Controls.Add(this.sl1);
            this.panel2.Controls.Add(this.sr4);
            this.panel2.Controls.Add(this.sr3);
            this.panel2.Controls.Add(this.sr2);
            this.panel2.Controls.Add(this.sl4);
            this.panel2.Controls.Add(this.gs4);
            this.panel2.Controls.Add(this.gs3);
            this.panel2.Controls.Add(this.gs2);
            this.panel2.Controls.Add(this.gs1);
            this.panel2.Location = new System.Drawing.Point(12, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 488);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // portlist
            // 
            this.portlist.FormattingEnabled = true;
            this.portlist.Location = new System.Drawing.Point(3, 14);
            this.portlist.Name = "portlist";
            this.portlist.Size = new System.Drawing.Size(301, 24);
            this.portlist.TabIndex = 1;
            this.portlist.Text = "select port";
            this.portlist.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(0, 44);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(304, 37);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "start connection";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnstop
            // 
            this.btnstop.Enabled = false;
            this.btnstop.Location = new System.Drawing.Point(0, 87);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(304, 31);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "close connection";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnstop);
            this.panel1.Controls.Add(this.btnstart);
            this.panel1.Controls.Add(this.portlist);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 134);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(991, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 470);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // gs1
            // 
            this.gs1.LargeChange = 1;
            this.gs1.Location = new System.Drawing.Point(489, 373);
            this.gs1.Maximum = 512;
            this.gs1.Minimum = 102;
            this.gs1.Name = "gs1";
            this.gs1.Size = new System.Drawing.Size(754, 56);
            this.gs1.TabIndex = 22;
            this.gs1.Value = 300;
            this.gs1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.gs1.MouseCaptureChanged += new System.EventHandler(this.gs1_MouseCaptureChanged);
            // 
            // gs2
            // 
            this.gs2.LargeChange = 1;
            this.gs2.Location = new System.Drawing.Point(489, 263);
            this.gs2.Maximum = 512;
            this.gs2.Minimum = 102;
            this.gs2.Name = "gs2";
            this.gs2.Size = new System.Drawing.Size(754, 56);
            this.gs2.TabIndex = 23;
            this.gs2.Value = 300;
            this.gs2.MouseCaptureChanged += new System.EventHandler(this.gs2_MouseCaptureChanged);
            // 
            // gs3
            // 
            this.gs3.LargeChange = 1;
            this.gs3.Location = new System.Drawing.Point(489, 149);
            this.gs3.Maximum = 512;
            this.gs3.Minimum = 102;
            this.gs3.Name = "gs3";
            this.gs3.Size = new System.Drawing.Size(754, 56);
            this.gs3.TabIndex = 24;
            this.gs3.Value = 300;
            this.gs3.MouseCaptureChanged += new System.EventHandler(this.gs3_MouseCaptureChanged);
            // 
            // gs4
            // 
            this.gs4.LargeChange = 1;
            this.gs4.Location = new System.Drawing.Point(489, 38);
            this.gs4.Maximum = 400;
            this.gs4.Minimum = 250;
            this.gs4.Name = "gs4";
            this.gs4.Size = new System.Drawing.Size(754, 56);
            this.gs4.TabIndex = 25;
            this.gs4.Value = 320;
            this.gs4.Scroll += new System.EventHandler(this.gs4_Scroll);
            this.gs4.MouseCaptureChanged += new System.EventHandler(this.gs4_MouseCaptureChanged);
            // 
            // sl4
            // 
            this.sl4.Location = new System.Drawing.Point(408, 38);
            this.sl4.Name = "sl4";
            this.sl4.Size = new System.Drawing.Size(75, 23);
            this.sl4.TabIndex = 26;
            this.sl4.Text = "<";
            this.sl4.UseVisualStyleBackColor = true;
            this.sl4.Click += new System.EventHandler(this.sl4_Click);
            // 
            // sr2
            // 
            this.sr2.Location = new System.Drawing.Point(1249, 263);
            this.sr2.Name = "sr2";
            this.sr2.Size = new System.Drawing.Size(75, 23);
            this.sr2.TabIndex = 27;
            this.sr2.Text = ">";
            this.sr2.UseVisualStyleBackColor = true;
            this.sr2.Click += new System.EventHandler(this.sr2_Click);
            // 
            // sr3
            // 
            this.sr3.Location = new System.Drawing.Point(1249, 152);
            this.sr3.Name = "sr3";
            this.sr3.Size = new System.Drawing.Size(75, 23);
            this.sr3.TabIndex = 28;
            this.sr3.Text = ">";
            this.sr3.UseVisualStyleBackColor = true;
            this.sr3.Click += new System.EventHandler(this.sr3_Click);
            // 
            // sr4
            // 
            this.sr4.Location = new System.Drawing.Point(1249, 38);
            this.sr4.Name = "sr4";
            this.sr4.Size = new System.Drawing.Size(75, 23);
            this.sr4.TabIndex = 29;
            this.sr4.Text = ">";
            this.sr4.UseVisualStyleBackColor = true;
            this.sr4.Click += new System.EventHandler(this.sr4_Click);
            // 
            // sl1
            // 
            this.sl1.Location = new System.Drawing.Point(410, 373);
            this.sl1.Name = "sl1";
            this.sl1.Size = new System.Drawing.Size(75, 23);
            this.sl1.TabIndex = 30;
            this.sl1.Text = "<";
            this.sl1.UseVisualStyleBackColor = true;
            this.sl1.Click += new System.EventHandler(this.sl1_Click);
            // 
            // sl2
            // 
            this.sl2.Location = new System.Drawing.Point(410, 263);
            this.sl2.Name = "sl2";
            this.sl2.Size = new System.Drawing.Size(75, 23);
            this.sl2.TabIndex = 31;
            this.sl2.Text = "<";
            this.sl2.UseVisualStyleBackColor = true;
            this.sl2.Click += new System.EventHandler(this.sl2_Click);
            // 
            // sl3
            // 
            this.sl3.Location = new System.Drawing.Point(410, 149);
            this.sl3.Name = "sl3";
            this.sl3.Size = new System.Drawing.Size(75, 23);
            this.sl3.TabIndex = 32;
            this.sl3.Text = "<";
            this.sl3.UseVisualStyleBackColor = true;
            this.sl3.Click += new System.EventHandler(this.sl3_Click);
            // 
            // sr1
            // 
            this.sr1.Location = new System.Drawing.Point(1249, 370);
            this.sr1.Name = "sr1";
            this.sr1.Size = new System.Drawing.Size(75, 23);
            this.sr1.TabIndex = 33;
            this.sr1.Text = ">";
            this.sr1.UseVisualStyleBackColor = true;
            this.sr1.Click += new System.EventHandler(this.sr1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "servo4";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "servo3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "servo2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "servo1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1374, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "IIC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox portlist;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sr1;
        private System.Windows.Forms.Button sl3;
        private System.Windows.Forms.Button sl2;
        private System.Windows.Forms.Button sl1;
        private System.Windows.Forms.Button sr4;
        private System.Windows.Forms.Button sr3;
        private System.Windows.Forms.Button sr2;
        private System.Windows.Forms.Button sl4;
        private System.Windows.Forms.TrackBar gs4;
        private System.Windows.Forms.TrackBar gs3;
        private System.Windows.Forms.TrackBar gs2;
        private System.Windows.Forms.TrackBar gs1;
    }
}

