namespace RC_pro
{
    partial class yonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yonetim));
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.User_name = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.Sifremi_Unuttum_y = new System.Windows.Forms.ListBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kullanici_adi_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sifre_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            resources.ApplyResources(this.add, "add");
            this.add.Name = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // del
            // 
            resources.ApplyResources(this.del, "del");
            this.del.Name = "del";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // exit
            // 
            resources.ApplyResources(this.exit, "exit");
            this.exit.Name = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // User_name
            // 
            resources.ApplyResources(this.User_name, "User_name");
            this.User_name.Name = "User_name";
            this.User_name.Click += new System.EventHandler(this.User_name_Click);
            // 
            // pass
            // 
            resources.ApplyResources(this.pass, "pass");
            this.pass.Name = "pass";
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // edit
            // 
            resources.ApplyResources(this.edit, "edit");
            this.edit.Name = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Sifremi_Unuttum_y
            // 
            this.Sifremi_Unuttum_y.FormattingEnabled = true;
            resources.ApplyResources(this.Sifremi_Unuttum_y, "Sifremi_Unuttum_y");
            this.Sifremi_Unuttum_y.Name = "Sifremi_Unuttum_y";
            this.Sifremi_Unuttum_y.SelectedIndexChanged += new System.EventHandler(this.Sifremi_Unuttum_SelectedIndexChanged);
            // 
            // IP
            // 
            resources.ApplyResources(this.IP, "IP");
            this.IP.Name = "IP";
            this.IP.Click += new System.EventHandler(this.IP_Click);
            // 
            // ID
            // 
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_list,
            this.kullanici_adi_list,
            this.sifre_list,
            this.IP_list});
            this.listView1.HideSelection = false;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // ID_list
            // 
            resources.ApplyResources(this.ID_list, "ID_list");
            // 
            // kullanici_adi_list
            // 
            resources.ApplyResources(this.kullanici_adi_list, "kullanici_adi_list");
            // 
            // sifre_list
            // 
            resources.ApplyResources(this.sifre_list, "sifre_list");
            // 
            // IP_list
            // 
            resources.ApplyResources(this.IP_list, "IP_list");
            // 
            // refresh
            // 
            resources.ApplyResources(this.refresh, "refresh");
            this.refresh.Name = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yonetim
            // 
            this.AcceptButton = this.add;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.Sifremi_Unuttum_y);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Name = "yonetim";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox User_name;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.ColumnHeader ID_list;
        private System.Windows.Forms.ColumnHeader kullanici_adi_list;
        private System.Windows.Forms.ColumnHeader sifre_list;
        private System.Windows.Forms.ColumnHeader IP_list;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ListBox Sifremi_Unuttum_y;
        private System.Windows.Forms.Button button1;
    }
}