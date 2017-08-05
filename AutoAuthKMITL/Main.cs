using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace AutoAuthKMITL {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }
        private void Login() {
            try {
                string post_data = "userName=" + tb_studentno.Text.Trim().ToString() + "&password=" + tb_password.Text.Trim().ToString() + "&validCode=&authLan=en&hasValidateNextUpdatePassword=true&browserFlag=en&ClientIp=";
                string uri = "https://mylogin.kmitl.ac.th:8445/PortalServer/Webauth/webAuthAction!login.action";
                HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(uri); request.KeepAlive = false;
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "POST";
                byte[] postBytes = Encoding.ASCII.GetBytes(post_data);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = postBytes.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String Response = new StreamReader(response.GetResponseStream()).ReadToEnd();
                if (!Response.Contains("permitUpdatePwd\":true")) {
                    MessageBox.Show("Login Error !!", "Check your Username and Password !!");
                }
            } catch {
                
            }
        }

        private void Main_Load(object sender, EventArgs e) {
            if (Properties.Settings.Default.Remember) {
                tb_studentno.Text = Properties.Settings.Default.StudentNo;
                tb_password.Text = Properties.Settings.Default.Password;
                cb_startonrun.Checked = Properties.Settings.Default.StartOnProgramRun;
                cb_remember.Checked = Properties.Settings.Default.Remember;
            }
            if (cb_startonrun.Checked) {
                StartAutoAuth();
            }
        }

        private void bt_start_Click(object sender, EventArgs e) {
            StartAutoAuth();
        }
        private void StartAutoAuth() {
            if (timer.Enabled)
            {
                timer.Stop();
                bt_start.Text = "Start AutoAuth";
                tb_studentno.Enabled = true;
                tb_password.Enabled = true;
                numpick_delaycheck.Enabled = true;
                cb_remember.Enabled = true;
            }
            else
            {
                if (!CheckInternetConnection())
                    Login();
                if (cb_remember.Checked)
                    UpdateSetting();
                timer.Interval = (int)numpick_delaycheck.Value * 1000;
                timer.Start();
                bt_start.Text = "Stop AutoAuth";
                tb_studentno.Enabled = false;
                tb_password.Enabled = false;
                numpick_delaycheck.Enabled = false;
                cb_remember.Enabled = false;
            }
        }
        private void UpdateSetting() {
            Properties.Settings.Default.StudentNo = tb_studentno.Text;
            Properties.Settings.Default.Password = tb_password.Text;
            Properties.Settings.Default.CheckDelay = (int)numpick_delaycheck.Value;
            Properties.Settings.Default.Remember = cb_remember.Checked;
            Properties.Settings.Default.StartOnProgramRun = cb_startonrun.Checked;
            Properties.Settings.Default.Save();
        }
        private void bt_hide_Click(object sender, EventArgs e) {
            Hide();
            notifyIcon.Visible = true;
        }

        private void bt_exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e) {
            if (!CheckInternetConnection()) {
                Login();
            }
        }
        private bool CheckInternetConnection() {
            String URL = "https://www.google.com";
            try {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Timeout = 5000;
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                    return true;
                else
                    return false;
            } catch {
                return false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            notifyIcon.Visible = false;
        }
    }
}
