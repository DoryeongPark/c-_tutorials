using System;
using System.Text;
using MetroFramework;
using MetroFramework.Forms;
using System.Net;
using System.IO;

namespace Assignment0
{
    public partial class Assignment0 : MetroForm
    {
        public Assignment0()
        {
            InitializeComponent();
        }

        /*
         *   Parameter: msg - String message to be sent to server
         *   Returns: String value as a response for parameter from server 
         */
        private string GetResultForRequest(string msg)
        {
            string resultStr;
            string URL = "http://210.94.194.100:20151/lab02.asp";

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

        /*
         *  Event method called when "Send button" is clicked by user
         *  Text property of label is replaced with string value from server  
         */
        private void MainButtonClicked(object sender, EventArgs e)
        {
            lbl_main.Text = GetResultForRequest("val=test");
        }
    }
}
