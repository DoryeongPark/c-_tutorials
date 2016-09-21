using System;
using System.Drawing;
using System.Text;
using MetroFramework;
using MetroFramework.Forms;
using System.Net;
using System.IO;

namespace Assignment1
{
    public partial class Assignment1 : MetroForm
    {
        public Assignment1()
        {
            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e)
        {

        }

        /*
         *  Event method called when "Change Color button" is clicked by user
         *  String value as response will be handled as three 32bit integer values 
         */
        private void ChangeColorButtonClicked(object sender, EventArgs e)
        {
            var resultStr = GetResultForRequest("cmd=color");
            pnl_main.BackColor = Color.FromArgb(int.Parse(resultStr.Split('|')[0]),
                                                int.Parse(resultStr.Split('|')[1]),
                                                int.Parse(resultStr.Split('|')[2]));
        }
        
        /*
         *  Event method called when "Change Text button" is clicked by user
         *  Text property of label is replaced with string value from server  
         */
        private void ChangeTextButtonClicked(object sender, EventArgs e)
        {
            lbl_main.Text = GetResultForRequest("cmd=hello");
        }

        /*
         *  Event method called when "MessageBox button" is clicked by user 
         *  String value from server reveals with MessageBox
         */
        private void MessageBoxClicked(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, GetResultForRequest("cmd=echo"), "Result");
        }

        /*
         *   Parameter: msg - String message to be sent to server
         *   Returns: String value as a response for parameter from server 
         */
        private string GetResultForRequest(string msg)
        {
            string resultStr;
            string URL = "http://210.94.194.100:20151/lab03.asp";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            byte[] sendData = Encoding.UTF8.GetBytes(msg);
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            request.ContentLength = sendData.Length;
            request.Method = "POST";

            StreamWriter sw = new StreamWriter(request.GetRequestStream());
            sw.Write(msg);
            sw.Close();

            HttpWebResponse httpWebResponse = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
            resultStr = streamReader.ReadToEnd();

            streamReader.Close();
            httpWebResponse.Close();

            return resultStr;
        }
    }
}
