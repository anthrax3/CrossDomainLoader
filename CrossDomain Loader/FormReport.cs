using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrossDomain_Loader
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }
        
        public FormReport(string s,string d  )
        {
            InitializeComponent();
            this.richTextBox1.Text=s;
            this.domain = "";
                
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Title = domain + "insecure crossdomain.xml file.md";
            if (s.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(s.FileName, richTextBox1.Text);
                    MessageBox.Show("saved to " + s.FileName);
                }
                catch { }
            }
        }

        public string domain ="";

        private void button2_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength>0)
                Clipboard.SetText(richTextBox1.Text);
        }//{ get; set; }
    }
}
