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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            //Ad Soyad Veri Çekme
            SqlCommand komut = new SqlCommand("Select  HastaAd,HastaSoyad  From Tbl_Hastalar  where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                LblAdSoyad.Text = rd[0] +" "+ rd[1];


            }
            bgl.baglanti().Close();
            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC="+tc,bgl.baglanti());
            dr.Fill(dt);
            dataGridView1.DataSource=dt;
            //Branşları Çekme

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader rd2 = komut2.ExecuteReader();
            while (rd2.Read())
            {
                cmbBrans.Items.Add(rd2[0]);
            }
            bgl.baglanti().Close();




              





















        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        { 
            // Doktorları branşla eşitleme
            cmbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktor where Doktorbrans=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",cmbBrans.Text);
            SqlDataReader rd3 = komut3.ExecuteReader();
            while (rd3.Read())
            {
                cmbdoktor.Items.Add(rd3[0]+" "+rd3[1]);


            }

            bgl.baglanti().Close();


        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {//randevuları datagridwiew2 ye çekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor= '"+cmbdoktor.Text+"'" +"and randevuBrans='"+cmbBrans.Text+ "' and randevuDurum=0" ,bgl.baglanti());
            sda.Fill(dt2);
            dataGridView2.DataSource=dt2;




        }

        private void lnkbilgilerim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.TCno = lbltc.Text;
            fr.Show();


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            cmbBrans.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            cmbdoktor.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
           // richsikayet.Text = dataGridView2.Rows[secilen].Cells[].Value.ToString();






        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular set RandevuDurum= 1 ,HastaTC=@p1,HastaSikayet=@p2 where randevuid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lbltc.Text);
            komut.Parameters.AddWithValue("@p2",richsikayet.Text);
            komut.Parameters.AddWithValue("@p3",txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Talebiniz Alınmıştır.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaGiris frs = new FrmAnaGiris();
            frs.Show();
            this.Close();
        }
    }
}
