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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        

        }

        private void yonetici_Click(object sender, EventArgs e)
        {
            yonetici_giris Ypanel = new yonetici_giris(); 
            giris g = new giris();
            Ypanel.Show();
            this.Hide();
            Ypanel.Closed += (s, args) => g.Show();
            g.Closed += (s, args) => this.Close();
            
        }
        private void Kullanici_adi_TextChanged(object sender, EventArgs e)
        {

        }
        private void sifre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void iptal_ana_menu_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }

        private void Kullanici_adi_Click(object sender, EventArgs e)
        {
          
        }

        private void giris_Click(object sender, EventArgs e)
        {

        }

        private void Kullanici_adi_Click_1(object sender, EventArgs e)
        {

        }

        private void sifre_Click(object sender, EventArgs e)
        {

        }

        private void giris_ana_menu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd;
            SqlDataReader dr;

                
            try
            {
                
                    
                string sorgu = "SELECT * FROM kullanici_list where kullanici_adi_u=@user AND sifre=@pass";
                con = new SqlConnection("server=.; Initial Catalog=RC;Integrated Security=SSPI");
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@user", Kullanici_adi.Text);
                cmd.Parameters.AddWithValue("@pass", sifre.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    mesaj m = new mesaj();
                    giris g = new giris();
                    m.Show();
                    this.Hide();
                    m.Closed += (s, Args) => g.Show();
                    g.Closed += (s, Args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("bir hata ile karşılaşıldı" + err.Message);
            }
            
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            giris g = new giris();
            sifremi_unuttum su = new sifremi_unuttum();
            this.Hide();
            su.Show();
            su.Closed += (s, Args) => g.Show();
            g.Closed += (s, Args) => this.Close();

        }
    }
}
