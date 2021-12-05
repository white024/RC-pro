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
    public partial class sifremi_unuttum : Form
    {
        public sifremi_unuttum()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con;
        

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            
            

        }
        public void pass_k()
        {
            yonetim y = new yonetim();
            try
            {
                con = new SqlConnection("server=.; Initial Catalog=RC;Integrated Security=SSPI");
                if (con.State==ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("insert into unutulan_sifre(ID_sifre) values (@ID_pass)", con);
                cmd.Parameters.AddWithValue("@ID_pass", textBox1.Text);
                cmd.ExecuteNonQuery();
                textBox1.Text = "";
                MessageBox.Show("işlem başarılı");

            }
            catch (Exception err)
            {
                MessageBox.Show("bir hata ile karşolaşıldı", err.Message);
            }
            con.Close();
        }

        int id = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           id = int.Parse(comboBox1.SelectedItem.ToString());
            textBox1.Text = id.ToString();

            
        }

        private void sifremi_unuttum_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("server=.; Initial Catalog=RC;Integrated Security=SSPI");
                if (con.State==ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("select* from kullanici_list order by kullanici_adi_u", con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["kullanici_adi_u"].ToString());

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("bir hata ile karşılaşıldı ", err.Message);
            }
            con.Close();
        }
    }
}
