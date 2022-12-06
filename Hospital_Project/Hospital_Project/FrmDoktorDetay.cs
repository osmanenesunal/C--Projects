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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        public string TC;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text=TC;

            //Labela sqlden isim çekme
            SqlCommand komut1 = new SqlCommand("select DoktorAd,DoktorSoyad From Tbl_Doktor where DoktorTC=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader sd = komut1.ExecuteReader();
            while (sd.Read())
            {
                lbladsoyad.Text = sd[0] + " " + sd[1];

            }
            bgl.baglanti().Close();

            //Randevuları sqlden çekme

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_randevular where RandevuDoktor='"+lbladsoyad.Text+"'",bgl.baglanti());
            sda.Fill(dt);
            dataGridView1.DataSource=dt;



        }

        private void btnbilgi_Click(object sender, EventArgs e)
        {
           FrmDoktorDüzenle frs = new FrmDoktorDüzenle();
            frs.TC=lbltc.Text;
            frs.Show();



        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular frs = new FrmDuyurular();
            frs.Show();

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            FrmAnaGiris ana = new FrmAnaGiris();
            ana.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();



        }
    }
}
