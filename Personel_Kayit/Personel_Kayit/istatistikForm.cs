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
    public partial class istatistikForm : Form
    {
        SqlConnection baglantii = new SqlConnection("Data Source=OSMAN\\SQLEXPRESS;Initial Catalog=Personel_İslem;Integrated Security=True");


        public istatistikForm()
        {
            InitializeComponent();
        }
        //Toplam Personel Sayısı
        private void istatistikForm_Load(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand komut1 = new SqlCommand("SELECT COUNT(*) FROM tbl_personell",baglantii);
            SqlDataReader rd1 = komut1.ExecuteReader();
            while (rd1.Read())
            {
                lbltoplamper.Text = rd1[0].ToString();
            }
            baglantii.Close();

            //Evli Personel Sayısı

            baglantii.Open();

            SqlCommand komut2 = new SqlCommand("Select count(*) from tbl_personell where perdurum = 1",baglantii);
            SqlDataReader rd2 = komut2.ExecuteReader();
            while (rd2.Read())
            {

                lblevli.Text = rd2[0].ToString();

            }
            baglantii.Close();


            //Bekar Personel Sayısı

            baglantii.Open();

            SqlCommand komut3 = new SqlCommand("select count (*) from tbl_personell where perdurum = 0",baglantii);
            SqlDataReader rd3 = komut3.ExecuteReader();

            while (rd3.Read())
            {
                lblbekar.Text = rd3[0].ToString();
            }
            baglantii.Close();


            // Şehir sayısı
            baglantii.Open();
            SqlCommand komut4 = new SqlCommand("select  count (distinct(persehir)) from tbl_personell",baglantii);
            SqlDataReader rd4= komut4.ExecuteReader();
           
            while (rd4.Read())
            {
                lblsehir.Text = rd4[0].ToString();
            }

            baglantii.Close();


            baglantii.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(permaas) from tbl_personell",baglantii);
            SqlDataReader dr5 = komut5.ExecuteReader();

            while (dr5.Read())
            {
                lblmaastoplam.Text = dr5[0].ToString();


            }


            baglantii.Close();




            baglantii.Open();

            SqlCommand komut6 = new SqlCommand("Select avg(permaas) from tbl_personell",baglantii);

            SqlDataReader rd6 = komut6.ExecuteReader();

            while (rd6.Read())
            {
                lblmaasortalama.Text = rd6[0].ToString();
            }


            baglantii.Close();





















































































        }
    }
}
