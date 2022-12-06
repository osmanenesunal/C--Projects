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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_doktor where DoktorTC=@p1 and DoktorSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskdtcno.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);
            SqlDataReader rd = komut.ExecuteReader();
            if (rd.Read())
            {
                FrmDoktorDetay fdd = new FrmDoktorDetay();
                fdd.TC = mskdtcno.Text;
                fdd.Show();
                this.Hide();


            }

            else
            {
                MessageBox.Show("TC & Sifre Hatalıdır", "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
