namespace Assignment1_Polar
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.browseFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.ViewFile = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.sDate = new System.Windows.Forms.Label();
            this.sDate2 = new System.Windows.Forms.Label();
            this.viewFile2 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // browseFile
            // 
            this.browseFile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.browseFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseFile.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.browseFile.Location = new System.Drawing.Point(391, 342);
            this.browseFile.Name = "browseFile";
            this.browseFile.Size = new System.Drawing.Size(172, 32);
            this.browseFile.TabIndex = 0;
            this.browseFile.Text = "BROWSE";
            this.browseFile.UseVisualStyleBackColor = false;
            this.browseFile.Click += new System.EventHandler(this.browseFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose HRM  file";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(280, 145);
            this.monthCalendar1.MinimumSize = new System.Drawing.Size(100, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // ViewFile
            // 
            this.ViewFile.AutoSize = true;
            this.ViewFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewFile.Location = new System.Drawing.Point(17, 63);
            this.ViewFile.Name = "ViewFile";
            this.ViewFile.Size = new System.Drawing.Size(110, 17);
            this.ViewFile.TabIndex = 5;
            this.ViewFile.TabStop = true;
            this.ViewFile.Text = "Surf Calendar";
            this.ViewFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sDate_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Summary";
            // 
            // sDate
            // 
            this.sDate.AutoSize = true;
            this.sDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDate.Location = new System.Drawing.Point(17, 34);
            this.sDate.Name = "sDate";
            this.sDate.Size = new System.Drawing.Size(101, 17);
            this.sDate.TabIndex = 7;
            this.sDate.Text = "Choose Date";
            // 
            // sDate2
            // 
            this.sDate2.AutoSize = true;
            this.sDate2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDate2.Location = new System.Drawing.Point(17, 94);
            this.sDate2.Name = "sDate2";
            this.sDate2.Size = new System.Drawing.Size(52, 17);
            this.sDate2.TabIndex = 8;
            this.sDate2.Text = "label4";
            // 
            // viewFile2
            // 
            this.viewFile2.AutoSize = true;
            this.viewFile2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFile2.Location = new System.Drawing.Point(17, 126);
            this.viewFile2.Name = "viewFile2";
            this.viewFile2.Size = new System.Drawing.Size(83, 17);
            this.viewFile2.TabIndex = 9;
            this.viewFile2.TabStop = true;
            this.viewFile2.Text = "linkLabel1";
            this.viewFile2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewFile2_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.viewFile2);
            this.panel1.Controls.Add(this.sDate2);
            this.panel1.Controls.Add(this.sDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ViewFile);
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(200, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 162);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(391, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(445, 107);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(833, 439);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.LinkLabel ViewFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sDate;
        private System.Windows.Forms.Label sDate2;
        private System.Windows.Forms.LinkLabel viewFile2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}