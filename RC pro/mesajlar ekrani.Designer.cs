namespace RC_pro
{
    partial class mesaj
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
            this.send = new System.Windows.Forms.Button();
            this.Gelen_Kutusu = new System.Windows.Forms.ListBox();
            this.Mesajlar = new System.Windows.Forms.RichTextBox();
            this.Mesaj_Yaz = new System.Windows.Forms.RichTextBox();
            this.Başlık = new System.Windows.Forms.Label();
            this.exit_m = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(697, 469);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 25);
            this.send.TabIndex = 0;
            this.send.Text = "gönder";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gelen_Kutusu
            // 
            this.Gelen_Kutusu.FormattingEnabled = true;
            this.Gelen_Kutusu.ItemHeight = 16;
            this.Gelen_Kutusu.Location = new System.Drawing.Point(28, 94);
            this.Gelen_Kutusu.Name = "Gelen_Kutusu";
            this.Gelen_Kutusu.Size = new System.Drawing.Size(120, 372);
            this.Gelen_Kutusu.TabIndex = 2;
            this.Gelen_Kutusu.SelectedIndexChanged += new System.EventHandler(this.Gelen_Kutusu_SelectedIndexChanged);
            // 
            // Mesajlar
            // 
            this.Mesajlar.Location = new System.Drawing.Point(250, 86);
            this.Mesajlar.Name = "Mesajlar";
            this.Mesajlar.ReadOnly = true;
            this.Mesajlar.Size = new System.Drawing.Size(522, 196);
            this.Mesajlar.TabIndex = 4;
            this.Mesajlar.Text = "Mesajın yok";
            // 
            // Mesaj_Yaz
            // 
            this.Mesaj_Yaz.Location = new System.Drawing.Point(250, 300);
            this.Mesaj_Yaz.Name = "Mesaj_Yaz";
            this.Mesaj_Yaz.Size = new System.Drawing.Size(522, 163);
            this.Mesaj_Yaz.TabIndex = 5;
            this.Mesaj_Yaz.Tag = "";
            this.Mesaj_Yaz.Text = "Mesaj yaz...";
            // 
            // Başlık
            // 
            this.Başlık.Location = new System.Drawing.Point(28, 94);
            this.Başlık.Name = "Başlık";
            this.Başlık.Size = new System.Drawing.Size(120, 27);
            this.Başlık.TabIndex = 6;
            this.Başlık.Text = "Gelen Kutusu";
            this.Başlık.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Başlık.Click += new System.EventHandler(this.label1_Click);
            // 
            // exit_m
            // 
            this.exit_m.Location = new System.Drawing.Point(30, 487);
            this.exit_m.Name = "exit_m";
            this.exit_m.Size = new System.Drawing.Size(75, 25);
            this.exit_m.TabIndex = 7;
            this.exit_m.Text = "çıkış yap";
            this.exit_m.UseVisualStyleBackColor = true;
            this.exit_m.Click += new System.EventHandler(this.exit_m_Click);
            // 
            // mesaj
            // 
            this.AcceptButton = this.send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 532);
            this.Controls.Add(this.exit_m);
            this.Controls.Add(this.Başlık);
            this.Controls.Add(this.Mesaj_Yaz);
            this.Controls.Add(this.Mesajlar);
            this.Controls.Add(this.Gelen_Kutusu);
            this.Controls.Add(this.send);
            this.Name = "mesaj";
            this.Text = "Mesajlaşma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button send;
        private System.Windows.Forms.RichTextBox Mesajlar;
        private System.Windows.Forms.RichTextBox Mesaj_Yaz;
        private System.Windows.Forms.ListBox Gelen_Kutusu;
        private System.Windows.Forms.Label Başlık;
        private System.Windows.Forms.Button exit_m;
    }
}

