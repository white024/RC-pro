namespace RC_pro
{
    partial class edit_kullanici
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
            this.label04 = new System.Windows.Forms.Label();
            this.label03 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.label01 = new System.Windows.Forms.Label();
            this.id_edit = new System.Windows.Forms.TextBox();
            this.ip_edit = new System.Windows.Forms.TextBox();
            this.pass_edit = new System.Windows.Forms.TextBox();
            this.user_name_edit = new System.Windows.Forms.TextBox();
            this.edit_e = new System.Windows.Forms.Button();
            this.list_e = new System.Windows.Forms.ListView();
            this.ID_e = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_name_e = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pass_e = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ip_e = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refresh_e = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label04.Location = new System.Drawing.Point(62, 149);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(61, 16);
            this.label04.TabIndex = 24;
            this.label04.Text = "IP Giriniz:";
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label03.Location = new System.Drawing.Point(62, 121);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(76, 16);
            this.label03.TabIndex = 23;
            this.label03.Text = "Şifre Giriniz:";
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label02.Location = new System.Drawing.Point(59, 95);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(121, 16);
            this.label02.TabIndex = 22;
            this.label02.Text = "Kullanıcı Adı Giriniz:";
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label01.Location = new System.Drawing.Point(62, 71);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(62, 16);
            this.label01.TabIndex = 21;
            this.label01.Text = "ID Giriniz:";
            this.label01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // id_edit
            // 
            this.id_edit.Location = new System.Drawing.Point(191, 65);
            this.id_edit.Name = "id_edit";
            this.id_edit.Size = new System.Drawing.Size(217, 22);
            this.id_edit.TabIndex = 16;
            this.id_edit.TextChanged += new System.EventHandler(this.id_edit_TextChanged);
            // 
            // ip_edit
            // 
            this.ip_edit.Location = new System.Drawing.Point(191, 149);
            this.ip_edit.Name = "ip_edit";
            this.ip_edit.Size = new System.Drawing.Size(217, 22);
            this.ip_edit.TabIndex = 19;
            // 
            // pass_edit
            // 
            this.pass_edit.Location = new System.Drawing.Point(191, 121);
            this.pass_edit.Name = "pass_edit";
            this.pass_edit.Size = new System.Drawing.Size(217, 22);
            this.pass_edit.TabIndex = 18;
            // 
            // user_name_edit
            // 
            this.user_name_edit.Location = new System.Drawing.Point(191, 93);
            this.user_name_edit.Name = "user_name_edit";
            this.user_name_edit.Size = new System.Drawing.Size(217, 22);
            this.user_name_edit.TabIndex = 17;
            // 
            // edit_e
            // 
            this.edit_e.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.edit_e.Location = new System.Drawing.Point(333, 194);
            this.edit_e.Name = "edit_e";
            this.edit_e.Size = new System.Drawing.Size(75, 25);
            this.edit_e.TabIndex = 20;
            this.edit_e.Text = "kaydet";
            this.edit_e.UseVisualStyleBackColor = true;
            this.edit_e.Click += new System.EventHandler(this.edit_e_Click);
            // 
            // list_e
            // 
            this.list_e.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_e,
            this.user_name_e,
            this.pass_e,
            this.ip_e});
            this.list_e.HideSelection = false;
            this.list_e.Location = new System.Drawing.Point(429, 26);
            this.list_e.Name = "list_e";
            this.list_e.Size = new System.Drawing.Size(501, 395);
            this.list_e.TabIndex = 25;
            this.list_e.UseCompatibleStateImageBehavior = false;
            this.list_e.View = System.Windows.Forms.View.Details;
            this.list_e.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.list_e.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_e_MouseClick);
            // 
            // ID_e
            // 
            this.ID_e.Text = "ID";
            // 
            // user_name_e
            // 
            this.user_name_e.Text = "Kullanıcı adı";
            this.user_name_e.Width = 155;
            // 
            // pass_e
            // 
            this.pass_e.Text = "Şifre";
            this.pass_e.Width = 134;
            // 
            // ip_e
            // 
            this.ip_e.Text = "IP";
            this.ip_e.Width = 125;
            // 
            // refresh_e
            // 
            this.refresh_e.Location = new System.Drawing.Point(823, 427);
            this.refresh_e.Name = "refresh_e";
            this.refresh_e.Size = new System.Drawing.Size(93, 29);
            this.refresh_e.TabIndex = 26;
            this.refresh_e.Text = "listeyi yenile";
            this.refresh_e.UseVisualStyleBackColor = true;
            this.refresh_e.Click += new System.EventHandler(this.refresh_e_Click);
            // 
            // edit_kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 487);
            this.Controls.Add(this.refresh_e);
            this.Controls.Add(this.list_e);
            this.Controls.Add(this.label04);
            this.Controls.Add(this.label03);
            this.Controls.Add(this.label02);
            this.Controls.Add(this.label01);
            this.Controls.Add(this.id_edit);
            this.Controls.Add(this.ip_edit);
            this.Controls.Add(this.pass_edit);
            this.Controls.Add(this.user_name_edit);
            this.Controls.Add(this.edit_e);
            this.Name = "edit_kullanici";
            this.Text = "düzenle";
            this.Load += new System.EventHandler(this.edit_kullanici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label04;
        private System.Windows.Forms.Label label03;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.Label label01;
        public System.Windows.Forms.TextBox id_edit;
        public System.Windows.Forms.TextBox ip_edit;
        public System.Windows.Forms.TextBox pass_edit;
        public System.Windows.Forms.TextBox user_name_edit;
        public System.Windows.Forms.Button edit_e;
        public System.Windows.Forms.ColumnHeader ID_e;
        private System.Windows.Forms.ColumnHeader user_name_e;
        private System.Windows.Forms.ColumnHeader pass_e;
        private System.Windows.Forms.ColumnHeader ip_e;
        public System.Windows.Forms.ListView list_e;
        public System.Windows.Forms.Button refresh_e;
    }
}