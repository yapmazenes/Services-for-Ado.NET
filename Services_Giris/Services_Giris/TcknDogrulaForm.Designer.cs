namespace Services_Giris
{
    partial class TcknDogrulaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskdTCKN = new System.Windows.Forms.MaskedTextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.msk_txt_dogumyili = new System.Windows.Forms.MaskedTextBox();
            this.btn_Dogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKN : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyisim";
            // 
            // mskdTCKN
            // 
            this.mskdTCKN.Location = new System.Drawing.Point(92, 21);
            this.mskdTCKN.Mask = "00000000000";
            this.mskdTCKN.Name = "mskdTCKN";
            this.mskdTCKN.Size = new System.Drawing.Size(100, 20);
            this.mskdTCKN.TabIndex = 3;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(92, 51);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 20);
            this.txt_isim.TabIndex = 4;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(92, 77);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(100, 20);
            this.txt_soyisim.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doğum yılı";
            // 
            // msk_txt_dogumyili
            // 
            this.msk_txt_dogumyili.Location = new System.Drawing.Point(92, 110);
            this.msk_txt_dogumyili.Mask = "0000";
            this.msk_txt_dogumyili.Name = "msk_txt_dogumyili";
            this.msk_txt_dogumyili.Size = new System.Drawing.Size(100, 20);
            this.msk_txt_dogumyili.TabIndex = 3;
            // 
            // btn_Dogrula
            // 
            this.btn_Dogrula.Location = new System.Drawing.Point(92, 137);
            this.btn_Dogrula.Name = "btn_Dogrula";
            this.btn_Dogrula.Size = new System.Drawing.Size(100, 23);
            this.btn_Dogrula.TabIndex = 6;
            this.btn_Dogrula.Text = "Doğrula";
            this.btn_Dogrula.UseVisualStyleBackColor = true;
            this.btn_Dogrula.Click += new System.EventHandler(this.btn_Dogrula_Click);
            // 
            // TcknDogrulaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 213);
            this.Controls.Add(this.btn_Dogrula);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.msk_txt_dogumyili);
            this.Controls.Add(this.mskdTCKN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TcknDogrulaForm";
            this.Text = "TcknDogrulaForm";
            this.Load += new System.EventHandler(this.TcknDogrulaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskdTCKN;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msk_txt_dogumyili;
        private System.Windows.Forms.Button btn_Dogrula;
    }
}