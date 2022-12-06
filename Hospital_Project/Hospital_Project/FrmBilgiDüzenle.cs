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
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TCno;
        sqlbaglanti bgl =new sqlbaglanti();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskdtcno.Text = TCno;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskdtcno.Text);
            SqlDataReader sdr = komut.ExecuteReader();
            while (sdr.Read()) 
            {
                txtad.Text=sdr[1].ToString();
                txtsoyad.Text = sdr[2].ToString();
                mskdtcno.Text = sdr[3].ToString();
                mskdtelefon.Text = sdr[4].ToString();
                txtsifre.Text = sdr[5].ToString();
                combocinsiyet.Text = sdr[6].ToString();

            }
            bgl.baglanti().Close();



        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1 , HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",txtad.Text);
            komut2.Parameters.AddWithValue("@p2",txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3",mskdtelefon.Text);
            komut2.Parameters.AddWithValue("@p4",txtsifre.Text);    
            komut2.Parameters.AddWithValue("@p5",combocinsiyet.Text);
            komut2.Parameters.AddWithValue("@P6",mskdtcno.Text);
            //komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);






        }
    }
}
