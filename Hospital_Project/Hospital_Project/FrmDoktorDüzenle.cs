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
namespace Hospital_Project
{
    public partial class FrmDoktorDüzenle : Form
    {
        public FrmDoktorDüzenle()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        public string TC;

        private void FrmDoktorDüzenle_Load(object sender, EventArgs e)
        {
            mskdtcno.Text = TC;

            //Bilgileri kutucukllara akktarma

            SqlCommand komut = new SqlCommand("Select * from tbl_Doktor where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskdtcno.Text);
            SqlDataReader ds = komut.ExecuteReader();
            while (ds.Read())
            {
                txtad.Text = ds[1].ToString();
                txtsoyad.Text = ds[2].ToString();
                txtsifre.Text = ds[5].ToString();
                cmbbrans.Text = ds[3].ToString();

            }
            bgl.baglanti().Close();


        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktor set DoktorAd=@p1,DoktorSoyad=@p2,DoktorSifre=@p4,DoktorBrans=@p5 where DoktorTc=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtad.Text);
            komut.Parameters.AddWithValue("@p2",txtsoyad.Text);
            komut.Parameters.AddWithValue("@p4",txtsifre.Text);
            komut.Parameters.AddWithValue("@p3",mskdtcno.Text);
            komut.Parameters.AddWithValue("@p5",cmbbrans.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            
            
        }
    }
}
