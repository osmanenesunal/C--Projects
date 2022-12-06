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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlbaglanti baglan = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2 ",baglan.baglanti());
            komut.Parameters.AddWithValue("@p1",mskdtcno.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);

            SqlDataReader rd = komut.ExecuteReader();

            if (rd.Read())
            {
                FrmSekreterDetay fsd = new FrmSekreterDetay();
                fsd.TCnumara = mskdtcno.Text;
                fsd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC & Sifre Hatalıdır", "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            baglan.baglanti().Close();



        }
    }
}
