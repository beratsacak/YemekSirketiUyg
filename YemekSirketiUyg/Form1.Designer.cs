namespace YemekSirketiUyg
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.telefonTxt = new System.Windows.Forms.TextBox();
            this.adSoyadTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tatliSayi = new System.Windows.Forms.NumericUpDown();
            this.anaYemekSayi = new System.Windows.Forms.NumericUpDown();
            this.salataSayi = new System.Windows.Forms.NumericUpDown();
            this.corbaSayi = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tatliSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaYemekSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salataSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corbaSayi)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 362);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.adresTxt);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.telefonTxt);
            this.tabPage1.Controls.Add(this.adSoyadTxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // adresTxt
            // 
            this.adresTxt.Location = new System.Drawing.Point(168, 121);
            this.adresTxt.Multiline = true;
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(216, 125);
            this.adresTxt.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(168, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 20);
            this.textBox3.TabIndex = 1;
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(168, 84);
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(193, 20);
            this.telefonTxt.TabIndex = 1;
            // 
            // adSoyadTxt
            // 
            this.adSoyadTxt.Location = new System.Drawing.Point(168, 47);
            this.adSoyadTxt.Name = "adSoyadTxt";
            this.adSoyadTxt.Size = new System.Drawing.Size(193, 20);
            this.adSoyadTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tatliSayi);
            this.tabPage2.Controls.Add(this.anaYemekSayi);
            this.tabPage2.Controls.Add(this.salataSayi);
            this.tabPage2.Controls.Add(this.corbaSayi);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sipariş";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tatliSayi
            // 
            this.tatliSayi.Location = new System.Drawing.Point(209, 135);
            this.tatliSayi.Name = "tatliSayi";
            this.tatliSayi.Size = new System.Drawing.Size(120, 20);
            this.tatliSayi.TabIndex = 1;
            // 
            // anaYemekSayi
            // 
            this.anaYemekSayi.Location = new System.Drawing.Point(209, 98);
            this.anaYemekSayi.Name = "anaYemekSayi";
            this.anaYemekSayi.Size = new System.Drawing.Size(120, 20);
            this.anaYemekSayi.TabIndex = 1;
            // 
            // salataSayi
            // 
            this.salataSayi.Location = new System.Drawing.Point(209, 62);
            this.salataSayi.Name = "salataSayi";
            this.salataSayi.Size = new System.Drawing.Size(120, 20);
            this.salataSayi.TabIndex = 1;
            // 
            // corbaSayi
            // 
            this.corbaSayi.Location = new System.Drawing.Point(209, 26);
            this.corbaSayi.Name = "corbaSayi";
            this.corbaSayi.Size = new System.Drawing.Size(120, 20);
            this.corbaSayi.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tatlı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ana Yemek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Salata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Çorba";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtBilgi);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(920, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hesap";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // txtBilgi
            // 
            this.txtBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBilgi.Location = new System.Drawing.Point(3, 3);
            this.txtBilgi.Multiline = true;
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(914, 330);
            this.txtBilgi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 362);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tatliSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaYemekSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salataSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corbaSayi)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox adresTxt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox telefonTxt;
        private System.Windows.Forms.TextBox adSoyadTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tatliSayi;
        private System.Windows.Forms.NumericUpDown anaYemekSayi;
        private System.Windows.Forms.NumericUpDown salataSayi;
        private System.Windows.Forms.NumericUpDown corbaSayi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBilgi;
    }
}

