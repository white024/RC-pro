namespace RC_pro
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.Kullanici_adi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.giris_ana_menu = new System.Windows.Forms.Button();
            this.iptal_ana_menu = new System.Windows.Forms.Button();
            this.yonetici = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kullanici_adi
            // 
            this.Kullanici_adi.AcceptsTab = true;
            resources.ApplyResources(this.Kullanici_adi, "Kullanici_adi");
            this.Kullanici_adi.Name = "Kullanici_adi";
            this.Kullanici_adi.Click += new System.EventHandler(this.Kullanici_adi_Click_1);
            this.Kullanici_adi.TextChanged += new System.EventHandler(this.Kullanici_adi_TextChanged);
            // 
            // sifre
            // 
            resources.ApplyResources(this.sifre, "sifre");
            this.sifre.Name = "sifre";
            this.sifre.Click += new System.EventHandler(this.sifre_Click);
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // giris_ana_menu
            // 
            resources.ApplyResources(this.giris_ana_menu, "giris_ana_menu");
            this.giris_ana_menu.Name = "giris_ana_menu";
            this.giris_ana_menu.UseVisualStyleBackColor = true;
            this.giris_ana_menu.Click += new System.EventHandler(this.giris_ana_menu_Click);
            // 
            // iptal_ana_menu
            // 
            resources.ApplyResources(this.iptal_ana_menu, "iptal_ana_menu");
            this.iptal_ana_menu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iptal_ana_menu.Name = "iptal_ana_menu";
            this.iptal_ana_menu.UseVisualStyleBackColor = true;
            this.iptal_ana_menu.Click += new System.EventHandler(this.iptal_ana_menu_Click);
            // 
            // yonetici
            // 
            resources.ApplyResources(this.yonetici, "yonetici");
            this.yonetici.Name = "yonetici";
            this.yonetici.UseVisualStyleBackColor = true;
            this.yonetici.Click += new System.EventHandler(this.yonetici_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // giris
            // 
            this.AcceptButton = this.giris_ana_menu;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.iptal_ana_menu;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yonetici);
            this.Controls.Add(this.iptal_ana_menu);
            this.Controls.Add(this.giris_ana_menu);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.Kullanici_adi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "giris";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.giris_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Kullanici_adi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button giris_ana_menu;
        private System.Windows.Forms.Button iptal_ana_menu;
        private System.Windows.Forms.Button yonetici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}