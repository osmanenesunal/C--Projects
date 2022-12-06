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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        public string TCnumara;

        sqlbaglanti bgl = new sqlbaglanti();

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = TCnumara;
            //Ad soyad aktarma
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
               lbladsoyad.Text = dr1[0].ToString();


            }
            bgl.baglanti().Close();

            //Bransları datagride ekleme


            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter("Select BransAd from Tbl_Branslar",bgl.baglanti());
            sda1.Fill(dt1);
            dataGridView1.DataSource=dt1;



            //Doktorları datagride ekleme

            DataTable dt2 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad)as Doktorlar,DoktorBrans,DoktorTC from Tbl_Doktor",bgl.baglanti());
            sda2.Fill(dt2);
            dataGridView2.DataSource = dt2;



            //Branşları combobox getirme


            SqlCommand komut4 = new SqlCommand("Select BransAd From Tbl_Branslar ",bgl.baglanti());
            SqlDataReader dr2 = komut4.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);

            }

            bgl.baglanti().Close();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4) ",bgl.baglanti());

            komut3.Parameters.AddWithValue("@r1",mskdtarih.Text);
            komut3.Parameters.AddWithValue("@r2",mskdsaat.Text);
            komut3.Parameters.AddWithValue("@r3",cmbbrans.Text);
            komut3.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Randevu Kaydedilmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);










        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktor where DoktorBrans=@d1",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",cmbbrans.Text);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                cmbdoktor.Items.Add(rd[0]+ " "+ rd[1]);


            }
            bgl.baglanti().Close();






        }

        private void btnolustur_Click(object sender, EventArgs e)
        {

            SqlCommand komut1 = new SqlCommand("insert into Tbl_Duyuru (Duyuru) values (@d1)",bgl.baglanti());
            komut1.Parameters.AddWithValue("@d1",richduyuru.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Duyurunuz Eklenmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);






        }

        private void btndoktorpanel_Click(object sender, EventArgs e)
        {

            FrmSekreterDoktorEkle fsde = new FrmSekreterDoktorEkle();
            fsde.Show();


        }

        private void btnbranspanel_Click(object sender, EventArgs e)
        {
            FrmSekreterBransPanel fsbp = new FrmSekreterBransPanel();
            fsbp.Show();



        }

        private void lblrandevulistesi_Click(object sender, EventArgs e)
        {
            FrmSekreterRandevuListesi fr = new FrmSekreterRandevuListesi();
            fr.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frs = new FrmDuyurular();
            frs.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaGiris frs = new FrmAnaGiris();
            frs.Show();
            this.Close();
        }
    }
}