namespace ReflectionWinForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_object = new System.Windows.Forms.TextBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lst_ctors = new System.Windows.Forms.ListBox();
            this.lst_meths = new System.Windows.Forms.ListBox();
            this.lst_props = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_getir);
            this.groupBox1.Controls.Add(this.txt_object);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1422, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lütfen bilgi almak istediğiniz classın adını giriniz.";
            // 
            // txt_object
            // 
            this.txt_object.Location = new System.Drawing.Point(7, 22);
            this.txt_object.Name = "txt_object";
            this.txt_object.Size = new System.Drawing.Size(1229, 22);
            this.txt_object.TabIndex = 0;
            // 
            // btn_getir
            // 
            this.btn_getir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_getir.Location = new System.Drawing.Point(1270, 13);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(145, 41);
            this.btn_getir.TabIndex = 1;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = false;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_ctors);
            this.groupBox2.Location = new System.Drawing.Point(45, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 665);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ConstructorInfo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_meths);
            this.groupBox3.Location = new System.Drawing.Point(1003, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 665);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MethodInfo";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lst_props);
            this.groupBox4.Location = new System.Drawing.Point(529, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 665);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PropertyInfo";
            // 
            // lst_ctors
            // 
            this.lst_ctors.FormattingEnabled = true;
            this.lst_ctors.ItemHeight = 16;
            this.lst_ctors.Location = new System.Drawing.Point(7, 22);
            this.lst_ctors.Name = "lst_ctors";
            this.lst_ctors.Size = new System.Drawing.Size(371, 628);
            this.lst_ctors.TabIndex = 0;
            // 
            // lst_meths
            // 
            this.lst_meths.FormattingEnabled = true;
            this.lst_meths.ItemHeight = 16;
            this.lst_meths.Location = new System.Drawing.Point(6, 22);
            this.lst_meths.Name = "lst_meths";
            this.lst_meths.Size = new System.Drawing.Size(371, 628);
            this.lst_meths.TabIndex = 2;
            // 
            // lst_props
            // 
            this.lst_props.FormattingEnabled = true;
            this.lst_props.ItemHeight = 16;
            this.lst_props.Location = new System.Drawing.Point(6, 22);
            this.lst_props.Name = "lst_props";
            this.lst_props.Size = new System.Drawing.Size(371, 628);
            this.lst_props.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 772);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Reflection Win Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.TextBox txt_object;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lst_ctors;
        private System.Windows.Forms.ListBox lst_meths;
        private System.Windows.Forms.ListBox lst_props;
    }
}

