namespace Updater
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnAbout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(626, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(70, 50);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(702, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnTest2);
            this.groupBox1.Controls.Add(this.btnTest1);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Place";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTest2
            // 
            this.btnTest2.Image = ((System.Drawing.Image)(resources.GetObject("btnTest2.Image")));
            this.btnTest2.Location = new System.Drawing.Point(668, 19);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(86, 68);
            this.btnTest2.TabIndex = 1;
            this.btnTest2.UseVisualStyleBackColor = true;
            // 
            // btnTest1
            // 
            this.btnTest1.Image = ((System.Drawing.Image)(resources.GetObject("btnTest1.Image")));
            this.btnTest1.Location = new System.Drawing.Point(576, 19);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(86, 68);
            this.btnTest1.TabIndex = 0;
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Infomation";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Resize += new System.EventHandler(this.Home_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}