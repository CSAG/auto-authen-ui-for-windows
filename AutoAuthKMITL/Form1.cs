using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoAuthKMITL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Login() {
            try
            {
                string post_data = "userName=" + textBox1.Text.Trim().ToString() + "&password=" + textBox2.Text.Trim().ToString() + "&validCode=&authLan=en&hasValidateNextUpdatePassword=true&browserFlag=en&ClientIp=";

                // this is where we will send it
                string uri = "https://mylogin.kmitl.ac.th:8445/PortalServer/Webauth/webAuthAction!login.action";

                // create a request
                HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(uri); request.KeepAlive = false;
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "POST";

                // turn our request string into a byte stream
                byte[] postBytes = Encoding.ASCII.GetBytes(post_data);

                // this is important - make sure you specify type this way
                ServicePointManager.CertificatePolicy = new MyPolicy();
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = postBytes.Length;
                Stream requestStream = request.GetRequestStream();

                // now send it
                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();

                // grab te response and print it out to the console along with the status code
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                textBox3.Text = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           Login();
        }
        
    }
}
