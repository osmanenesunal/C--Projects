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
namespace Personel_Kayit
{
    public partial class formgiriş : Form
    {
        public formgiriş()
        {
            InitializeComponent();
        }
        SqlConnection baglantii = new SqlConnection("Data Source=OSMAN\\SQLEXPRESS;Initial Catalog=Personel_İslem;Integrated Security=True");
        private void formgiriş_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            baglantii.Open();

            SqlCommand komutgiris1 = new SqlCommand("Select * from tbl_giris where kullaniciadi = @p1 and kullanicisife = @p2",baglantii);
            komutgiris1.Parameters.AddWithValue("@p1",txtgiris.Text);
            komutgiris1.Parameters.AddWithValue("@p2",txtsifre.Text);
            
            SqlDataReader rd1 = komutgiris1.ExecuteReader();
            if (rd1.Read())
            {
                Anaform1 frm = new Anaform1();
                frm.Show();
                this.Hide();



            }

            else
            {
                MessageBox.Show("Hatalı Giriş Lütfen Tekrar Deneyin");
            }

            baglantii.Close();




        }
    }
}
