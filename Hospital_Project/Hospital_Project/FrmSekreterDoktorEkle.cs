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
    public partial class FrmSekreterDoktorEkle : Form
    {
        public FrmSekreterDoktorEkle()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void FrmSekreterDoktorEkle_Load(object sender, EventArgs e)
        {
            //Data gride doktor ekleme  
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Tbl_Doktor",bgl.baglanti());
            sda.Fill(dt1);
            dataGridView1.DataSource=dt1;



            SqlCommand komut1 = new SqlCommand("Select Bransad from Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                cmbbrans.Items.Add(dr[0]);
            }






        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_doktor (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre) values(@d1,@d2,@d3,@d4,@d5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",txtad.Text);
            komut.Parameters.AddWithValue("@d2",txtsoyad.Text);
            komut.Parameters.AddWithValue("@d3",cmbbrans.Text);
            komut.Parameters.AddWithValue("@d4",mskdtc.Text);
            komut.Parameters.AddWithValue("@d5",txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklenmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen =dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskdtc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();




        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktor where DoktorTC=@d1",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",mskdtc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silinmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);



        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktor set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTC=@p4",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtad.Text);
            komut.Parameters.AddWithValue("@p2",txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3",cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4",mskdtc.Text);
            komut.Parameters.AddWithValue("@p5",txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kişi Güncellenmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);



        }
    }
}
