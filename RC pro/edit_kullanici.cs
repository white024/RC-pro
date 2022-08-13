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
    public partial class edit_kullanici : Form
    {

        

        public edit_kullanici()
        { //Oğuzhan 
            InitializeComponent();
            con = new SqlConnection("server=.; database=RC; Integrated Security=True; ");
            
        }

        public void edit_kullanici_Load(object sender, EventArgs e)
        {
            

        }
        SqlConnection con;

        int id = 0;
        public void edit_e_Click(object sender, EventArgs e)

        {
            /*yonetim y = new yonetim()*/;

           

            try
            {


                con = new SqlConnection("server=.; database=RC; Integrated Security=True; ");


                if (con.State==ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE kullanici_list SET ID_kullanici='"+id_edit.Text.ToString()+"', kullanici_adi_u='"+user_name_edit.Text.ToString()+"', sifre='"+pass_edit.Text.ToString()+"', IP='"+ip_edit.Text.ToString()+"' where ID_kullanici="+id+"", con);



                cmd.ExecuteNonQuery();

                MessageBox.Show("Müşteri Bilgileri Güncellendi.");
            }
            catch (Exception err)
            {
                MessageBox.Show("bir hata ile karşılaşıldı" + err.Message);
            }
            con.Close();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            list_e.Items.Clear();
            kullanici_list_e();


            //y.edit_list();
            //Close();
            //y.listView1.Items.Clear();
            //y.kullanici_listesi();

        }

        private void id_edit_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //yonetim y = new yonetim();
            //y.listView1.SelectedItems.ToString();
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void kullanici_list_e()
        {
            try
            {
                if (con.State==ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM kullanici_list order by ID_kullanici, kullanici_adi_u, sifre, IP", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = dr["ID_kullanici"].ToString();
                    ekle.SubItems.Add(dr["kullanici_adi_u"].ToString());
                    ekle.SubItems.Add(dr["sifre"].ToString());
                    ekle.SubItems.Add(dr["IP"].ToString());

                    list_e.Items.Add(ekle);
                }
            }
            catch(Exception err) 
            { 
                MessageBox.Show("işlem sırasında bir hata oluştu ", err.Message);
            }
            con.Close();
            
        }

        public void refresh_e_Click(object sender, EventArgs e)
        {
            //yonetim y = new yonetim();
            list_e.Items.Clear();
            kullanici_list_e();
           
        }

        public void list_e_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(list_e.SelectedItems[0].SubItems[0].Text);
            id_edit.Text = list_e.SelectedItems[0].SubItems[0].Text;
            user_name_edit.Text = list_e.SelectedItems[0].SubItems[1].Text;
            pass_edit.Text = list_e.SelectedItems[0].SubItems[2].Text;
            ip_edit.Text = list_e.SelectedItems[0].SubItems[3].Text;
        }
    }
}
