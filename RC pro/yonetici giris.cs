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

    public partial class yonetici_giris : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public yonetici_giris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yonetici_giris_Load(object sender, EventArgs e)
        {

        }

        private void giris_y_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM yonetici_giris where kullanici_adi_a=@user AND sifre=@pass";
            con = new SqlConnection("server=.; Initial Catalog=RC;Integrated Security=SSPI");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", Kullanici_adi_y.Text);
            cmd.Parameters.AddWithValue("@pass", sifre_y.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                yonetim yonet = new yonetim();
                yonetici_giris y = new yonetici_giris();
                yonet.Show();
                yonet.kullanici_listesi();
                this.Hide();
                yonet.Closed += (s, Args) => y.Show();
                y.Closed += (s, Args) => this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();

        }

        private void iptal_y_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kullanici_adi_y_Click(object sender, EventArgs e)
        {
            
        }

        private void sifre_y_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Kullanici_adi_y_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
