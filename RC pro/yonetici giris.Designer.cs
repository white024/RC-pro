namespace RC_pro
{
    partial class yonetici_giris
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
            this.Kullanici_adi_y = new System.Windows.Forms.TextBox();
            this.sifre_y = new System.Windows.Forms.TextBox();
            this.iptal_y = new System.Windows.Forms.Button();
            this.giris_y = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kullanici_adi_y
            // 
            this.Kullanici_adi_y.Location = new System.Drawing.Point(309, 165);
            this.Kullanici_adi_y.Name = "Kullanici_adi_y";
            this.Kullanici_adi_y.Size = new System.Drawing.Size(187, 22);
            this.Kullanici_adi_y.TabIndex = 0;
            this.Kullanici_adi_y.Click += new System.EventHandler(this.Kullanici_adi_y_Click);
            this.Kullanici_adi_y.TextChanged += new System.EventHandler(this.Kullanici_adi_y_TextChanged);
            // 
            // sifre_y
            // 
            this.sifre_y.Location = new System.Drawing.Point(309, 212);
            this.sifre_y.Name = "sifre_y";
            this.sifre_y.PasswordChar = '*';
            this.sifre_y.Size = new System.Drawing.Size(187, 22);
            this.sifre_y.TabIndex = 1;
            this.sifre_y.TextChanged += new System.EventHandler(this.sifre_y_TextChanged);
            // 
            // iptal_y
            // 
            this.iptal_y.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iptal_y.Location = new System.Drawing.Point(309, 312);
            this.iptal_y.Name = "iptal_y";
            this.iptal_y.Size = new System.Drawing.Size(75, 25);
            this.iptal_y.TabIndex = 2;
            this.iptal_y.Text = "iptal";
            this.iptal_y.UseVisualStyleBackColor = true;
            this.iptal_y.Click += new System.EventHandler(this.iptal_y_Click);
            // 
            // giris_y
            // 
            this.giris_y.Location = new System.Drawing.Point(421, 312);
            this.giris_y.Name = "giris_y";
            this.giris_y.Size = new System.Drawing.Size(75, 25);
            this.giris_y.TabIndex = 3;
            this.giris_y.Text = "giriş";
            this.giris_y.UseVisualStyleBackColor = true;
            this.giris_y.Click += new System.EventHandler(this.giris_y_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yönetici modu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lütfen kullanıcı adı ve şifre giriniz...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanıcı Adı Giriniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre Giriniz:";
            // 
            // yonetici_giris
            // 
            this.AcceptButton = this.giris_y;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.iptal_y;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giris_y);
            this.Controls.Add(this.iptal_y);
            this.Controls.Add(this.sifre_y);
            this.Controls.Add(this.Kullanici_adi_y);
            this.Name = "yonetici_giris";
            this.Text = "yönetici giriş";
            this.Load += new System.EventHandler(this.yonetici_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Kullanici_adi_y;
        private System.Windows.Forms.TextBox sifre_y;
        private System.Windows.Forms.Button iptal_y;
        private System.Windows.Forms.Button giris_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}