using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace CrossDomain_Loader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                this.counter++;
                string url = textBox1.Text;
                string domain = (textBox1.Text);

                this. ResponseMessage = "";
                if (textBox1.Text.StartsWith("http://") == false && textBox1.Text.StartsWith("https") == false)
                    url = "http" + "://" +( url + "/crossdomain.xml").Replace("//","/");
               
                var req = (HttpWebRequest)WebRequest.Create(url);
                req.AllowAutoRedirect = true;
                req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:49.0) Gecko/20100101 Firefox/49.0";

                richTextBox1.Text = "";
                  var res = (HttpWebResponse)req.GetResponse();
                string stcod = ((int)res.StatusCode).ToString();
                string stDesc = res.StatusDescription;
                ResponseMessage = "HTTP/1.1 " + (stcod + " " + stDesc) + "\n";
                for (int i = 0; i < res.Headers.Count; i++)
                {
                    try
                    {
                        string k = res.Headers.GetKey(i);
                        string v = res.Headers[k];
                        ResponseMessage += k + ": " + v + "\n";
                    }
                    catch { }
                }
                ResponseMessage += "\n";
                StreamReader s = new StreamReader(res.GetResponseStream());
                this.CurrentBody += s.ReadToEnd();
                ResponseMessage += "\n\n" + this.CurrentBody;
                ResponseMessage = ResponseMessage.Replace("\n\n\n", "\n\n");
                richTextBox1.Text = ResponseMessage;
                labelStatue.Text = "[" + this.counter.ToString() + "] success";
            }
            catch (Exception x)
            {
                labelStatue.Text = x.Message;
                string code = ExtractCode(x.Message);
                labelStatue.Text = x.Message;
                if (x.Message.Contains("Unable to connect to the remote server"))
                {
                    labelStatue.Text = "Unable to connect to the remote server";
                }
                else
                    try
                    {
                        var s = (x as System.Net.WebException).Response;
                        var sc = s.GetResponseStream();
                        string body = new StreamReader(sc).ReadToEnd();
                        string responseMessage = "HTTP/1.1 " + (code) + "\n";
                        for (int i = 0; i < s.Headers.Count; i++)
                        {
                            try
                            {
                                string k = s.Headers.GetKey(i);
                                string v = s.Headers[k];
                                responseMessage += k + ": " + v + "\n";
                            }
                            catch { }
                        }
                        this.CurrentBody = body;
                        responseMessage = responseMessage + "\n" + body;
                        richTextBox1.Text = responseMessage;
                        labelStatue.Text = "[" + this.counter.ToString() + "] success";


                    }
                    catch (Exception xsa) { labelStatue.Text = "[" + this.counter.ToString() + "] Error " + xsa.Message; }

            }
            this.Text =Program.Getname()+ "     at " + DateTime.Now.ToString();
        }

        public int counter = 0;// { get; set; }

        public string ResponseMessage ="";// { get; set; }
        private string ExtractCode(string p)
        {
            //The remote server returned an error: (402) Payment Required.

            if (p.Contains("error: ("))
            {
                return p.Split(new string[] { "error: (", ")" }, StringSplitOptions.RemoveEmptyEntries)[1];


            }
            else return "";
        }

        public string CurrentBody = "";

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            labelVulnerable.Visible = richTextBox1.Text.Contains("allow-access-from domain=\"*\"");
            if (labelVulnerable.Visible)
            {
                int ind = richTextBox1.Text.IndexOf("allow-access-from domain=\"*\"");
                 
                richTextBox1.SelectionStart = ind;
                richTextBox1.SelectionLength = "allow-access-from domain=\"*\"".Length;
                richTextBox1.SelectionColor = Color.Red;
            }
            //"
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string old = "";
                try
                {
                    old = System.IO.File.ReadAllText("last.domains");
                }
                catch { }
                System.IO.File.WriteAllText("last.domains", textBox1.Text.Trim()+((old.Trim().Length<4)?"":"\r\n"+old));
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            try
            {

                string data = System.IO.File.ReadAllLines("last.domains")[0].Trim();
                if (data.Length >= 4 && data.Contains("."))
                    textBox1.Text = data;
            }
            catch
            {
            }
        }

        private void labelVulnerable_VisibleChanged(object sender, EventArgs e)
        {
            linkLabel_Gen_report.Visible=linkLabelScreen.Visible = labelVulnerable.Visible;
        }

        private void linkLabelScreen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelScreen.Visible = false;
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "where to save the image";
                s.FileName = textBox1.Text.Trim() + "_Crossdomain_POC_.jpg";
                if(s.ShowDialog()==System.Windows.Forms.DialogResult.OK)

                    bitmap.Save(s.FileName+((s.FileName.EndsWith(".jpg"))?"":".jpg"), ImageFormat.Bmp);
            }

            linkLabelScreen.Visible = true;
        }

        private void linkLabel_Gen_report_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string report_ = richTextBox2.Text.Replace("www.example.com", textBox1.Text) + "\r\n\r\n\r\nBest,\r\n"+Environment.UserName;
            FormReport f = new FormReport(report_,textBox1.Text.Trim());
            f.Icon = this.Icon;
            f.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            var c = richTextBox1.BackColor;
            var c2 = panel1.BackColor;
            panel1.BackColor = c;
            richTextBox1.BackColor = c2;
        }// { get; set; }
    }
}
