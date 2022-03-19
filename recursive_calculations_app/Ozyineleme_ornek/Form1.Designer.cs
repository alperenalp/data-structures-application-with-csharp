
namespace Ozyineleme_ornek
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.butonTemizle = new System.Windows.Forms.Button();
            this.butonListele = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.butonSayiEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butonSapmaHesapla = new System.Windows.Forms.Button();
            this.sayiGiris = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.faktoriyelSonuc2 = new System.Windows.Forms.TextBox();
            this.faktoriyelSonuc1 = new System.Windows.Forms.TextBox();
            this.faktoriyelBul = new System.Windows.Forms.Button();
            this.faktoriyelGiris = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fibonacciSonuc2 = new System.Windows.Forms.TextBox();
            this.fibonacciSonuc1 = new System.Windows.Forms.TextBox();
            this.fibonacciGiris = new System.Windows.Forms.TextBox();
            this.fibonacciHesapla = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toplamaSonuc2 = new System.Windows.Forms.TextBox();
            this.toplamaSonuc1 = new System.Windows.Forms.TextBox();
            this.toplamaGiris = new System.Windows.Forms.TextBox();
            this.toplamBul = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 407);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gray;
            this.tabPage4.Controls.Add(this.listBox2);
            this.tabPage4.Controls.Add(this.butonTemizle);
            this.tabPage4.Controls.Add(this.butonListele);
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Controls.Add(this.butonSayiEkle);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.butonSapmaHesapla);
            this.tabPage4.Controls.Add(this.sayiGiris);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(555, 381);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Standar Sapma Bul";
            // 
            // butonTemizle
            // 
            this.butonTemizle.Location = new System.Drawing.Point(426, 269);
            this.butonTemizle.Name = "butonTemizle";
            this.butonTemizle.Size = new System.Drawing.Size(89, 41);
            this.butonTemizle.TabIndex = 12;
            this.butonTemizle.Text = "Temizle";
            this.butonTemizle.UseVisualStyleBackColor = true;
            this.butonTemizle.Click += new System.EventHandler(this.butonTemizle_Click);
            // 
            // butonListele
            // 
            this.butonListele.Location = new System.Drawing.Point(426, 78);
            this.butonListele.Name = "butonListele";
            this.butonListele.Size = new System.Drawing.Size(89, 41);
            this.butonListele.TabIndex = 11;
            this.butonListele.Text = "Sayıları Listele";
            this.butonListele.UseVisualStyleBackColor = true;
            this.butonListele.Click += new System.EventHandler(this.butonListele_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(426, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(96, 134);
            this.listBox1.TabIndex = 10;
            // 
            // butonSayiEkle
            // 
            this.butonSayiEkle.Location = new System.Drawing.Point(189, 78);
            this.butonSayiEkle.Name = "butonSayiEkle";
            this.butonSayiEkle.Size = new System.Drawing.Size(89, 41);
            this.butonSayiEkle.TabIndex = 9;
            this.butonSayiEkle.Text = "Sayi Ekle";
            this.butonSayiEkle.UseVisualStyleBackColor = true;
            this.butonSayiEkle.Click += new System.EventHandler(this.sayiEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(63, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sayiları giriniz";
            // 
            // butonSapmaHesapla
            // 
            this.butonSapmaHesapla.Location = new System.Drawing.Point(162, 163);
            this.butonSapmaHesapla.Name = "butonSapmaHesapla";
            this.butonSapmaHesapla.Size = new System.Drawing.Size(116, 48);
            this.butonSapmaHesapla.TabIndex = 5;
            this.butonSapmaHesapla.Text = "Standart Sapma Hesapla";
            this.butonSapmaHesapla.UseVisualStyleBackColor = true;
            this.butonSapmaHesapla.Click += new System.EventHandler(this.butonSapmaHesapla_Click);
            // 
            // sayiGiris
            // 
            this.sayiGiris.Location = new System.Drawing.Point(67, 88);
            this.sayiGiris.Multiline = true;
            this.sayiGiris.Name = "sayiGiris";
            this.sayiGiris.Size = new System.Drawing.Size(100, 31);
            this.sayiGiris.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.faktoriyelSonuc2);
            this.tabPage1.Controls.Add(this.faktoriyelSonuc1);
            this.tabPage1.Controls.Add(this.faktoriyelBul);
            this.tabPage1.Controls.Add(this.faktoriyelGiris);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Faktöriyel Hesapla";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // faktoriyelSonuc2
            // 
            this.faktoriyelSonuc2.Location = new System.Drawing.Point(212, 175);
            this.faktoriyelSonuc2.Multiline = true;
            this.faktoriyelSonuc2.Name = "faktoriyelSonuc2";
            this.faktoriyelSonuc2.Size = new System.Drawing.Size(100, 36);
            this.faktoriyelSonuc2.TabIndex = 3;
            this.faktoriyelSonuc2.Text = "İteratif Sonuç";
            // 
            // faktoriyelSonuc1
            // 
            this.faktoriyelSonuc1.Location = new System.Drawing.Point(85, 175);
            this.faktoriyelSonuc1.Multiline = true;
            this.faktoriyelSonuc1.Name = "faktoriyelSonuc1";
            this.faktoriyelSonuc1.Size = new System.Drawing.Size(100, 36);
            this.faktoriyelSonuc1.TabIndex = 2;
            this.faktoriyelSonuc1.Text = "Recursive Sonuç";
            // 
            // faktoriyelBul
            // 
            this.faktoriyelBul.Location = new System.Drawing.Point(212, 45);
            this.faktoriyelBul.Name = "faktoriyelBul";
            this.faktoriyelBul.Size = new System.Drawing.Size(108, 31);
            this.faktoriyelBul.TabIndex = 1;
            this.faktoriyelBul.Text = "Faktöriyel BUL";
            this.faktoriyelBul.UseVisualStyleBackColor = true;
            this.faktoriyelBul.Click += new System.EventHandler(this.FaktoriyelBul_Click);
            // 
            // faktoriyelGiris
            // 
            this.faktoriyelGiris.Location = new System.Drawing.Point(85, 45);
            this.faktoriyelGiris.Multiline = true;
            this.faktoriyelGiris.Name = "faktoriyelGiris";
            this.faktoriyelGiris.Size = new System.Drawing.Size(100, 31);
            this.faktoriyelGiris.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fibonacciSonuc2);
            this.tabPage2.Controls.Add(this.fibonacciSonuc1);
            this.tabPage2.Controls.Add(this.fibonacciGiris);
            this.tabPage2.Controls.Add(this.fibonacciHesapla);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(555, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fibonacci Hesapla";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fibonacciSonuc2
            // 
            this.fibonacciSonuc2.Location = new System.Drawing.Point(211, 172);
            this.fibonacciSonuc2.Multiline = true;
            this.fibonacciSonuc2.Name = "fibonacciSonuc2";
            this.fibonacciSonuc2.Size = new System.Drawing.Size(100, 31);
            this.fibonacciSonuc2.TabIndex = 3;
            this.fibonacciSonuc2.Text = "İteratif";
            // 
            // fibonacciSonuc1
            // 
            this.fibonacciSonuc1.Location = new System.Drawing.Point(70, 172);
            this.fibonacciSonuc1.Multiline = true;
            this.fibonacciSonuc1.Name = "fibonacciSonuc1";
            this.fibonacciSonuc1.Size = new System.Drawing.Size(100, 31);
            this.fibonacciSonuc1.TabIndex = 2;
            this.fibonacciSonuc1.Text = "Recursive ";
            // 
            // fibonacciGiris
            // 
            this.fibonacciGiris.Location = new System.Drawing.Point(70, 59);
            this.fibonacciGiris.Multiline = true;
            this.fibonacciGiris.Name = "fibonacciGiris";
            this.fibonacciGiris.Size = new System.Drawing.Size(100, 31);
            this.fibonacciGiris.TabIndex = 1;
            // 
            // fibonacciHesapla
            // 
            this.fibonacciHesapla.Location = new System.Drawing.Point(211, 52);
            this.fibonacciHesapla.Name = "fibonacciHesapla";
            this.fibonacciHesapla.Size = new System.Drawing.Size(124, 38);
            this.fibonacciHesapla.TabIndex = 0;
            this.fibonacciHesapla.Text = "fibonacci Hesapla";
            this.fibonacciHesapla.UseVisualStyleBackColor = true;
            this.fibonacciHesapla.Click += new System.EventHandler(this.fibonacciHesapla_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.toplamaSonuc2);
            this.tabPage3.Controls.Add(this.toplamaSonuc1);
            this.tabPage3.Controls.Add(this.toplamaGiris);
            this.tabPage3.Controls.Add(this.toplamBul);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(555, 381);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Toplama Yap";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toplamaSonuc2
            // 
            this.toplamaSonuc2.Location = new System.Drawing.Point(245, 191);
            this.toplamaSonuc2.Multiline = true;
            this.toplamaSonuc2.Name = "toplamaSonuc2";
            this.toplamaSonuc2.Size = new System.Drawing.Size(100, 31);
            this.toplamaSonuc2.TabIndex = 7;
            this.toplamaSonuc2.Text = "İteratif";
            // 
            // toplamaSonuc1
            // 
            this.toplamaSonuc1.Location = new System.Drawing.Point(104, 191);
            this.toplamaSonuc1.Multiline = true;
            this.toplamaSonuc1.Name = "toplamaSonuc1";
            this.toplamaSonuc1.Size = new System.Drawing.Size(100, 31);
            this.toplamaSonuc1.TabIndex = 6;
            this.toplamaSonuc1.Text = "Recursive ";
            // 
            // toplamaGiris
            // 
            this.toplamaGiris.Location = new System.Drawing.Point(104, 78);
            this.toplamaGiris.Multiline = true;
            this.toplamaGiris.Name = "toplamaGiris";
            this.toplamaGiris.Size = new System.Drawing.Size(100, 31);
            this.toplamaGiris.TabIndex = 5;
            // 
            // toplamBul
            // 
            this.toplamBul.Location = new System.Drawing.Point(245, 71);
            this.toplamBul.Name = "toplamBul";
            this.toplamBul.Size = new System.Drawing.Size(124, 38);
            this.toplamBul.TabIndex = 4;
            this.toplamBul.Text = "Toplam BUL";
            this.toplamBul.UseVisualStyleBackColor = true;
            this.toplamBul.Click += new System.EventHandler(this.toplamBul_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(67, 217);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(304, 134);
            this.listBox2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 407);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Veri Yapıları Uygulamaları";
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button faktoriyelBul;
        private System.Windows.Forms.TextBox faktoriyelGiris;
        private System.Windows.Forms.TextBox faktoriyelSonuc2;
        private System.Windows.Forms.TextBox faktoriyelSonuc1;
        private System.Windows.Forms.Button fibonacciHesapla;
        private System.Windows.Forms.TextBox fibonacciSonuc2;
        private System.Windows.Forms.TextBox fibonacciSonuc1;
        private System.Windows.Forms.TextBox fibonacciGiris;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox toplamaSonuc2;
        private System.Windows.Forms.TextBox toplamaSonuc1;
        private System.Windows.Forms.TextBox toplamaGiris;
        private System.Windows.Forms.Button toplamBul;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button butonSayiEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonSapmaHesapla;
        private System.Windows.Forms.TextBox sayiGiris;
        private System.Windows.Forms.Button butonListele;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button butonTemizle;
        private System.Windows.Forms.ListBox listBox2;
    }
}

