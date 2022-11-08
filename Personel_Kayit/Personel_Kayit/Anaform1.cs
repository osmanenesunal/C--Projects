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
    public partial class Anaform1 : Form
    {
        public Anaform1()
        {
            InitializeComponent();
        }

        SqlConnection baglantii = new SqlConnection("Data Source=OSMAN\\SQLEXPRESS;Initial Catalog=Personel_İslem;Integrated Security=True"); 

        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            cmbxsehir.Text = "";
            mskdmaas.Text = "";
            txtmeslek.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked =false;

            txtad.Focus();

         

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personel_İslemDataSet.tbl_personell' table. You can move, or remove it, as needed.
            this.tbl_personellTableAdapter.Fill(this.personel_İslemDataSet.tbl_personell);

        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            this.tbl_personellTableAdapter.Fill(this.personel_İslemDataSet.tbl_personell);
        }
        //ExecuteNonQuery sorguyu çalıştırmaya yarar updute delette ve insertte kullanılıyo
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_personell (Perad,Persoyad,persehir,permaas,permeslek,perdurum) values (@p1, @p2,@p3,@p4,@p5,@p6)",baglantii);
            komut.Parameters.AddWithValue("@p1",txtad.Text);
            komut.Parameters.AddWithValue("@p2",txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3",cmbxsehir.Text);
            komut.Parameters.AddWithValue("@p4",mskdmaas.Text);
            komut.Parameters.AddWithValue("@p5",txtmeslek.Text);
            komut.Parameters.AddWithValue("@p6",label8.Text);

            komut.ExecuteNonQuery();
            baglantii.Close();
            MessageBox.Show("Kişi Eklenmiştir");
            


        }

        private void label8_Click(object sender, EventArgs e)
        {

          


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                label8.Text = "True";
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbxsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskdmaas.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();







        }

        private void label8_TextChanged(object sender, EventArgs e)
        {

            if (label8.Text=="True")
            {
                radioButton1.Checked = true;
            }


            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }






        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand komutsil = new SqlCommand("DELETE from tbl_personell where personelid=@k1",baglantii);
            komutsil.Parameters.AddWithValue("@k1",txtid.Text);
            komutsil.ExecuteNonQuery(); 
            baglantii.Close();
            MessageBox.Show("Kişi Sildiniz");



        }

        private void btngüncel_Click(object sender, EventArgs e)
        {

            baglantii.Open();
            SqlCommand komutguncelle = new SqlCommand("update tbl_personell Set perad=@a1 , persoyad=@a2, persehir = @a3, permaas = @a4 ,perdurum = @a5,permeslek = @a6  where personelid = @a7",baglantii);
            komutguncelle.Parameters.AddWithValue("@a1",txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2",txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3",cmbxsehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4",mskdmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5",label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6",txtmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7",txtid.Text);
            komutguncelle.ExecuteNonQuery();

            baglantii.Close();
            MessageBox.Show("Kişi Güncellendi");





        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            istatistikForm frm = new istatistikForm();
            frm.Show();
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {

            formGrafik frmgrf = new formGrafik();
            frmgrf.Show();

        }
    }
}
