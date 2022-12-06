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
    public partial class FrmHastKayit : Form
    {
        public FrmHastKayit()
        {
            InitializeComponent();
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {

            sqlbaglanti bgl = new sqlbaglanti();
            SqlCommand kmt = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet)values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",txtad.Text);
            kmt.Parameters.AddWithValue("@p2",txtsoyad.Text);
            kmt.Parameters.AddWithValue("@p3",mskdtcno.Text);
            kmt.Parameters.AddWithValue("@p4",mskdtelefon.Text);
            kmt.Parameters.AddWithValue("@p5",txtsifre.Text);
            kmt.Parameters.AddWithValue("@p6",combocinsiyet.Text);

            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();


            MessageBox.Show("Kayıt İşleminiz Yapılmıştır. Şifreniz: "+txtsifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);



            







        }
    }
}
