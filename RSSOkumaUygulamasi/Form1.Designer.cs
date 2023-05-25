namespace RSSOkumaUygulamasi
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
            this.txt_rssurl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.lst_baslik = new System.Windows.Forms.ListBox();
            this.web_browser = new System.Windows.Forms.WebBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_rssurl
            // 
            this.txt_rssurl.Location = new System.Drawing.Point(6, 21);
            this.txt_rssurl.Name = "txt_rssurl";
            this.txt_rssurl.Size = new System.Drawing.Size(1072, 22);
            this.txt_rssurl.TabIndex = 0;
            this.txt_rssurl.Text = "https://www.sabah.com.tr/rss/gundem.xml";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_getir);
            this.groupBox1.Controls.Add(this.txt_rssurl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1221, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSS Uygulama";
            // 
            // btn_getir
            // 
            this.btn_getir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_getir.Location = new System.Drawing.Point(1084, 17);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(131, 31);
            this.btn_getir.TabIndex = 5;
            this.btn_getir.Text = "Ara";
            this.btn_getir.UseVisualStyleBackColor = false;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lst_baslik
            // 
            this.lst_baslik.FormattingEnabled = true;
            this.lst_baslik.ItemHeight = 16;
            this.lst_baslik.Location = new System.Drawing.Point(6, 21);
            this.lst_baslik.Name = "lst_baslik";
            this.lst_baslik.Size = new System.Drawing.Size(332, 564);
            this.lst_baslik.TabIndex = 3;
            this.lst_baslik.SelectedIndexChanged += new System.EventHandler(this.lst_baslik_SelectedIndexChanged);
            // 
            // web_browser
            // 
            this.web_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_browser.Location = new System.Drawing.Point(3, 18);
            this.web_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_browser.Name = "web_browser";
            this.web_browser.Size = new System.Drawing.Size(841, 573);
            this.web_browser.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_baslik);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 600);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Haber Başlıkları";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.web_browser);
            this.groupBox3.Location = new System.Drawing.Point(380, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(847, 594);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Haber Detayı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 699);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS Okuma Uygulaması";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_rssurl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_baslik;
        private System.Windows.Forms.WebBrowser web_browser;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

