namespace CrossDomain_Loader
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
            this.labelDomain = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelStatue = new System.Windows.Forms.Label();
            this.labelVulnerable = new System.Windows.Forms.Label();
            this.linkLabelScreen = new System.Windows.Forms.LinkLabel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.linkLabel_Gen_report = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Location = new System.Drawing.Point(23, 12);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(43, 13);
            this.labelDomain.TabIndex = 0;
            this.labelDomain.Text = "Domain";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(147, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(7, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(547, 367);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(72, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(482, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "google.com";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelStatue
            // 
            this.labelStatue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatue.AutoSize = true;
            this.labelStatue.Location = new System.Drawing.Point(12, 429);
            this.labelStatue.Name = "labelStatue";
            this.labelStatue.Size = new System.Drawing.Size(16, 13);
            this.labelStatue.TabIndex = 4;
            this.labelStatue.Text = "...";
            // 
            // labelVulnerable
            // 
            this.labelVulnerable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVulnerable.AutoSize = true;
            this.labelVulnerable.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelVulnerable.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelVulnerable.Location = new System.Drawing.Point(491, 410);
            this.labelVulnerable.Name = "labelVulnerable";
            this.labelVulnerable.Size = new System.Drawing.Size(57, 13);
            this.labelVulnerable.TabIndex = 5;
            this.labelVulnerable.Text = "Vulnerable";
            this.labelVulnerable.Visible = false;
            this.labelVulnerable.VisibleChanged += new System.EventHandler(this.labelVulnerable_VisibleChanged);
            // 
            // linkLabelScreen
            // 
            this.linkLabelScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelScreen.AutoSize = true;
            this.linkLabelScreen.Location = new System.Drawing.Point(491, 426);
            this.linkLabelScreen.Name = "linkLabelScreen";
            this.linkLabelScreen.Size = new System.Drawing.Size(63, 13);
            this.linkLabelScreen.TabIndex = 6;
            this.linkLabelScreen.TabStop = true;
            this.linkLabelScreen.Text = "ScreenShot";
            this.linkLabelScreen.Visible = false;
            this.linkLabelScreen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelScreen_LinkClicked);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(8, 405);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(10, 10);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            this.richTextBox2.Visible = false;
            // 
            // linkLabel_Gen_report
            // 
            this.linkLabel_Gen_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_Gen_report.AutoSize = true;
            this.linkLabel_Gen_report.Location = new System.Drawing.Point(399, 426);
            this.linkLabel_Gen_report.Name = "linkLabel_Gen_report";
            this.linkLabel_Gen_report.Size = new System.Drawing.Size(86, 13);
            this.linkLabel_Gen_report.TabIndex = 8;
            this.linkLabel_Gen_report.TabStop = true;
            this.linkLabel_Gen_report.Text = "Generate Report";
            this.linkLabel_Gen_report.Visible = false;
            this.linkLabel_Gen_report.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Gen_report_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(7, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 19);
            this.panel1.TabIndex = 9;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel_Gen_report);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.linkLabelScreen);
            this.Controls.Add(this.labelVulnerable);
            this.Controls.Add(this.labelStatue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDomain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CrossDomain Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelStatue;
        private System.Windows.Forms.Label labelVulnerable;
        private System.Windows.Forms.LinkLabel linkLabelScreen;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.LinkLabel linkLabel_Gen_report;
        private System.Windows.Forms.Panel panel1;
    }
}

