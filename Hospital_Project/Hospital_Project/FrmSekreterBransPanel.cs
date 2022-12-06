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
    public partial class FrmSekreterBransPanel : Form
    {
        public FrmSekreterBransPanel()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void FrmSekreterBransPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglanti());
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            


        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_branslar (BransAd) values (@p1) ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtbransad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklenmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);





        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen =dataGridView1.SelectedCells[0].RowIndex;
            txtbransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtbransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();



        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Branslar where Bransid=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silinmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Update tbl_branslar set BransAd=@p1 where Bransid=@p2 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtbransad.Text);
            komut.Parameters.AddWithValue("@p2",txtbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellenmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);





        }
    }
}
