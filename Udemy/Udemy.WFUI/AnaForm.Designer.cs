namespace Udemy.WFUI
{
    partial class AnaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_liste = new System.Windows.Forms.ListBox();
            this.grpbox_kayit = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_yeni_kayit = new System.Windows.Forms.Button();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_website = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_emailadres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_telefon3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_telefon2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_telefon1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_data_alcer_durum = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_json_ver = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_csv_ver = new System.Windows.Forms.Button();
            this.btn_xml_ver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpbox_kayit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_liste);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 738);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rehber Listesi";
            // 
            // lst_liste
            // 
            this.lst_liste.FormattingEnabled = true;
            this.lst_liste.ItemHeight = 16;
            this.lst_liste.Location = new System.Drawing.Point(7, 22);
            this.lst_liste.Name = "lst_liste";
            this.lst_liste.Size = new System.Drawing.Size(377, 708);
            this.lst_liste.TabIndex = 0;
            this.lst_liste.DoubleClick += new System.EventHandler(this.lst_liste_DoubleClick);
            // 
            // grpbox_kayit
            // 
            this.grpbox_kayit.Controls.Add(this.tabControl1);
            this.grpbox_kayit.Location = new System.Drawing.Point(410, 13);
            this.grpbox_kayit.Name = "grpbox_kayit";
            this.grpbox_kayit.Size = new System.Drawing.Size(975, 514);
            this.grpbox_kayit.TabIndex = 1;
            this.grpbox_kayit.TabStop = false;
            this.grpbox_kayit.Text = "Yeni Rehber Kaydı";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_sil);
            this.tabPage1.Controls.Add(this.btn_guncelle);
            this.tabPage1.Controls.Add(this.btn_yeni_kayit);
            this.tabPage1.Controls.Add(this.txt_adres);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txt_website);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_emailadres);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_telefon3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_telefon2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_telefon1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_soyisim);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_isim);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(954, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kişisel Bilgiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.DimGray;
            this.btn_sil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sil.Location = new System.Drawing.Point(494, 389);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(428, 54);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.DimGray;
            this.btn_guncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guncelle.Location = new System.Drawing.Point(41, 389);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(428, 54);
            this.btn_guncelle.TabIndex = 9;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_yeni_kayit
            // 
            this.btn_yeni_kayit.BackColor = System.Drawing.Color.Silver;
            this.btn_yeni_kayit.Location = new System.Drawing.Point(41, 329);
            this.btn_yeni_kayit.Name = "btn_yeni_kayit";
            this.btn_yeni_kayit.Size = new System.Drawing.Size(881, 54);
            this.btn_yeni_kayit.TabIndex = 8;
            this.btn_yeni_kayit.Text = "Yeni Kayıt";
            this.btn_yeni_kayit.UseVisualStyleBackColor = false;
            this.btn_yeni_kayit.Click += new System.EventHandler(this.btn_yeni_kayit_Click);
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(384, 86);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(538, 215);
            this.txt_adres.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(381, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Adres";
            // 
            // txt_website
            // 
            this.txt_website.Location = new System.Drawing.Point(144, 283);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(201, 22);
            this.txt_website.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(37, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Web Site";
            // 
            // txt_emailadres
            // 
            this.txt_emailadres.Location = new System.Drawing.Point(144, 245);
            this.txt_emailadres.Name = "txt_emailadres";
            this.txt_emailadres.Size = new System.Drawing.Size(201, 22);
            this.txt_emailadres.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(37, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email";
            // 
            // txt_telefon3
            // 
            this.txt_telefon3.Location = new System.Drawing.Point(144, 206);
            this.txt_telefon3.Name = "txt_telefon3";
            this.txt_telefon3.Size = new System.Drawing.Size(201, 22);
            this.txt_telefon3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(37, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon 3";
            // 
            // txt_telefon2
            // 
            this.txt_telefon2.Location = new System.Drawing.Point(144, 169);
            this.txt_telefon2.Name = "txt_telefon2";
            this.txt_telefon2.Size = new System.Drawing.Size(201, 22);
            this.txt_telefon2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon 2";
            // 
            // txt_telefon1
            // 
            this.txt_telefon1.Location = new System.Drawing.Point(144, 133);
            this.txt_telefon1.Name = "txt_telefon1";
            this.txt_telefon1.Size = new System.Drawing.Size(201, 22);
            this.txt_telefon1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon 1";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(144, 97);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(201, 22);
            this.txt_soyisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(144, 59);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(201, 22);
            this.txt_isim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_aciklama);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(954, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Açıklama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(7, 7);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(941, 444);
            this.txt_aciklama.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(410, 534);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(975, 217);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data AL / VER";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 123);
            this.button3.TabIndex = 0;
            this.button3.Text = "XML Ver";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 123);
            this.button2.TabIndex = 0;
            this.button2.Text = "XML Ver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 123);
            this.button1.TabIndex = 0;
            this.button1.Text = "XML Ver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_data_alcer_durum);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.btn_json_ver);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.btn_csv_ver);
            this.groupBox4.Controls.Add(this.btn_xml_ver);
            this.groupBox4.Location = new System.Drawing.Point(409, 533);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(975, 217);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data AL / VER";
            // 
            // lbl_data_alcer_durum
            // 
            this.lbl_data_alcer_durum.AutoSize = true;
            this.lbl_data_alcer_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_data_alcer_durum.Location = new System.Drawing.Point(659, 84);
            this.lbl_data_alcer_durum.Name = "lbl_data_alcer_durum";
            this.lbl_data_alcer_durum.Size = new System.Drawing.Size(175, 20);
            this.lbl_data_alcer_durum.TabIndex = 1;
            this.lbl_data_alcer_durum.Text = "Durum : Beklemede";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(485, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 123);
            this.button8.TabIndex = 0;
            this.button8.Text = "XML AL";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btn_json_ver
            // 
            this.btn_json_ver.Location = new System.Drawing.Point(342, 41);
            this.btn_json_ver.Name = "btn_json_ver";
            this.btn_json_ver.Size = new System.Drawing.Size(124, 123);
            this.btn_json_ver.TabIndex = 0;
            this.btn_json_ver.Text = "JSON VER";
            this.btn_json_ver.UseVisualStyleBackColor = true;
            this.btn_json_ver.Click += new System.EventHandler(this.btn_json_ver_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(341, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 123);
            this.button4.TabIndex = 0;
            this.button4.Text = "XML Ver";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_csv_ver
            // 
            this.btn_csv_ver.Location = new System.Drawing.Point(201, 41);
            this.btn_csv_ver.Name = "btn_csv_ver";
            this.btn_csv_ver.Size = new System.Drawing.Size(124, 123);
            this.btn_csv_ver.TabIndex = 0;
            this.btn_csv_ver.Text = "CSV VER";
            this.btn_csv_ver.UseVisualStyleBackColor = true;
            this.btn_csv_ver.Click += new System.EventHandler(this.btn_csv_ver_Click);
            // 
            // btn_xml_ver
            // 
            this.btn_xml_ver.Location = new System.Drawing.Point(57, 41);
            this.btn_xml_ver.Name = "btn_xml_ver";
            this.btn_xml_ver.Size = new System.Drawing.Size(124, 123);
            this.btn_xml_ver.TabIndex = 0;
            this.btn_xml_ver.Text = "XML VER";
            this.btn_xml_ver.UseVisualStyleBackColor = true;
            this.btn_xml_ver.Click += new System.EventHandler(this.btn_xml_ver_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 763);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpbox_kayit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpbox_kayit.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbox_kayit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_website;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_emailadres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_telefon3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_telefon2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_telefon1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Button btn_yeni_kayit;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn_json_ver;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_csv_ver;
        private System.Windows.Forms.Button btn_xml_ver;
        private System.Windows.Forms.ListBox lst_liste;
        private System.Windows.Forms.Label lbl_data_alcer_durum;
        private System.Windows.Forms.Button btn_sil;
    }
}