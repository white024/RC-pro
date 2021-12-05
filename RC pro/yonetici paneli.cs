using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RC_pro
{
    public partial class yonetim : Form
    {
        SqlConnection con;

        


        public yonetim()
        {
            InitializeComponent();
            con = new SqlConnection("server=.; database=RC; Integrated Security=True; ");
            
        }
                     

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void add_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (con.State==ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("insert into kullanici_list(ID_kullanici,kullanici_adi_u,sifre,IP) values (@ID_kullanici,@kullanici_adi_u,@sifre,@IP);", con);

                cmd.Parameters.AddWithValue("@ID_kullanici", ID.Text);
                cmd.Parameters.AddWithValue("@kullanici_adi_u", User_name.Text);
                cmd.Parameters.AddWithValue("@sifre", pass.Text);
                cmd.Parameters.AddWithValue("@IP", IP.Text);
                
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            
            listView1.Items.Clear();
            kullanici_listesi();

            ID.Clear();
            User_name.Clear();
            pass.Clear();
            IP.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            con.Close();
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void kullanici_listesi()
        {
            if (con.State==ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand ("SELECT * FROM kullanici_list order by ID_kullanici, kullanici_adi_u, sifre, IP", con);
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["ID_kullanici"].ToString();
                ekle.SubItems.Add(dr["kullanici_adi_u"].ToString());
                ekle.SubItems.Add(dr["sifre"].ToString());
                ekle.SubItems.Add(dr["IP"].ToString());

                listView1.Items.Add(ekle);

                

            }
               



            con.Close();
        }

        public void refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            kullanici_listesi();
            
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ID_Click(object sender, EventArgs e)
        {
            
        }

        private void User_name_Click(object sender, EventArgs e)
        {
            
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void IP_Click(object sender, EventArgs e)
        {
            
        }

        int id = 0;
        private void del_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (con.State==ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Delete from kullanici_list where ID_kullanici=(" +id+ ")", con);
                cmd.ExecuteNonQuery();
                listView1.Items.Clear();
                kullanici_listesi();
                

                MessageBox.Show("silme işlemi gerçekleşti");

            }
            catch (Exception err)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + err.Message);
            }
            con.Close();
        }

        public void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
        }
       

        public void edit_Click(object sender, EventArgs e)
        {
            yonetim y = new yonetim();
            edit_kullanici ed = new edit_kullanici();
            //try
            //{
            //    ed.id_edit.Text = listView1.SelectedItems[0].SubItems[0].Text;
            //    ed.user_name_edit.Text = listView1.SelectedItems[0].SubItems[1].Text;
            //    ed.pass_edit.Text = listView1.SelectedItems[0].SubItems[2].Text;
            //    ed.ip_edit.Text = listView1.SelectedItems[0].SubItems[3].Text;
            this.Hide();
            ed.Show();
            ed.Closed += (s, Args) => y.Show();
            y.Closed += (s, Args) => this.Close();
            ed.kullanici_list_e();
            


            //}
            //catch(Exception err)
            //{
            //    MessageBox.Show("İşlem Sırasında Hata Oluştu." + err.Message);
            //}

        }
        public void edit_list()
        {
           edit_kullanici edit = new edit_kullanici();
            
        }


        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        public void Sifremi_Unuttum_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void f_pass()
        {
            try
            {
                con = new SqlConnection("server=.; Initial Catalog=RC;Integrated Security=SSPI");
                if (con.State==ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("select* from unutulan_sifre order by ID_sifre", con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Sifremi_Unuttum_y.Items.Add(dr["ID_sifre"].ToString());

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("bir hata ile karşılaşıldı ", err.Message);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Sifremi_Unuttum_y.Items.Clear();
            f_pass();                       

        }
    }
}
