using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Library_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\90545\Desktop\Kitaplık.mdb");

        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Kitaplar",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }
        string durum = "";
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kitaplar (KitapAd,Yazar,Tur,Sayfasi,Durum) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1",txtkitapadi.Text);
            komut.Parameters.AddWithValue("@p2",txtyazar.Text);
            komut.Parameters.AddWithValue("@p3",cmbtür.Text);
            komut.Parameters.AddWithValue("@p4",txtsayfa.Text);
            komut.Parameters.AddWithValue("@p5",durum);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Kaydedilmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void radiokullanilmis_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";


        }

        private void radiosifir_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void txtsayfa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtkitapid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtkitapadi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtyazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbtür.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtsayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString()=="True")
            {
                radiosifir.Checked = true;
            }
            else
            {
                radiokullanilmis.Checked = true;
            }

            


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("Delete from Kitaplar where Kitapid=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",txtkitapid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Listeden Silidi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            listele();

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update kitaplar set KitapAd=@p1,Yazar=@p2,Tur=@p3,Sayfasi=@p4,Durum=@p5 where Kitapid=@p6",baglanti);
            komut.Parameters.AddWithValue("@p1",txtkitapadi.Text);
            komut.Parameters.AddWithValue("@p2",txtyazar.Text);
            komut.Parameters.AddWithValue("@p3",cmbtür.Text);
            komut.Parameters.AddWithValue("@p4",txtsayfa.Text);
            if (radiosifir.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            if (radiokullanilmis.Checked == true)
            {

                komut.Parameters.AddWithValue("@p5", durum);
            }
            komut.Parameters.AddWithValue("@p6",txtkitapid.Text);
           
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar Where KitapAd like '%"+ txtkitapbul.Text+ "%'" ,baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;



        }
    }
}
