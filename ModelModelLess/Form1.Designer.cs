namespace ModelModelLess
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
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnGosterPopUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoster.Location = new System.Drawing.Point(235, 27);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(217, 93);
            this.btnGoster.TabIndex = 0;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnGosterPopUp
            // 
            this.btnGosterPopUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGosterPopUp.Location = new System.Drawing.Point(773, 27);
            this.btnGosterPopUp.Name = "btnGosterPopUp";
            this.btnGosterPopUp.Size = new System.Drawing.Size(217, 93);
            this.btnGosterPopUp.TabIndex = 1;
            this.btnGosterPopUp.Text = "Göster PopUp";
            this.btnGosterPopUp.UseVisualStyleBackColor = false;
            this.btnGosterPopUp.Click += new System.EventHandler(this.btnGosterPopUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 595);
            this.Controls.Add(this.btnGosterPopUp);
            this.Controls.Add(this.btnGoster);
            this.Name = "Form1";
            this.Text = "Ana Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnGosterPopUp;
    }
}

