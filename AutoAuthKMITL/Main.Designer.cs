namespace AutoAuthKMITL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bt_start = new System.Windows.Forms.Button();
            this.tb_studentno = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_remember = new System.Windows.Forms.CheckBox();
            this.numpick_delaycheck = new System.Windows.Forms.NumericUpDown();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_studentno = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.bt_hide = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.pb_title = new System.Windows.Forms.PictureBox();
            this.cb_startonrun = new System.Windows.Forms.CheckBox();
            this.gb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numpick_delaycheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_start
            // 
            resources.ApplyResources(this.bt_start, "bt_start");
            this.bt_start.Name = "bt_start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // tb_studentno
            // 
            resources.ApplyResources(this.tb_studentno, "tb_studentno");
            this.tb_studentno.Name = "tb_studentno";
            // 
            // tb_password
            // 
            resources.ApplyResources(this.tb_password, "tb_password");
            this.tb_password.Name = "tb_password";
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.cb_startonrun);
            this.gb_info.Controls.Add(this.label1);
            this.gb_info.Controls.Add(this.cb_remember);
            this.gb_info.Controls.Add(this.numpick_delaycheck);
            this.gb_info.Controls.Add(this.lb_password);
            this.gb_info.Controls.Add(this.lb_studentno);
            this.gb_info.Controls.Add(this.tb_studentno);
            this.gb_info.Controls.Add(this.tb_password);
            resources.ApplyResources(this.gb_info, "gb_info");
            this.gb_info.Name = "gb_info";
            this.gb_info.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cb_remember
            // 
            resources.ApplyResources(this.cb_remember, "cb_remember");
            this.cb_remember.Name = "cb_remember";
            this.cb_remember.UseVisualStyleBackColor = true;
            // 
            // numpick_delaycheck
            // 
            resources.ApplyResources(this.numpick_delaycheck, "numpick_delaycheck");
            this.numpick_delaycheck.Name = "numpick_delaycheck";
            this.numpick_delaycheck.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lb_password
            // 
            resources.ApplyResources(this.lb_password, "lb_password");
            this.lb_password.Name = "lb_password";
            // 
            // lb_studentno
            // 
            resources.ApplyResources(this.lb_studentno, "lb_studentno");
            this.lb_studentno.Name = "lb_studentno";
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // bt_hide
            // 
            resources.ApplyResources(this.bt_hide, "bt_hide");
            this.bt_hide.Name = "bt_hide";
            this.bt_hide.UseVisualStyleBackColor = true;
            this.bt_hide.Click += new System.EventHandler(this.bt_hide_Click);
            // 
            // bt_exit
            // 
            resources.ApplyResources(this.bt_exit, "bt_exit");
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // pb_title
            // 
            this.pb_title.Image = global::AutoAuthKMITL.Properties.Resources.tittle;
            resources.ApplyResources(this.pb_title, "pb_title");
            this.pb_title.Name = "pb_title";
            this.pb_title.TabStop = false;
            // 
            // cb_startonrun
            // 
            resources.ApplyResources(this.cb_startonrun, "cb_startonrun");
            this.cb_startonrun.Name = "cb_startonrun";
            this.cb_startonrun.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AcceptButton = this.bt_start;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ControlBox = false;
            this.Controls.Add(this.pb_title);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_hide);
            this.Controls.Add(this.gb_info);
            this.Controls.Add(this.bt_start);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.gb_info.ResumeLayout(false);
            this.gb_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numpick_delaycheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.TextBox tb_studentno;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_studentno;
        private System.Windows.Forms.CheckBox cb_remember;
        private System.Windows.Forms.NumericUpDown numpick_delaycheck;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button bt_hide;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_title;
        private System.Windows.Forms.CheckBox cb_startonrun;
    }
}

