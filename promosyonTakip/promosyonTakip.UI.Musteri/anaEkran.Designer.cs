namespace promosyonTakip.UI.Musteri
{
    partial class anaEkran
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
            this.gpMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTctKimlikNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.chkEpostaOnay = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.chkSmsOnay = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.hediyePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gpMusteriBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpMusteriBilgileri
            // 
            this.gpMusteriBilgileri.Controls.Add(this.btnIptal);
            this.gpMusteriBilgileri.Controls.Add(this.btnKaydet);
            this.gpMusteriBilgileri.Controls.Add(this.chkSmsOnay);
            this.gpMusteriBilgileri.Controls.Add(this.chkEpostaOnay);
            this.gpMusteriBilgileri.Controls.Add(this.cmbCinsiyet);
            this.gpMusteriBilgileri.Controls.Add(this.txtDogumTarih);
            this.gpMusteriBilgileri.Controls.Add(this.label4);
            this.gpMusteriBilgileri.Controls.Add(this.label5);
            this.gpMusteriBilgileri.Controls.Add(this.txtTelefon);
            this.gpMusteriBilgileri.Controls.Add(this.label8);
            this.gpMusteriBilgileri.Controls.Add(this.txtEposta);
            this.gpMusteriBilgileri.Controls.Add(this.label7);
            this.gpMusteriBilgileri.Controls.Add(this.txtMeslek);
            this.gpMusteriBilgileri.Controls.Add(this.label6);
            this.gpMusteriBilgileri.Controls.Add(this.txtSoyisim);
            this.gpMusteriBilgileri.Controls.Add(this.label3);
            this.gpMusteriBilgileri.Controls.Add(this.txtIsim);
            this.gpMusteriBilgileri.Controls.Add(this.label2);
            this.gpMusteriBilgileri.Controls.Add(this.txtTctKimlikNo);
            this.gpMusteriBilgileri.Controls.Add(this.label1);
            this.gpMusteriBilgileri.Location = new System.Drawing.Point(525, 12);
            this.gpMusteriBilgileri.Name = "gpMusteriBilgileri";
            this.gpMusteriBilgileri.Size = new System.Drawing.Size(405, 558);
            this.gpMusteriBilgileri.TabIndex = 0;
            this.gpMusteriBilgileri.TabStop = false;
            this.gpMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik Numara";
            // 
            // txtTctKimlikNo
            // 
            this.txtTctKimlikNo.Location = new System.Drawing.Point(163, 82);
            this.txtTctKimlikNo.Name = "txtTctKimlikNo";
            this.txtTctKimlikNo.Size = new System.Drawing.Size(236, 22);
            this.txtTctKimlikNo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "İsim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(163, 110);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(236, 22);
            this.txtIsim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyisim";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(163, 138);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(236, 22);
            this.txtSoyisim.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğum Tarih";
            // 
            // txtDogumTarih
            // 
            this.txtDogumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDogumTarih.Location = new System.Drawing.Point(163, 166);
            this.txtDogumTarih.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.txtDogumTarih.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.txtDogumTarih.Name = "txtDogumTarih";
            this.txtDogumTarih.Size = new System.Drawing.Size(236, 22);
            this.txtDogumTarih.TabIndex = 3;
            this.txtDogumTarih.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyet";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(163, 194);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(236, 24);
            this.cmbCinsiyet.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Meslek";
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(163, 224);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(236, 22);
            this.txtMeslek.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "E-Posta Adres";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(163, 252);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(236, 22);
            this.txtEposta.TabIndex = 6;
            // 
            // chkEpostaOnay
            // 
            this.chkEpostaOnay.AutoSize = true;
            this.chkEpostaOnay.Location = new System.Drawing.Point(163, 280);
            this.chkEpostaOnay.Name = "chkEpostaOnay";
            this.chkEpostaOnay.Size = new System.Drawing.Size(227, 21);
            this.chkEpostaOnay.TabIndex = 7;
            this.chkEpostaOnay.Text = "E posta bildirim almak istiyorum";
            this.chkEpostaOnay.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(163, 307);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(236, 22);
            this.txtTelefon.TabIndex = 8;
            // 
            // chkSmsOnay
            // 
            this.chkSmsOnay.AutoSize = true;
            this.chkSmsOnay.Location = new System.Drawing.Point(163, 335);
            this.chkSmsOnay.Name = "chkSmsOnay";
            this.chkSmsOnay.Size = new System.Drawing.Size(208, 21);
            this.chkSmsOnay.TabIndex = 9;
            this.chkSmsOnay.Text = "SMS bildirim almak istiyorum";
            this.chkSmsOnay.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(163, 374);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(236, 33);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(163, 413);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(236, 33);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // hediyePanel
            // 
            this.hediyePanel.Location = new System.Drawing.Point(12, 12);
            this.hediyePanel.Name = "hediyePanel";
            this.hediyePanel.Size = new System.Drawing.Size(507, 558);
            this.hediyePanel.TabIndex = 1;
            // 
            // anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 582);
            this.Controls.Add(this.hediyePanel);
            this.Controls.Add(this.gpMusteriBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "anaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promosyon Müşteri Takip Ekranı";
            this.Load += new System.EventHandler(this.anaEkran_Load);
            this.gpMusteriBilgileri.ResumeLayout(false);
            this.gpMusteriBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpMusteriBilgileri;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox chkSmsOnay;
        private System.Windows.Forms.CheckBox chkEpostaOnay;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker txtDogumTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTctKimlikNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel hediyePanel;
    }
}